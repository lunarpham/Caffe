use CoffeManager

go
create database CoffeManager
go
--backup database
BACKUP DATABASE CMS
TO DISK = 'D:\Database\AdventureWorks_Backup.bak'
WITH INIT;

-- tao table va them du lieu
create table LoaiTaiKhoan(
 ID int identity primary key,
 VaiTro nvarchar (20) default N'Trống')

create table TaiKhoan(
 TenTK nvarchar (50) primary key,
 ChucVu nvarchar (20) default N'Không',
 MatKhau nvarchar (1000) default 0 not null,
 LoaiID int not null
 constraint fk_TaiKhoan_LoaiID
  foreign key (LoaiID)
  references LoaiTaiKhoan (ID)
  on delete cascade
  on update cascade)
  select * from TaiKhoan
create table BanAn(
 ID int identity primary key,
 SoBan nvarchar (50) default N'Bàn chưa có số' not null,
 TrangThai nvarchar (20) default N'Bàn trống')

create table LoaiDoUong(
 ID int identity primary key,
 TenDoUong nvarchar (50) default N'Chưa đặt tên' not null)

create table ThucDon(
 ID int identity primary key,
 IDLoaiDoUong int not null,
 TenDoUong nvarchar (50) default N'Chưa đặt tên' not null,
 DonGia float default 0 not null,
 constraint fk_ThucDon_IDLoaiDoUong
  foreign key (IDLoaiDoUong)
  references LoaiDoUong (ID)
  on delete cascade
  on update cascade)

create table HoaDon(
 ID int identity primary key,
 IDBanAn int not null,
 TrangThai int default 0 not null,
 TongTien float,
 ThoiGianVao date default getdate() not null,
 GiamGia int,
 ThoiGianRa date,
 constraint fk_HoaDon_IDBanAn
  foreign key (IDBanAn)
  references BanAn (ID)
  on delete cascade
  on update cascade)

create table ThongTinHoaDon(
 ID int identity primary key,
 IDHoaDon int not null,
 IDThucDon int not null,
 count int default 0 not null,
 constraint fk_ThongTinHoaDon_IDThucDon
  foreign key (IDThucDon)
  references ThucDon (ID)
  on delete cascade
  on update cascade,
 constraint fk_ThongTinHoaDon_IDHoaDon
  foreign key (IDHoaDon)
  references HoaDon (ID)
  on delete cascade
  on update cascade)

update HoaDon set GiamGia = 0

-- tao procedure tai khoan
go
create proc USP_GetTaiKhoanByTenTK
@tentk nvarchar (50)
as
 begin
   select * from dbo.TaiKhoan where TenTK = @tentk
 end
go

-- tao proc dang nhap (sua loi dmm thang lon KTeam)
go
create proc USP_DangNhap
@tentk nvarchar (50),
@matkhau nvarchar (50)
as
 begin
     select * from dbo.TaiKhoan where TenTK = @tentk and MatKhau = @matkhau
 end
go
select * from TaiKhoan
-- hien thi ban an (them ban)
declare @i int = 1
while @i <= 20
 begin
	 insert into BanAn(SoBan)
	 values (N'Bàn số ' + cast(@i as nvarchar (50)))
	 set @i = @i + 1
 end

-- tao proc ban an
go
create proc USP_DanhSachBanAn
as select * from dbo.BanAn
go

-- nhap hoa don
go
create proc USP_NhapHD
@idbanan int
as
 begin
     insert into HoaDon(ThoiGianVao, ThoiGianRa, IDBanAn, TrangThai, GiamGia)
	 values (getdate(), null, @idbanan, 0, 0)
 end
go

-- nhap tthd
go
create proc USP_NhapTTHD
@idhoadon int, @idthucdon int, @soluong int
as
 begin
	insert into ThongTinHoaDon(IDHoaDon, IDThucDon, count)
    values (@idhoadon, @idthucdon, @soluong)
 end
go

--???
drop proc USP_NhapTTHD

-- alter tthd
go
create proc USP_NhapTTHD
@idhoadon int, @idthucdon int, @soluong int
as
 begin
    declare @tthddaco int
    declare @sltd int = 1
     select @tthddaco = ID, @sltd = tthd.count 
     from ThongTinHoaDon as tthd
     where IDHoaDon = @idhoadon and IDThucDon = @idthucdon
     if (@tthddaco > 0)
	  begin
         declare @slmoi int = @sltd + @soluong
		    if (@slmoi > 0)
		     update ThongTinHoaDon set count = @slmoi where IDHoaDon = @idhoadon and IDThucDon = @idthucdon
			else
			 delete ThongTinHoaDon where IDHoaDon = @idhoadon and IDThucDon = @idthucdon
            end
	 else if (@soluong > 0)
      begin
	     insert into ThongTinHoaDon(IDHoaDon, IDThucDon, count)
	     values (@idhoadon, @idthucdon, @soluong)
	 end
 end
