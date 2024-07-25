﻿CREATE DATABASE QLCHOCO
ALTER DATABASE QLCHOCO COLLATE Vietnamese_CI_AS;
ALTER TABLE NHANVIEN ALTER COLUMN HOTEN NVARCHAR(100) COLLATE Vietnamese_CI_AS;

CREATE TABLE NHANVIEN(
	MANV INT IDENTITY(1,1) NOT NULL,
	HOTEN NVARCHAR(100) NOT NULL,
	DIACHI NVARCHAR(200) NOT NULL,
	SODIENTHOAI VARCHAR(10) NOT NULL,
	GIOITINH INT,
	TENTAIKHOAN NVARCHAR(100) NOT NULL,
	MATKHAU VARCHAR(20) NOT NULL,
	VAITRO NVARCHAR(10) NOT NULL
	PRIMARY KEY(MANV)
);

CREATE TABLE NHACUNGCAP(
	MANCC INT IDENTITY(1,1) NOT NULL,
	TENNHACUNGCAP NVARCHAR(100) NOT NULL
	PRIMARY KEY (MANCC)
);

CREATE TABLE KHACHHANG(
	MAKH INT IDENTITY(1,1) NOT NULL,
	HOTEN NVARCHAR(100) NOT NULL,
	DIACHI NVARCHAR(200) NULL,
	SODIENTHOAI VARCHAR(10) NOT NULL,
	DIEMTICHLUY INT NULL
	PRIMARY KEY (MAKH)
);

CREATE TABLE DANHMUCSANPHAM(
	MADMSP INT IDENTITY(1,1) NOT NULL,
	LOAI NVARCHAR(50) NOT NULL,
	KICHTHUOC NVARCHAR(50) NOT NULL
	PRIMARY KEY (MADMSP)
);

CREATE TABLE HOADON(
	MAHD INT IDENTITY(1,1) NOT NULL,
	MANV INT NOT NULL,
	MAKH INT NOT NULL,
	GIAMGIA FLOAT NULL,
	NGAYBANGHANG DATETIME NOT NULL
	PRIMARY KEY(MAHD)
	FOREIGN KEY (MANV) REFERENCES NHANVIEN (MANV),
	FOREIGN KEY (MAKH) REFERENCES KHACHHANG (MAKH)
);

CREATE TABLE SANPHAM(
	MASP INT IDENTITY(1,1) NOT NULL,
	TENSP NVARCHAR(100) NOT NULL,
	HANSUDUNG DATETIME NOT NULL,
	NGAYSANXUAT DATETIME NOT NULL,
	DONGIA FLOAT NOT NULL,
	SOLUONG INT NOT NULL,
	HINHSP IMAGE NULL,
	MADMSP INT NOT NULL,
	MANCC INT NOT NULL,
	PRIMARY KEY (MASP),
	FOREIGN KEY (MADMSP) REFERENCES DANHMUCSANPHAM (MADMSP),
	FOREIGN KEY (MANCC) REFERENCES NHACUNGCAP (MANCC)
);

CREATE TABLE CTHD(
	MACTHD INT IDENTITY(1,1) NOT NULL,
	MAHD INT NOT NULL,
	MASP INT NOT NULL,
	SOLUONG INT NOT NULL,
	DONGIA FLOAT NOT NULL
	FOREIGN KEY (MASP) REFERENCES SANPHAM (MASP),
	FOREIGN KEY (MAHD) REFERENCES HOADON (MAHD)
);

CREATE TRIGGER TRG_AfterDelete_NHANVIEN
ON NHANVIEN
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TempTable TABLE (NewID INT, HOTEN NVARCHAR(100), DIACHI NVARCHAR(200), SODIENTHOAI VARCHAR(10), GIOITINH INT, TENTAIKHOAN NVARCHAR(100), MATKHAU VARCHAR(20), VAITRO NVARCHAR(10));

    INSERT INTO @TempTable (NewID, HOTEN, DIACHI, SODIENTHOAI, GIOITINH, TENTAIKHOAN, MATKHAU, VAITRO)
    SELECT ROW_NUMBER() OVER (ORDER BY MANV), HOTEN, DIACHI, SODIENTHOAI, GIOITINH, TENTAIKHOAN, MATKHAU, VAITRO
    FROM NHANVIEN;

    DELETE FROM NHANVIEN;

    DBCC CHECKIDENT ('NHANVIEN', RESEED, 0);

    SET IDENTITY_INSERT NHANVIEN ON;

    INSERT INTO NHANVIEN (MANV, HOTEN, DIACHI, SODIENTHOAI, GIOITINH, TENTAIKHOAN, MATKHAU, VAITRO)
    SELECT NewID, HOTEN, DIACHI, SODIENTHOAI, GIOITINH, TENTAIKHOAN, MATKHAU, VAITRO
    FROM @TempTable;

    SET IDENTITY_INSERT NHANVIEN OFF;
END;

