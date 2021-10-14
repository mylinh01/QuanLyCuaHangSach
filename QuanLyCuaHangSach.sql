USE [QuanLyCuaHangSach]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 10/11/2021 12:52:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ID_HD] [bigint] NOT NULL,
	[ID_Sach] [bigint] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NOT NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[ID_HD] ASC,
	[ID_Sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 10/11/2021 12:52:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[ID_PN] [bigint] NOT NULL,
	[ID_Sach] [bigint] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GiaTong] [bigint] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ID_PN] ASC,
	[ID_Sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiamGia]    Script Date: 10/11/2021 12:52:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiamGia](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[NgayBatDau] [datetime] NOT NULL,
	[NgayKetThuc] [datetime] NOT NULL,
	[PhanTramGG] [float] NOT NULL,
	[NgayTao] [datetime] NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_GiamGia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10/11/2021 12:52:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_NV] [bigint] NOT NULL,
	[ID_TV] [bigint] NOT NULL,
	[ID_GG] [bigint] NULL,
	[NgayMua] [datetime] NOT NULL,
	[ThanhTien] [bigint] NOT NULL,
	[NgayBatDau] [datetime] NOT NULL,
	[NgayKetThuc] [datetime] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 10/11/2021 12:52:43 PM ******/
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
/****** Object:  Table [dbo].[LoaiThanhVien]    Script Date: 10/11/2021 12:52:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThanhVien](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[TenLoaiTV] [nvarchar](50) NOT NULL,
	[MucUuDai] [float] NOT NULL,
	[NgayTao] [datetime] NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_LoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/11/2021 12:52:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[Luong] [bigint] NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 10/11/2021 12:52:43 PM ******/
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
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 10/11/2021 12:52:43 PM ******/
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
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 10/11/2021 12:52:43 PM ******/
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
/****** Object:  Table [dbo].[TacGia]    Script Date: 10/11/2021 12:52:43 PM ******/
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
/****** Object:  Table [dbo].[ThanhVien]    Script Date: 10/11/2021 12:52:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhVien](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDT] [varchar](11) NOT NULL,
	[NgayTao] [datetime] NOT NULL,
	[NgayUpdate] [datetime] NULL,
	[ID_LoaiTV] [bigint] NULL,
 CONSTRAINT [PK_ThanhVien] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GiamGia] ON 

INSERT [dbo].[GiamGia] ([ID], [NgayBatDau], [NgayKetThuc], [PhanTramGG], [NgayTao], [NgayUpdate]) VALUES (2, CAST(N'2021-10-07T00:00:00.000' AS DateTime), CAST(N'2021-10-07T00:00:00.000' AS DateTime), 10, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[GiamGia] ([ID], [NgayBatDau], [NgayKetThuc], [PhanTramGG], [NgayTao], [NgayUpdate]) VALUES (3, CAST(N'2021-10-07T00:00:00.000' AS DateTime), CAST(N'2021-10-07T00:00:00.000' AS DateTime), 5, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[GiamGia] ([ID], [NgayBatDau], [NgayKetThuc], [PhanTramGG], [NgayTao], [NgayUpdate]) VALUES (4, CAST(N'2021-10-07T00:00:00.000' AS DateTime), CAST(N'2021-10-07T00:00:00.000' AS DateTime), 20, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[GiamGia] ([ID], [NgayBatDau], [NgayKetThuc], [PhanTramGG], [NgayTao], [NgayUpdate]) VALUES (5, CAST(N'2021-10-07T00:00:00.000' AS DateTime), CAST(N'2021-10-07T00:00:00.000' AS DateTime), 50, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
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
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (11, N'	Sức khỏe, thể chất', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (12, N'Tạp chí, báo hàng ngày', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[LoaiSach] ([ID], [TenLoaiSach], [NgayTao], [NgayUpdate]) VALUES (13, N'	Bí ẩn, bí mật, huyền bí', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
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
INSERT [dbo].[LoaiThanhVien] ([ID], [TenLoaiTV], [MucUuDai], [NgayTao], [NgayUpdate]) VALUES (4, N'Kim Cương', 13, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[LoaiThanhVien] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [Username], [Password], [HoTen], [DiaChi], [SDT], [Luong], [NgayTao], [NgayUpdate]) VALUES (1, N'1', N'1', N'Đỗ Quốc Việt', N'Hồ Chí Minh', N'0393014871', 10000, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([ID], [Username], [Password], [HoTen], [DiaChi], [SDT], [Luong], [NgayTao], [NgayUpdate]) VALUES (3, N'2', N'2', N'Trung', N'Hồ Chí Minh', N'0935544787', 10000, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([ID], [Username], [Password], [HoTen], [DiaChi], [SDT], [Luong], [NgayTao], [NgayUpdate]) VALUES (5, N'3', N'3', N'Ngọc Diễm', N'Hồ Chí Minh', N'0936074295', 10000, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([ID], [Username], [Password], [HoTen], [DiaChi], [SDT], [Luong], [NgayTao], [NgayUpdate]) VALUES (6, N'4', N'4', N'Nguyễn Thị Mỹ Linh', N'Hồ Chí Minh', N'0963577215', 10000, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([ID], [Username], [Password], [HoTen], [DiaChi], [SDT], [Luong], [NgayTao], [NgayUpdate]) VALUES (7, N'5', N'5', N'Phạm Văn Thắng', N'Hồ Chí Minh', N'0868690043', 10000, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[NXB] ON 

INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (1, N'Kim Đồng', N'55 Quang Trung, Hai Bà Trưng, Hà Nội', N'02439434730', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (2, N'Trẻ', N'161B Lý Chính Thắng, Phường 7, Quận 3, Thành phố Hồ Chí Minh', N'39316289', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (4, N'Tổng hợp thành phố Hồ Chí Minh', N'62 Nguyễn Thị Minh Khai, Phường Đa Kao, Quận 1, TP.HCM', N'38296764', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (5, N'chính trị quốc gia sự thật', N'6/86 Duy Tân, Cầu Giấy, Hà Nội', N'0280.49221', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (11, N'giáo dục', N'81 Trần Hưng Đạo, Hà Nội', N'02438220801', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (12, N'Hội Nhà văn', N'65 Nguyễn Du, Hà Nội', N'02438222135', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (13, N'Tư pháp', N'35 Trần Quốc Toản, Hoàn Kiếm, Hà Nội', N'02462632078', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (14, N'thông tin và truyền thông', N' Tầng 6, Tòa nhà Cục Tần số Vô tuyến điện, số 115 Trần Duy Hưng, Hà Nội', N'35772139', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (15, N'lao động', N'175 Giảng Võ, Đống Đa, Hà Nội', N'02438515380', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (16, N'giao thông vận tải', N'80B Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', N'38221627', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (18, N'Đại học Quốc Gia Hà Nội', N'16 Hàng Chuối, Phạm Đình Hổ, Hai Bà Trưng, Hà Nội', N'02439714896', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (21, N'Phụ Nữ', N'Hà Nội', N'01212122', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (22, N'Văn Hóa-Văn Nghệ', N'Hồ Chí Minh', N'02828123', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NXB] ([ID], [TenNXB], [DiaChi], [SDT], [NgayTao], [NgayUpdate]) VALUES (23, N'Hồng Đức', N'Hà Nội', N'0121221', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
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
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (11, N'Chồng Xứ Lạ', 13, 21, 3, 44280, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (12, N'Đàn Bà 30', 13, 21, 3, 50000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (13, N'Đàn ông không đọc Trang Hạ', 13, 12, 3, 60250, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (14, N'Sao Phải Đau Đến Như Vậy', 14, 22, 4, 80000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (15, N'Như Một Dòng Chảy Ngược, Sinh Ra Để Cô Đơn', 14, 22, 4, 65000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (16, N'Đi Qua Thương Nhớ', 14, 12, 4, 120000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (17, N'Về Đâu Những Vết Thương', 14, 12, 4, 80000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (18, N'Đi Đâu Cũng Nhớ Sài Gòn Và... Em', 15, 22, 5, 63100, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (19, N'Thả Thính Chân Kinh', 15, 2, 5, 74100, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (20, N'Buồn Làm Sao Buông', 15, 22, 5, 62400, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (21, N'Thương Mấy Cũng Là Người Dưng', 15, 22, 5, 94000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (22, N'Trời Vẫn Còn Xanh, Em Vẫn Còn Anh', 15, 22, 5, 66500, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (23, N'Người Xưa Đã Quên Ngày Xưa
', 15, 22, 5, 70900, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (24, N'Trót Lỡ Chạm Môi Nhau', 3, 12, 6, 60000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (25, N'Mười Ba - Đừng Khóc Nữa Nhé, Phải Mạnh Mẽ Lên!', 3, 12, 6, 76000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (26, N'Muốn Khóc Thật To', 15, 22, 6, 84000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (27, N'Đời CallBoy', 11, 12, 7, 79000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (28, N'Lạc giữa miền đau', 3, 12, 7, 87200, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (29, N'Người cũ còn thương', 15, 18, 7, 79000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (30, N'Chênh vênh 25', 16, 22, 7, 63200, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Sach] ([ID], [TenSach], [ID_LoaiSach], [ID_NXB], [ID_TacGia], [GiaBan], [SoLuongTonKho], [NgayTao], [NgayUpdate]) VALUES (35, N'Khóc giữa Sài Gòn', 2, 23, 7, 68000, 1, CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
SET IDENTITY_INSERT [dbo].[TacGia] ON 

INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (1, N'Đỗ Quốc Việt', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (2, N'Nguyễn Nhật Ánh', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (3, N'Trang Hạ', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (4, N'Nguyễn Phong Việt', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (5, N'Anh Khang', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (6, N'Sơn Paris

', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (7, N'Nguyễn Ngọc Thạch', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (8, N'Đỗ Nhật Nam', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (9, N'Nguyễn Minh Nhật
', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TacGia] ([ID], [TenTacGia], [NgayTao], [NgayUpdate]) VALUES (10, N'Hồng Cửu', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[TacGia] OFF
GO
SET IDENTITY_INSERT [dbo].[ThanhVien] ON 

INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (1, N'Nguyễn Thúy An', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (2, N'Nguyễn Mai Anh', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 2)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (3, N'Nguyễn Thùy Chi', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 3)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (4, N'Nguyễn Tùng Chi', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (5, N'Nguyễn Thu Thảo', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 2)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (6, N'Lê Bảo Châu', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 3)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (7, N'Lê Bảo Trân', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 4)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (8, N'Lê Hoài Anh', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 2)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (9, N'Lê Đức Minh', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (10, N'Lê Hoài Anh', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (11, N'Phạm Khánh Vân', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 1)
INSERT [dbo].[ThanhVien] ([ID], [HoTen], [DiaChi], [SDT], [NgayTao], [NgayUpdate], [ID_LoaiTV]) VALUES (12, N'Phạm Nhật Minh', N'Hồ Chí Minh', N'0123456789', CAST(N'2021-10-07T00:00:00.000' AS DateTime), NULL, 1)
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
ALTER TABLE [dbo].[LoaiThanhVien] ADD  CONSTRAINT [DF__LoaiThanh__MucUu__31EC6D26]  DEFAULT ((0)) FOR [MucUuDai]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  DEFAULT ((1)) FOR [ID_NV]
GO
ALTER TABLE [dbo].[PhieuNhap] ADD  DEFAULT ((1)) FOR [ID_NXB]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF__Sach__ID_LoaiSac__2A4B4B5E]  DEFAULT ((1)) FOR [ID_LoaiSach]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF__Sach__ID_NXB__2B3F6F97]  DEFAULT ((1)) FOR [ID_NXB]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF__Sach__ID_TacGia__2C3393D0]  DEFAULT ((1)) FOR [ID_TacGia]
GO
ALTER TABLE [dbo].[ThanhVien] ADD  CONSTRAINT [DF__ThanhVien__ID_Lo__34C8D9D1]  DEFAULT ((1)) FOR [ID_LoaiTV]
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
