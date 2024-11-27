CREATE DATABASE QLBS
USE QLBS

-- Bảng tbl_loai_sach
CREATE TABLE tbl_loai_sach (
    ma_loai_sach INT PRIMARY KEY IDENTITY,
    ten_loai_sach NVARCHAR(100)
);

-- Bảng tbl_sach
CREATE TABLE tbl_sach (
    ma_sach INT PRIMARY KEY IDENTITY,
    ten_sach NVARCHAR(100),
    ma_loai_sach INT,
    tac_gia NVARCHAR(100),
    so_luong INT,
    gia_ban DECIMAL(18, 2),
    FOREIGN KEY (ma_loai_sach) REFERENCES tbl_loai_sach(ma_loai_sach)
);

-- Bảng tbl_hoa_don
CREATE TABLE tbl_hoa_don (
    ma_hoa_don INT PRIMARY KEY IDENTITY,
    ngay_lap_hoa_don DATE,
    ten_khach_hang NVARCHAR(100),
    sdt_khach_hang NVARCHAR(15)
);

-- Bảng tbl_chi_tiet_hoa_don
CREATE TABLE tbl_chi_tiet_hoa_don (
    ma_hoa_don INT,
    ma_sach INT,
    so_luong INT,
    PRIMARY KEY (ma_hoa_don, ma_sach),
);

-- Bảng tbl_phieu_nhap
CREATE TABLE tbl_phieu_nhap (
    ma_phieu_nhap INT PRIMARY KEY IDENTITY,
    ngay_lap_phieu_nhap DATE,
    ten_nha_cung_cap NVARCHAR(100)
);

-- Bảng tbl_chi_tiet_phieu_nhap
CREATE TABLE tbl_chi_tiet_phieu_nhap (
    ma_phieu_nhap INT,
    ma_sach INT,
    so_luong INT,
	gia_nhap FLOAT,
    PRIMARY KEY (ma_phieu_nhap, ma_sach),
    FOREIGN KEY (ma_phieu_nhap) REFERENCES tbl_phieu_nhap(ma_phieu_nhap),
    FOREIGN KEY (ma_sach) REFERENCES tbl_sach(ma_sach)
);




CREATE TABLE TaiKhoan (
	ma_tai_khoan INT PRIMARY KEY IDENTITY,
	user_name nvarchar(100),
	pass_word nvarchar(100)
)


CREATE PROC proc_them_sach 
@tenSach NVARCHAR(256), @maLoaiSach int, @tacGia NVARCHAR(256), @soLuong INT, @giaBan FLOAT
AS 
	BEGIN 
	   INSERT INTO tbl_sach(ten_sach, ma_loai_sach, tac_gia, so_luong, gia_ban)
	   VALUES(@tenSach, @maLoaiSach, @tacGia, @soLuong, @giaBan)
	END


CREATE PROC proc_cap_nhat_sach 
@maSach INT, @tenSach NVARCHAR(256), @maLoaiSach int, @tacGia NVARCHAR(256), @soLuong int, @giaBan float
AS 
   BEGIN 
       UPDATE tbl_sach 
	   SET ten_sach = @tenSach, ma_loai_sach = @maLoaiSach, tac_gia = @tacGia, so_luong = @soLuong, gia_ban = @giaBan
	   WHERE ma_sach = @maSach
	END



CREATE PROC proc_them_loai_sach 
	@ten_loai_sach NVARCHAR(256)
AS 
   BEGIN
      INSERT INTO tbl_loai_sach(ten_loai_sach) VALUES(@ten_loai_sach)
	END



CREATE proc proc_cap_nhat_loai_sach 
@maLoaiSach int, @tenLoaiSach nvarchar(256)
as 
   begin 
      update tbl_loai_sach
	  SET ten_loai_sach = @tenLoaiSach
	  WHERE ma_loai_sach = @maLoaiSach
    END 


-- Thêm hóa đơn
CREATE PROC proc_them_hoa_don 
    @ngayLapHoaDon DATE, @tenKhachHang NVARCHAR(256), @sdtKhachHang NVARCHAR(15)
AS 
BEGIN
    INSERT INTO tbl_hoa_don(ngay_lap_hoa_don, ten_khach_hang, sdt_khach_hang)
    VALUES(@ngayLapHoaDon, @tenKhachHang, @sdtKhachHang)
END



CREATE PROC proc_cap_nhat_hoa_don 
    @maHoaDon INT, @ngayLapHoaDon DATE, @tenKhachHang NVARCHAR(256), @sdtKhachHang NVARCHAR(15)
AS 
BEGIN
    UPDATE tbl_hoa_don
    SET ngay_lap_hoa_don = @ngayLapHoaDon, 
        ten_khach_hang = @tenKhachHang, 
        sdt_khach_hang = @sdtKhachHang
    WHERE ma_hoa_don = @maHoaDon
