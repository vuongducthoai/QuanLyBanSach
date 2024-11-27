using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach
{
    public partial class Form1 : Form
    {
        private DataProvider dataProvider = new DataProvider();
        private int maSachLoaiSach;
        private int maSachSach;
        private int maLoaiSachLoaiSach;
        private int maHoaDonHoaDon;
        private int maPhieuNhapPhieuNhap;
        public Form1(string selectedQ)
        {
            InitializeComponent();
            init();
            RemoveTabsBasedOnSelection(selectedQ);
        }

        private void init()
        {
            initSach();
            initLoaiSach();
            initHoaDon();
            initPhieuNhap();
        }

        private void RemoveTabsBasedOnSelection(string selectedQ)
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                if (tabPage.Name != selectedQ)
                {
                    tabControl1.TabPages.Remove(tabPage);
                }
            }
        }



        //Xu ly sach
        private void initSach()
        {
            loaddgSach();
            loadcbSachLoaiSach();
        }

        private void loaddgSach()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT ma_sach as [Mã Sách]");
            query.Append(",ten_sach as [Tên Sách]");
            query = query.Append(", ten_loai_sach as [Loại Sách]");
            query.Append(",tac_gia as [Tác Gỉa]");
            query.Append(",so_luong as [Số Lượng]");
            query.Append(",gia_ban as [Gía Bán]");
            query.Append(" FROM tbl_sach, tbl_loai_sach");
            query.Append(" WHERE  tbl_sach.ma_loai_sach = tbl_loai_sach.ma_loai_sach");

            dt = dataProvider.execQuery(query.ToString());
            dgSach.DataSource = dt;

            maSachSach = (int)dt.Rows[0][0];
        }


        private void loadcbSachLoaiSach()
        {
            DataTable dt = new DataTable();
            dt = dataProvider.execQuery("SELECT * FROM tbl_loai_sach");
            cbSachLoaiSach.DisplayMember = "ten_loai_sach";
            cbSachLoaiSach.ValueMember = "ma_loai_sach";
            cbSachLoaiSach.DataSource = dt;
        }

        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            // Kiểm tra nếu chỉ số dòng hợp lệ
            if (rowId < 0 || rowId >= dgSach.Rows.Count - 1)
            {
                return; // Nếu dòng không hợp lệ, thoát
            }

             DataGridViewRow row = dgSach.Rows[rowId];
            if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
            {
                maSachSach = (int) row.Cells[0].Value;
                txtSachTenSach.Text = row.Cells[1].Value.ToString();
                cbSachLoaiSach.Text = row.Cells[2].Value.ToString();
                txtSachTacGia.Text  = row.Cells[3].Value.ToString();
                numSachSoLuong.Value = (int) row.Cells[4].Value;
                numSachGiaBan.Value = Convert.ToInt32(row.Cells[5].Value);
                maSachLoaiSach = (int) dataProvider.execScaler("SELECT ma_loai_sach FROM tbl_loai_sach WHERE ten_loai_sach = N'" + cbSachLoaiSach.Text + "'");
            }
           
        }

        private void btnSachThem_Click(object sender, EventArgs e)
        {

            StringBuilder query = new StringBuilder("EXEC proc_them_sach");
            query.Append(" @tenSach = N'" + txtSachTenSach.Text + "'");
            query.Append(",@maLoaiSach = " + maSachLoaiSach);
            query.Append(",@tacGia = N'" + txtSachTacGia.Text + "'");   
            query.Append(",@soLuong = " + numSachSoLuong.Value);
            query.Append(",@giaBan = " + numSachGiaBan.Value);

            int result = dataProvider.execNonQuery(query.ToString());

            if(result > 0)
            {
                MessageBox.Show("Thêm Sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgSach();
            } else
            {
                MessageBox.Show("Thêm sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSachSua_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_sach");
            query = query.Append(" @maSach = " + maSachSach);
            query.Append(",@tenSach = N'" + txtSachTenSach.Text + "'");
            query.Append(",@maLoaiSach = " + maSachLoaiSach);
            query.Append(",@tacGia = N'" + txtSachTacGia.Text + "'");
            query.Append(",@soLuong = " + numSachSoLuong.Value);
            query.Append(",@giaBan = " + numSachGiaBan.Value);

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                MessageBox.Show("Cập nhật Sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgSach();
            }
            else
            {
                MessageBox.Show("Cập nhật Sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSachXoa_Click(object sender, EventArgs e)
        {

         DialogResult check =  MessageBox.Show("Bạn có chắc chắn muốn xóa sách " + txtSachTenSach.Text + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_sach WHERE ma_sach = " + maSachSach;
                int result = dataProvider.execNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Xóa sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddgSach();
                }
                else
                {
                    MessageBox.Show("Xóa sách  không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnSachSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchSach.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                StringBuilder query = new StringBuilder("SELECT ma_sach as [Mã Sách]");
                query.Append(",ten_sach as [Tên Sách]");
                query.Append(", ten_loai_sach as [Loại Sách]");
                query.Append(",tac_gia as [Tác Gỉa]");
                query.Append(",so_luong as [Số Lượng]");
                query.Append(",gia_ban as [Gía Bán]");
                query.Append(" FROM tbl_sach, tbl_loai_sach");
                query.Append(" WHERE tbl_sach.ma_loai_sach = tbl_loai_sach.ma_loai_sach");
                query.Append(" AND (ten_sach LIKE N'%" + keyword + "%'");
                query.Append(" OR ten_loai_sach LIKE N'%" + keyword + "%'");
                query.Append(" OR tac_gia LIKE N'%" + keyword + "%')");

                DataTable dt = dataProvider.execQuery(query.ToString());
                dgSach.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loaddgSach(); // Load lại toàn bộ dữ liệu nếu không nhập từ khóa
            }
        }


        private void cbSachLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            maSachLoaiSach = (int)comboBox.SelectedValue;
        }
            


       //Xu ly loai sach
       private void initLoaiSach()
       {
            loadDgLoaiSach();
       }

        private void loadDgLoaiSach()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT ma_loai_sach as [Mã Loại Sách]");
            query.Append(",ten_loai_sach as [Tên Loại Sách]");
            query.Append(" FROM tbl_loai_sach");
            dt = dataProvider.execQuery(query.ToString());
            dgLoaiSach.DataSource = dt;

            maLoaiSachLoaiSach = (int)dt.Rows[0][0];
        }

        private void dgLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

           if(rowId < dgLoaiSach.RowCount - 1 && rowId > 0)
            {
                DataGridViewRow row = dgLoaiSach.Rows[rowId];
                maLoaiSachLoaiSach = (int)row.Cells[0].Value;
                txtLoaiSachTenLoaiSach.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnLoaiSachThem_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_them_loai_sach");
            query.Append(" @ten_loai_sach = N'" + txtLoaiSachTenLoaiSach.Text + "'");

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                MessageBox.Show("Thêm Loại Sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDgLoaiSach();
                loadcbSachLoaiSach();
            }
            else
            {
                MessageBox.Show("Thêm Loại Sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoaiSachSua_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_loai_sach");
            query.Append(" @maLoaiSach = " + maLoaiSachLoaiSach);
            query.Append(",@tenLoaiSach = N'" + txtLoaiSachTenLoaiSach.Text+ "'");
      
   
            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgLoaiSach();
                loaddgSach();
                loadcbSachLoaiSach();
                MessageBox.Show("Cập nhật loại sách thành công !!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật Loại Sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoaiSachXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sách " + txtLoaiSachTenLoaiSach.Text + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_loai_sach WHERE ma_loai_sach = " + maLoaiSachLoaiSach;
                int result = dataProvider.execNonQuery(query);

                if (result > 0)
                {
                    loadDgLoaiSach();
                    loadcbSachLoaiSach();
                    MessageBox.Show("Xóa loại sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                }
                else
                {
                    MessageBox.Show("Xóa loại sách không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoaiSachSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtLoaiSachSearch.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                StringBuilder query = new StringBuilder("SELECT ma_loai_sach as [Mã Loại Sách]");
                query.Append(",ten_loai_sach as [Tên Loại Sách]");
                query.Append(" FROM tbl_loai_sach");
                query.Append(" WHERE ten_loai_sach LIKE N'%" + keyword + "%'");

                DataTable dt = dataProvider.execQuery(query.ToString());
                dgLoaiSach.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy loại sách nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadDgLoaiSach();
            }
        }


        //Xy ly hoa don 
        private void initHoaDon()
        {
            loadDgoaDon();
        }

        private void loadDgoaDon()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT ma_hoa_don as [Mã Hóa Đơn]");
            query.Append(",ngay_lap_hoa_don as [Ngày Lập Hóa Đơn]");
            query.Append(" ,ten_khach_hang as [Tên Khách Hàng]");
            query.Append(" ,sdt_khach_hang as [SDT KH]");
            query.Append(" FROM tbl_hoa_don");
            dt = dataProvider.execQuery(query.ToString());
            dgHoaDon.DataSource = dt;

            maHoaDonHoaDon = (int)dt.Rows[0][0];
        }

        private void dgHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            // Kiểm tra nếu chỉ số dòng hợp lệ
            if (rowId < 0 || rowId >= dgHoaDon.Rows.Count - 1)
            {
                return; // Nếu dòng không hợp lệ, thoát
            }

            DataGridViewRow row = dgHoaDon.Rows[rowId];
            if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
            {
                maHoaDonHoaDon = (int)row.Cells[0].Value;
                dateTimeHoaDon.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                txtHoaDonTenKH.Text = row.Cells[2].Value.ToString();
                txtHoaDonSDT.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnHoaDonThem_Click(object sender, EventArgs e)
        {

            StringBuilder query = new StringBuilder("EXEC proc_them_hoa_don");
            query.Append(" @ngayLapHoaDon = '" + dateTimeHoaDon.Value +"'");
            query.Append(",@tenKhachHang = N'" + txtHoaDonTenKH.Text + "'");
            query.Append(",@sdtKhachHang = N'" + txtHoaDonSDT.Text + "'");

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgoaDon();
                MessageBox.Show("Thêm Hóa Đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            else
            {
                MessageBox.Show("Thêm Hóa Đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoaDonSua_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_hoa_don");
            query.Append(" @ngayLapHoaDon = '" + dateTimeHoaDon.Value + "'");
            query.Append(",@tenKhachHang = N'" + txtHoaDonTenKH.Text + "'");
            query.Append(",@sdtKhachHang = N'" + txtHoaDonSDT.Text +"'");
            query.Append(",@maHoaDon = " + maHoaDonHoaDon);

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgoaDon();
                MessageBox.Show("Cập nhật Hóa Đơn thành công !!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật Hóa Đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoaDonXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn " + maHoaDonHoaDon+ " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_hoa_don WHERE ma_hoa_don = " + maHoaDonHoaDon;
                int result = dataProvider.execNonQuery(query);

                if (result > 0)
                {
                    loadDgoaDon();
                    MessageBox.Show("Xóa Hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Xóa Hóa đơn không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtHoaDonSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')){
                e.Handled = true;
            }

            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnHoaDonSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtHoaDonSearch.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                StringBuilder query = new StringBuilder("SELECT ma_hoa_don as [Mã Hóa Đơn]");
                query.Append(",ngay_lap_hoa_don as [Ngày Lập Hóa Đơn]");
                query.Append(",ten_khach_hang as [Tên Khách Hàng]");
                query.Append(",sdt_khach_hang as [SDT KH]");
                query.Append(" FROM tbl_hoa_don");
                query.Append(" WHERE ten_khach_hang LIKE N'%" + keyword + "%'");
                query.Append(" OR sdt_khach_hang LIKE '%" + keyword + "%'");
                query.Append(" OR ma_hoa_don LIKE '%" + keyword + "%'");

                DataTable dt = dataProvider.execQuery(query.ToString());
                dgHoaDon.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadDgoaDon(); // Load lại danh sách đầy đủ nếu không nhập từ khóa
            }
        }


        //Xu ly phieu nhap
        private void initPhieuNhap()
        {
            loadDgPhieuNhap();
        }

        private void loadDgPhieuNhap()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("SELECT ma_phieu_nhap as [Mã Phiếu Nhập]");
            query.Append(",ngay_lap_phieu_nhap as [Ngày Lập Phiếu Nhập]");
            query.Append(" ,ten_nha_cung_cap as [Tên Nhà Cung Cấp]");
            query.Append(" FROM tbl_phieu_nhap");
            dt = dataProvider.execQuery(query.ToString());
            dgPhieuNhap.DataSource = dt;

            maPhieuNhapPhieuNhap = (int)dt.Rows[0][0];
        }

        private void dgPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            // Kiểm tra nếu chỉ số dòng hợp lệ
            if (rowId < 0 || rowId >= dgPhieuNhap.Rows.Count - 1)
            {
                return; // Nếu dòng không hợp lệ, thoát
            }

            DataGridViewRow row = dgPhieuNhap.Rows[rowId];
            if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
            {
                maPhieuNhapPhieuNhap = (int)row.Cells[0].Value;
                DateLapPhieuNhap.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                txtPhieuNhapTenNCC.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnPhieuNhapThem_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_them_phieu_nhap");
            query.Append(" @ngayLapPhieuNhap = '" + DateLapPhieuNhap.Value + "'");
            query.Append(",@tenNhaCungCap = N'" + txtPhieuNhapTenNCC.Text + "'");

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgPhieuNhap();
                MessageBox.Show("Thêm Phiếu Nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Thêm Phiếu Nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhieuNhapSua_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_phieu_nhap");
            query.Append(" @ngayLapPhieuNhap = '" + DateLapPhieuNhap.Value + "'");
            query.Append(",@tenNhaCungCap = N'" + txtPhieuNhapTenNCC.Text + "'");
            query.Append(",@maPhieuNhap = " + maPhieuNhapPhieuNhap);

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgoaDon();
                MessageBox.Show("Cập nhật Phiếu Nhập thành công !!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật Phiếu Nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhieuNhapXoa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập " + maPhieuNhapPhieuNhap + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_phieu_nhap WHERE ma_phieu_nhap = " + maPhieuNhapPhieuNhap;
                int result = dataProvider.execNonQuery(query);

                if (result > 0)
                {
                    loadDgPhieuNhap();
                    MessageBox.Show("Xóa Phiếu Nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Xóa Phiếu Nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPhieuNhapSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtPhieuNhapSearch.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                StringBuilder query = new StringBuilder("SELECT ma_phieu_nhap as [Mã Phiếu Nhập]");
                query.Append(",ngay_lap_phieu_nhap as [Ngày Lập Phiếu Nhập]");
                query.Append(",ten_nha_cung_cap as [Tên Nhà Cung Cấp]");
                query.Append(" FROM tbl_phieu_nhap");
                query.Append(" WHERE ten_nha_cung_cap LIKE N'%" + keyword + "%'");
                query.Append(" OR ma_phieu_nhap LIKE '%" + keyword + "%'");

                DataTable dt = dataProvider.execQuery(query.ToString());
                dgPhieuNhap.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy phiếu nhập nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadDgPhieuNhap(); 
            }
        }


        private void btnChiTietPN_Click_1(object sender, EventArgs e)
        {
            FormChiTietPhieuNhap frm = new FormChiTietPhieuNhap(maPhieuNhapPhieuNhap);
            frm.ShowDialog(this);
        }

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            FormChiTietHoaDon frm = new FormChiTietHoaDon(maHoaDonHoaDon);
            frm.ShowDialog(this);

        }
    }
}