go

-- them tai khoan
insert into LoaiTaiKhoan (VaiTro) 
values (N'Quản lí')
insert into LoaiTaiKhoan (VaiTro)
values (N'Nhân viên')

insert into TaiKhoan (TenTK, ChucVu, MatKhau, LoaiID)
values ('Quang', 'Quản lí', '6969', 1)
insert into TaiKhoan (TenTK, ChucVu, MatKhau, LoaiID)
values ('Qúy', 'Nhân viên', '2103', 2)
insert into TaiKhoan (TenTK, ChucVu, MatKhau, LoaiID)
values ('Trưởng','Nhân viên', '2114', 2)

-- them danh sach do uong
insert into LoaiDoUong (TenDoUong)
values (N'Cà phê')
insert into LoaiDoUong (TenDoUong)
values (N'Soda')
insert into LoaiDoUong (TenDoUong)
values (N'Nước ép')

-- them mon
insert into ThucDon (TenDoUong, IDLoaiDoUong, DonGia)
values (N'Cà phê sữa Sài Gòn', 1, 25000)
insert into ThucDon (TenDoUong, IDLoaiDoUong, DonGia)
values (N'Cafe đen đá', 1, 20000)
insert into ThucDon (TenDoUong, IDLoaiDoUong, DonGia)
values (N'Soda chanh', 2, 35000)
insert into ThucDon (TenDoUong, IDLoaiDoUong, DonGia)
values (N'Soda việt quất', 2, 35000)
insert into ThucDon (TenDoUong, IDLoaiDoUong, DonGia)
values (N'Nước ép cam', 3, 30000)
insert into ThucDon (TenDoUong, IDLoaiDoUong, DonGia)
values (N'Nước ép táo', 3, 25000)

--trigger table
go
create trigger UTG_CapNhatTTHD
on ThongTinHoaDon for insert, update
as
 begin
    declare @idhd int
	 select @idhd = IDHoaDon from inserted
	declare @idbanan int
	 select @idbanan = IDBanAn from HoaDon where ID = @idhd and TrangThai = 0
	 update BanAn set TrangThai = N'Có người' where ID = @idbanan
 end
go

go
create trigger UTG_CapNhatHD
on HoaDon for update
as
 begin
    declare @idhd int
	 select @idhd = ID from inserted
	declare @idbanan int
	 select @idbanan = IDBanAn from HoaDon where ID = @idhd
	declare @count int = 0
	 select @count = count(*) from HoaDon where IDBanAn = @idbanan and TrangThai = 0
	 if (@count = 0)
	     update BanAn set TrangThai = N'Bàn trống' where ID = @idbanan
 end
go

--proc chuyen ban
go
create proc USP_ChuyenBan
@idban1 int, @idban2 int
as 
 begin
    declare @idhdbandau int
	declare @idhdcuoi int
	declare @idban1trong int = 1
	declare @idban2trong int = 1
	 select @idhdbandau = ID from HoaDon where IDBanAn = @idban1 and TrangThai = 0
	 select @idhdcuoi = ID from HoaDon where IDBanAn = @idban2 and TrangThai = 0
     select ID from HoaDon where IDBanAn = @idban1 and TrangThai = 0
	 if (@idhdbandau is null)
	  begin
	     insert into HoaDon (IDBanAn, ThoiGianVao, ThoiGianRa, TrangThai)
		 values (@idban1, getdate(), null, 0)
         select @idhdbandau = max(ID) from HoaDon 
		 where IDBanAn = @idban1 and TrangThai = 0
      end
	  select @idban1trong = count(*) from ThongTinHoaDon
	  where IDHoaDon = @idhdbandau
	  if (@idhdcuoi is null)
	  begin
	     insert into HoaDon (IDBanAn, ThoiGianVao, ThoiGianRa, TrangThai)
		 values (@idban2, getdate(), null, 0)
         select @idhdcuoi = max(ID) from HoaDon 
		 where IDBanAn = @idban2 and TrangThai = 0
      end
	  select @idban2trong = count(*) from ThongTinHoaDon
	  where IDHoaDon = @idhdcuoi
	  select id into IDHDTheoBan from ThongTinHoaDon
	  where IDHoaDon = @idhdcuoi
	  update ThongTinHoaDon set IDHoaDon = @idhdcuoi 
	  where IDHoaDon = @idhdbandau
	  update ThongTinHoaDon set IDHoaDon = @idhdbandau
	  where ID in (select * from IDHDTheoBan)
drop table IDHDTheoBan
	  if (@idban1trong = 0)
	      update BanAn set TrangThai = N'Bàn trống' where ID = @idban2
      if (@idban2trong = 0)
	      update BanAn set TrangThai = N'Bàn trống' where ID = @idban1

 end
