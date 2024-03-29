USE [QLHSPT]
GO
/****** Object:  StoredProcedure [dbo].[gte_DIEM]    Script Date: 1/4/2020 12:07:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery6.sql|0|0|C:\Users\quang\AppData\Local\Temp\~vsC47B.sql
create proc [dbo].[gte_DIEM]
as 
select * from scoresTHPT
GO
/****** Object:  StoredProcedure [dbo].[gte_dtSearch]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gte_dtSearch]
as 
select * from StudentTHPT
GO
/****** Object:  StoredProcedure [dbo].[gte_GV]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gte_GV]
as 
select * from TeacherTHPT
GO
/****** Object:  StoredProcedure [dbo].[gte_HS]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gte_HS]
as 
select * from StudentTHPT
GO
/****** Object:  StoredProcedure [dbo].[gte_load]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gte_load]
as 
select * from SumScrores
GO
/****** Object:  StoredProcedure [dbo].[gte_LOP]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gte_LOP]
as 
select * from ClassTHPT
GO
/****** Object:  StoredProcedure [dbo].[gte_MH]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gte_MH]
as 
select * from SubjectsTHPT
GO
/****** Object:  StoredProcedure [dbo].[gte_timkiem]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[gte_timkiem]
@MaHS nvarchar(10)
as select * from StudentTHPT
where MaHS LIKE '%'+@MaHS+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_DelectDIEM]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DelectDIEM]
@MaMon nvarchar(10)
AS
delete from scoresTHPT
WHERE MaMon = @MaMon
GO
/****** Object:  StoredProcedure [dbo].[sp_DelectGV]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DelectGV]
@MaGV nvarchar(10)
AS
DELETE FROM TeacherTHPT
WHERE MaGV = @MaGV
GO
/****** Object:  StoredProcedure [dbo].[sp_DelectHS]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DelectHS]
@MaHS nvarchar(10)
as
delete from StudentTHPT

where MaHS =@MaHS
GO
/****** Object:  StoredProcedure [dbo].[sp_DelectLOP]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DelectLOP]
@MaLop nvarchar(10)
AS
DELETE FROM ClassTHPT
WHERE MaLop = @MaLop
GO
/****** Object:  StoredProcedure [dbo].[sp_DelectMH]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_DelectMH]
@MaMon nvarchar(10)
AS
delete from SubjectsTHPT
WHERE MaMon = @MaMon
GO
/****** Object:  StoredProcedure [dbo].[sp_getALLlogin]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_getALLlogin]
as
select * from LoginTHPT
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDIEM]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertDIEM]
@MaMon nvarchar(10),
@TenMon nvarchar(50),
@MaHS nvarchar(10),
@HoTen nvarchar(50),
@DiemTb nvarchar(5)
AS
insert into scoresTHPT(MaMon,TenMon,MaHS,HoTen,DiemTb)
VALUES(@MaMon,@TenMon,@MaHS,@HoTen,@DiemTb)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertGV]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertGV]
@MaGV nvarchar(10),
@TenGV nvarchar(30),
@GioiTinh nvarchar(10),
@Phone nvarchar(15),
@Email nvarchar(20),
@GiangDayMon nvarchar(20),
@MaLop nvarchar(10)
AS
insert into TeacherTHPT(MaGV,TenGV,GioiTinh,Phone,Email,GiangDayMon,MaLop)
VALUES(@MaGV,@TenGV,@GioiTinh,@Phone,@Email,@GiangDayMon,@MaLop)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertHocsinh]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertHocsinh]
@MaHS nvarchar(10),
@HoTen nvarchar(50),
@NgaySinh nvarchar(10),
@GioiTinh nvarchar(5),
@DiaChi nvarchar(50),
@MaLop nvarchar(10)
as
insert into StudentTHPT(MaHS,HoTen,NgaySinh,GioiTinh,DiaChi,MaLop)
values(@MaHS,@HoTen,@NgaySinh,@GioiTinh,@DiaChi,@MaLop)
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertLOP]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_InsertLOP]
@MaLop nvarchar(10),
@TenLop nvarchar(50),
@MaGV nvarchar(10),
@MaHS nvarchar(10)
AS
insert into ClassTHPT(MaLop,TenLop,MaGV,MaHS)
values(@MaLop,@TenLop,@MaGV,@MaHS)
GO
/****** Object:  StoredProcedure [dbo].[sp_Insertmonhoc]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Insertmonhoc]
@MaMon nvarchar(10),
@TenMon nvarchar(50),
@MaGV nvarchar(50),
@MaHS nvarchar(50)
AS
INSERT INTO SubjectsTHPT(MaMon,TenMon,MaGV,MaHS)
values(@MaMon,@TenMon,@MaGV,@MaHS)
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDIEM]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateDIEM]
@MaMon nvarchar(10),
@TenMon nvarchar(50),
@MaHS nvarchar(10),
@HoTen nvarchar(50),
@DiemTb nvarchar(5)
AS
UPDATE scoresTHPT
SET TenMon = @TenMon,
MaHS = @MaHS,
HoTen = @HoTen,
DiemTb = @DiemTb
WHERE MaMon = @MaMon
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateGV]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateGV]
@MaGV nvarchar(10),
@TenGV nvarchar(30),
@GioiTinh nvarchar(10),
@Phone nvarchar(15),
@Email nvarchar(20),
@GiangDayMon nvarchar(20),
@MaLop nvarchar(10)
AS
UPDATE TeacherTHPT
SET TenGV = @TenGV,
GioiTinh = @GioiTinh,
Phone = @Phone,
Email = @Email,
GiangDayMon = @GiangDayMon,
MaLop = @MaLop
WHERE MaGV = @MaGV
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateHS]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateHS]
@MaHS nvarchar(10),
@HoTen nvarchar(50),
@NgaySinh nvarchar(10),
@GioiTinh nvarchar(5),
@DiaChi nvarchar(50),
@MaLop nvarchar(10)
as
UpDATE StudentTHPT
SET HoTen =@HoTen,
NgaySinh =@NgaySinh,
GioiTinh =@GioiTinh,
DiaChi =@DiaChi,
MaLop =@MaLop
where MaHS =@MaHS
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateLOP]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateLOP]
@MaLop nvarchar(10),
@TenLop nvarchar(50),
@MaGV nvarchar(10),
@MaHS nvarchar(10)
AS
UPDATE ClassTHPT
SET TenLop = @TenLop,
MaGV = @MaGV,
MaHS = @MaHS
WHERE MaLop = @MaLop

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMH]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_UpdateMH]
@MaMon nvarchar(10),
@TenMon nvarchar(50),
@MaGV nvarchar(50),
@MaHS nvarchar(50)
AS
UPDATE SubjectsTHPT
SET TenMon = @TenMon,
MaGV = @MaGV,
MaHS = @MaHS
WHERE MaMon = @MaMon

GO
/****** Object:  Table [dbo].[ClassTHPT]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClassTHPT](
	[MaLop] [nvarchar](10) NULL,
	[TenLop] [nvarchar](50) NULL,
	[MaGV] [nvarchar](10) NULL,
	[MaHS] [nvarchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoginTHPT]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginTHPT](
	[Taikhoan] [nvarchar](50) NULL,
	[Matkhau] [nvarchar](20) NULL,
	[Quyen] [nvarchar](20) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[scoresTHPT]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[scoresTHPT](
	[MaMon] [nvarchar](10) NULL,
	[TenMon] [nvarchar](50) NULL,
	[MaHS] [nvarchar](10) NULL,
	[HoTen] [nvarchar](50) NULL,
	[DiemTb] [nvarchar](5) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentTHPT]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentTHPT](
	[MaHS] [nvarchar](10) NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [nvarchar](10) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaLop] [nvarchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SubjectsTHPT]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubjectsTHPT](
	[MaMon] [nvarchar](10) NULL,
	[TenMon] [nvarchar](50) NULL,
	[MaGV] [nvarchar](50) NULL,
	[MaHS] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SumScrores]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SumScrores](
	[MaHS] [nvarchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
	[Toán] [nvarchar](10) NULL,
	[Văn] [nvarchar](10) NULL,
	[Anh] [nvarchar](10) NULL,
	[Lý] [nvarchar](10) NULL,
	[Hóa] [nvarchar](10) NULL,
	[Sinh] [nvarchar](10) NULL,
	[Địa] [nvarchar](10) NULL,
	[Sử] [nvarchar](10) NULL,
	[Tin] [nvarchar](10) NULL,
	[DiemTb] [nvarchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TeacherTHPT]    Script Date: 1/4/2020 12:07:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeacherTHPT](
	[MaGV] [nvarchar](10) NULL,
	[TenGV] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[Phone] [nvarchar](15) NULL,
	[Email] [nvarchar](20) NULL,
	[GiangDayMon] [nvarchar](20) NULL,
	[MaLop] [nvarchar](10) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[ClassTHPT] ([MaLop], [TenLop], [MaGV], [MaHS]) VALUES (N'A111', N'11A1', N'01A', N'02')
INSERT [dbo].[ClassTHPT] ([MaLop], [TenLop], [MaGV], [MaHS]) VALUES (N'A101', N'10A1', N'01', N'01')
INSERT [dbo].[ClassTHPT] ([MaLop], [TenLop], [MaGV], [MaHS]) VALUES (N'A121', N'12A1', N'01A1', N'03')
INSERT [dbo].[LoginTHPT] ([Taikhoan], [Matkhau], [Quyen]) VALUES (N'admin', N'123456', N'admin')
INSERT [dbo].[LoginTHPT] ([Taikhoan], [Matkhau], [Quyen]) VALUES (N'user', N'123456', N'user')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'01', N'Văn-10', N'01', N'Lê Văn Luyện', N'5.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'02', N'Toán-10', N'01', N'Lê Văn Luyện', N'6.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'03', N'Anh-10', N'01', N'Lê Văn Luyện', N'7.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'04', N'Lý-10', N'01', N'Lê Văn Luyện', N'8.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'05', N'Hóa-10', N'01', N'Lê Văn Luyện', N'8.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'06', N'Sinh-10', N'01', N'Lê Văn Luyện', N'7.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'07', N'Địa-10', N'01', N'Lê Văn Luyện', N'7.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'08', N'Sử-10', N'01', N'Lê Văn Luyện', N'6.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'09', N'Tin-10', N'01', N'Lê Văn Luyện', N'8.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'01A', N'Văn-11', N'02', N'Nguyễn Thị Như Quỳnh', N'8.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'02A', N'Toán-11', N'02', N'Nguyễn Thị Như Quỳnh', N'7.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'03A', N'Anh-11', N'02', N'Nguyễn Thị Như Quỳnh', N'6.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'04A', N'Lý-11', N'02', N'Nguyễn Thị Như Quỳnh', N'7.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'05A', N'Hóa-11', N'02', N'Nguyễn Thị Như Quỳnh', N'5.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'06A', N'Sinh-11', N'02', N'Nguyễn Thị Như Quỳnh', N'7.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'07A', N'Địa-11', N'02', N'Nguyễn Thị Như Quỳnh', N'9.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'08A', N'Sử-11', N'02', N'Nguyễn Thị Như Quỳnh', N'10.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'09A', N'Tin-11', N'02', N'Nguyễn Thị Như Quỳnh', N'9.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'01A1', N'Văn-12', N'03', N'Nguyễn Văn Lãm', N'9.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'02A1', N'Toán-12', N'03', N'Nguyễn Văn Lãm', N'8.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'03A1', N'Anh-12', N'03', N'Nguyễn Văn Lãm', N'7.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'04A1', N'Lý-12', N'03', N'Nguyễn Văn Lãm', N'8.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'05A1', N'Hoá-12', N'03', N'Nguyễn Văn Lãm', N'7.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'06A1', N'Sinh-12', N'03', N'Nguyễn Văn Lãm', N'8.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'07A1', N'Địa-12', N'03', N'Nguyễn Văn Lãm', N'5.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'08A1', N'Sử-12', N'03', N'Nguyễn Văn Lãm', N'6.0')
INSERT [dbo].[scoresTHPT] ([MaMon], [TenMon], [MaHS], [HoTen], [DiemTb]) VALUES (N'09A1', N'Tin-12', N'03', N'Nguyễn Văn Lãm', N'8.0')
INSERT [dbo].[StudentTHPT] ([MaHS], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [MaLop]) VALUES (N'01', N'Lê Văn Luyện', N'2/7/2004', N'Nam', N'Trần Duy Hưng, Tp.HCM', N'A101')
INSERT [dbo].[StudentTHPT] ([MaHS], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [MaLop]) VALUES (N'03', N'Nguyễn Thị Như Quỳnh', N'2/5/2002', N'Nữ', N'Q.12, Tp.HCM', N'A121')
INSERT [dbo].[StudentTHPT] ([MaHS], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [MaLop]) VALUES (N'02', N'Nguyễn Văn Lãm', N'7/9/2003', N'Nam', N'Bến Nghé, Tp.HCM', N'A111')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'01', N'Văn-10', N'01', N'01')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'02', N'Toán-10', N'01', N'01')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'03', N'Anh-10', N'01', N'01')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'04', N'Lý-10', N'02', N'01')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'05', N'Hoá-10', N'02', N'01')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'06', N'Sinh-10', N'02', N'01')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'07', N'Địa-10', N'03', N'01')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'08', N'Sử-10', N'03', N'01')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'09', N'Tin-10', N'03', N'01')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'01A', N'Văn-11', N'01A', N'02')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'02A', N'Toán-11', N'01A', N'02')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'03A', N'Anh-11', N'01A', N'02')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'04A', N'Lý-11', N'02A', N'02')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'05A', N'Hóa-11', N'02A', N'02')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'06A', N'Sinh-11', N'02A', N'02')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'07A', N'Địa-11', N'03A', N'02')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'08A', N'Sử-11', N'03A', N'02')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'09A', N'Tin-11', N'03A', N'02')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'01A1', N'Văn-12', N'01A1', N'03')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'02A1', N'Toán-12', N'01A1', N'03')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'03A1', N'Anh-12', N'01A1', N'03')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'04A1', N'Lý-12', N'02A1', N'03')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'05A1', N'Hóa-12', N'02A1', N'03')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'06A1', N'Sinh-12', N'02A1', N'03')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'07A1', N'Địa-12', N'03A1', N'03')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'08A1', N'Sử-12', N'03A1', N'03')
INSERT [dbo].[SubjectsTHPT] ([MaMon], [TenMon], [MaGV], [MaHS]) VALUES (N'09A1', N'Tin-12', N'03A1', N'03')
INSERT [dbo].[SumScrores] ([MaHS], [HoTen], [Toán], [Văn], [Anh], [Lý], [Hóa], [Sinh], [Địa], [Sử], [Tin], [DiemTb]) VALUES (N'01', N'Lê Văn Luyện', N'5', N'6', N'7', N'8', N'8', N'7', N'7', N'6', N'8', N'6.9')
INSERT [dbo].[SumScrores] ([MaHS], [HoTen], [Toán], [Văn], [Anh], [Lý], [Hóa], [Sinh], [Địa], [Sử], [Tin], [DiemTb]) VALUES (N'02', N'Nguyễn Thị Như Quỳnh', N'8', N'7', N'6', N'7', N'5', N'7', N'9', N'10', N'9', N'7.5')
INSERT [dbo].[SumScrores] ([MaHS], [HoTen], [Toán], [Văn], [Anh], [Lý], [Hóa], [Sinh], [Địa], [Sử], [Tin], [DiemTb]) VALUES (N'03', N'Nguyễn Văn Lãm', N'9', N'8', N'7', N'8', N'7', N'8', N'5', N'6', N'8', N'7.3')
INSERT [dbo].[TeacherTHPT] ([MaGV], [TenGV], [GioiTinh], [Phone], [Email], [GiangDayMon], [MaLop]) VALUES (N'01', N'Lương Văn Tiền', N'Khác', N'0988778445', N'giausang@gmail.com', N'Toán', N'A101')
INSERT [dbo].[TeacherTHPT] ([MaGV], [TenGV], [GioiTinh], [Phone], [Email], [GiangDayMon], [MaLop]) VALUES (N'02', N'Trần Thị Lượm', N'Nữ', N'0987896571', N'luom@gmail.com', N'Hoá', N'A101')
INSERT [dbo].[TeacherTHPT] ([MaGV], [TenGV], [GioiTinh], [Phone], [Email], [GiangDayMon], [MaLop]) VALUES (N'03', N'Lê Văn Thắng', N'Nam', N'0987896578', N'thang@gmail.com', N'Tin', N'A101')
INSERT [dbo].[TeacherTHPT] ([MaGV], [TenGV], [GioiTinh], [Phone], [Email], [GiangDayMon], [MaLop]) VALUES (N'01A', N'Lê Văn Hùng', N'Nam', N'0987896578', N'hung@gmail.com', N'Văn-11', N'A111')
INSERT [dbo].[TeacherTHPT] ([MaGV], [TenGV], [GioiTinh], [Phone], [Email], [GiangDayMon], [MaLop]) VALUES (N'02A', N'Lê Thị Thanh', N'Nữ', N'0987896789', N'thanh@gmail.com', N'Lý-11', N'A111')
INSERT [dbo].[TeacherTHPT] ([MaGV], [TenGV], [GioiTinh], [Phone], [Email], [GiangDayMon], [MaLop]) VALUES (N'03A', N'Lê Thành Tài', N'Nam', N'0988996789', N'tai@gmail.com', N'Điạ-11', N'A111')
INSERT [dbo].[TeacherTHPT] ([MaGV], [TenGV], [GioiTinh], [Phone], [Email], [GiangDayMon], [MaLop]) VALUES (N'01A1', N'Nguyễn Thanh Trà', N'Nữ', N'0988116789', N'tra@gmail.com', N'Anh-12', N'A121')
INSERT [dbo].[TeacherTHPT] ([MaGV], [TenGV], [GioiTinh], [Phone], [Email], [GiangDayMon], [MaLop]) VALUES (N'02A1', N'Nguyễn Văn Tuấn', N'Nam', N'0988116999', N'tuan@gmail.com', N'Sinh-12', N'A121')
INSERT [dbo].[TeacherTHPT] ([MaGV], [TenGV], [GioiTinh], [Phone], [Email], [GiangDayMon], [MaLop]) VALUES (N'03A1', N'Nguyễn Thị Lanh', N'Nữ', N'0988116912', N'lanh@gmail.com', N'Sử-12', N'A121')
