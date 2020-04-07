create function Bao_cao_thong_ke_Nhap(@ngayBatDau date) returns
@Table_Thong_ke table (
	[Mã Sản phẩm] char(5) ,
	[Tên sản Phẩm] nvarchar(50),

	[Số Lượng Nhập] int
) as
begin
	if(@ngayBatDau is null or @ngayBatDau < (select NgayNhap from PhieuNhap where MaPN='PN001'))
		begin
			insert into @Table_Thong_ke([Mã Sản phẩm],[Tên sản Phẩm],[Số Lượng Nhập])
			select sp.MaSP,sp.TenSP,0
			from SanPham sp 
			order by sp.MaSp asc
		end
		
	else
		begin
			insert into @Table_Thong_ke([Mã Sản phẩm],[Tên sản Phẩm],[Số Lượng Nhập])
			select sp.MaSP,sp.TenSP,sum(ctPN.SLNhap)
			from CTPhieuNhap ctPN
			inner join SanPham sp on sp.MaSp=ctPN.MaSP
			inner join PhieuNhap PN on PN.MaPN=ctPN.MaPN
			where PN.NgayNhap<@ngayBatDau
			group by sp.MaSp,sp.TenSP 
			order by sp.MaSp asc
		end
	return
end
go
create function Bao_cao_thong_ke_Xuat(@ngayBatDau date) returns
@Table_Thong_ke table (
	[Mã Sản phẩm] char(5) ,
	[Tên sản Phẩm] nvarchar(50),
	[Số Lượng Xuất] int
) as
begin
	if(@ngayBatDau is null or @ngayBatDau < (select NgayXuat from PhieuXuat where MaPX='PX001'))
		begin
			insert into @Table_Thong_ke([Mã Sản phẩm],[Tên sản Phẩm],[Số Lượng Xuất])
			select sp.MaSP,sp.TenSP,0
			from SanPham sp 
			order by sp.MaSp asc
		end
		
	else
		begin
			insert into @Table_Thong_ke([Mã Sản phẩm],[Tên sản Phẩm],[Số Lượng Xuất])
			select sp.MaSP,sp.TenSP,sum(ctPX.SLXuat)
			from CTPhieuXuat ctPX
			inner join SanPham sp on sp.MaSp=ctPX.MaSP
			inner join PhieuXuat PX on PX.MaPX=ctPX.MaPX
			where PX.NgayXuat<@ngayBatDau
			group by sp.MaSp,sp.TenSP 
			order by sp.MaSp asc
		end
	return
end
go
create function Thong_ke_Dau_ky(@ngayBatDau date) returns
@table_thong_ke table(
	[Mã Sản phẩm] char(5) ,
	[Tên sản Phẩm] nvarchar(50),
	[Số Lượng Sản Phẩm Đầu Kỳ] int
) as
begin
	insert into @table_thong_ke([Mã Sản phẩm],[Tên sản Phẩm],[Số Lượng Sản Phẩm Đầu Kỳ])
	select TKnhap.[Mã Sản phẩm],TKnhap.[Tên sản Phẩm],(TKnhap.[Số Lượng Nhập]-TKxuat.[Số Lượng Xuất])
	from Bao_cao_thong_ke_Nhap(@ngayBatDau) TKnhap
	inner join Bao_cao_thong_ke_Xuat(@ngayBatDau) TKxuat on TKxuat.[Mã Sản phẩm]=TKnhap.[Mã Sản phẩm]
	return
end
go
create function Kiem_ke_sl_Nhap(@ngayBatDau date,@ngayKetThuc date) returns
@table_Thong_ke table(
	[Mã Sản phẩm] char(5) ,
	[Tên sản Phẩm] nvarchar(50),
	[Số Lượng Nhập] int
) as
begin
	if((@ngayBatDau is null and @ngayKetThuc is null) or (@ngayBatDau > (select top(1) NgayNhap from PhieuNhap order by NgayNhap desc) ) )
		begin
			insert into @table_Thong_ke([Mã Sản phẩm],[Tên sản Phẩm],[Số Lượng Nhập])
			select sp.MaSp,sp.TenSP,sum(ctPN.SLNhap)
			from SanPham sp
			inner join CTPhieuNhap ctPN on ctPN.MaSP=sp.MaSp
			inner join PhieuNhap pn on pn.MaPN=ctPN.MaPN
			group by sp.MaSp,sp.TenSP
		end
	else
		begin
			insert into @table_Thong_ke([Mã Sản phẩm],[Tên sản Phẩm],[Số Lượng Nhập])
			select sp.MaSp,sp.TenSP,sum(ctPN.SLNhap)
			from SanPham sp
			inner join CTPhieuNhap ctPN on ctPN.MaSP=sp.MaSp
			inner join PhieuNhap pn on pn.MaPN=ctPN.MaPN
			where pn.NgayNhap>=@ngayBatDau and pn.NgayNhap<=@ngayKetThuc
			group by sp.MaSp,sp.TenSP
		end
	return
