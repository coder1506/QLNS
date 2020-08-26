CREATE DATABASE QuanLyNhanSu
GO
USE QuanLyNhanSu
GO
CREATE TABLE PhongBan (
	MaPB varchar(10),
	TenPB nvarchar(50),
	NgayThanhLap datetime,
	PRIMARY KEY (MaPB)
)
GO
CREATE TABLE BangLuongCongTy (
	MaLuong varchar(10),
	LCB money,
	PhuCap money,
	NgaySua datetime,
	PRIMARY KEY (MaLuong)
)
GO
CREATE TABLE TTNVCoBan (
	MaNV varchar(10),
	MaPB varchar(10),
	HoTen nvarchar(50),
	MaLuong varchar(10),
	NgaySinh datetime,
	GioiTinh nvarchar(10),
	CMTND numeric,
	NgayCap datetime,
	NoiCap nvarchar(100),
	ChucVu nvarchar(40),
	ThoiGianLamViec int,
	NgayKy datetime,
	NgayHetHan datetime,
	TinhTrangHD nvarchar(50),
	PRIMARY KEY (MaNV),
	CONSTRAINT fk_TTNVCoBanMaPB FOREIGN KEY (MaPB) REFERENCES PhongBan(MaPB),
	CONSTRAINT fk_TTNVCoBanMaLuong FOREIGN KEY (MaLuong) REFERENCES BangLuongCongTy(MaLuong)
)
GO
CREATE TABLE TTCaNhan (
	MaNV varchar(10),
	HoTen nvarchar(50),
	NgaySinh datetime,
	GioiTinh nvarchar(10),
	NoiSinh nvarchar(100),
	Dctamtru nvarchar(100),
	DCThuongChu nvarchar(100),
	DanToc nvarchar(50),
	TonGiao nvarchar(50),
	QuocTich nvarchar(50),
	BangCap nvarchar(50),
	SDT numeric,
	PRIMARY KEY (MaNV),
	CONSTRAINT fk_TTCaNhanMaNV FOREIGN KEY (MaNV) REFERENCES TTNVCoBan(MaNV)
)
GO
CREATE TABLE tbuser (
	Username varchar(50) PRIMARY KEY,
	Pass varchar(10),
	quyen varchar(10),
	Ten nvarchar(50),
	NgaySinh date
)
GO
CREATE TABLE BangCongNV (
	MaPB varchar(10),
	MaNV varchar(10),
	MaLuong varchar(10),
	LCB money,
	PhuCap money,
	Thuong money,
	KyLuat money,
	Thang int,
	Nam int,
	SoGioLamThem int ,
	SoNgayCong int,
	Luong money,
	PRIMARY KEY (MaNV),
	CONSTRAINT fk_BangCongNVMaNV FOREIGN KEY (MaNV) REFERENCES TTNVCoBan(MaNV),
	CONSTRAINT fk_BangCongNVMaPB FOREIGN KEY (MaPB) REFERENCES PhongBan(MaPB)
)
GO
CREATE TABLE ThaiSan (
	MaPB varchar(10),
	MaNV varchar(10),
	HoTen nvarchar(50),
	TroCap money,
	NgayVeSinh datetime,
	NgayLamTroLai datetime,
	PRIMARY KEY (MaNV),
	CONSTRAINT fk_ThaiSanMaNV FOREIGN KEY (MaNV) REFERENCES TTNVCoBan(MaNV),
	CONSTRAINT fk_ThaiSanMaPB FOREIGN KEY (MaPB) REFERENCES PhongBan(MaPB)
)
GO
CREATE TABLE BaoHiem (
	MaNV varchar(10),
	MaBH varchar(50),
	NgayCap datetime,
	NgayHetHan datetime,
	NoiCap nvarchar(50),
	PRIMARY KEY (MaNV),
	CONSTRAINT fk_BaoHiemMaNV FOREIGN KEY (MaNV) REFERENCES TTNVCoBan(MaNV)
)
GO
CREATE TABLE HoSoNVThuViec (
	MaNVTV varchar(10),
	MaPB varchar(10),
	HoTen nvarchar(50),
	GioiTinh nvarchar(10),
	NgaySinh datetime,
	DiaChi nvarchar(100),
	ViTriTV nvarchar(30),
	SoThangTV int,
	NgayBatDau datetime,
	NgayHetHan datetime,
	TrinhDo nvarchar(50),
	PRIMARY KEY (MaNVTV),
	CONSTRAINT fk_NVTVMaPB FOREIGN KEY (MaPB) REFERENCES PhongBan(MaPB)
)
GO
CREATE TABLE BangCongNVThuViec (
	MaPB varchar(10),
	MaNVTV varchar(10),
	Thang int,
	Nam int,
	LuongTV money,
	SoGioLamThem int ,
	SoNgayCong int,
	Luong money,
	PRIMARY KEY (MaNVTV),
	CONSTRAINT fk_BangCongNVTV FOREIGN KEY (MaNVTV) REFERENCES HoSoNVThuViec(MaNVTV)
)
GO
CREATE TABLE TangLuong (
	MaPB varchar(10),
	MaNV varchar(10),
	HoTen nvarchar(50),
	GioiTinh nvarchar(10),
	ChucVu nvarchar(40),
	MaLuong varchar(10),
	NgayTang datetime,
	PRIMARY KEY (MaNV),
	CONSTRAINT fk_TangLuongMaLuong FOREIGN KEY (MaLuong) REFERENCES BangLuongCongTy(MaLuong),
	CONSTRAINT fk_TangLuongMaNV FOREIGN KEY (MaNV) REFERENCES TTNVCoBan(MaNV)
)
GO
CREATE TABLE Thuong (
	MaPB varchar(10),
	MaNV varchar(10),
	HoTen nvarchar(50),
	TienThuong money,
	MaThuong varchar(10),
	NgayThuong datetime,
	LyDo nvarchar(1000),
	PRIMARY KEY (MaThuong),
	CONSTRAINT fk_ThuongMaNV FOREIGN KEY (MaNV) REFERENCES BangCongNV(MaNV)
)
GO
CREATE TABLE KyLuat (
	MaPB varchar(10),
	MaNV varchar(10),
	HoTen nvarchar(50),
	KyLuat money,
	MaKyLuat varchar(10),
	NgayKyLuat datetime,
	LyDo nvarchar(1000),
	PRIMARY KEY (MaKyLuat),
	CONSTRAINT fk_KyLuatMaNV FOREIGN KEY (MaNV) REFERENCES BangCongNV(MaNV)
)
------
INSERT INTO PhongBan values ('PB01',N'Phòng marketing','09-27-2018'), ('PB02',N'Phòng Kế Toán','09-28-2018')
GO
INSERT INTO BangLuongCongTy values ('L01',300000,500000,'08-09-2020'), ('L02',250000,500000,'08-09-2020')
GO
INSERT INTO TTNVCoBan 
values ('NV0001','PB01',N'Trần Sơn Đỉnh','L01','03-27-2000',N'Nam',123456789,'10-15-2015',N'Nam Định',N'Nhân viên',12,'03-12-2020','03-12-2021',N'Đang làm việc'),
('NV0002','PB02',N'Vũ Thị Huyền','L02','04-09-1999',N'NỮ',465976549,'9-05-2015',N'Hà Nội',N'Nhân viên',24,'08-12-2019','08-12-2021',N'Đang làm việc')
GO
INSERT INTO TTCaNhan 
values ('NV0001',N'Trần Sơn Đỉnh','03-27-2000',N'Nam',N'Nam Định',N'Nam Định',N'Hà Nội',N'Kinh',N'Không',N'Việt Nam',N'Kỹ sư công nghệ thông tin',0328488022),
('NV0002',N'Vũ Thị Huyền','04-09-1999',N'NỮ',N'Hà Nội',N'Hà Nội',N'Hà Nội',N'Kinh',N'Đạo thiên chúa',N'Việt Nam',N'Cử nhân',0215497514)
GO
INSERT INTO tbuser values ('admin','123456','Admin',N'Trần Sơn Đỉnh','2000-5-5'),('DinhDuc','123456','User',N'Đào Đình Đức','2000-7-5')
GO
INSERT INTO BangCongNV 
values ('PB01','NV0001','L01',300000,500000,0,0,5,2020,0,30,9500000),('PB02','NV0002','L02',250000,500000,0,0,5,2020,0,30,9500000)
GO
INSERT INTO ThaiSan values ('PB01','NV0001',N'Vũ Thị Huyền',2000000,'09-10-2019','09-10-2020')
GO
INSERT INTO BaoHiem values ('NV0001','VN12346789','9-8-2020','9-8-2021',N'Bệnh viện Hà Nội'),('NV0002','VN12313589','9-8-2020','9-8-2021',N'Bệnh viện Hà Nội')
GO
INSERT INTO HoSoNVThuViec
values ('NVTV001','PB01',N'Nguyễn Văn Hải',N'Nam','3-20-1998',N'Hải Phòng',N'Kế toán',3,'5-23-2020','8-23-2020',1),
('NVTV002','PB02',N'Trần Thị Thu',N'Nữ','4-19-1999',N'Hà Nam',N'3',3,'5-23-2020','8-23-2020',1)
GO
INSERT INTO BangCongNVThuViec
values ('PB01','NVTV001',5,2020,1000000,0,25,2500000),
('PB02','NVTV002',5,2020,130000,0,30,3900000)
GO
INSERT INTO TangLuong
values ('PB01','NV0001',N'Trần Sơn Đỉnh',N'Nam',N'Kỹ sư công nghệ thông tin','L01','9-8-2019')
GO
INSERT INTO Thuong
values ('PB01','NV0001',N'Trần Sơn Đỉnh',500000,'T001','2020-8-9',N'Hoàn thành tốt nghiệm vụ được giao')
GO
INSERT INTO KyLuat
values ('PB01','NV0001',N'Trần Sơn Đỉnh',-100000,'KL001','2020-7-8',N'Đi muộn 15 phút')

