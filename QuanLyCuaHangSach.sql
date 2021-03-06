CREATE DATABASE QuanLyCuaHangSach
GO
USE [QuanLyCuaHangSach]
GO
--- Tạo login
CREATE LOGIN admin WITH PASSWORD = '12345'
GO
CREATE LOGIN viet WITH PASSWORD = '12345'
GO
CREATE LOGIN trung WITH PASSWORD = '12345'
GO
CREATE LOGIN diem WITH PASSWORD = '12345'
GO
CREATE LOGIN linh WITH PASSWORD = '12345'
GO
CREATE LOGIN thang WITH PASSWORD = '12345'
GO
/****** Object:  User [admin]    Script Date: 03-Nov-21 9:37:45 PM ******/
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [diem]    Script Date: 03-Nov-21 9:37:45 PM ******/
CREATE USER [diem] FOR LOGIN [diem] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [linh]    Script Date: 03-Nov-21 9:37:45 PM ******/
CREATE USER [linh] FOR LOGIN [linh] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [thang]    Script Date: 03-Nov-21 9:37:45 PM ******/
CREATE USER [thang] FOR LOGIN [thang] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [trung]    Script Date: 03-Nov-21 9:37:45 PM ******/
CREATE USER [trung] FOR LOGIN [trung] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [viet]    Script Date: 03-Nov-21 9:37:45 PM ******/
CREATE USER [viet] FOR LOGIN [viet] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [admin]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Quyen] [char](6) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[Luong] [bigint] NOT NULL,
	[HinhAnh] [image] NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[funTimKiemIDNV]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Tìm kiếm ID Nhân viên
CREATE FUNCTION [dbo].[funTimKiemIDNV]
(@ID varchar(10) )
RETURNS TABLE
    RETURN (select * from Nhanvien where ID like '%'+@ID+'%');