end
go
create function Kiem_ke_sl_Xuat(@ngayBatDau date,@ngayKetThuc date) returns
@table_Thong_ke table(
	[Mã Sản phẩm] char(5) ,
	[Tên sản Phẩm] nvarchar(50),
	[Số Lượng Xuất] int
) as
begin
	if((@ngayBatDau is null and @ngayKetThuc is null) or (@ngayBatDau > (select top(1) NgayXuat from PhieuXuat order by NgayXuat desc) ) )
		begin
			insert into @table_Thong_ke([Mã Sản phẩm],[Tên sản Phẩm],[Số Lượng Xuất])
			select sp.MaSp,sp.TenSP,sum(ctPX.SLXuat)
			from SanPham sp
			inner join CTPhieuXuat ctPX on ctPX.MaSP=sp.MaSp
			inner join PhieuXuat px on px.MaPX=ctPX.MaPX
			group by sp.MaSp,sp.TenSP
		end
	else
		begin
			insert into @table_Thong_ke([Mã Sản phẩm],[Tên sản Phẩm],[Số Lượng Xuất])
			select sp.MaSp,sp.TenSP,sum(ctPX.SLXuat)
			from SanPham sp
			inner join CTPhieuXuat ctPX on ctPX.MaSP=sp.MaSp
			inner join PhieuXuat px on px.MaPX=ctPX.MaPX
			where px.NgayXuat>=@ngayBatDau and px.NgayXuat<=@ngayKetThuc
			group by sp.MaSp,sp.TenSP
		end
	return
end
go
create function Bao_cao_dau_ra(@ngayBatDau date,@ngayKetThuc date) returns
@table_thong_ke table(
	[Mã Sản phẩm] char(5) ,
	[Tên sản Phẩm] nvarchar(50),
	[Số Lượng Sản Phẩm Đầu Kỳ] int,
	[Số Lượng Sản Phẩm Nhập Vào Trong Kỳ] int ,
	[Số Lượng Sản Phẩm Xuất Ra Trong Kỳ] int,
	[Số Lượng Sản Phẩm Còn Lại] int
) as
begin
	if(@ngayBatDau is null or @ngayBatDau>(select top(1) NgayNhap from PhieuNhap order by NgayNhap desc) or @ngayBatDau=@ngayKetThuc)
		begin
			insert into @table_thong_ke([Mã Sản phẩm],[Tên sản Phẩm],[Số Lượng Sản Phẩm Đầu Kỳ],[Số Lượng Sản Phẩm Nhập Vào Trong Kỳ],
			[Số Lượng Sản Phẩm Xuất Ra Trong Kỳ],[Số Lượng Sản Phẩm Còn Lại])
			select dauKy.[Mã Sản phẩm],dauKy.[Tên sản Phẩm],dauKy.[Số Lượng Sản Phẩm Đầu Kỳ],slNhap.[Số Lượng Nhập],slXuat.[Số Lượng Xuất],
			(dauKy.[Số Lượng Sản Phẩm Đầu Kỳ]+slNhap.[Số Lượng Nhập]-slXuat.[Số Lượng Xuất])
			from Thong_ke_Dau_ky(null) dauKy
			inner join Kiem_ke_sl_Nhap(null,null) slNhap on dauKy.[Mã Sản phẩm]=slNhap.[Mã Sản phẩm]
			inner join Kiem_ke_sl_Xuat(null,null) slXuat on dauKy.[Mã Sản phẩm]=slXuat.[Mã Sản phẩm]
		end
	else
		begin
			insert into @table_thong_ke([Mã Sản phẩm],[Tên sản Phẩm],[Số Lượng Sản Phẩm Đầu Kỳ],[Số Lượng Sản Phẩm Nhập Vào Trong Kỳ],
			[Số Lượng Sản Phẩm Xuất Ra Trong Kỳ],[Số Lượng Sản Phẩm Còn Lại])
			select dauKy.[Mã Sản phẩm],dauKy.[Tên sản Phẩm],dauKy.[Số Lượng Sản Phẩm Đầu Kỳ],slNhap.[Số Lượng Nhập],slXuat.[Số Lượng Xuất],
			(dauKy.[Số Lượng Sản Phẩm Đầu Kỳ]+slNhap.[Số Lượng Nhập]-slXuat.[Số Lượng Xuất])
			from Thong_ke_Dau_ky(@ngayBatDau) dauKy
			inner join Kiem_ke_sl_Nhap(@ngayBatDau,@ngayKetThuc) slNhap on dauKy.[Mã Sản phẩm]=slNhap.[Mã Sản phẩm]
			inner join Kiem_ke_sl_Xuat(@ngayBatDau,@ngayKetThuc) slXuat on dauKy.[Mã Sản phẩm]=slXuat.[Mã Sản phẩm]
		end
	return
end
go