CREATE TRIGGER TRG_AfterDelete_NHACUNGCAP
ON NHACUNGCAP
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TempTable TABLE (NewID INT, TENNHACUNGCAP NVARCHAR(100));

    INSERT INTO @TempTable (NewID, TENNHACUNGCAP)
    SELECT ROW_NUMBER() OVER (ORDER BY MANCC), TENNHACUNGCAP
    FROM NHACUNGCAP;

    DELETE FROM NHACUNGCAP;

    DBCC CHECKIDENT ('NHACUNGCAP', RESEED, 0);

    SET IDENTITY_INSERT NHACUNGCAP ON;

    INSERT INTO NHACUNGCAP (MANCC, TENNHACUNGCAP)
    SELECT NewID, TENNHACUNGCAP
    FROM @TempTable;

    SET IDENTITY_INSERT NHACUNGCAP OFF;
END;

CREATE TRIGGER TRG_AfterDelete_KHACHHANG
ON KHACHHANG
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TempTable TABLE (NewID INT, HOTEN NVARCHAR(100), DIACHI NVARCHAR(200), SODIENTHOAI VARCHAR(10), DIEMTICHLUY INT);

    INSERT INTO @TempTable (NewID, HOTEN, DIACHI, SODIENTHOAI, DIEMTICHLUY)
    SELECT ROW_NUMBER() OVER (ORDER BY MAKH), HOTEN, DIACHI, SODIENTHOAI, DIEMTICHLUY
    FROM KHACHHANG;

    DELETE FROM KHACHHANG;

    DBCC CHECKIDENT ('KHACHHANG', RESEED, 0);

    SET IDENTITY_INSERT KHACHHANG ON;

    INSERT INTO KHACHHANG (MAKH, HOTEN, DIACHI, SODIENTHOAI, DIEMTICHLUY)
    SELECT NewID, HOTEN, DIACHI, SODIENTHOAI, DIEMTICHLUY
    FROM @TempTable;

    SET IDENTITY_INSERT KHACHHANG OFF;
END;

CREATE TRIGGER TRG_AfterDelete_DANHMUCSANPHAM
ON DANHMUCSANPHAM
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TempTable TABLE (NewID INT, LOAI NVARCHAR(50), KICHTHUOC NVARCHAR(50));

    INSERT INTO @TempTable (NewID, LOAI, KICHTHUOC)
    SELECT ROW_NUMBER() OVER (ORDER BY MADMSP), LOAI, KICHTHUOC
    FROM DANHMUCSANPHAM;

    DELETE FROM DANHMUCSANPHAM;

    DBCC CHECKIDENT ('DANHMUCSANPHAM', RESEED, 0);

    SET IDENTITY_INSERT DANHMUCSANPHAM ON;

    INSERT INTO DANHMUCSANPHAM (MADMSP, LOAI, KICHTHUOC)
    SELECT NewID, LOAI, KICHTHUOC
    FROM @TempTable;

    SET IDENTITY_INSERT DANHMUCSANPHAM OFF;
END;

CREATE TRIGGER TRG_AfterDelete_HOADON
ON HOADON
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TempTable TABLE (NewID INT, MANV INT, MAKH INT, GIAMGIA FLOAT, NGAYBANGHANG DATETIME);

    INSERT INTO @TempTable (NewID, MANV, MAKH, GIAMGIA, NGAYBANGHANG)
    SELECT ROW_NUMBER() OVER (ORDER BY MAHD), MANV, MAKH, GIAMGIA, NGAYBANGHANG
    FROM HOADON;

    DELETE FROM HOADON;

    DBCC CHECKIDENT ('HOADON', RESEED, 0);

    SET IDENTITY_INSERT HOADON ON;

    INSERT INTO HOADON (MAHD, MANV, MAKH, GIAMGIA, NGAYBANGHANG)
    SELECT NewID, MANV, MAKH, GIAMGIA, NGAYBANGHANG
    FROM @TempTable;

    SET IDENTITY_INSERT HOADON OFF;
END;

CREATE TRIGGER TRG_AfterDelete_SANPHAM
ON SANPHAM
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TempTable TABLE (NewID INT, TENSP NVARCHAR(100), HANSUDUNG DATETIME, NGAYSANXUAT DATETIME, DONGIA FLOAT, SOLUONG INT, HINHSP IMAGE, MADMSP INT, MANCC INT);

    INSERT INTO @TempTable (NewID, TENSP, HANSUDUNG, NGAYSANXUAT, DONGIA, SOLUONG, HINHSP, MADMSP, MANCC)
    SELECT ROW_NUMBER() OVER (ORDER BY MASP), TENSP, HANSUDUNG, NGAYSANXUAT, DONGIA, SOLUONG, HINHSP, MADMSP, MANCC
    FROM SANPHAM;

    DELETE FROM SANPHAM;

    DBCC CHECKIDENT ('SANPHAM', RESEED, 0);

    SET IDENTITY_INSERT SANPHAM ON;

    INSERT INTO SANPHAM (MASP, TENSP, HANSUDUNG, NGAYSANXUAT, DONGIA, SOLUONG, HINHSP, MADMSP, MANCC)
    SELECT NewID, TENSP, HANSUDUNG, NGAYSANXUAT, DONGIA, SOLUONG, HINHSP, MADMSP, MANCC
    FROM @TempTable;

    SET IDENTITY_INSERT SANPHAM OFF;
