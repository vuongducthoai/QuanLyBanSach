namespace QuanLyBanSach
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SACH = new System.Windows.Forms.TabPage();
            this.btnSachSearch = new System.Windows.Forms.Button();
            this.txtSearchSach = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numSachGiaBan = new System.Windows.Forms.NumericUpDown();
            this.numSachSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSachXoa = new System.Windows.Forms.Button();
            this.txtSachTacGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSachLoaiSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSachTenSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSachSua = new System.Windows.Forms.Button();
            this.btnSachThem = new System.Windows.Forms.Button();
            this.dgSach = new System.Windows.Forms.DataGridView();
            this.LOAISACH = new System.Windows.Forms.TabPage();
            this.btnLoaiSachSearch = new System.Windows.Forms.Button();
            this.txtLoaiSachSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoaiSachXoa = new System.Windows.Forms.Button();
            this.txtLoaiSachTenLoaiSach = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLoaiSachSua = new System.Windows.Forms.Button();
            this.btnLoaiSachThem = new System.Windows.Forms.Button();
            this.dgLoaiSach = new System.Windows.Forms.DataGridView();
            this.HOADON = new System.Windows.Forms.TabPage();
            this.btnHoaDonSearch = new System.Windows.Forms.Button();
            this.txtHoaDonSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChiTietHD = new System.Windows.Forms.Button();
            this.txtHoaDonSDT = new System.Windows.Forms.TextBox();
            this.txtHoaDonTenKH = new System.Windows.Forms.TextBox();
            this.dateTimeHoaDon = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHoaDonXoa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnHoaDonSua = new System.Windows.Forms.Button();
            this.btnHoaDonThem = new System.Windows.Forms.Button();
            this.dgHoaDon = new System.Windows.Forms.DataGridView();
            this.PHIEUNHAP = new System.Windows.Forms.TabPage();
            this.btnPhieuNhapSearch = new System.Windows.Forms.Button();
            this.txtPhieuNhapSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChiTietPN = new System.Windows.Forms.Button();
            this.txtPhieuNhapTenNCC = new System.Windows.Forms.TextBox();
            this.DateLapPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.btnPhieuNhapXoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPhieuNhapSua = new System.Windows.Forms.Button();
            this.btnPhieuNhapThem = new System.Windows.Forms.Button();
            this.dgPhieuNhap = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.SACH.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSachGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSachSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).BeginInit();
            this.LOAISACH.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiSach)).BeginInit();
            this.HOADON.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).BeginInit();
            this.PHIEUNHAP.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SACH);
            this.tabControl1.Controls.Add(this.LOAISACH);
            this.tabControl1.Controls.Add(this.HOADON);
            this.tabControl1.Controls.Add(this.PHIEUNHAP);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // SACH
            // 
            this.SACH.Controls.Add(this.btnSachSearch);
            this.SACH.Controls.Add(this.txtSearchSach);
            this.SACH.Controls.Add(this.panel1);
            this.SACH.Controls.Add(this.dgSach);
            this.SACH.Location = new System.Drawing.Point(4, 29);
            this.SACH.Name = "SACH";
            this.SACH.Padding = new System.Windows.Forms.Padding(3);
            this.SACH.Size = new System.Drawing.Size(892, 507);
            this.SACH.TabIndex = 0;
            this.SACH.Text = "Sách";
            this.SACH.UseVisualStyleBackColor = true;
            // 
            // btnSachSearch
            // 
            this.btnSachSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSachSearch.Location = new System.Drawing.Point(502, 10);
            this.btnSachSearch.Name = "btnSachSearch";
            this.btnSachSearch.Size = new System.Drawing.Size(134, 40);
            this.btnSachSearch.TabIndex = 15;
            this.btnSachSearch.Text = "Tìm Kiếm";
            this.btnSachSearch.UseVisualStyleBackColor = false;
            this.btnSachSearch.Click += new System.EventHandler(this.btnSachSearch_Click);
            // 
            // txtSearchSach
            // 
            this.txtSearchSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSach.Location = new System.Drawing.Point(280, 15);
            this.txtSearchSach.Name = "txtSearchSach";
            this.txtSearchSach.Size = new System.Drawing.Size(189, 30);
            this.txtSearchSach.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numSachGiaBan);
            this.panel1.Controls.Add(this.numSachSoLuong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSachXoa);
            this.panel1.Controls.Add(this.txtSachTacGia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbSachLoaiSach);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSachTenSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSachSua);
            this.panel1.Controls.Add(this.btnSachThem);
            this.panel1.Location = new System.Drawing.Point(12, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 158);
            this.panel1.TabIndex = 1;
            // 
            // numSachGiaBan
            // 
            this.numSachGiaBan.Location = new System.Drawing.Point(722, 9);
            this.numSachGiaBan.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSachGiaBan.Name = "numSachGiaBan";
            this.numSachGiaBan.Size = new System.Drawing.Size(102, 27);
            this.numSachGiaBan.TabIndex = 14;
            // 
            // numSachSoLuong
            // 
            this.numSachSoLuong.Location = new System.Drawing.Point(607, 56);
            this.numSachSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSachSoLuong.Name = "numSachSoLuong";
            this.numSachSoLuong.Size = new System.Drawing.Size(187, 27);
            this.numSachSoLuong.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(614, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gía Bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số Lượng";
            // 
            // btnSachXoa
            // 
            this.btnSachXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSachXoa.Location = new System.Drawing.Point(370, 102);
            this.btnSachXoa.Name = "btnSachXoa";
            this.btnSachXoa.Size = new System.Drawing.Size(163, 45);
            this.btnSachXoa.TabIndex = 9;
            this.btnSachXoa.Text = "Xóa";
            this.btnSachXoa.UseVisualStyleBackColor = false;
            this.btnSachXoa.Click += new System.EventHandler(this.btnSachXoa_Click);
            // 
            // txtSachTacGia
            // 
            this.txtSachTacGia.Location = new System.Drawing.Point(370, 11);
            this.txtSachTacGia.Name = "txtSachTacGia";
            this.txtSachTacGia.Size = new System.Drawing.Size(192, 27);
            this.txtSachTacGia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tác Gỉa";
            // 
            // cbSachLoaiSach
            // 
            this.cbSachLoaiSach.FormattingEnabled = true;
            this.cbSachLoaiSach.Location = new System.Drawing.Point(227, 55);
            this.cbSachLoaiSach.Name = "cbSachLoaiSach";
            this.cbSachLoaiSach.Size = new System.Drawing.Size(212, 28);
            this.cbSachLoaiSach.TabIndex = 6;
            this.cbSachLoaiSach.SelectedIndexChanged += new System.EventHandler(this.cbSachLoaiSach_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại Sách";
            // 
            // txtSachTenSach
            // 
            this.txtSachTenSach.Location = new System.Drawing.Point(97, 8);
            this.txtSachTenSach.Name = "txtSachTenSach";
            this.txtSachTenSach.Size = new System.Drawing.Size(130, 27);
            this.txtSachTenSach.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Sách";
            // 
            // btnSachSua
            // 
            this.btnSachSua.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSachSua.Location = new System.Drawing.Point(195, 103);
            this.btnSachSua.Name = "btnSachSua";
            this.btnSachSua.Size = new System.Drawing.Size(139, 42);
            this.btnSachSua.TabIndex = 1;
            this.btnSachSua.Text = "Sửa";
            this.btnSachSua.UseVisualStyleBackColor = false;
            this.btnSachSua.Click += new System.EventHandler(this.btnSachSua_Click);
            // 
            // btnSachThem
            // 
            this.btnSachThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSachThem.Location = new System.Drawing.Point(44, 108);
            this.btnSachThem.Name = "btnSachThem";
            this.btnSachThem.Size = new System.Drawing.Size(134, 40);
            this.btnSachThem.TabIndex = 0;
            this.btnSachThem.Text = "Thêm";
            this.btnSachThem.UseVisualStyleBackColor = false;
            this.btnSachThem.Click += new System.EventHandler(this.btnSachThem_Click);
            // 
            // dgSach
            // 
            this.dgSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSach.Location = new System.Drawing.Point(3, 62);
            this.dgSach.Name = "dgSach";
            this.dgSach.RowHeadersWidth = 51;
            this.dgSach.RowTemplate.Height = 24;
            this.dgSach.Size = new System.Drawing.Size(858, 268);
            this.dgSach.TabIndex = 0;
            this.dgSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSach_CellClick);
            // 
            // LOAISACH
            // 
            this.LOAISACH.Controls.Add(this.btnLoaiSachSearch);
            this.LOAISACH.Controls.Add(this.txtLoaiSachSearch);
            this.LOAISACH.Controls.Add(this.panel2);
            this.LOAISACH.Controls.Add(this.dgLoaiSach);
            this.LOAISACH.Location = new System.Drawing.Point(4, 29);
            this.LOAISACH.Name = "LOAISACH";
            this.LOAISACH.Padding = new System.Windows.Forms.Padding(3);
            this.LOAISACH.Size = new System.Drawing.Size(892, 507);
            this.LOAISACH.TabIndex = 1;
            this.LOAISACH.Text = "Loại Sách";
            this.LOAISACH.UseVisualStyleBackColor = true;
            // 
            // btnLoaiSachSearch
            // 
            this.btnLoaiSachSearch.BackColor = System.Drawing.Color.Gold;
            this.btnLoaiSachSearch.Location = new System.Drawing.Point(542, 20);
            this.btnLoaiSachSearch.Name = "btnLoaiSachSearch";
            this.btnLoaiSachSearch.Size = new System.Drawing.Size(134, 40);
            this.btnLoaiSachSearch.TabIndex = 16;
            this.btnLoaiSachSearch.Text = "Tìm Kiếm";
            this.btnLoaiSachSearch.UseVisualStyleBackColor = false;
            this.btnLoaiSachSearch.Click += new System.EventHandler(this.btnLoaiSachSearch_Click);
            // 
            // txtLoaiSachSearch
            // 
            this.txtLoaiSachSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiSachSearch.Location = new System.Drawing.Point(331, 23);
            this.txtLoaiSachSearch.Name = "txtLoaiSachSearch";
            this.txtLoaiSachSearch.Size = new System.Drawing.Size(189, 30);
            this.txtLoaiSachSearch.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLoaiSachXoa);
            this.panel2.Controls.Add(this.txtLoaiSachTenLoaiSach);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnLoaiSachSua);
            this.panel2.Controls.Add(this.btnLoaiSachThem);
            this.panel2.Location = new System.Drawing.Point(7, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 110);
            this.panel2.TabIndex = 2;
            // 
            // btnLoaiSachXoa
            // 
            this.btnLoaiSachXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoaiSachXoa.Location = new System.Drawing.Point(427, 62);
            this.btnLoaiSachXoa.Name = "btnLoaiSachXoa";
            this.btnLoaiSachXoa.Size = new System.Drawing.Size(163, 45);
            this.btnLoaiSachXoa.TabIndex = 9;
            this.btnLoaiSachXoa.Text = "Xóa";
            this.btnLoaiSachXoa.UseVisualStyleBackColor = false;
            this.btnLoaiSachXoa.Click += new System.EventHandler(this.btnLoaiSachXoa_Click);
            // 
            // txtLoaiSachTenLoaiSach
            // 
            this.txtLoaiSachTenLoaiSach.Location = new System.Drawing.Point(196, 19);
            this.txtLoaiSachTenLoaiSach.Name = "txtLoaiSachTenLoaiSach";
            this.txtLoaiSachTenLoaiSach.Size = new System.Drawing.Size(371, 27);
            this.txtLoaiSachTenLoaiSach.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tên Loại Sách";
            // 
            // btnLoaiSachSua
            // 
            this.btnLoaiSachSua.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnLoaiSachSua.Location = new System.Drawing.Point(231, 65);
            this.btnLoaiSachSua.Name = "btnLoaiSachSua";
            this.btnLoaiSachSua.Size = new System.Drawing.Size(139, 42);
            this.btnLoaiSachSua.TabIndex = 1;
            this.btnLoaiSachSua.Text = "Sửa";
            this.btnLoaiSachSua.UseVisualStyleBackColor = false;
            this.btnLoaiSachSua.Click += new System.EventHandler(this.btnLoaiSachSua_Click);
            // 
            // btnLoaiSachThem
            // 
            this.btnLoaiSachThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoaiSachThem.Location = new System.Drawing.Point(44, 65);
            this.btnLoaiSachThem.Name = "btnLoaiSachThem";
            this.btnLoaiSachThem.Size = new System.Drawing.Size(134, 40);
            this.btnLoaiSachThem.TabIndex = 0;
            this.btnLoaiSachThem.Text = "Thêm";
            this.btnLoaiSachThem.UseVisualStyleBackColor = false;
            this.btnLoaiSachThem.Click += new System.EventHandler(this.btnLoaiSachThem_Click);
            // 
            // dgLoaiSach
            // 
            this.dgLoaiSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoaiSach.Location = new System.Drawing.Point(7, 72);
            this.dgLoaiSach.Name = "dgLoaiSach";
            this.dgLoaiSach.RowHeadersWidth = 51;
            this.dgLoaiSach.RowTemplate.Height = 24;
            this.dgLoaiSach.Size = new System.Drawing.Size(858, 313);
            this.dgLoaiSach.TabIndex = 1;
            this.dgLoaiSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLoaiSach_CellClick);
            // 
            // HOADON
            // 
            this.HOADON.Controls.Add(this.btnHoaDonSearch);
            this.HOADON.Controls.Add(this.txtHoaDonSearch);
            this.HOADON.Controls.Add(this.panel3);
            this.HOADON.Controls.Add(this.dgHoaDon);
            this.HOADON.Location = new System.Drawing.Point(4, 29);
            this.HOADON.Name = "HOADON";
            this.HOADON.Padding = new System.Windows.Forms.Padding(3);
            this.HOADON.Size = new System.Drawing.Size(892, 507);
            this.HOADON.TabIndex = 2;
            this.HOADON.Text = "Hóa Đơn";
            this.HOADON.UseVisualStyleBackColor = true;
            // 
            // btnHoaDonSearch
            // 
            this.btnHoaDonSearch.BackColor = System.Drawing.Color.Gold;
            this.btnHoaDonSearch.Location = new System.Drawing.Point(483, 21);
            this.btnHoaDonSearch.Name = "btnHoaDonSearch";
            this.btnHoaDonSearch.Size = new System.Drawing.Size(134, 40);
            this.btnHoaDonSearch.TabIndex = 18;
            this.btnHoaDonSearch.Text = "Tìm Kiếm";
            this.btnHoaDonSearch.UseVisualStyleBackColor = false;
            this.btnHoaDonSearch.Click += new System.EventHandler(this.btnHoaDonSearch_Click);
            // 
            // txtHoaDonSearch
            // 
            this.txtHoaDonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDonSearch.Location = new System.Drawing.Point(272, 24);
            this.txtHoaDonSearch.Name = "txtHoaDonSearch";
            this.txtHoaDonSearch.Size = new System.Drawing.Size(189, 30);
            this.txtHoaDonSearch.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnChiTietHD);
            this.panel3.Controls.Add(this.txtHoaDonSDT);
            this.panel3.Controls.Add(this.txtHoaDonTenKH);
            this.panel3.Controls.Add(this.dateTimeHoaDon);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnHoaDonXoa);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnHoaDonSua);
            this.panel3.Controls.Add(this.btnHoaDonThem);
            this.panel3.Location = new System.Drawing.Point(6, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 158);
            this.panel3.TabIndex = 2;
            // 
            // btnChiTietHD
            // 
            this.btnChiTietHD.BackColor = System.Drawing.SystemColors.Info;
            this.btnChiTietHD.Location = new System.Drawing.Point(594, 103);
            this.btnChiTietHD.Name = "btnChiTietHD";
            this.btnChiTietHD.Size = new System.Drawing.Size(163, 45);
            this.btnChiTietHD.TabIndex = 19;
            this.btnChiTietHD.Text = "Chi Tiết";
            this.btnChiTietHD.UseVisualStyleBackColor = false;
            this.btnChiTietHD.Click += new System.EventHandler(this.btnChiTietHD_Click);
            // 
            // txtHoaDonSDT
            // 
            this.txtHoaDonSDT.Location = new System.Drawing.Point(594, 63);
            this.txtHoaDonSDT.Name = "txtHoaDonSDT";
            this.txtHoaDonSDT.Size = new System.Drawing.Size(233, 27);
            this.txtHoaDonSDT.TabIndex = 17;
            this.txtHoaDonSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoaDonSDT_KeyPress);
            // 
            // txtHoaDonTenKH
            // 
            this.txtHoaDonTenKH.Location = new System.Drawing.Point(201, 57);
            this.txtHoaDonTenKH.Name = "txtHoaDonTenKH";
            this.txtHoaDonTenKH.Size = new System.Drawing.Size(209, 27);
            this.txtHoaDonTenKH.TabIndex = 16;
            // 
            // dateTimeHoaDon
            // 
            this.dateTimeHoaDon.Location = new System.Drawing.Point(218, 5);
            this.dateTimeHoaDon.Name = "dateTimeHoaDon";
            this.dateTimeHoaDon.Size = new System.Drawing.Size(327, 27);
            this.dateTimeHoaDon.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số Điện Thoại:";
            // 
            // btnHoaDonXoa
            // 
            this.btnHoaDonXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHoaDonXoa.Location = new System.Drawing.Point(382, 106);
            this.btnHoaDonXoa.Name = "btnHoaDonXoa";
            this.btnHoaDonXoa.Size = new System.Drawing.Size(163, 45);
            this.btnHoaDonXoa.TabIndex = 9;
            this.btnHoaDonXoa.Text = "Xóa";
            this.btnHoaDonXoa.UseVisualStyleBackColor = false;
            this.btnHoaDonXoa.Click += new System.EventHandler(this.btnHoaDonXoa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tên Khách Hàng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ngày Lập Hóa Đơn:";
            // 
            // btnHoaDonSua
            // 
            this.btnHoaDonSua.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnHoaDonSua.Location = new System.Drawing.Point(201, 107);
            this.btnHoaDonSua.Name = "btnHoaDonSua";
            this.btnHoaDonSua.Size = new System.Drawing.Size(139, 42);
            this.btnHoaDonSua.TabIndex = 1;
            this.btnHoaDonSua.Text = "Sửa";
            this.btnHoaDonSua.UseVisualStyleBackColor = false;
            this.btnHoaDonSua.Click += new System.EventHandler(this.btnHoaDonSua_Click);
            // 
            // btnHoaDonThem
            // 
            this.btnHoaDonThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHoaDonThem.Location = new System.Drawing.Point(47, 108);
            this.btnHoaDonThem.Name = "btnHoaDonThem";
            this.btnHoaDonThem.Size = new System.Drawing.Size(134, 40);
            this.btnHoaDonThem.TabIndex = 0;
            this.btnHoaDonThem.Text = "Thêm";
            this.btnHoaDonThem.UseVisualStyleBackColor = false;
            this.btnHoaDonThem.Click += new System.EventHandler(this.btnHoaDonThem_Click);
            // 
            // dgHoaDon
            // 
            this.dgHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHoaDon.Location = new System.Drawing.Point(6, 71);
            this.dgHoaDon.Name = "dgHoaDon";
            this.dgHoaDon.RowHeadersWidth = 51;
            this.dgHoaDon.RowTemplate.Height = 24;
            this.dgHoaDon.Size = new System.Drawing.Size(880, 254);
            this.dgHoaDon.TabIndex = 1;
            this.dgHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHoaDon_CellClick);
            // 
            // PHIEUNHAP
            // 
            this.PHIEUNHAP.Controls.Add(this.btnPhieuNhapSearch);
            this.PHIEUNHAP.Controls.Add(this.txtPhieuNhapSearch);
            this.PHIEUNHAP.Controls.Add(this.panel4);
            this.PHIEUNHAP.Controls.Add(this.dgPhieuNhap);
            this.PHIEUNHAP.Location = new System.Drawing.Point(4, 29);
            this.PHIEUNHAP.Name = "PHIEUNHAP";
            this.PHIEUNHAP.Padding = new System.Windows.Forms.Padding(3);
            this.PHIEUNHAP.Size = new System.Drawing.Size(892, 507);
            this.PHIEUNHAP.TabIndex = 3;
            this.PHIEUNHAP.Text = "Phiếu Nhập";
            this.PHIEUNHAP.UseVisualStyleBackColor = true;
            // 
            // btnPhieuNhapSearch
            // 
            this.btnPhieuNhapSearch.BackColor = System.Drawing.Color.Gold;
            this.btnPhieuNhapSearch.Location = new System.Drawing.Point(505, 12);
            this.btnPhieuNhapSearch.Name = "btnPhieuNhapSearch";
            this.btnPhieuNhapSearch.Size = new System.Drawing.Size(134, 40);
            this.btnPhieuNhapSearch.TabIndex = 20;
            this.btnPhieuNhapSearch.Text = "Tìm Kiếm";
            this.btnPhieuNhapSearch.UseVisualStyleBackColor = false;
            this.btnPhieuNhapSearch.Click += new System.EventHandler(this.btnPhieuNhapSearch_Click);
            // 
            // txtPhieuNhapSearch
            // 
            this.txtPhieuNhapSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhieuNhapSearch.Location = new System.Drawing.Point(294, 15);
            this.txtPhieuNhapSearch.Name = "txtPhieuNhapSearch";
            this.txtPhieuNhapSearch.Size = new System.Drawing.Size(189, 30);
            this.txtPhieuNhapSearch.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnChiTietPN);
            this.panel4.Controls.Add(this.txtPhieuNhapTenNCC);
            this.panel4.Controls.Add(this.DateLapPhieuNhap);
            this.panel4.Controls.Add(this.btnPhieuNhapXoa);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnPhieuNhapSua);
            this.panel4.Controls.Add(this.btnPhieuNhapThem);
            this.panel4.Location = new System.Drawing.Point(17, 366);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(859, 125);
            this.panel4.TabIndex = 3;
            // 
            // btnChiTietPN
            // 
            this.btnChiTietPN.BackColor = System.Drawing.SystemColors.Info;
            this.btnChiTietPN.Location = new System.Drawing.Point(565, 64);
            this.btnChiTietPN.Name = "btnChiTietPN";
            this.btnChiTietPN.Size = new System.Drawing.Size(163, 45);
            this.btnChiTietPN.TabIndex = 18;
            this.btnChiTietPN.Text = "Chi Tiết";
            this.btnChiTietPN.UseVisualStyleBackColor = false;
            this.btnChiTietPN.Click += new System.EventHandler(this.btnChiTietPN_Click_1);
            // 
            // txtPhieuNhapTenNCC
            // 
            this.txtPhieuNhapTenNCC.Location = new System.Drawing.Point(604, 17);
            this.txtPhieuNhapTenNCC.Name = "txtPhieuNhapTenNCC";
            this.txtPhieuNhapTenNCC.Size = new System.Drawing.Size(169, 27);
            this.txtPhieuNhapTenNCC.TabIndex = 17;
            // 
            // DateLapPhieuNhap
            // 
            this.DateLapPhieuNhap.Location = new System.Drawing.Point(199, 15);
            this.DateLapPhieuNhap.Name = "DateLapPhieuNhap";
            this.DateLapPhieuNhap.Size = new System.Drawing.Size(267, 27);
            this.DateLapPhieuNhap.TabIndex = 15;
            // 
            // btnPhieuNhapXoa
            // 
            this.btnPhieuNhapXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPhieuNhapXoa.Location = new System.Drawing.Point(348, 67);
            this.btnPhieuNhapXoa.Name = "btnPhieuNhapXoa";
            this.btnPhieuNhapXoa.Size = new System.Drawing.Size(163, 45);
            this.btnPhieuNhapXoa.TabIndex = 9;
            this.btnPhieuNhapXoa.Text = "Xóa";
            this.btnPhieuNhapXoa.UseVisualStyleBackColor = false;
            this.btnPhieuNhapXoa.Click += new System.EventHandler(this.btnPhieuNhapXoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên NCC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ngày Lập Phiếu Nhập";
            // 
            // btnPhieuNhapSua
            // 
            this.btnPhieuNhapSua.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnPhieuNhapSua.Location = new System.Drawing.Point(178, 65);
            this.btnPhieuNhapSua.Name = "btnPhieuNhapSua";
            this.btnPhieuNhapSua.Size = new System.Drawing.Size(139, 42);
            this.btnPhieuNhapSua.TabIndex = 1;
            this.btnPhieuNhapSua.Text = "Sửa";
            this.btnPhieuNhapSua.UseVisualStyleBackColor = false;
            this.btnPhieuNhapSua.Click += new System.EventHandler(this.btnPhieuNhapSua_Click);
            // 
            // btnPhieuNhapThem
            // 
            this.btnPhieuNhapThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPhieuNhapThem.Location = new System.Drawing.Point(24, 67);
            this.btnPhieuNhapThem.Name = "btnPhieuNhapThem";
            this.btnPhieuNhapThem.Size = new System.Drawing.Size(134, 40);
            this.btnPhieuNhapThem.TabIndex = 0;
            this.btnPhieuNhapThem.Text = "Thêm";
            this.btnPhieuNhapThem.UseVisualStyleBackColor = false;
            this.btnPhieuNhapThem.Click += new System.EventHandler(this.btnPhieuNhapThem_Click);
            // 
            // dgPhieuNhap
            // 
            this.dgPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPhieuNhap.Location = new System.Drawing.Point(6, 60);
            this.dgPhieuNhap.Name = "dgPhieuNhap";
            this.dgPhieuNhap.RowHeadersWidth = 51;
            this.dgPhieuNhap.RowTemplate.Height = 24;
            this.dgPhieuNhap.Size = new System.Drawing.Size(870, 256);
            this.dgPhieuNhap.TabIndex = 2;
            this.dgPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhieuNhap_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 564);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyBanSach";
            this.tabControl1.ResumeLayout(false);
            this.SACH.ResumeLayout(false);
            this.SACH.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSachGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSachSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).EndInit();
            this.LOAISACH.ResumeLayout(false);
            this.LOAISACH.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoaiSach)).EndInit();
            this.HOADON.ResumeLayout(false);
            this.HOADON.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).EndInit();
            this.PHIEUNHAP.ResumeLayout(false);
            this.PHIEUNHAP.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SACH;
        private System.Windows.Forms.TabPage LOAISACH;
        private System.Windows.Forms.TabPage HOADON;
        private System.Windows.Forms.TabPage PHIEUNHAP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgSach;
        private System.Windows.Forms.Button btnSachThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSachSua;
        private System.Windows.Forms.TextBox txtSachTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSachLoaiSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSachXoa;
        private System.Windows.Forms.TextBox txtSachTacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSachSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSachGiaBan;
        private System.Windows.Forms.DataGridView dgLoaiSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLoaiSachXoa;
        private System.Windows.Forms.TextBox txtLoaiSachTenLoaiSach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoaiSachSua;
        private System.Windows.Forms.Button btnLoaiSachThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHoaDonXoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHoaDonSua;
        private System.Windows.Forms.Button btnHoaDonThem;
        private System.Windows.Forms.DataGridView dgHoaDon;
        private System.Windows.Forms.DateTimePicker dateTimeHoaDon;
        private System.Windows.Forms.TextBox txtHoaDonSDT;
        private System.Windows.Forms.TextBox txtHoaDonTenKH;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPhieuNhapTenNCC;
        private System.Windows.Forms.DateTimePicker DateLapPhieuNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPhieuNhapSua;
        private System.Windows.Forms.Button btnPhieuNhapThem;
        private System.Windows.Forms.DataGridView dgPhieuNhap;
        private System.Windows.Forms.Button btnPhieuNhapXoa;
        private System.Windows.Forms.TextBox txtSearchSach;
        private System.Windows.Forms.Button btnSachSearch;
        private System.Windows.Forms.Button btnLoaiSachSearch;
        private System.Windows.Forms.TextBox txtLoaiSachSearch;
        private System.Windows.Forms.Button btnHoaDonSearch;
        private System.Windows.Forms.TextBox txtHoaDonSearch;
        private System.Windows.Forms.Button btnPhieuNhapSearch;
        private System.Windows.Forms.TextBox txtPhieuNhapSearch;
        private System.Windows.Forms.Button btnChiTietPN;
        private System.Windows.Forms.Button btnChiTietHD;
    }
}