go

--proc doanh thu
go
create proc USP_LayDSHDTheoNgay
@tgv date , @tgr date
as
 begin
     select b.SoBan, hd.TongTien, ThoiGianVao, ThoiGianRa, GiamGia
	 from HoaDon as hd, BanAn as b
	 where ThoiGianVao >= @tgv and ThoiGianRa <= @tgr and hd.TrangThai = 1
	 and b.ID = hd.IDBanAn
 end
go

--proc cntk
go
create proc USP_CapNhatTK
@tentk nvarchar (50), @mk nvarchar (50), @mkmoi nvarchar (50)
as
 begin
     declare @mkdung int = 0
	 select @mkdung = count(*) from TaiKhoan where TenTK = @tentk and MatKhau = @mk
	 if (@mkdung = 1)
	 begin
	     if (@mkdung = null or @mkmoi = '')
		 begin 
		     update TaiKhoan set TenTK = @tentk where TenTK = @tentk
		 end
		 else
		     update TaiKhoan set TenTK = @tentk, MatKhau = @mkmoi where TenTK = @tentk
		 end
 end
go

--trigger xoa tthd
go
create trigger UTG_XoaTTHD
on ThongTinHoaDon for delete
as
 begin
    declare @idtthd int
	declare @idhd int
	select @idtthd = ID, @idhd = Deleted.IDHoaDon from Deleted

	declare @idbanan int
	select @idtthd = IDBanAn from HoaDon where ID = @idhd

	declare @count int = 0

	select @count = count(*) from ThongTinHoaDon
	as tthd, HoaDon as hd 
	where hd.ID  = tthd.IDHoaDon and hd.TrangThai = 0

	if (@count = 0)
	    update BanAn set TrangThai = N'Bàn trống' where ID = @idbanan
end
go

select * from LoaiTaiKhoan


go
create proc USP_DSHDTheoNgayVaTrang
@tgv date, @tgr date, @st int
as
begin
	declare @pageRows int = 10
	declare @selectRows int = @pageRows
	declare @exceptRows int = (@st - 1) * @pageRows
	
	;with HienHD as( select hd.ID, ba.SoBan as [Bàn số], hd.TongTien as [Tổng tiền], ThoiGianVao as [Ngày vào], ThoiGianRa as [Ngày ra], GiamGia as [Giảm giá]
	from HoaDon as hd, BanAn as ba
	where ThoiGianVao >= @tgv AND ThoiGianRa <= @tgr AND hd.TrangThai = 1
	AND ba.ID = hd.IDBanAn)
	
	select top (@selectRows) * from HienHD where ID NOT IN (SELECT TOP (@exceptRows) ID from HienHD)
end
go

go
create proc USP_SoHD
@tgv date, @tgr date
as 
begin
	select count(*)
	from HoaDon as hd,BanAn AS ba
	WHERE ThoiGianVao >= @tgv AND ThoiGianRa <= @tgr AND hd.TrangThai = 1
	AND ba.ID = hd.IDBanAn
end
go

--proc gop ban
go
create proc USP_GopBan
@idban1 int, @idban2 int
as
	begin
		declare @idhduncheck1 int = -1
		declare @idhduncheck2 int = -1
		select @idhduncheck1 = ID from HoaDon where IDBanAn = @idban1 and TrangThai = 0
		select @idhduncheck2 = ID from HoaDon where IDBanAn = @idban2 and TrangThai = 0

		if (@idhduncheck1 != -1 AND @idhduncheck2 != -1)
			begin
				declare @idtthd int
				select @idtthd = ID from ThongTinHoaDon where IDHoaDon = @idhduncheck1

				update ThongTinHoaDon set IDHoaDon = @idhduncheck2 where ID = @idtthd
				delete HoaDon where ID = @idhduncheck1

				update BanAn set TrangThai = N'Bàn trống' where ID = @idban1
			end
    end
go

--proc table admin
create proc USP_ThemBan
@tenban nvarchar(100)
as
	insert BanAn( SoBan )
	values  ( @tenban )

create proc USP_SuaBan
@idbanan int, @tenban nvarchar(100)
as
	update BanAn set SoBan = @tenban WHERE ID = @idbanan

create proc USP_XoaBan
@idbanan int
as begin
	declare @count int = 0
	select @count = count(*) from BanAn where ID = @idbanan and TrangThai = N'Bàn trống'

	if (@count <> 0)
	begin
		declare @idhd int
		select @idhd = hd.ID from HoaDon as hd, BanAn as ba where hd.IDBanAn = ba.ID

		delete ThongTinHoaDon where IDHoaDon = @idhd
		delete HoaDon where ID = @idhd
		delete BanAn where ID = @idbanan
	end
end

