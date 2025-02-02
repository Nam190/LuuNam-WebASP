USE [lvnk22cnt1]
GO
/****** Object:  Table [dbo].[CHI_TIET_DON_HANG]    Script Date: 11/7/2024 4:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHI_TIET_DON_HANG](
	[OrderDetailID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[So_luong] [int] NULL,
	[Gia] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DON_HANG]    Script Date: 11/7/2024 4:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DON_HANG](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[Ngay_dat_hang] [datetime] NULL,
	[Tong_gia] [decimal](10, 2) NULL,
	[Trang_thai] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACH_HANG]    Script Date: 11/7/2024 4:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH_HANG](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Ho_ten] [nvarchar](100) NULL,
	[Tai_khoan] [varchar](50) NOT NULL,
	[Mat_khau] [varchar](32) NULL,
	[Dia_chi] [nvarchar](200) NULL,
	[Dien_thoai] [varchar](30) NULL,
	[Email] [varchar](50) NOT NULL,
	[Ngay_sinh] [datetime] NULL,
	[Ngay_cap_nhat] [datetime] NULL,
	[Gioi_tinh] [tinyint] NULL,
	[Tich_diem] [int] NULL,
	[Trang_thai] [tinyint] NULL,
 CONSTRAINT [PK__KHACH_HA__A4AE64B8CEB5B938] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUAN_TRI]    Script Date: 11/7/2024 4:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUAN_TRI](
	[Tai_khoan] [varchar](50) NOT NULL,
	[Mat_khau] [varchar](32) NULL,
	[Trang_thai] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Tai_khoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SAN_PHAM]    Script Date: 11/7/2024 4:54:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SAN_PHAM](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Ten_san_pham] [nvarchar](100) NULL,
	[Mo_ta] [nvarchar](150) NULL,
	[Gia] [decimal](10, 2) NULL,
	[So_luong_ton_kho] [int] NULL,
	[CategoryID] [int] NULL,
	[Anh] [varchar](250) NULL,
 CONSTRAINT [PK__SAN_PHAM__B40CC6EDEF9D8A09] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DON_HANG] ON 

INSERT [dbo].[DON_HANG] ([OrderID], [CustomerID], [Ngay_dat_hang], [Tong_gia], [Trang_thai]) VALUES (1, 1, CAST(N'2024-11-05T20:07:40.310' AS DateTime), CAST(100000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[DON_HANG] ([OrderID], [CustomerID], [Ngay_dat_hang], [Tong_gia], [Trang_thai]) VALUES (2, 2, CAST(N'2024-11-05T20:07:40.310' AS DateTime), CAST(150000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[DON_HANG] ([OrderID], [CustomerID], [Ngay_dat_hang], [Tong_gia], [Trang_thai]) VALUES (3, 3, CAST(N'2024-11-05T20:07:40.310' AS DateTime), CAST(200000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[DON_HANG] ([OrderID], [CustomerID], [Ngay_dat_hang], [Tong_gia], [Trang_thai]) VALUES (4, 4, CAST(N'2024-11-05T20:07:40.310' AS DateTime), CAST(250000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[DON_HANG] ([OrderID], [CustomerID], [Ngay_dat_hang], [Tong_gia], [Trang_thai]) VALUES (5, 5, CAST(N'2024-11-05T20:07:40.310' AS DateTime), CAST(300000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[DON_HANG] ([OrderID], [CustomerID], [Ngay_dat_hang], [Tong_gia], [Trang_thai]) VALUES (8, 1, CAST(N'2024-11-06T17:56:22.657' AS DateTime), CAST(20000.00 AS Decimal(10, 2)), NULL)
SET IDENTITY_INSERT [dbo].[DON_HANG] OFF
GO
SET IDENTITY_INSERT [dbo].[KHACH_HANG] ON 

INSERT [dbo].[KHACH_HANG] ([CustomerID], [Ho_ten], [Tai_khoan], [Mat_khau], [Dia_chi], [Dien_thoai], [Email], [Ngay_sinh], [Ngay_cap_nhat], [Gioi_tinh], [Tich_diem], [Trang_thai]) VALUES (1, N'Luu Viết Nam', N'user1', N'123', NULL, NULL, N'user1@example.com', CAST(N'1990-01-01T00:00:00.000' AS DateTime), CAST(N'2024-11-05T20:07:40.300' AS DateTime), 1, 100, 1)
INSERT [dbo].[KHACH_HANG] ([CustomerID], [Ho_ten], [Tai_khoan], [Mat_khau], [Dia_chi], [Dien_thoai], [Email], [Ngay_sinh], [Ngay_cap_nhat], [Gioi_tinh], [Tich_diem], [Trang_thai]) VALUES (2, N'Tran Thi B', N'user2', N'userpass2', N'456 Nguyen Trai', N'0901234568', N'user2@example.com', CAST(N'1992-02-02T00:00:00.000' AS DateTime), CAST(N'2024-11-05T20:07:40.300' AS DateTime), 0, 200, 1)
INSERT [dbo].[KHACH_HANG] ([CustomerID], [Ho_ten], [Tai_khoan], [Mat_khau], [Dia_chi], [Dien_thoai], [Email], [Ngay_sinh], [Ngay_cap_nhat], [Gioi_tinh], [Tich_diem], [Trang_thai]) VALUES (3, N'Le Van C', N'user3', N'userpass3', N'789 Tran Phu', N'0901234569', N'user3@example.com', CAST(N'1995-03-03T00:00:00.000' AS DateTime), CAST(N'2024-11-05T20:07:40.300' AS DateTime), 1, 150, 1)
INSERT [dbo].[KHACH_HANG] ([CustomerID], [Ho_ten], [Tai_khoan], [Mat_khau], [Dia_chi], [Dien_thoai], [Email], [Ngay_sinh], [Ngay_cap_nhat], [Gioi_tinh], [Tich_diem], [Trang_thai]) VALUES (4, N'Pham Thi D', N'user4', N'userpass4', N'111 Hoang Dieu', N'0901234570', N'user4@example.com', CAST(N'1998-04-04T00:00:00.000' AS DateTime), CAST(N'2024-11-05T20:07:40.300' AS DateTime), 0, 250, 1)
INSERT [dbo].[KHACH_HANG] ([CustomerID], [Ho_ten], [Tai_khoan], [Mat_khau], [Dia_chi], [Dien_thoai], [Email], [Ngay_sinh], [Ngay_cap_nhat], [Gioi_tinh], [Tich_diem], [Trang_thai]) VALUES (5, N'Hoang Van E', N'user5', N'userpass5', N'222 Ly Thuong Kiet', N'0901234571', N'user5@example.com', CAST(N'2000-05-05T00:00:00.000' AS DateTime), CAST(N'2024-11-05T20:07:40.300' AS DateTime), 1, 50, 1)
INSERT [dbo].[KHACH_HANG] ([CustomerID], [Ho_ten], [Tai_khoan], [Mat_khau], [Dia_chi], [Dien_thoai], [Email], [Ngay_sinh], [Ngay_cap_nhat], [Gioi_tinh], [Tich_diem], [Trang_thai]) VALUES (7, N'Manh', N'manh', N'123', NULL, NULL, N'example@gmail.com', NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[KHACH_HANG] OFF
GO
INSERT [dbo].[QUAN_TRI] ([Tai_khoan], [Mat_khau], [Trang_thai]) VALUES (N'admin1', N'password1', 1)
INSERT [dbo].[QUAN_TRI] ([Tai_khoan], [Mat_khau], [Trang_thai]) VALUES (N'admin2', N'password2', 1)
INSERT [dbo].[QUAN_TRI] ([Tai_khoan], [Mat_khau], [Trang_thai]) VALUES (N'admin3', N'password3', 0)
INSERT [dbo].[QUAN_TRI] ([Tai_khoan], [Mat_khau], [Trang_thai]) VALUES (N'admin4', N'password4', 1)
INSERT [dbo].[QUAN_TRI] ([Tai_khoan], [Mat_khau], [Trang_thai]) VALUES (N'admin5', N'password5', 0)
GO
SET IDENTITY_INSERT [dbo].[SAN_PHAM] ON 

INSERT [dbo].[SAN_PHAM] ([ProductID], [Ten_san_pham], [Mo_ta], [Gia], [So_luong_ton_kho], [CategoryID], [Anh]) VALUES (6, N'Cà r?t', N'Cà r?t tuoi, giàu vitamin A', CAST(15000.00 AS Decimal(10, 2)), 100, 1, N'4e731af1-0dd2-49a7-8002-8b37a9d3f202_1f4h_ca_rot.jpg')
INSERT [dbo].[SAN_PHAM] ([ProductID], [Ten_san_pham], [Mo_ta], [Gia], [So_luong_ton_kho], [CategoryID], [Anh]) VALUES (7, N'Khoai tây', N'Khoai tây Ðà L?t, tuoi và ngon', CAST(20000.00 AS Decimal(10, 2)), 80, 1, N'18c34ae5-c1cc-481c-ac44-401058c6924b_khoaitay.jpg')
INSERT [dbo].[SAN_PHAM] ([ProductID], [Ten_san_pham], [Mo_ta], [Gia], [So_luong_ton_kho], [CategoryID], [Anh]) VALUES (8, N'Súp lo xanh', N'Súp lo xanh, t?t cho s?c kh?e', CAST(25000.00 AS Decimal(10, 2)), 50, 1, N'0419a3ee-b64f-4c9e-bb88-ea61a0db594e_suplotrang1.jpg')
INSERT [dbo].[SAN_PHAM] ([ProductID], [Ten_san_pham], [Mo_ta], [Gia], [So_luong_ton_kho], [CategoryID], [Anh]) VALUES (9, N'Bí d?', N'Bí d? giàu ch?t xo và vitamin', CAST(18000.00 AS Decimal(10, 2)), 70, 1, N'a0ab4725-7b47-448b-8dc4-c7d8e83b0eb6_bidao.jpg')
INSERT [dbo].[SAN_PHAM] ([ProductID], [Ten_san_pham], [Mo_ta], [Gia], [So_luong_ton_kho], [CategoryID], [Anh]) VALUES (10, N'Rau c?i ng?t', N'Rau c?i ng?t s?ch, không hóa ch?t', CAST(12000.00 AS Decimal(10, 2)), 60, 1, N'01d52e64-cb20-4a72-9590-a4b0d3695cb9_cai_thao.png')
INSERT [dbo].[SAN_PHAM] ([ProductID], [Ten_san_pham], [Mo_ta], [Gia], [So_luong_ton_kho], [CategoryID], [Anh]) VALUES (11, N'Dua leo', N'Dua leo xanh, mát và giòn', CAST(14000.00 AS Decimal(10, 2)), 90, 1, N'bd7a60f7-3f74-4100-bdcd-ed9b141f7137_duachuot.jpg')
INSERT [dbo].[SAN_PHAM] ([ProductID], [Ten_san_pham], [Mo_ta], [Gia], [So_luong_ton_kho], [CategoryID], [Anh]) VALUES (12, N'C?i bó xôi', N'C?i bó xôi b? sung s?t, t?t cho máu', CAST(22000.00 AS Decimal(10, 2)), 40, 1, N'631c2b25-e527-4b36-b1c8-2c530f6d149f_cai_thao_da_lat.jpg')
INSERT [dbo].[SAN_PHAM] ([ProductID], [Ten_san_pham], [Mo_ta], [Gia], [So_luong_ton_kho], [CategoryID], [Anh]) VALUES (14, N'a', N'a', CAST(1213.00 AS Decimal(10, 2)), 1313, 1, N'39ebcded-e47b-4bdf-bff3-c375cd179afe_bapcai.jpg')
SET IDENTITY_INSERT [dbo].[SAN_PHAM] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__KHACH_HA__52AE88F56CEA4973]    Script Date: 11/7/2024 4:54:28 PM ******/
ALTER TABLE [dbo].[KHACH_HANG] ADD  CONSTRAINT [UQ__KHACH_HA__52AE88F56CEA4973] UNIQUE NONCLUSTERED 
(
	[Tai_khoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHI_TIET_DON_HANG]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[DON_HANG] ([OrderID])
GO
ALTER TABLE [dbo].[CHI_TIET_DON_HANG]  WITH CHECK ADD  CONSTRAINT [FK__CHI_TIET___Produ__2F10007B] FOREIGN KEY([ProductID])
REFERENCES [dbo].[SAN_PHAM] ([ProductID])
GO
ALTER TABLE [dbo].[CHI_TIET_DON_HANG] CHECK CONSTRAINT [FK__CHI_TIET___Produ__2F10007B]
GO
ALTER TABLE [dbo].[DON_HANG]  WITH CHECK ADD  CONSTRAINT [FK__DON_HANG__Custom__29572725] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[KHACH_HANG] ([CustomerID])
GO
ALTER TABLE [dbo].[DON_HANG] CHECK CONSTRAINT [FK__DON_HANG__Custom__29572725]
GO
