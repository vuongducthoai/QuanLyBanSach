using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyBanSach
{
    public partial class FormChiTietPhieuNhap : Form
    {
        DataProvider dataProvider = new DataProvider();
        private int maSach;
        private string tenSach;
        private int maPhieuNhap;
        public FormChiTietPhieuNhap(int maPhieuNhap)
        {
            InitializeComponent();
            this.maPhieuNhap = maPhieuNhap;
            init();
        }

        private void init()
        {
            title.Text = "Chi Tiết Phiếu Nhập " + maPhieuNhap;
            loadCbSach();
            loadDgPhieuNhap();
            loadTongTien();
        }


        private void loadDgPhieuNhap()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT tbl_sach.ten_sach as [Tên Sách]");
            query.Append(",tbl_chi_tiet_phieu_nhap.so_luong as [So Luong]");
            query.Append(",tbl_chi_tiet_phieu_nhap.gia_nhap as [Gia Nhap]");
            query.Append(",tbl_chi_tiet_phieu_nhap.gia_nhap * tbl_chi_tiet_phieu_nhap.so_luong as [Thanh Tien]");

            query.Append(" FROM tbl_sach, tbl_chi_tiet_phieu_nhap");
            query.Append(" WHERE  tbl_sach.ma_sach = tbl_chi_tiet_phieu_nhap.ma_sach");
            query.Append(" AND  ma_phieu_nhap = " + maPhieuNhap);

            dt = dataProvider.execQuery(query.ToString());
            dgChiTietPN.DataSource = dt;

        }


        private void loadTongTien()
        {
            if((int)dataProvider.execScaler("SELECT COUNT(*) FROM tbl_chi_tiet_phieu_nhap WHERE ma_phieu_nhap = " + maPhieuNhap) > 0)
            {
                double tongTien = (double)dataProvider.execScaler("SELECT SUM(so_luong * gia_nhap) FROM tbl_chi_tiet_phieu_nhap WHERE ma_phieu_nhap = " + maPhieuNhap);
                txtTongTien.Text = "Tong Tien: " + tongTien.ToString();
            }
        }

        private void loadCbSach()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery("SELECT * FROM tbl_sach");
            cbTenSach.DisplayMember = "ten_sach";
            cbTenSach.ValueMember = "ma_sach";
            cbTenSach.DataSource = dt;
        }

        private void cbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            maSach = (int)comboBox.SelectedValue;
            tenSach = comboBox.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int dem =(int)dataProvider.execScaler("SELECT count(*) FROM tbl_chi_tiet_phieu_nhap WHERE ma_phieu_nhap = " + maPhieuNhap + " AND ma_sach  = " + maSach);  

            if(dem  == 0)
            {
                StringBuilder query = new StringBuilder("EXEC proc_them_chi_tiet_phieu_nhap");
                query.Append(" @maPhieuNhap = " + maPhieuNhap);
                query.Append(",@maSach = " + maSach);
                query.Append(",@soLuong = " + numSachSoLuong.Value);
                query.Append(",@giaNhap = " + numSachGiaNhap.Value);

                int result = dataProvider.execNonQuery(query.ToString());

                if (result > 0)
                {
                    MessageBox.Show("Thêm Sách vào phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDgPhieuNhap();
                    loadTongTien();
                }
                else
                {
                    MessageBox.Show("Thêm sách vào phiếu nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                dem = (int)dataProvider.execScaler("SELECT SUM(so_luong) FROM tbl_chi_tiet_phieu_nhap WHERE ma_phieu_nhap = " + maPhieuNhap + " AND ma_sach  = " + maSach);
                update(dem);
            }
          
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            update(0);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa sách " + tenSach + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_chi_tiet_phieu_nhap WHERE ma_phieu_nhap = " + maPhieuNhap + "AND ma_sach = " + maSach;
                int result = dataProvider.execNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Xóa khỏi phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDgPhieuNhap();
                    loadTongTien();
                }
                else
                {
                    MessageBox.Show("Xóa khỏi phiếu nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void update(int soLuong)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_chi_tiet_phieu_nhap");
            query.Append(" @maPhieuNhap = " + maPhieuNhap);
            query.Append(",@maSach = " + maSach);
            query.Append(",@soLuong = " + (numSachSoLuong.Value + soLuong));
            query.Append(",@giaNhap = " + numSachGiaNhap.Value);

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                MessageBox.Show("Cập nhật so luong trong phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDgPhieuNhap();
                loadTongTien();
            }
            else
            {
                MessageBox.Show("Cập nhật so luong trong phiếu nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgChiTietPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            // Kiểm tra nếu chỉ số dòng hợp lệ
            if (rowId < 0 || rowId >= dgChiTietPN.Rows.Count - 1)
            {
                return; // Nếu dòng không hợp lệ, thoát
            }

            DataGridViewRow row = dgChiTietPN.Rows[rowId];
            if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
            {
               
                tenSach = row.Cells[0].Value.ToString();
                cbTenSach.Text = tenSach;
                numSachSoLuong.Value = Convert.ToInt32(row.Cells[1].Value);
                numSachGiaNhap.Value = Convert.ToInt32(row.Cells[2].Value);

                maSach = (int)dataProvider.execScaler("SELECT ma_sach FROM tbl_sach WHERE ten_sach = N'" + tenSach + "'");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgChiTietPN.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = "PhieuNhap";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                            PdfWriter.GetInstance(document, fileStream);
                            document.Open();

                            iTextSharp.text.Font font3 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD);
                            //Add title to the PDF document 
                            Paragraph title = new Paragraph("CHI TIET PHIEU NHAP", font3);
                            title.Alignment = Element.ALIGN_CENTER;

                            //Thiet lap khoang cach le tren va le duoi
                            title.SpacingBefore = 20f;
                            title.SpacingAfter = 40f;

                            document.Add(title);

                            PdfPTable pTable = new PdfPTable(dgChiTietPN.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 80;
                            pTable.HorizontalAlignment = Element.ALIGN_CENTER;

                            float[] columnWidths = new float[dgChiTietPN.Columns.Count];
                            float equalWidth = 100f / dgChiTietPN.Columns.Count; // Calculate equal width for each column
                            for (int i = 0; i < dgChiTietPN.Columns.Count; i++)
                            {
                                columnWidths[i] = equalWidth; // Set equal width for each column
                            }
                            pTable.SetWidths(columnWidths);

                            iTextSharp.text.Font font1 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLUE);
                            // Add column headers to the PDF table
                            foreach (DataGridViewColumn col in dgChiTietPN.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, font1));
                                pCell.BackgroundColor = new BaseColor(System.Drawing.Color.LightGray);
                                pCell.Padding = 5;
                                pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                pTable.AddCell(pCell);
                            }

                            iTextSharp.text.Font font11 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10f, iTextSharp.text.Font.BOLD, BaseColor.RED);

                            foreach (DataGridViewRow viewRow in dgChiTietPN.Rows)
                            {
                                foreach (DataGridViewCell cell in viewRow.Cells)
                                {
                                    PdfPCell contentCell = new PdfPCell(new Phrase(cell.Value?.ToString(), font11));
                                    contentCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                    pTable.AddCell(contentCell);
                                }
                            }
                            document.Add(pTable);

                            //set Font
                            iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD);
                            font.SetStyle(iTextSharp.text.Font.NORMAL);

                            //Add title to the PDF document 
                            Paragraph ending = new Paragraph(txtTongTien.Text + "           ", font);
                            ending.Alignment = Element.ALIGN_RIGHT;

                            //Thiet lap khoang cach le tren va le duoi
                            ending.SpacingBefore = 20f;

                            document.Add(ending);

                            document.Close();
                        }
                        MessageBox.Show("Data Printed Successfully", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error While Exporting Data: " + ex.Message, "Error");
                    }

                }
            }
            else
            {
                MessageBox.Show("No Record Found", "Info");
            }
        }
    }
}
