create database S4_N11_QuanLyKhoSua
go
use S4_N11_QuanLyKhoSua
go

create table PhongBan(
	MaPB char(5) primary key,
	TenPB nvarchar(50),
	MaTP char(5)				--se trung voi MaNV
)
go
create table NhanVien(
	MaNV char(5) primary key,
	HoNV nvarchar(50),
	TenNV nvarchar(50),
	DiaChi nvarchar(50),
	GT nvarchar(10) check(GT in ('Nam', N'Nữ' , N'Khác')),
	NgaySinh date,
	Luong money,
	MaPB char(5) references PhongBan(MaPB)
)
go

create table PhieuNhap(
	MaPN char(5) primary key,
	NgayNhap date default getdate(),
	GhiChu ntext,
	ThanhTien money,
	MaNV char(5) references NhanVien(MaNV)
)
go

create table PhieuXuat(
	MaPX char(5) primary key,
	NgayXuat date default getdate(),
	GhiChu ntext,
	ThanhTien money,
	MaNV char(5) references NhanVien(MaNV)
)
go

create table LoaiSP(
	MaLoai char(5) primary key,
	TenLoai nvarchar(50),
	SoLuong int,
	GhiChu ntext
)
go
create table SanPham(
	MaSp char(5) primary key,
	TenSP nvarchar(50),
	DonGia money,
	NSX date,
	HSD date,
	GhiChu ntext,
	MaLoai char(5) references LoaiSP(MaLoai)
)
go
create table CTPhieuNhap(
	SLNhap int,
	ThanhTien money,
	GhiChu ntext,
	MaPN char(5) references PhieuNhap(MaPN),
	MaSP char(5) references SanPham(MaSP),
	primary key (MaPN,MaSP)
)
go
create table CTPhieuXuat(
	SLXuat int,
	ThanhTien money,
	GhiChu ntext,
	MaPX char(5) references PhieuXuat(MaPX),
	MaSP char(5) references SanPham(MaSP),
	primary key (MaPX,MaSP)
)
go