END;

CREATE TRIGGER TRG_AfterDelete_CTHD
ON CTHD
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TempTable TABLE (NewID INT, MAHD INT, MASP INT, SOLUONG INT, DONGIA FLOAT);

    INSERT INTO @TempTable (NewID, MAHD, MASP, SOLUONG, DONGIA)
    SELECT ROW_NUMBER() OVER (ORDER BY MACTHD), MAHD, MASP, SOLUONG, DONGIA
    FROM CTHD;

    DELETE FROM CTHD;

    DBCC CHECKIDENT ('CTHD', RESEED, 0);

    SET IDENTITY_INSERT CTHD ON;

    INSERT INTO CTHD (MACTHD, MAHD, MASP, SOLUONG, DONGIA)
    SELECT NewID, MAHD, MASP, SOLUONG, DONGIA
    FROM @TempTable;

    SET IDENTITY_INSERT CTHD OFF;
END;


INSERT INTO DANHMUCSANPHAM(LOAI, KICHTHUOC)
VALUES
('Bars','LARGE'),
('Bars','SMALL'),
('Bites','LARGE'),
('Bites','SMALL'),
('Other','LARGE'),
('Other','SMALL');

INSERT INTO NHACUNGCAP(TENNHACUNGCAP)
VALUES
('Hershey'),
('Snicker'),
('Nestle'),
('Dove'),
('M&M');

INSERT INTO NHANVIEN(HOTEN, DIACHI, SODIENTHOAI, GIOITINH, TENTAIKHOAN, MATKHAU, VAITRO)
VALUES
(N'Nguyễn Văn Thịnh',N'458/3F Nguyễn Hữu Thọ','0793648213','0','ThinhVan2003','321','Nhân Viên'),
(N'Âu Dương Thúy Nguyên',N'173 Phạm Hùng','0941411005','1','NguyenAu','123','Admin');

INSERT INTO SANPHAM(TENSP, HANSUDUNG, NGAYSANXUAT, DONGIA, SOLUONG, MADMSP, MANCC)
VALUES
('Milk Bars','03/05/2025','03/05/2024','1.52','634','2','3'),
('50% Dark Bites','03/05/2025','03/05/2024', '2.57','247','1','2'),
('Almond Choco','03/05/2025','03/05/2024', '9.6','387','5','5'),
('Raspberry Choco','03/05/2025','03/05/2024', '4.09','984','1','2'),
('Mint Chip Choco','03/05/2025','03/05/2024', '1.54','284','4','2'),
('Eclairs','03/05/2025','03/05/2024', '2.24','647','2','1'),
('Drinking Coco','03/05/2025','03/05/2024', '1.62','218','4','5'),
('99% Dark & Pure','03/05/2025','03/05/2024', '2.47','945','6','2'),
('Orange Choco','03/05/2025','03/05/2024', '7.14','398','3','4'),
('After Eight','03/05/2025','03/05/2024', '4.43','842','3','1'),
('Fruit & Nut Bars','03/05/2025','03/05/2024', '1.58','345','4','2'),
('85% Dark Bars','03/05/2025','03/05/2024', '0.64','572','1','1'),
('White Choco','03/05/2025','03/05/2024', '0.16','961','4','2'),
('Bakers Choco Chips','03/05/2025','03/05/2024', '3.4','748','3','2'),
('Organic Choco Syrup','03/05/2025','03/05/2024', '1.47','682','6','5'),
('Caramel Stuffed Bars','03/05/2025','03/05/2024', '0.54','183','3','2'),
('Manuka Honey Choco','03/05/2025','03/05/2024', '4.75','567','5','5'),
('70% Dark Bites','03/05/2025','03/05/2024', '4.97','659','3','5'),
('Smooth Sliky Salty','03/05/2025','03/05/2024', '2.97','238','4','4'),
('Choco Coated Almonds','03/05/2025','03/05/2024', '6.17','573','4','1'),
('Peanut Butter Cubes','03/05/2025','03/05/2024', '3.57','297','3','2');

DELETE NHANVIEN
DELETE NHACUNGCAP
DELETE DANHMUCSANPHAM
DELETE SANPHAM
DELETE KHACHHANG
DROP TABLE NHANVIEN
DROP TABLE KHACHHANG
DROP TABLE CTHD
DROP TABLE DANHMUCSANPHAM
DROP TABLE HOADON
DROP TABLE NHACUNGCAP
DROP TABLE SANPHAM
SELECT * FROM KHACHHANG

SELECT 
    sp.MASP, sp.TENSP, sp.HANSUDUNG, sp.NGAYSANXUAT, sp.DONGIA, sp.SOLUONG,
    dm.LOAI, dm.KICHTHUOC,
    ncc.TENNHACUNGCAP
FROM SANPHAM AS sp
JOIN DANHMUCSANPHAM AS dm ON sp.MADMSP = dm.MADMSP
JOIN NHACUNGCAP AS ncc ON sp.MANCC = ncc.MANCC