GO
/****** Object:  UserDefinedFunction [dbo].[funTimKiemTenNV]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Tìm kiếm tên Nhân viên
CREATE FUNCTION [dbo].[funTimKiemTenNV]
(@HoTen nvarchar(50) )
RETURNS TABLE
    RETURN (select * from Nhanvien where HoTen like '%'+@HoTen+'%');
GO
/****** Object:  UserDefinedFunction [dbo].[funTimKiemUserNameNV]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Tìm kiếm username của nhân viên
CREATE FUNCTION [dbo].[funTimKiemUserNameNV]
(@UserName nvarchar(50) )
RETURNS TABLE
    RETURN (select * from Nhanvien where UserName like  '%' + @UserName + '%' );
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_NV] [bigint] NOT NULL,
	[ID_TV] [bigint] NULL,
	[ID_GG] [bigint] NULL,
	[NgayMua] [datetime] NOT NULL,
	[ThanhTien] [bigint] NOT NULL,
	[NgayTao] [datetime] NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[funFindMonthOnHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create function [dbo].[funFindMonthOnHoaDon]()
RETURNS TABLE
AS
	RETURN (select distinct  month(NgayMua) as thang from HoaDon)
GO
/****** Object:  UserDefinedFunction [dbo].[funCountTotalbyMonth]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---Tính tổng doanh thu theo tháng 
create function [dbo].[funCountTotalbyMonth] ()
returns table
as
return 
select MONTH(NgayMua) AS 'Thang', SUM(ThanhTien) as 'Doanhthu'
from HoaDon
group by MONTH(NgayMua)
GO
/****** Object:  UserDefinedFunction [dbo].[funCountTotalbyDay]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Tính tổng doanh thu theo ngày
create function [dbo].[funCountTotalbyDay] ()
returns table
as
return 
select NgayMua AS 'NgayMua', SUM(ThanhTien) as 'Doanhthu'
from HoaDon
group by NgayMua
GO
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[ID_LoaiTV] [bigint] NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_ThanhVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[funCountTotalbyThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Tính doanh thu đối với mỗi thành viên
create function [dbo].[funCountTotalbyThanhVien] ()
returns table
as 
return
	select HoaDon.ID_TV, ThanhVien.HoTen, sum(HoaDon.ThanhTien) as DoanhThu
	from HoaDon, ThanhVien
	where HoaDon.ID_TV = ThanhVien.ID
	group by HoaDon.ID_TV, ThanhVien.HoTen
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ID_HD] [bigint] NOT NULL,
	[ID_Sach] [bigint] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayTao] [datetime] NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[ID_HD] ASC,
	[ID_Sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenSach] [nvarchar](200) NOT NULL,
	[ID_LoaiSach] [bigint] NOT NULL,
	[ID_NXB] [bigint] NOT NULL,
	[ID_TacGia] [bigint] NOT NULL,
	[GiaBan] [bigint] NOT NULL,
	[SoLuongTonKho] [int] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[funSoLuongSachBanDuoc]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Tính số lượng sách bán được
create function [dbo].[funSoLuongSachBanDuoc] ()
returns table
as 
return
	select ChiTietHoaDon.ID_Sach, TenSach, sum(ChiTietHoaDon.SoLuong) as slBanDuoc
	from Sach, ChiTietHoaDon
	where Sach.ID = ChiTietHoaDon.ID_Sach
	group by ChiTietHoaDon.ID_Sach, Sach.TenSach
GO
/****** Object:  View [dbo].[viewNhanVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- view  nhân viên
CREATE VIEW [dbo].[viewNhanVien] AS
SELECT ID, HoTen ,Luong
FROM NHANVIEN
WHERE Luong IS NOT NULL
WITH CHECK OPTION
GO
/****** Object:  Table [dbo].[GiamGia]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiamGia](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TieuDe] [nvarchar](100) NOT NULL,
	[PhanTramGG] [float] NOT NULL,
	[NgayBatDau] [datetime] NOT NULL,
	[NgayKetThuc] [datetime] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
	[NgayTao] [datetime] NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_GiamGia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThanhVien](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenLoaiTV] [nvarchar](50) NOT NULL,
	[MucUuDai] [float] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewChiTietHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Chi tiết hóa đơn
CREATE VIEW [dbo].[viewChiTietHoaDon] AS
SELECT ChiTietHoaDon.ID_HD, NhanVien.HoTen as TenNV, ThanhVien.HoTen as TenTV, ThanhVien.SDT as SDT_TV, TenSach, SoLuong, GiaBan, ThanhTien = (ChiTietHoaDon.SoLuong * Sach.GiaBan), MucUuDai, GiamGia.ID as MaGiamGia, PhanTramGG
FROM HoaDon, ChiTietHoaDon, NhanVien, ThanhVien, Sach, GiamGia, LoaiThanhVien
WHERE ChiTietHoaDon.ID_HD = HoaDon.ID
	and HoaDon.ID_NV = NhanVien.ID
	and HoaDon.ID_TV = ThanhVien.ID
	and ChiTietHoaDon.ID_Sach =  Sach.ID
	and HoaDon.ID_GG = GiamGia.ID
	and ThanhVien.ID = LoaiThanhVien.ID
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[ID_PN] [bigint] NOT NULL,
	[ID_Sach] [bigint] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiaNhap] [bigint] NOT NULL,
	[NgayTao] [datetime] NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ID_PN] ASC,
	[ID_Sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenNXB] [nvarchar](200) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_NXB] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_NV] [bigint] NOT NULL,
	[ID_NXB] [bigint] NOT NULL,
	[NgayNhap] [datetime] NOT NULL,
	[ThanhTien] [bigint] NOT NULL,
	[NgayTao] [datetime] NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewChiTietPhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Chi tiết phiếu nhập
CREATE VIEW [dbo].[viewChiTietPhieuNhap] AS
SELECT ChiTietPhieuNhap.ID_PN, NhanVien.HoTen as TenNV, TenNXB, NXB.SDT as SDT_NXB, TenSach, SoLuong, GiaNhap, ThanhTien = (ChiTietPhieuNhap.SoLuong * ChiTietPhieuNhap.GiaNhap)
FROM PhieuNhap, ChiTietPhieuNhap, NhanVien, NXB, Sach
WHERE ChiTietPhieuNhap.ID_PN = PhieuNhap.ID
	and PhieuNhap.ID_NV = NhanVien.ID
	and PhieuNhap.ID_NXB = NXB.ID
	and ChiTietPhieuNhap.ID_Sach =  Sach.ID
GO
/****** Object:  View [dbo].[viewTop10BanChay]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Lấy ra top 10 cuốn sách bán chạy nhất
CREATE VIEW [dbo].[viewTop10BanChay] AS
SELECT top(10) * from funSoLuongSachBanDuoc ()
ORDER BY slBanDuoc DESC
GO
/****** Object:  View [dbo].[viewSoLanMuaHang]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--So lan mua hang cua moi thanh vien
CREATE VIEW [dbo].[viewSoLanMuaHang] AS
select ThanhVien.ID, ThanhVien.HoTen, count(HoaDon.ID_TV) as SoLanMua
from ThanhVien, HoaDon
where ThanhVien.ID = HoaDon.ID_TV
group by ThanhVien.ID, ThanhVien.HoTen
GO
/****** Object:  View [dbo].[viewDoanhThuThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Doanh thu doi voi moi thanh vien
CREATE VIEW [dbo].[viewDoanhThuThanhVien] AS
select top(20) * from funCountTotalbyThanhVien ()
order by DoanhThu desc
GO
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSach](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenLoaiSach] [nvarchar](200) NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_LoaiSach] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenTacGia] [nvarchar](50) NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GiamGia] ON 

INSERT [dbo].[GiamGia] ([ID], [TieuDe], [PhanTramGG], [NgayBatDau], [NgayKetThuc], [GhiChu], [NgayTao], [NgayUpdate]) VALUES (1, N'Sale 10/10', 10, CAST(N'2021-10-07T00:00:00.000' AS DateTime), CAST(N'2021-10-10T00:00:00.000' AS DateTime), NULL, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[GiamGia] ([ID], [TieuDe], [PhanTramGG], [NgayBatDau], [NgayKetThuc], [GhiChu], [NgayTao], [NgayUpdate]) VALUES (2, N'Sale 15/10', 5, CAST(N'2021-10-15T00:00:00.000' AS DateTime), CAST(N'2021-10-15T00:00:00.000' AS DateTime), NULL, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[GiamGia] ([ID], [TieuDe], [PhanTramGG], [NgayBatDau], [NgayKetThuc], [GhiChu], [NgayTao], [NgayUpdate]) VALUES (3, N'Sale 11/11', 15, CAST(N'2021-11-09T00:00:00.000' AS DateTime), CAST(N'2021-11-11T00:00:00.000' AS DateTime), NULL, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[GiamGia] ([ID], [TieuDe], [PhanTramGG], [NgayBatDau], [NgayKetThuc], [GhiChu], [NgayTao], [NgayUpdate]) VALUES (4, N'Sale 15/11', 5, CAST(N'2021-11-15T00:00:00.000' AS DateTime), CAST(N'2021-11-15T00:00:00.000' AS DateTime), NULL, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[GiamGia] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiSach] ON 

INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (1, N'Hành động và phiêu lưu', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (2, N'Nghệ thuật', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (3, N'Tự truyện', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (4, N'Tiểu sử', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (5, N'Truyện tranh', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (6, N'Sách dạy nấu ăn', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (7, N'Sách giáo khoa, kiến thức chung', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (8, N'Ngoại ngữ', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (9, N'Lịch sử', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (10, N'Kinh dị', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (11, N'Sức khỏe, thể chất', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (12, N'Tạp chí, báo hàng ngày', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (13, N'Bí ẩn, bí mật, huyền bí', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (14, N'Thơ', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (15, N'Lãng mạn', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (16, N'Trinh thám', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (17, N'Khoa học viễn tưởng', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (18, N'Văn học thiếu nhi', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[LoaiSach] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiThanhVien] ON 

INSERT [dbo].[LoaiThanhVien] ([ID], [TenLoaiTV], [MucUuDai], [NgayTao], [NgayUpdate]) VALUES (1, N'Đồng', 3, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiThanhVien] ([ID], [TenLoaiTV], [MucUuDai], [NgayTao], [NgayUpdate]) VALUES (2, N'Bạc', 7, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiThanhVien] ([ID], [TenLoaiTV], [MucUuDai], [NgayTao], [NgayUpdate]) VALUES (3, N'Vàng', 10, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiThanhVien] ([ID], [TenLoaiTV], [MucUuDai], [NgayTao], [NgayUpdate]) VALUES (4, N'Bạch Kim', 15, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[LoaiThanhVien] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [Quyen], [Username], [Password], [HoTen], [DiaChi], [SDT], [Luong], [HinhAnh], [NgayTao], [NgayUpdate]) VALUES (1, N'admin ', N'admin', N'12345', N'Quản Lý', N'Hồ Chí Minh', N'0969799909', 15000000, NULL, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([ID], [Quyen], [Username], [Password], [HoTen], [DiaChi], [SDT], [Luong], [HinhAnh], [NgayTao], [NgayUpdate]) VALUES (2, N'user  ', N'viet', N'12345', N'Đỗ Quốc Việt', N'Hồ Chí Minh', N'0393014871', 7000000, NULL, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([ID], [Quyen], [Username], [Password], [HoTen], [DiaChi], [SDT], [Luong], [HinhAnh], [NgayTao], [NgayUpdate]) VALUES (3, N'user  ', N'trung', N'12345', N'Lương Quốc Trung', N'Hồ Chí Minh', N'0935544787', 7000000, NULL, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([ID], [Quyen], [Username], [Password], [HoTen], [DiaChi], [SDT], [Luong], [HinhAnh], [NgayTao], [NgayUpdate]) VALUES (4, N'user  ', N'diem', N'12345', N'Lê Thị Ngọc Diễm', N'Hồ Chí Minh', N'0936074295', 7000000, NULL, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([ID], [Quyen], [Username], [Password], [HoTen], [DiaChi], [SDT], [Luong], [HinhAnh], [NgayTao], [NgayUpdate]) VALUES (5, N'user  ', N'linh', N'12345', N'Nguyễn Thị Mỹ Linh', N'Hồ Chí Minh', N'0963577215', 7000000, NULL, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([ID], [Quyen], [Username], [Password], [HoTen], [DiaChi], [SDT], [Luong], [HinhAnh], [NgayTao], [NgayUpdate]) VALUES (6, N'user  ', N'thang', N'12345', N'Phạm Văn Thắng', N'Hồ Chí Minh', N'0868690043', 7000000, NULL, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[NXB] ON 

INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (1, N'Kim Đồng', N'55 Quang Trung, Hai Bà Trưng, Hà Nội', N'02439434730', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (2, N'Trẻ', N'161B Lý Chính Thắng, Phường 7, Quận 3, Thành phố Hồ Chí Minh', N'39316289', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (3, N'Tổng hợp thành phố Hồ Chí Minh', N'62 Nguyễn Thị Minh Khai, Phường Đa Kao, Quận 1, TP.HCM', N'38296764', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (4, N'Chính trị quốc gia sự thật', N'6/86 Duy Tân, Cầu Giấy, Hà Nội', N'0280.49221', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (5, N'Giáo dục', N'81 Trần Hưng Đạo, Hà Nội', N'02438220801', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (6, N'Hội Nhà văn', N'65 Nguyễn Du, Hà Nội', N'02438222135', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (7, N'Tư pháp', N'35 Trần Quốc Toản, Hoàn Kiếm, Hà Nội', N'02462632078', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (8, N'Thông tin và truyền thông', N' Tầng 6, Tòa nhà Cục Tần số Vô tuyến điện, số 115 Trần Duy Hưng, Hà Nội', N'35772139', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (9, N'Lao động', N'175 Giảng Võ, Đống Đa, Hà Nội', N'02438515380', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (10, N'Giao thông vận tải', N'80B Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', N'38221627', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (11, N'Đại học Quốc Gia Hà Nội', N'16 Hàng Chuối, Phạm Đình Hổ, Hai Bà Trưng, Hà Nội', N'02439714896', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (12, N'Phụ Nữ', N'Hà Nội', N'01212122', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (13, N'Văn Hóa-Văn Nghệ', N'Hồ Chí Minh', N'02828123', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (14, N'Hồng Đức', N'Hà Nội', N'0121221', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[NXB] OFF
GO
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (1, N'Cho tôi xin một vé đi tuổi thơ', 15, 2, 2, 64000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (2, N'Tôi thấy hoa vàng trên cỏ xanh', 15, 2, 2, 63800, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (3, N'Tôi là Bêtô', 15, 2, 2, 72250, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (4, N'Cô gái đến từ hôm qua', 15, 2, 2, 64000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (5, N'Con chó nhỏ mang giỏ hoa hồng', 18, 2, 2, 63900, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (6, N'Có hai con mèo ngồi bên cửa sổ ', 18, 2, 2, 72250, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (7, N'Mắt Biếc', 15, 2, 2, 91300, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (8, N'Chúc một ngày tốt lành', 18, 2, 2, 99000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (9, N'Ngồi khóc trên cây', 18, 2, 2, 90200, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (10, N'Ngày xưa có một chuyện tình', 15, 2, 2, 106250, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (11, N'Chồng Xứ Lạ', 13, 12, 3, 44280, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (12, N'Đàn Bà 30', 13, 12, 3, 50000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (13, N'Đàn ông không đọc Trang Hạ', 13, 6, 3, 60250, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (14, N'Sao Phải Đau Đến Như Vậy', 14, 13, 4, 80000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (15, N'Như Một Dòng Chảy Ngược, Sinh Ra Để Cô Đơn', 14, 13, 4, 65000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (16, N'Đi Qua Thương Nhớ', 14, 6, 4, 120000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (17, N'Về Đâu Những Vết Thương', 14, 6, 4, 80000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (18, N'Đi Đâu Cũng Nhớ Sài Gòn Và... Em', 15, 6, 5, 63100, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (19, N'Thả Thính Chân Kinh', 15, 2, 5, 74100, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (20, N'Buồn Làm Sao Buông', 15, 13, 5, 62400, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (21, N'Thương Mấy Cũng Là Người Dưng', 15, 13, 5, 94000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (22, N'Trời Vẫn Còn Xanh, Em Vẫn Còn Anh', 15, 13, 5, 66500, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (23, N'Người Xưa Đã Quên Ngày Xưa', 15, 13, 5, 70900, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (24, N'Trót Lỡ Chạm Môi Nhau', 3, 6, 6, 60000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (25, N'Mười Ba - Đừng Khóc Nữa Nhé, Phải Mạnh Mẽ Lên!', 3, 12, 6, 76000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (26, N'Muốn Khóc Thật To', 15, 13, 6, 84000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (27, N'Đời CallBoy', 11, 6, 7, 79000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (28, N'Lạc giữa miền đau', 3, 6, 7, 87200, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (29, N'Người cũ còn thương', 15, 11, 7, 79000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (30, N'Chênh vênh 25', 16, 13, 7, 63200, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (35, N'Khóc giữa Sài Gòn', 2, 14, 7, 68000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
SET IDENTITY_INSERT [dbo].[TacGia] ON 

INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (1, N'Đỗ Quốc Việt', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (2, N'Nguyễn Nhật Ánh', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (3, N'Trang Hạ', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (4, N'Nguyễn Phong Việt', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (5, N'Anh Khang', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (6, N'Sơn Paris', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (7, N'Nguyễn Ngọc Thạch', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (8, N'Đỗ Nhật Nam', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (9, N'Nguyễn Minh Nhật', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (10, N'Hồng Cửu', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[TacGia] OFF
GO
SET IDENTITY_INSERT [dbo].[ThanhVien] ON 

INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (1, N'Nguyễn Thúy An', N'Hồ Chí Minh', N'0123456789', 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (2, N'Nguyễn Mai Anh', N'Hồ Chí Minh', N'0123456789', 2, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (3, N'Nguyễn Thùy Chi', N'Hồ Chí Minh', N'0123456789', 3, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (4, N'Nguyễn Tùng Chi', N'Hồ Chí Minh', N'0123456789', 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (5, N'Nguyễn Thu Thảo', N'Hồ Chí Minh', N'0123456789', 2, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (6, N'Lê Bảo Châu', N'Hồ Chí Minh', N'0123456789', 3, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (7, N'Lê Bảo Trân', N'Hồ Chí Minh', N'0123456789', 4, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (8, N'Lê Hoài Anh', N'Hồ Chí Minh', N'0123456789', 2, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (9, N'Lê Đức Minh', N'Hồ Chí Minh', N'0123456789', 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (10, N'Lê Hoài Anh', N'Hồ Chí Minh', N'0123456789', 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (11, N'Phạm Khánh Vân', N'Hồ Chí Minh', N'0123456789', 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [ID_LoaiTV], [NgayTao], [NgayUpdate]) VALUES (12, N'Phạm Nhật Minh', N'Hồ Chí Minh', N'0123456789', 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[ThanhVien] OFF
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((1)) FOR [ID_HD]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((1)) FOR [ID_Sach]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  DEFAULT ((1)) FOR [ID_PN]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ADD  DEFAULT ((1)) FOR [ID_Sach]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((1)) FOR [ID_NV]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((1)) FOR [ID_TV]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [ID_GG]
GO
ALTER TABLE [dbo].[LoaiThanhVien] ADD  DEFAULT ((0)) FOR [MucUuDai]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  DEFAULT ((1)) FOR [ID_NV]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  DEFAULT ((1)) FOR [ID_NXB]
GO
ALTER TABLE [dbo].[Sach] ADD  DEFAULT ((1)) FOR [ID_LoaiSach]
GO
ALTER TABLE [dbo].[Sach] ADD  DEFAULT ((1)) FOR [ID_NXB]
GO
ALTER TABLE [dbo].[Sach] ADD  DEFAULT ((1)) FOR [ID_TacGia]
GO
ALTER TABLE [dbo].[ThanhVien] ADD  DEFAULT ((1)) FOR [ID_LoaiTV]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([ID_HD])
REFERENCES [dbo].[HoaDon] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_Sach] FOREIGN KEY([ID_Sach])
REFERENCES [dbo].[Sach] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_Sach]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([ID_PN])
REFERENCES [dbo].[PhieuNhap] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_Sach] FOREIGN KEY([ID_Sach])
REFERENCES [dbo].[Sach] ([ID])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_Sach]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_GiamGia] FOREIGN KEY([ID_GG])
REFERENCES [dbo].[GiamGia] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_GiamGia]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([ID_NV])
REFERENCES [dbo].[NhanVien] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_ThanhVien] FOREIGN KEY([ID_TV])
REFERENCES [dbo].[ThanhVien] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_ThanhVien]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhanVien] FOREIGN KEY([ID_NV])
REFERENCES [dbo].[NhanVien] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NXB] FOREIGN KEY([ID_NXB])
REFERENCES [dbo].[NXB] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NXB]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_LoaiSach] FOREIGN KEY([ID_LoaiSach])
REFERENCES [dbo].[LoaiSach] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_LoaiSach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_NXB] FOREIGN KEY([ID_NXB])
REFERENCES [dbo].[NXB] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_NXB]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia] FOREIGN KEY([ID_TacGia])
REFERENCES [dbo].[TacGia] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TacGia]
GO
ALTER TABLE [dbo].[ThanhVien]  WITH CHECK ADD  CONSTRAINT [FK_ThanhVien_LoaiThanhVien] FOREIGN KEY([ID_LoaiTV])
REFERENCES [dbo].[LoaiThanhVien] ([ID])
ON UPDATE CASCADE
ON DELETE SET DEFAULT
GO
ALTER TABLE [dbo].[ThanhVien] CHECK CONSTRAINT [FK_ThanhVien_LoaiThanhVien]
GO
/****** Object:  StoredProcedure [dbo].[spCountTotalbyMonth]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spCountTotalbyMonth]
	--@month INT 
AS
    SELECT MONTH(NgayMua) AS 'Thang', SUM(ThanhTien) as 'Doanhthu'
    FROM HoaDon
    --WHERE CAST(MONTH(NgayMua) AS INT)= @month
    GROUP BY MONTH(NgayMua)
GO
/****** Object:  StoredProcedure [dbo].[spDeleteChiTietHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteChiTietHoaDon]
	@ID_HD bigint,
	@ID_Sach bigint
AS
BEGIN
	DELETE FROM ChiTietHoaDon
	WHERE ID_HD = @ID_HD AND ID_Sach = @ID_Sach
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteChiTietPhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spDeleteChiTietPhieuNhap]
@ID_PN BIGINT,
@ID_Sach BIGINT
AS
BEGIN
	DELETE FROM ChiTietPhieuNhap WHERE ID_PN = @ID_PN AND ID_Sach = ID_Sach
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteGiamGia]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteGiamGia]
	@ID bigint
AS
BEGIN
	DELETE FROM GiamGia
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteHoaDon]
	@ID bigint
AS
BEGIN
	DELETE FROM HoaDon
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteLoaiSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteLoaiSach]
	@ID bigint
AS
BEGIN
	DELETE FROM LoaiSach
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteLoaiThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteLoaiThanhVien]
	@ID bigint
AS
BEGIN
	DELETE FROM LoaiThanhVien
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteNhanVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteNhanVien]
	@ID bigint
AS
BEGIN
	DELETE FROM NhanVien
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteNXB]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteNXB]
	@ID bigint
AS
BEGIN
	DELETE FROM NXB
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeletePhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeletePhieuNhap]
	@ID bigint
AS
BEGIN
	DELETE FROM PhieuNhap
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteSach]
	@ID bigint
AS
BEGIN
	DELETE FROM Sach
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteTacGia]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- TacGia

CREATE PROCEDURE [dbo].[spDeleteTacGia]
	@ID bigint
AS
BEGIN
	DELETE FROM TacGia
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spDeleteThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spDeleteThanhVien]
@ID BIGINT
AS
BEGIN
	DELETE FROM ThanhVien WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[spFindLoaiSachByIDAndName]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spFindLoaiSachByIDAndName]
AS
BEGIN
	SELECT ID, TenLoaiSach FROM LoaiSach
END
GO
/****** Object:  StoredProcedure [dbo].[spFindLoaiSachByName]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spFindLoaiSachByName]
AS
BEGIN
	SELECT TenLoaiSach FROM LoaiSach
END
GO
/****** Object:  StoredProcedure [dbo].[spFindSachByName]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spFindSachByName]
	@TenSach nvarchar(200)
AS
BEGIN	
	SELECT TenSach,GiaBan, SoLuongTonKho FROM Sach WHERE TenSach LIKE  '%' + @TenSach + '%' 
END
GO
/****** Object:  StoredProcedure [dbo].[spFindSachByNameLoaiSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spFindSachByNameLoaiSach]
	@ID_LoaiSach bigint
AS	
BEGIN
	SELECT TenSach FROM Sach WHERE ID_LoaiSach=ID_LoaiSach
END
GO
/****** Object:  StoredProcedure [dbo].[spGetChiTietHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Chi Tiet Hoa Don
CREATE PROCEDURE [dbo].[spGetChiTietHoaDon]
AS
BEGIN
	SELECT * FROM ChiTietHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[spGetChiTietPhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ChiTietPhieuNhap

CREATE PROCEDURE [dbo].[spGetChiTietPhieuNhap]
AS
BEGIN
	SELECT * FROM ChiTietPhieuNhap
END
GO
/****** Object:  StoredProcedure [dbo].[spGetGiaBanByName]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetGiaBanByName]
	@TenSach nvarchar(200)
AS
BEGIN
	SELECT GiaBan FROM Sach WHERE TenSach = @TenSach 
END
GO
/****** Object:  StoredProcedure [dbo].[spGetGiamGia]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--GiamGia
CREATE PROCEDURE [dbo].[spGetGiamGia]
AS
BEGIN
	SELECT * FROM GiamGia
END
GO
/****** Object:  StoredProcedure [dbo].[spGetGiamGiaByIDThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetGiamGiaByIDThanhVien]
	@ID bigint
AS
BEGIN
	SELECT MucUuDai 
	FROM  ThanhVien, LoaiThanhVien
	WHERE ThanhVien.ID_LoaiTV=LoaiThanhVien.ID AND ThanhVien.ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spGetGiamGiaByNgay]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetGiamGiaByNgay]
	@ngay datetime
AS
BEGIN
	SELECT ID, NgayBatDau, NgayKetThuc, PhanTramGG
	FROM  GiamGia
	WHERE NgayBatDau<= @ngay AND @ngay<=NgayKetThuc
END
GO
/****** Object:  StoredProcedure [dbo].[spGetGiamGiaByTenThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetGiamGiaByTenThanhVien]
	@HoTen nvarchar(50)
AS
BEGIN
	SELECT MucUuDai 
	FROM  ThanhVien, LoaiThanhVien
	WHERE ThanhVien.ID_LoaiTV=LoaiThanhVien.ID AND ThanhVien.HoTen = @HoTen
END
GO
/****** Object:  StoredProcedure [dbo].[spGetHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--HoaDon
CREATE PROCEDURE [dbo].[spGetHoaDon]
AS
BEGIN
	SELECT * FROM HoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[spGetIDSachByName]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetIDSachByName]
	@TenSach nvarchar(200)
AS
BEGIN
	SELECT ID FROM Sach WHERE TenSach=@TenSach
END
GO
/****** Object:  StoredProcedure [dbo].[spGetLastRowInHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetLastRowInHoaDon]
AS
BEGIN
	SELECT ID FROM HoaDon WHERE ID=(SELECT max(ID) FROM HoaDon)
END
GO
/****** Object:  StoredProcedure [dbo].[spGetLoaiSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--LOAI SACH
CREATE PROCEDURE [dbo].[spGetLoaiSach]
AS
BEGIN
	SELECT * FROM LoaiSach
END
GO
/****** Object:  StoredProcedure [dbo].[spGetLoaiThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- LoaiThanhVien

CREATE PROCEDURE [dbo].[spGetLoaiThanhVien]
AS
BEGIN
	SELECT * FROM LoaiThanhVien
END
GO
/****** Object:  StoredProcedure [dbo].[spGetNameAndIdNhanVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetNameAndIdNhanVien]
AS
BEGIN
	SELECT ID, HoTen FROM NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[spGetNameAndIdThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetNameAndIdThanhVien]
AS
BEGIN
	SELECT ID, HoTen FROM ThanhVien
END
GO
/****** Object:  StoredProcedure [dbo].[spGetNhanVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- NhanVien

CREATE PROCEDURE [dbo].[spGetNhanVien]
AS
BEGIN
	SELECT * FROM NhanVien
END
GO
/****** Object:  StoredProcedure [dbo].[spGetNXB]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- NXB

CREATE PROCEDURE [dbo].[spGetNXB]
AS
BEGIN
	SELECT * FROM NXB
END
GO
/****** Object:  StoredProcedure [dbo].[spGetPhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- PhieuNhap
CREATE PROCEDURE [dbo].[spGetPhieuNhap]
AS
BEGIN
	SELECT * FROM PhieuNhap
END
GO
/****** Object:  StoredProcedure [dbo].[spGetSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Sach

CREATE PROCEDURE [dbo].[spGetSach]
AS
BEGIN
	SELECT * FROM Sach
END
GO
/****** Object:  StoredProcedure [dbo].[spGetSoSachTonKho]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetSoSachTonKho]
	@TenSach nvarchar(200)
AS
BEGIN
	SELECT SoLuongTonKho FROM Sach WHERE TenSach = @TenSach
END
GO
/****** Object:  StoredProcedure [dbo].[spGetTacGia]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetTacGia]
AS
BEGIN
	SELECT * FROM TacGia
END
GO
/****** Object:  StoredProcedure [dbo].[spGetThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--ThanhVien
CREATE PROCEDURE [dbo].[spGetThanhVien]
AS
BEGIN
	SELECT * FROM ThanhVien
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertChiTietHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertChiTietHoaDon]
	@ID_HD bigint,
	@ID_Sach bigint,
	@SoLuong int,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO ChiTietHoaDon (ID_HD,ID_Sach,SoLuong,NgayTao,NgayUpdate) 
	VALUES 
	(
		@ID_HD,
		@ID_Sach,
		@SoLuong ,
		@NgayTao,
		@NgayUpdate
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertChiTietPhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spInsertChiTietPhieuNhap]
	@ID_PN BIGINT,
	@ID_Sach BIGINT,
	@SoLuong INT,
	@GiaNhap BIGINT,
	@NgayTao DATETIME,
	@NgayUpdate DATETIME
AS
BEGIN
	INSERT INTO ChiTietPhieuNhap (ID_PN, ID_Sach, SoLuong, GiaNhap, NgayTao, NgayUpdate)
	VALUES 
	(
		@ID_PN,
		@ID_Sach,
		@SoLuong, 
		@GiaNhap, 
		@NgayTao, 
		@NgayUpdate
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertGiamGia]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertGiamGia]
	@TieuDe nvarchar(100),
	@PhanTramGG float,
	@NgayBatDau datetime,
	@NgayKetThuc datetime,
	@GhiChu nvarchar(100),
	@NgayTao datetime
AS
BEGIN
	INSERT INTO GiamGia (TieuDe,PhanTramGG,NgayBatDau,NgayKetThuc,GhiChu,NgayTao) 
	VALUES 
	(
		@TieuDe,
		@PhanTramGG,
		@NgayBatDau,
		@NgayKetThuc,
		@GhiChu,
		@NgayTao
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertHoaDon]
	@ID_NV bigint,
	@ID_TV bigint,
	@ID_GG bigint,
	@NgayMua datetime,
	@ThanhTien bigint,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO HoaDon (ID_NV,ID_TV,ID_GG,NgayMua,ThanhTien,NgayTao,NgayUpdate) 
	VALUES 
	(
		@ID_NV,
		@ID_TV,
		@ID_GG,
		@NgayMua,
		@ThanhTien,
		@NgayTao,
		@NgayUpdate
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertLoaiSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertLoaiSach]
	@TenLoaiSach nvarchar(200),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO LoaiSach (TenLoaiSach,NgayTao,NgayUpdate) 
	VALUES 
	(
		@TenLoaiSach,
		@NgayTao,
		@NgayUpdate
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertLoaiThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertLoaiThanhVien]
	@TenLoaiTV nvarchar(50),
	@MucUuDai float,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO LoaiThanhVien(TenLoaiTV, MucUuDai, NgayTao, NgayUpdate) 
	VALUES 
	(
		@TenLoaiTV,
		@MucUuDai,
		@NgayTao,
		@NgayUpdate
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertNhanVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertNhanVien]
	@Quyen char(6),
	@Username varchar(50),
	@Password varchar(50),
	@HoTen nvarchar(50),
	@DiaChi nvarchar(200),
	@SDT varchar(11),
	@Luong bigint,
	@HinhAnh image,
	@NgayTao datetime
AS
BEGIN
	INSERT INTO NhanVien (Quyen, Username, Password, HoTen, DiaChi, SDT, Luong, HinhAnh, NgayTao) 
    VALUES 
    (
		@Quyen,
		@Username,
		@Password,
		@HoTen,
		@DiaChi,
		@SDT,
		@Luong,
		@HinhAnh,
		@NgayTao
    )
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertNXB]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertNXB]
	@TenNXB nvarchar(200),
	@DiaChi nvarchar(200),
	@SDT varchar(11),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO NXB(TenNXB, DiaChi,SDT, NgayTao, NgayUpdate) 
	VALUES 
	(
		@TenNXB,
		@DiaChi,
		@SDT,
		@NgayTao,
		@NgayUpdate
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertPhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertPhieuNhap]
	@ID_NV bigint,
	@ID_NXB bigint,
	@NgayNhap datetime,
	@ThanhTien bigint,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO PhieuNhap(ID_NV,ID_NXB,NgayNhap,ThanhTien, NgayTao, NgayUpdate) 
	VALUES 
	(
		@ID_NV,
		@ID_NXB,
		@NgayNhap,
		@ThanhTien,
		@NgayTao,
		@NgayUpdate
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertSach]
	@TenSach nvarchar(200),
	@ID_LoaiSach bigint,
	@ID_NXB bigint,
	@ID_TacGia bigint,
	@GiaBan bigint,
	@SoLuongTonKho int,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO Sach (TenSach,ID_LoaiSach,ID_NXB,ID_TacGia,GiaBan,SoLuongTonKho,NgayTao,NgayUpdate) 
	VALUES 
	(
		@TenSach,
		@ID_LoaiSach,
		@ID_NXB,
		@ID_TacGia,
		@GiaBan,
		@SoLuongTonKho,
		@NgayTao,
		@NgayUpdate
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertTacGia]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInsertTacGia]
	@TenTacGia nvarchar(50),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	INSERT INTO TacGia(TenTacGia, NgayTao, NgayUpdate) 
	VALUES 
	(
		@TenTacGia,
		@NgayTao,
		@NgayUpdate
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spInsertThanhVien]
	@HoTen NVARCHAR(50),
	@DiaChi NVARCHAR(200), 
	@SDT VARCHAR(11), 
	@ID_LoaiTV BIGINT,
	@NgayTao DATETIME,
	@NgayUpdate DATETIME 
	
AS
BEGIN
	INSERT INTO ThanhVien (HoTen, DiaChi, SDT, ID_LoaiTV, NgayTao,  NgayUpdate) 
	VALUES 
	( 
		@HoTen, 
		@DiaChi, 
		@SDT, 
		@ID_LoaiTV,
		@NgayTao, 
		@NgayUpdate	
	)
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateChiTietHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateChiTietHoaDon]
	@ID_HD bigint,
	@ID_Sach bigint,
	@SoLuong int,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE ChiTietHoaDon
	SET 
		ID_HD = @ID_HD,
		ID_Sach= @ID_Sach,
		SoLuong= @SoLuong,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID_HD = @ID_HD AND ID_Sach=@ID_Sach
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateChiTietPhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spUpdateChiTietPhieuNhap]
	@ID_PN BIGINT,
	@ID_Sach BIGINT,
	@SoLuong INT,
	@GiaNhap BIGINT,
	@NgayTao DATETIME,
	@NgayUpdate DATETIME

AS
BEGIN
	UPDATE ChiTietPhieuNhap
	SET 
		ID_PN = @ID_PN,
		ID_Sach = @ID_Sach,
		SoLuong = @SoLuong,
		GiaNhap = @GiaNhap,
		NgayTao = @NgayTao, 
		NgayUpdate = @NgayUpdate
	WHERE ID_PN = @ID_PN AND ID_Sach = @ID_Sach
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateGiamGia]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateGiamGia]
	@ID bigint,
	@TieuDe nvarchar(100),
	@PhanTramGG float,
	@NgayBatDau datetime,
	@NgayKetThuc datetime,
	@GhiChu nvarchar(100),
	@NgayUpdate datetime
AS
BEGIN
	UPDATE GiamGia
	SET 
		NgayBatDau = @NgayBatDau,
		NgayKetThuc = @NgayKetThuc,
		PhanTramGG = @PhanTramGG,
		GhiChu = @GhiChu,
		NgayUpdate= @NgayUpdate
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spUpdateHoaDon]
	@ID bigint,
	@ID_NV bigint,
	@ID_TV bigint,
	@ID_GG bigint,
	@NgayMua datetime,
	@ThanhTien bigint,
	@NgayBatDau datetime,
	@NgayKetThuc datetime,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE HoaDon
	SET 
		ID_NV=@ID_NV,
		ID_TV=@ID_TV,
		ID_GG=@ID_GG,
		NgayMua=@NgayMua,
		ThanhTien=@ThanhTien,
		NgayTao=@NgayTao,
		NgayUpdate=@NgayUpdate
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateLoaiSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateLoaiSach]
	@ID bigint,
	@TenLoaiSach nvarchar(200),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE LoaiSach
	SET 
		TenLoaiSach = @TenLoaiSach,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateLoaiThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateLoaiThanhVien]
	@ID bigint,
	@TenLoaiTV nvarchar(50),
	@MucUuDai float,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE LoaiThanhVien
	SET 
		TenLoaiTV = @TenLoaiTV,
		MucUuDai = @MucUuDai,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateNhanVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateNhanVien]
	@Quyen char(6),
	@ID bigint,
	@Username varchar(50),
	@Password varchar(50),
	@HoTen nvarchar(50),
	@DiaChi nvarchar(200),
	@SDT varchar(11),
	@Luong bigint,
	@HinhAnh image,
	@NgayUpdate datetime
AS
	BEGIN TRANSACTION NhanVienUpdate 
		WITH MARK N'UPDATE NHAN VIEN';  
	IF (@HoTen is null or @UserName is null or @Password is null)
	begin
		raiserror ('Ho ten, UserName. Password cua nhan vien khong duoc bo trong',16,1)
		rollback
		return
	end
	UPDATE NhanVien
	SET 
		Quyen=@Quyen,
		Username = @Username,
		Password = @Password,
		HoTen = @HoTen,
		DiaChi = @DiaChi,
		SDT = @SDT,
		Luong = @Luong,
		HinhAnh = @HinhAnh,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
	IF (@@ERROR <>0)
	BEGIN
	raiserror('Error',16,1)
	rollback
	return
END
commit tran
GO
/****** Object:  StoredProcedure [dbo].[spUpdateNXB]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateNXB]
	@ID bigint,
	@TenNXB nvarchar(200),
	@DiaChi nvarchar(200),
	@SDT varchar(11),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE NXB
	SET 
		TenNXB = @TenNXB,
		DiaChi=@DiaChi,
		SDT=@SDT,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdatePhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdatePhieuNhap]
	@ID bigint,
	@ID_NV bigint,
	@ID_NXB bigint,
	@NgayNhap datetime,
	@ThanhTien bigint,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE PhieuNhap
	SET 
		ID_NV=@ID_NV,
		ID_NXB=@ID_NXB,
		NgayNhap=@NgayNhap,
		ThanhTien=@ThanhTien,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateSach]
	@ID bigint,
	@TenSach nvarchar(200),
	@ID_LoaiSach bigint,
	@ID_NXB bigint,
	@ID_TacGia bigint,
	@GiaBan bigint,
	@SoLuongTonKho int,
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE Sach
	SET 
		TenSach = @TenSach,
		ID_LoaiSach = @ID_LoaiSach,
		ID_NXB = @ID_NXB,
		ID_TacGia = @ID_TacGia,
		GiaBan = @GiaBan,
		SoLuongTonKho=@SoLuongTonKho,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateTacGia]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateTacGia]
	@ID bigint,
	@TenTacGia nvarchar(50),
	@NgayTao datetime,
	@NgayUpdate datetime
AS
BEGIN
	UPDATE TacGia
	SET 
		TenTacGia = @TenTacGia,
		NgayTao = @NgayTao,
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[spUpdateThanhVien]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[spUpdateThanhVien]
	@ID BIGINT,
	@HoTen NVARCHAR(50),
	@DiaChi NVARCHAR(200), 
	@SDT VARCHAR(11), 
	@ID_LoaiTV BIGINT,
	@NgayTao DATETIME,
	@NgayUpdate DATETIME
	
AS
BEGIN
	UPDATE ThanhVien 
	SET 
		HoTen = @HoTen, 
		DiaChi = @DiaChi, 
		SDT = @SDT, 
		ID_LoaiTV = @ID_LoaiTV,
		NgayTao = @NgayTao, 
		NgayUpdate = @NgayUpdate
	WHERE ID = @ID
END
GO
/****** Object:  Trigger [dbo].[trgBanSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--2. Cập nhật số lượng sách sau khi bán sách
CREATE TRIGGER [dbo].[trgBanSach] ON [dbo].[ChiTietHoaDon] 
AFTER INSERT AS 
BEGIN
	UPDATE Sach
	SET SoLuongTonKho = SoLuongTonKho - (
		SELECT SoLuong
		FROM inserted
		WHERE ID_Sach = Sach.ID
	)
	FROM Sach
	JOIN inserted ON Sach.ID = inserted.ID_Sach
END
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ENABLE TRIGGER [trgBanSach]
GO
/****** Object:  Trigger [dbo].[trgCapNhatBanSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--3. Cập nhật sách trong kho sau khi cập nhật bán sách
CREATE TRIGGER [dbo].[trgCapNhatBanSach] ON [dbo].[ChiTietHoaDon]  
AFTER UPDATE AS
BEGIN
   UPDATE Sach SET SoLuongTonKho = SoLuongTonKho -
	   (SELECT SoLuong FROM inserted WHERE ID_Sach = Sach.ID) +
	   (SELECT SoLuong FROM deleted WHERE ID_Sach = Sach.ID)
   FROM Sach 
   JOIN deleted ON Sach.ID = deleted.ID_Sach
END
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ENABLE TRIGGER [trgCapNhatBanSach]
GO
/****** Object:  Trigger [dbo].[trgSoLuongChiTietHoaDon]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--1. Kiểm tra số lượng sách trên hóa đơn phải nhỏ hơn số lượng tồn kho
CREATE TRIGGER [dbo].[trgSoLuongChiTietHoaDon] ON [dbo].[ChiTietHoaDon]
AFTER INSERT AS
DECLARE @sl INT, @sltk INT
SELECT @sl=ChiTietHoaDon.SoLuong, @sltk = Sach.SoLuongTonKho
FROM Inserted ChiTietHoaDon JOIN Sach ON ChiTietHoaDon.ID_Sach = Sach.ID
IF (@sl > @sltk)
BEGIN 
	
	RAISERROR(N'Số lượng tồn kho không đủ', 16, 1)
	ROLLBACK
	RETURN
END
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ENABLE TRIGGER [trgSoLuongChiTietHoaDon]
GO
EXEC sp_settriggerorder @triggername=N'[dbo].[trgSoLuongChiTietHoaDon]', @order=N'First', @stmttype=N'INSERT'
GO
/****** Object:  Trigger [dbo].[trgCapNhatNhapSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--6. Cập nhật sách trong kho sau khi cập nhật nhập sách
CREATE TRIGGER [dbo].[trgCapNhatNhapSach] ON [dbo].[ChiTietPhieuNhap] 
AFTER UPDATE AS
BEGIN
   UPDATE Sach SET SoLuongTonKho = SoLuongTonKho +
	   (SELECT SoLuong FROM inserted WHERE ID_Sach = Sach.ID) +
	   (SELECT SoLuong FROM deleted WHERE ID_Sach = Sach.ID)
   FROM Sach 
   JOIN deleted ON Sach.ID = deleted.ID_Sach
END
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ENABLE TRIGGER [trgCapNhatNhapSach]
GO
/****** Object:  Trigger [dbo].[trgNhapSach]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--5. Cập nhật số lượng sách sau khi nhập sách 
CREATE TRIGGER [dbo].[trgNhapSach] ON [dbo].[ChiTietPhieuNhap] 
AFTER INSERT AS 
BEGIN
	UPDATE Sach
	SET SoLuongTonKho = SoLuongTonKho + (
		SELECT SoLuong
		FROM inserted
		WHERE ID_Sach = Sach.ID
	)
	FROM Sach
	JOIN inserted ON Sach.ID = inserted.ID_Sach
END
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ENABLE TRIGGER [trgNhapSach]
GO
/****** Object:  Trigger [dbo].[trgSoLuongChiTietPhieuNhap]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--4. Kiểm tra số lượng sách nhập phải lớn hơn 0 
CREATE TRIGGER [dbo].[trgSoLuongChiTietPhieuNhap] ON [dbo].[ChiTietPhieuNhap]
AFTER INSERT AS
DECLARE @sl INT
SELECT @sl= ChiTietPhieuNhap.SoLuong
FROM Inserted ChiTietPhieuNhap
IF @sl<1
BEGIN 
	
	RAISERROR(N'Số lượng không hợp lệ', 16, 1)
	ROLLBACK
	RETURN
END
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] ENABLE TRIGGER [trgSoLuongChiTietPhieuNhap]
GO
/****** Object:  Trigger [dbo].[trgNgayBatDau]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--7. Ngày bắt đầu của giảm giá phải trước ngày kết thúc
CREATE TRIGGER [dbo].[trgNgayBatDau] ON [dbo].[GiamGia]
AFTER INSERT AS 
DECLARE @NgayBatDau datetime, @NgayKetThuc datetime
SELECT @NgayBatDau = ne.NgayBatDau, @NgayKetThuc = ne.NgayKetThuc 
FROM inserted ne
IF(@NgayBatDau >= @NgayKetThuc)
BEGIN
ROLLBACK
RAISERROR(N'Ngày bắt đầu của giảm giá phải trước ngày kết thúc', 16, 1)
RETURN
END
GO
ALTER TABLE [dbo].[GiamGia] ENABLE TRIGGER [trgNgayBatDau]
GO
/****** Object:  Trigger [dbo].[trgPTGG]    Script Date: 03-Nov-21 9:37:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--8. Trigger kiểm tra phần trăm giảm nhỏ hơn 100
CREATE TRIGGER [dbo].[trgPTGG] ON [dbo].[GiamGia]
AFTER INSERT AS 
DECLARE @PhanTramGG FLOAT
SELECT @PhanTramGG=PhanTramGG FROM inserted 
IF(@PhanTramGG>100)
BEGIN
ROLLBACK
RAISERROR(N'Phần trăm giảm giá không hợp lệ', 16, 1)
RETURN
END
GO
ALTER TABLE [dbo].[GiamGia] ENABLE TRIGGER [trgPTGG]
GO
