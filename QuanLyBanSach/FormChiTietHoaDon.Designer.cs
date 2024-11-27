namespace QuanLyBanSach
{
    partial class FormChiTietHoaDon
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
            this.dgChiTietHD = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSachGiaHoaDon = new System.Windows.Forms.NumericUpDown();
            this.numSachSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTenSach = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietHD)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSachGiaHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSachSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgChiTietHD
            // 
            this.dgChiTietHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTietHD.Location = new System.Drawing.Point(21, 51);
            this.dgChiTietHD.Name = "dgChiTietHD";
            this.dgChiTietHD.RowHeadersWidth = 51;
            this.dgChiTietHD.RowTemplate.Height = 24;
            this.dgChiTietHD.Size = new System.Drawing.Size(871, 329);
            this.dgChiTietHD.TabIndex = 0;
            this.dgChiTietHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChiTietHD_CellClick);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(285, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(234, 29);
            this.title.TabIndex = 1;
            this.title.Text = "Chi Tiết Hóa Đơn 1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.txtTongTien);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.numSachGiaHoaDon);
            this.panel4.Controls.Add(this.numSachSoLuong);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cbTenSach);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Location = new System.Drawing.Point(21, 409);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(871, 125);
            this.panel4.TabIndex = 5;
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(680, 83);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(114, 20);
            this.txtTongTien.TabIndex = 19;
            this.txtTongTien.Text = "Tổng Tiền: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Gía Hóa Đơn";
            // 
            // numSachGiaHoaDon
            // 
            this.numSachGiaHoaDon.Location = new System.Drawing.Point(712, 7);
            this.numSachGiaHoaDon.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSachGiaHoaDon.Name = "numSachGiaHoaDon";
            this.numSachGiaHoaDon.Size = new System.Drawing.Size(156, 22);
            this.numSachGiaHoaDon.TabIndex = 17;
            // 
            // numSachSoLuong
            // 
            this.numSachSoLuong.Location = new System.Drawing.Point(434, 10);
            this.numSachSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSachSoLuong.Name = "numSachSoLuong";
            this.numSachSoLuong.Size = new System.Drawing.Size(123, 22);
            this.numSachSoLuong.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số Lương:";
            // 
            // cbTenSach
            // 
            this.cbTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSach.FormattingEnabled = true;
            this.cbTenSach.Location = new System.Drawing.Point(128, 6);
            this.cbTenSach.Name = "cbTenSach";
            this.cbTenSach.Size = new System.Drawing.Size(183, 28);
            this.cbTenSach.TabIndex = 10;
            this.cbTenSach.SelectedIndexChanged += new System.EventHandler(this.cbTenSach_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Location = new System.Drawing.Point(299, 72);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(163, 45);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên Sách:";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSua.Location = new System.Drawing.Point(143, 71);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(139, 42);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThem.Location = new System.Drawing.Point(3, 70);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(468, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 571);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dgChiTietHD);
            this.Name = "FormChiTietHoaDon";
            this.Text = "FormChiTietHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietHD)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSachGiaHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSachSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgChiTietHD;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSachGiaHoaDon;
        private System.Windows.Forms.NumericUpDown numSachSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTenSach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button1;
    }
}