END


-- Thêm chi tiết hóa đơn
CREATE PROC proc_them_chi_tiet_hoa_don 
    @maHoaDon INT, @maSach INT, @soLuong INT
AS 
BEGIN
    INSERT INTO tbl_chi_tiet_hoa_don(ma_hoa_don, ma_sach, so_luong)
    VALUES(@maHoaDon, @maSach, @soLuong)
END




-- Thêm chi tiết hóa đơn
CREATE PROC proc_them_chi_tiet_hoa_don 
    @maHoaDon INT, @maSach INT, @soLuong INT, @giaHoaDon FLOAT
AS 
BEGIN
    INSERT INTO tbl_chi_tiet_hoa_don(ma_hoa_don, ma_sach, so_luong, gia_hoa_don)
    VALUES(@maHoaDon, @maSach, @soLuong, @giaHoaDon)
END


-- Cập nhật chi tiết hóa đơn
CREATE PROC proc_cap_nhat_chi_tiet_hoa_don 
    @maHoaDon INT, @maSach INT, @soLuong INT, @giaHoaDon FLOAT
AS 
BEGIN
    UPDATE tbl_chi_tiet_hoa_don
    SET so_luong = @soLuong
    WHERE ma_hoa_don = @maHoaDon AND ma_sach = @maSach
END



-- Thêm phiếu nhập
CREATE PROC proc_them_phieu_nhap 
    @ngayLapPhieuNhap DATE, @tenNhaCungCap NVARCHAR(256)
AS 
BEGIN
    INSERT INTO tbl_phieu_nhap(ngay_lap_phieu_nhap, ten_nha_cung_cap)
    VALUES(@ngayLapPhieuNhap, @tenNhaCungCap)
END


-- Cập nhật phiếu nhập
CREATE PROC proc_cap_nhat_phieu_nhap 
    @maPhieuNhap INT, @ngayLapPhieuNhap DATE, @tenNhaCungCap NVARCHAR(256)
AS 
BEGIN
    UPDATE tbl_phieu_nhap
    SET ngay_lap_phieu_nhap = @ngayLapPhieuNhap, 
        ten_nha_cung_cap = @tenNhaCungCap
    WHERE ma_phieu_nhap = @maPhieuNhap
END


-- Thêm chi tiết phiếu nhập
CREATE PROC proc_them_chi_tiet_phieu_nhap 
    @maPhieuNhap INT, @maSach INT, @soLuong INT, @giaNhap float
AS 
BEGIN
    INSERT INTO tbl_chi_tiet_phieu_nhap(ma_phieu_nhap, ma_sach, so_luong, gia_nhap)
    VALUES(@maPhieuNhap, @maSach, @soLuong, @giaNhap)
END



CREATE PROC proc_cap_nhat_chi_tiet_phieu_nhap 
    @maPhieuNhap INT, @maSach INT, @soLuong INT,  @giaNhap float
AS 
BEGIN
    UPDATE tbl_chi_tiet_phieu_nhap
    SET so_luong = @soLuong
    WHERE ma_phieu_nhap = @maPhieuNhap AND ma_sach = @maSach
END



ALTER TABLE tbl_sach
ADD CONSTRAINT fk_tbl_sach_ma_loai_sach
FOREIGN KEY (ma_loai_sach) REFERENCES tbl_loai_sach(ma_loai_sach)
ON DELETE CASCADE
ON UPDATE CASCADE;


ALTER TABLE tbl_chi_tiet_hoa_don
ADD CONSTRAINT fk_tbl_chi_tiet_hoa_don_ma_hoa_don
FOREIGN KEY (ma_hoa_don) REFERENCES tbl_hoa_don(ma_hoa_don)
ON DELETE CASCADE
ON UPDATE CASCADE;



ALTER TABLE tbl_chi_tiet_hoa_don
ADD CONSTRAINT fk_tbl_chi_tiet_hoa_don_ma_sach
FOREIGN KEY (ma_sach) REFERENCES tbl_sach(ma_sach)
ON DELETE CASCADE
ON UPDATE CASCADE;


ALTER TABLE tbl_chi_tiet_phieu_nhap
ADD CONSTRAINT fk_tbl_chi_tiet_phieu_nhap_ma_phieu_nhap
FOREIGN KEY (ma_phieu_nhap) REFERENCES tbl_phieu_nhap(ma_phieu_nhap)
ON DELETE CASCADE
ON UPDATE CASCADE;


ALTER TABLE tbl_chi_tiet_phieu_nhap
ADD CONSTRAINT fk_tbl_chi_tiet_phieu_nhap_ma_sach
FOREIGN KEY (ma_sach) REFERENCES tbl_sach(ma_sach)
ON DELETE CASCADE
ON UPDATE CASCADE;
