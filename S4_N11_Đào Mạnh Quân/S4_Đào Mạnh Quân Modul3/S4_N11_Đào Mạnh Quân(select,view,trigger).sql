--số lượng nhân viên trong từng phòng ban
select pb.MaPB,pb.TenPB,count(nv.MaNV) 'số lượng nhân viên'
from NhanVien nv
inner join PhongBan pb on nv.MaPB=pb.MaPB
group by pb.MaPB,pb.TenPB
go
--tính tổng tiền lương phải tra cho nhân viên trong từng phòng ban
select pb.MaPB,pb.TenPB,sum(nv.Luong) 'số lượng nhân viên'
from NhanVien nv
inner join PhongBan pb on nv.MaPB=pb.MaPB
group by pb.MaPB,pb.TenPB
go
--Hiển thị ra ra danh sách nhân viên và thông tin nhân viên
select*
from NhanVien
go
--view tổng số lượng sản phẩm nhập theo từng sản phẩm
create view Tong_so_luong_tung_SP_Nhap
as
select sp.MaSp,sp.TenSP,SUM(ctPN.SLNhap) as 'Số lượng sản phẩm nhập'
from SanPham sp
inner join CTPhieuNhap ctPN on ctPN.MaSP=sp.MaSp
group by sp.MaSp,sp.TenSP
go
--view tổng số lượng sản phẩm xuất theo từng sản phẩm
create view Tong_so_luong_tung_SP_Xuat
as
select sp.MaSp,sp.TenSP,SUM(ctPX.SLXuat) as 'Số lượng sản phẩm xuất'
from SanPham sp
inner join CTPhieuXuat ctPX on ctPX.MaSP=sp.MaSp
group by sp.MaSp,sp.TenSP
go
--view tổng số lượng nhân viên theo từng phòng
create view tong_so_NV_theo_PB
as
select pb.MaPB,pb.TenPB,COUNT(nv.MaNV) as 'tổng số lượng nhân viên'
from NhanVien nv
inner join PhongBan pb on pb.MaPB=nv.MaPB
group by pb.MaPB,pb.TenPB
go
--proc: Thêm sản phẩm mới
create proc Them_SP(@MaSP char(5),@TenSP nvarchar(50),@DonGia money,@NSX date,@HSD date,@GhiChu ntext,@MaLoai char(5))
as
begin
	insert into SanPham(MaSp,TenSP,DonGia,NSX,HSD,GhiChu,MaLoai)
	values(@MaSP,@TenSP,@DonGia,@NSX,@HSD,@GhiChu,@MaLoai)
end
go
--proc: tìm kiếm thông tin của 1 phiếu xuất bất kỳ
create proc TimPhieuXuat(@MaPhieuXuat char(5))
as
begin
	select *
	from PhieuXuat px
	inner join CTPhieuXuat ctPX on ctPX.MaPX=px.MaPX
	where px.MaPX=@MaPhieuXuat
end
go
--proc: tìm kiếm thông tin của 1 phiếu Nhap bất kỳ
create proc TimPhieuNhap(@MaPhieuNhap char(5))
as
begin
	select *
	from PhieuNhap pN
	inner join CTPhieuNhap ctPN on ctPN.MaPN=pN.MaPN
	where pN.MaPN=@MaPhieuNhap
end
go
--trigger: bắt lỗi: người viết phiếu nhập phải là nhân viên thuộc phòng ban nhân sự
create trigger NhanVienVietPhieuNhap on PhieuNhap for insert
as
begin
	declare @NguoiVietPhieu char(5);
	select @NguoiVietPhieu=inserted.MaNV
	from inserted 
	inner join NhanVien nv on nv.MaNV=inserted.MaNV
	inner join PhongBan pb on pb.MaPB=nv.MaPB
	where pb.MaPB='PB002'

	if(@NguoiVietPhieu IS NULL)
	begin
		print N'Không phải là nhân viết phòng nhân sự k được viết phiếu'
		rollback tran
	end
end
go
--trigger: bắt lỗi: người viết phiếu xuất phải là nhân viên thuộc phòng ban nhân sự
create trigger NhanVienVietPhieuXuat on PhieuXuat for insert
as
begin
	declare @NguoiVietPhieu char(5);
	select @NguoiVietPhieu=inserted.MaNV
	from inserted 
	inner join NhanVien nv on nv.MaNV=inserted.MaNV
	inner join PhongBan pb on pb.MaPB=nv.MaPB
	where pb.MaPB='PB002'

	if(@NguoiVietPhieu is null)
	begin
		print N'Không phải là nhân viết phòng nhân sự k được viết phiếu'
		rollback tran
	end
end
go
--trigger: bắt lỗi: Lương của nhân viên không thể lớn hơn lương của trưởng phòng
create trigger loiNhapLuongChoNhanVien on NhanVien for insert 
as 
begin
	declare @LuongNhanVienMoi money;
	declare @LuongTruongPhong money;
	declare @maTP char(5); 

	select @LuongNhanVienMoi=Luong
	from inserted
	
	select @maTP=pb.MaTP
	from inserted
	inner join PhongBan pb on pb.MaPB=inserted.MaPB


	select @LuongTruongPhong=Luong
	from NhanVien 
	where MaNV=@maTP

	if(@LuongNhanVienMoi>@LuongTruongPhong)
	begin
		print N'nhập sai! Lương nhân viên không thể lớn hơn lương trưởng phòng'
		rollback tran
	end
end
go
