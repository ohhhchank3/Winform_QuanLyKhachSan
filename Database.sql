CREATE DATABASE QLKS
GO
USE [QLKS]
GO
/****** Object:  StoredProcedure [dbo].[Laydata]    Script Date: 20/6/2021 10:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE TAIKHOAN(
 TaiKhoan nvarchar(100)
 ,MatKhau nvarchar(100)
 ,IdTaiKhoan int 


)
go
select IdTaiKhoan  from TAIKHOAN where TAIKHOAN.TaiKhoan = N'20133118'
select * from TAIKHOAN
insert into TAIKHOAN values(N'ohhhchank3',N'123456789a',123)
insert into TAIKHOAN values(N'admin',N'admin',234)
insert into TAIKHOAN values(N'20133118',N'20133118',256)
insert into TAIKHOAN values(N'20133080',N'20133080',257)
insert into TAIKHOAN values(N'1',N'1',125)
go
inner join 
CREATE PROC [dbo].[Laydata]
 @ngaydau date , @ngaycuoi DATE
 AS 
 BEGIN 
	 DELETE dbo.data
	 DECLARE @ngay DATE 
	 SET @ngay = @ngaydau
	 DECLARE @sophong FLOAT
	 SELECT @sophong=COUNT(*) FROM dbo.phong
	 
	--------------------
	DECLARE @sophongsd FLOAT
	
	--------------------
	DECLARE @AOR FLOAT 

	--------------------
	DECLARE @doanhthuphongngay FLOAT

	--------------------
	DECLARE @ADR FLOAT

	--------------------
	DECLARE @tongdttheongay FLOAT

	--------------------------------------------
	DECLARE @trevPAR FLOAT

	-----------------------------------------------

	 WHILE (@ngay<=@ngaycuoi)
	 BEGIN
	 ------------------------------------------------------------------------
	SELECT @sophongsd=COUNT(*) FROM dbo.hoadonphong 
	WHERE ((@ngay<= ngaycheckout AND @ngay>= ngaycheckin )
	OR (ngaycheckout IS NULL AND @ngay>= ngaycheckin ))
	----------------
	SET @AOR = ROUND(@sophongsd /@sophong *100 ,3,0)
	----------------------------------------------------------------
	SELECT @doanhthuphongngay=SUM(giaphong) FROM dbo.phong,dbo.hoadonphong
	 WHERE hoadonphong.idphong=phong.idphong
	 AND ( ((@ngay<= ngaycheckout AND @ngay>= ngaycheckin )
		 OR (ngaycheckout IS NULL AND @ngay>= ngaycheckin )) )
	-------------------------------------------------------------------
	SET @ADR = ROUND(@doanhthuphongngay / @sophongsd ,3,0)
	--------------------------------------------------------
	
	SELECT @tongdttheongay = @doanhthuphongngay + SUM(giadv*soluong) FROM dbo.hoadondv,dbo.dichvu,dbo.hoadonphong
	 WHERE 
		hoadondv.idhdp= hoadonphong.idhdp
		AND dichvu.tendv = dbo.hoadondv.tendv
	 AND @ngay=ngaygoi
	 AND ( ((@ngay<= ngaycheckout AND @ngay>= ngaycheckin )
		 OR (ngaycheckout IS NULL AND @ngay>= ngaycheckin )) )
	IF (@tongdttheongay IS NULL) SET @tongdttheongay=@doanhthuphongngay
	--------------------------------------------
	SET @trevPAR=ROUND(@tongdttheongay/@sophong ,3,0)
	-----------------------------------------------
	 INSERT dbo.data VALUES 
	 (@ngay,@sophongsd,@AOR,@doanhthuphongngay,@ADR,@tongdttheongay,@trevPAR)
	 SET @ngay = DATEADD(DAY,1,@ngay) 
	 END	
END	



GO
/****** Object:  Table [dbo].[dangnhap]    Script Date: 20/6/2021 10:50:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dangnhap](
	[tdn] [varchar](10) NOT NULL,
	[mk] [varchar](200) NULL,
	[tennv] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[tdn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[data]    Script Date: 20/6/2021 10:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[data](
	[ngay] [date] NULL,
	[sophongsd] [int] NULL,
	[AOR] [float] NULL,
	[tongDTthuephongngay] [float] NULL,
	[ADR] [float] NULL,
	[tongDTngay] [float] NULL,
	[trevPAR] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dichvu]    Script Date: 20/6/2021 10:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dichvuEnglish](
	[tendv] [nvarchar](100) NOT NULL,
	[donvi] [nvarchar](20) NULL,
	[giadv] [float] NULL
	)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'beer', N'Can', 15000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'Breakfast', N'Meal', 50000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'Dinner', N'Meal', 200000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'Lunch', N'Meal', 150000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'Coca', N'Stripe', 1000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'housekeeping', N'number of times', 150000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'Karaoke', N'number of times', 100000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'nail making', N'number of times', 200000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'nail making23', N'number of times', 150000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'filtered water', N'Chai', 8000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'Sauna', N'number of times', 150000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'laundry', N'number of times', 60000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'cold towels', N'female', 5000)
INSERT [dbo].[dichvuEnglish] ([tendv], [donvi], [giadv]) VALUES (N'Red bull	', N'Stripe', 15000)
CREATE TABLE [dbo].[dichvu](
	[tendv] [nvarchar](100) NOT NULL,
	[donvi] [nvarchar](20) NULL,
	[giadv] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[tendv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[hoadondv]    Script Date: 20/6/2021 10:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoadondv](
	[idhddv] [int] IDENTITY(1,1) NOT NULL,
	[idhdp] [int] NULL,
	[tendv] [nvarchar](100) NULL,
	[ngaygoi] [date] NULL,
	[soluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idhddv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hoadonphong]    Script Date: 20/6/2021 10:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[hoadonphong](
	[idhdp] [int] IDENTITY(1,1) NOT NULL,
	[idkh] [int] NULL,
	[phuongthuctt] [nvarchar](50) NULL,
	[idphong] [varchar](20) NULL,
	[ngaycheckin] [date] NULL,
	[ngaycheckout] [date] NULL,
	[tongtien] [float] NULL,
	[tienphong] [float] NULL,
	[tiendichvu] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idhdp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 20/6/2021 10:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khachhang](
	[idkh] [int] IDENTITY(1,1) NOT NULL,
	[cmnd] [varchar](50) NULL,
	[hoten] [nvarchar](100) NULL,
	[diachi] [nvarchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[idkh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phong]    Script Date: 20/6/2021 10:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phong](
	[idphong] [varchar](20) NOT NULL,
	[loaiphong] [nvarchar](50) NULL,
	[sogiuong] [int] NULL,
	[trangthai] [nvarchar](100) NULL,
	[giaphong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[thongtin]    Script Date: 20/6/2021 10:50:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[thongtin](
	[tenks] [nvarchar](50) NULL,
	[tenchuks] [nvarchar](30) NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [varchar](20) NULL,
	[masothue] [varchar](20) NULL,
	[ngaythanhlap] [datetime] NULL,
	[logofile] [nvarchar](150) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[dangnhap] ([tdn], [mk], [tennv]) VALUES (N'nv1', N'1', N'Nguy?n Qu?c Anh')
INSERT [dbo].[dangnhap] ([tdn], [mk], [tennv]) VALUES (N'nv2', N'1', N'Chu Mai Phương')
INSERT [dbo].[dangnhap] ([tdn], [mk], [tennv]) VALUES (N'nv3', N'1', N'Nguy?n Thúy Qu?nh')
INSERT [dbo].[dangnhap] ([tdn], [mk], [tennv]) VALUES (N'nv4', N'1', N'Ph?m Văn Di?n')
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'Bia', N'Lon', 15000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'B?a sáng', N'B?a', 50000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'B?a t?i', N'B?a', 200000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'B?a trưa', N'B?a', 150000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'Coca', N'Lon', 1000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'D?n ph?ng', N'L?n', 150000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'Karaoke', N'L?n', 100000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'Làm nail', N'L?n', 200000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'Mát-xa', N'L?n', 150000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'Nư?c l?c', N'Chai', 8000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'Xông hơi', N'L?n', 150000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'Gi?t là', N'L?n', 60000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'Khăn l?nh', N'Cái', 5000)
INSERT [dbo].[dichvu] ([tendv], [donvi], [giadv]) VALUES (N'B? húc', N'Lon', 15000)
SET IDENTITY_INSERT [dbo].[hoadondv] ON 

INSERT [dbo].[hoadondv] ([idhddv], [idhdp], [tendv], [ngaygoi], [soluong]) VALUES (1, 2, N'Karaoke', CAST(0x9D420B00 AS Date), 4)
INSERT [dbo].[hoadondv] ([idhddv], [idhdp], [tendv], [ngaygoi], [soluong]) VALUES (2, 3, N'Karaoke', CAST(0x9D420B00 AS Date), 3)
INSERT [dbo].[hoadondv] ([idhddv], [idhdp], [tendv], [ngaygoi], [soluong]) VALUES (3, 5, N'D?n ph?ng', CAST(0x9F420B00 AS Date), 2)
INSERT [dbo].[hoadondv] ([idhddv], [idhdp], [tendv], [ngaygoi], [soluong]) VALUES (4, 6, N'Karaoke', CAST(0x9F420B00 AS Date), 1)
INSERT [dbo].[hoadondv] ([idhddv], [idhdp], [tendv], [ngaygoi], [soluong]) VALUES (5, 7, N'Nư?c l?c', CAST(0x9F420B00 AS Date), 10)
INSERT [dbo].[hoadondv] ([idhddv], [idhdp], [tendv], [ngaygoi], [soluong]) VALUES (6, 8, N'Coca', CAST(0xA0420B00 AS Date), 8)
SET IDENTITY_INSERT [dbo].[hoadondv] OFF
SET IDENTITY_INSERT [dbo].[hoadonphong] ON 
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (1, 1, NULL, N'P201', CAST(0x9D420B00 AS Date), CAST(0x9D420B00 AS Date), 200000, 200000, 0)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (2, 2, NULL, N'P202', CAST(0x9D420B00 AS Date), CAST(0x9D420B00 AS Date), 550000, 150000, 400000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (3, 1, NULL, N'P202', CAST(0x9D420B00 AS Date), CAST(0x9D420B00 AS Date), 450000, 150000, 300000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (4, 3, NULL, N'P201', CAST(0x9F420B00 AS Date), CAST(0xA0420B00 AS Date), 200000, 200000, 0)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (5, 4, NULL, N'P202', CAST(0x9F420B00 AS Date), CAST(0xA0420B00 AS Date), 450000, 150000, 300000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (6, 5, NULL, N'P203', CAST(0x9F420B00 AS Date), CAST(0x9F420B00 AS Date), 250000, 150000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (7, 6, NULL, N'P204', CAST(0x9F420B00 AS Date), CAST(0x9F420B00 AS Date), 180000, 100000, 80000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (8, 11, NULL, N'P201', CAST(0x9E420B00 AS Date), CAST(0xA0420B00 AS Date), 480000, 400000, 80000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (9, 1, NULL, N'P301', CAST(0x95420B00 AS Date), CAST(0x96420B00 AS Date), 280000, 200000, 80000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (10, 2, NULL, N'P302', CAST(0x95420B00 AS Date), CAST(0x96420B00 AS Date), 400000, 300000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (11, 3, NULL, N'P303', CAST(0x95420B00 AS Date), CAST(0x96420B00 AS Date), 250000, 150000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (12, 4, NULL, N'P304', CAST(0x95420B00 AS Date), CAST(0x97420B00 AS Date), 120000, 100000, 20000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (13, 5, NULL, N'P401', CAST(0x95420B00 AS Date), CAST(0x97420B00 AS Date), 350000, 200000, 150000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (14, 6, NULL, N'P402', CAST(0x96420B00 AS Date), CAST(0x97420B00 AS Date), 300000, 200000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (15, 7, NULL, N'P403', CAST(0x96420B00 AS Date), CAST(0x97420B00 AS Date), 330000, 300000, 30000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (16, 8, NULL, N'P404', CAST(0x96420B00 AS Date), CAST(0x97420B00 AS Date), 280000, 200000, 80000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (17, 9, NULL, N'P501', CAST(0x97420B00 AS Date), CAST(0x98420B00 AS Date), 210000, 150000, 60000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (18, 10, NULL, N'P502', CAST(0x97420B00 AS Date), CAST(0x98420B00 AS Date), 450000, 300000, 150000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (19, 11, NULL, N'P503', CAST(0x97420B00 AS Date), CAST(0x98420B00 AS Date), 300000, 200000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (20, 12, NULL, N'P504', CAST(0x97420B00 AS Date), CAST(0x99420B00 AS Date), 400000, 300000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (21, 13, NULL, N'P201', CAST(0x97420B00 AS Date), CAST(0x99420B00 AS Date), 500000, 400000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (22, 14, NULL, N'P202', CAST(0x97420B00 AS Date), CAST(0x99420B00 AS Date), 280000, 200000, 80000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (23, 15, NULL, N'P203', CAST(0x97420B00 AS Date), CAST(0x9A420B00 AS Date), 230000, 150000, 80000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (24, 16, NULL, N'P204', CAST(0x98420B00 AS Date), CAST(0x9A420B00 AS Date), 18000, 100000, 80000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (25, 17, NULL, N'P301', CAST(0x98420B00 AS Date), CAST(0x9A420B00 AS Date), 230000, 150000, 80000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (26, 18, NULL, N'P302', CAST(0x99420B00 AS Date), CAST(0x9B420B00 AS Date), 250000, 150000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (27, 19, NULL, N'P303', CAST(0x99420B00 AS Date), CAST(0x9B420B00 AS Date), 200000, 100000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (28, 20, NULL, N'P304', CAST(0x99420B00 AS Date), CAST(0x9B420B00 AS Date), 30000, 200000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (29, 21, NULL, N'P401', CAST(0x99420B00 AS Date), CAST(0x9B420B00 AS Date), 400000, 300000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (30, 22, NULL, N'P402', CAST(0x99420B00 AS Date), CAST(0x9B420B00 AS Date), 450000, 300000, 150000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (31, 23, NULL, N'P403', CAST(0x9A420B00 AS Date), CAST(0x9B420B00 AS Date), 470000, 350000, 120000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (32, 24, NULL, N'P404', CAST(0x9A420B00 AS Date), CAST(0x9B420B00 AS Date), 500000, 400000, 120000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (33, 25, NULL, N'P501', CAST(0x9A420B00 AS Date), CAST(0x9D420B00 AS Date), 600000, 400000, 130000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (34, 26, NULL, N'P502', CAST(0x9A420B00 AS Date), CAST(0x9D420B00 AS Date), 700000, 200000, 150000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (35, 27, NULL, N'P503', CAST(0x9B420B00 AS Date), CAST(0x9D420B00 AS Date), 300000, 300000, 120000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (36, 28, NULL, N'P504', CAST(0x9B420B00 AS Date), CAST(0x9D420B00 AS Date), 120000, 150000, 300000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (37, 29, NULL, N'P201', CAST(0x9B420B00 AS Date), CAST(0x9D420B00 AS Date), 150000, 300000, 150000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (38, 30, NULL, N'P202', CAST(0x9C420B00 AS Date), CAST(0x9E420B00 AS Date), 160000, 300000, 160000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (39, 31, NULL, N'P203', CAST(0x9C420B00 AS Date), CAST(0x9E420B00 AS Date), 130000, 150000, 200000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (40, 32, NULL, N'P204', CAST(0x9D420B00 AS Date), CAST(0x9E420B00 AS Date), 150000, 150000, 300000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (41, 33, NULL, N'P301', CAST(0x9D420B00 AS Date), CAST(0x9E420B00 AS Date), 500000, 15000, 150000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (42, 34, NULL, N'P302', CAST(0x9D420B00 AS Date), CAST(0x9F420B00 AS Date), 400000, 150000, 160000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (43, 35, NULL, N'P303', CAST(0x9D420B00 AS Date), CAST(0x9F420B00 AS Date), 600000, 150000, 130000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (44, 36, NULL, N'P304', CAST(0x9E420B00 AS Date), CAST(0x9F420B00 AS Date), 1000000, 300000, 120000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (45, 37, NULL, N'P401', CAST(0x9E420B00 AS Date), CAST(0x9F420B00 AS Date), 500000, 30000, 160000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (46, 38, NULL, N'P402', CAST(0x9E420B00 AS Date), CAST(0x9F420B00 AS Date), 600000, 300000, 130000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (47, 39, NULL, N'P403', CAST(0x9E420B00 AS Date), CAST(0x9F420B00 AS Date), 700000, 300000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (48, 40, NULL, N'P404', CAST(0x9E420B00 AS Date), CAST(0x9F420B00 AS Date), 800000, 300000, 100000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (49, 41, NULL, N'P501', CAST(0x9E420B00 AS Date), CAST(0x9F420B00 AS Date), 900000, 200000, 120000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (50, 42, NULL, N'P502', CAST(0x9E420B00 AS Date), CAST(0x9F420B00 AS Date), 50000, 200000, 130000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (51, 43, NULL, N'P503', CAST(0x9F420B00 AS Date), CAST(0xA0420B00 AS Date), 600000, 200000, 150000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (52, 44, NULL, N'P504', CAST(0x9F420B00 AS Date), CAST(0xA0420B00 AS Date), 400000, 200000, 160000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (53, 45, NULL, N'P201', CAST(0x9F420B00 AS Date), CAST(0xA0420B00 AS Date), 600000, 300000, 140000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (54, 46, NULL, N'P202', CAST(0x9F420B00 AS Date), CAST(0xA0420B00 AS Date), 700000, 150000, 130000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (55, 47, NULL, N'P203', CAST(0x9F420B00 AS Date), CAST(0xA0420B00 AS Date), 800000, 150000, 50000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (56, 48, NULL, N'P204', CAST(0x9F420B00 AS Date), CAST(0xA0420B00 AS Date), 900000, 100000, 50000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (57, 49, NULL, N'P301', CAST(0x94420B00 AS Date), CAST(0x95420B00 AS Date), 400000, 140000, 50000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (58, 50, NULL, N'P401', CAST(0x94420B00 AS Date), CAST(0x95420B00 AS Date), 500000, 120000, 50000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (59, 1, NULL, N'P402', CAST(0x94420B00 AS Date), CAST(0x95420B00 AS Date), 600000, 130000, 8000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (60, 2, NULL, N'P403', CAST(0x94420B00 AS Date), CAST(0x95420B00 AS Date), 500000, 160000, 80000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (61, 3, NULL, N'P404', CAST(0x94420B00 AS Date), CAST(0x95420B00 AS Date), 400000, 200000, 60000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (62, 4, NULL, N'P501', CAST(0x94420B00 AS Date), CAST(0x95420B00 AS Date), 600000, 210000, 60000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (63, 5, NULL, N'P502', CAST(0x93420B00 AS Date), CAST(0x95420B00 AS Date), 500000, 230000, 60000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (64, 6, NULL, N'P503', CAST(0x93420B00 AS Date), CAST(0x95420B00 AS Date), 400000, 230000, 50000)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (65, 1, NULL, N'P502', CAST(0xA6420B00 AS Date), CAST(0xA6420B00 AS Date), 150000, 150000, 0)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (66, 1, NULL, N'P502', CAST(0xA6420B00 AS Date), CAST(0xA6420B00 AS Date), 150000, 150000, 0)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (67, 6, NULL, N'P502', CAST(0xA6420B00 AS Date), CAST(0xA6420B00 AS Date), 150000, 150000, 0)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (68, 1, NULL, N'P204', CAST(0xA6420B00 AS Date), CAST(0xA6420B00 AS Date), 100000, 100000, 0)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (69, 5, NULL, N'P502', CAST(0xA6420B00 AS Date), CAST(0xA6420B00 AS Date), 150000, 150000, 0)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (70, 7, NULL, N'P401', CAST(0xA6420B00 AS Date), CAST(0xA6420B00 AS Date), 200000, 200000, 0)
INSERT [dbo].[hoadonphong] ([idhdp], [idkh], [phuongthuctt], [idphong], [ngaycheckin], [ngaycheckout], [tongtien], [tienphong], [tiendichvu]) VALUES (71, 8, NULL, N'P502', CAST(0xA6420B00 AS Date), CAST(0xA6420B00 AS Date), 150000, 150000, 0)

select * from hoadonphong
SET IDENTITY_INSERT [dbo].[hoadonphong] OFF
SET IDENTITY_INSERT   [dbo].[khachhang]  on
insert into  khachhang(idkh) values(444)
select * from khachhang
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (1, N'111', N'Nguy?n Quang H?i', N'Hà N?i')

INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (2, N'222', N'Nguy?n Ti?n Linh', N'H?i Dương')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (3, N'001', N'V? Văn Thanh', N'H?i Dương')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (4, N'002', N'Bùi T?n Trư?ng', N'H?i Dương')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (5, N'003', N'Nguy?n Qu?c Anh', N'Hà N?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (6, N'004', N'Ph?m Văn Di?n', N'H?i Dương')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (7, N'005', N'Đ? Duy M?nh', N'Thái B?nh')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (8, N'006', N'Qu? Ng?c H?i', N'Ngh? An')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (9, N'007', N'Đ? Hùng D?ng', N'Hà N?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (10, N'008', N'Lương Xuân Trư?ng', N'Gia Lai')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (11, N'009', N'Nguy?n Tr?ng Hoàng', N'Thanh Hóa')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (12, N'010', N'Ph?m Đ?c Huy', N'Hà N?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (13, N'011', N'Nguy?n Huy Hùng', N'Qu?ng Nam')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (14, N'012', N'Lê Thu Hà', N'Hai Bà Trưng')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (15, N'013', N'Lê th? dinh', N'Hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (16, N'014', N'Lê th? lan phương', N'Thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (17, N'015', N'Đào thu? dung', N'Hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (18, N'016', N'Nguy?n thu hương', N'Hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (19, N'017', N'Nguy?n lan hương', N'Thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (20, N'018', N'Nguy?n văn đ?nh', N'Hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (21, N'019', N'Nguy?n th? h?i', N'hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (22, N'020', N'Di?p minh h?nh', N'thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (23, N'021', N'Đ?i thi h?ng', N'Qu?ng ninh')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (24, N'022', N'Bùi th? lan', N'H?i phong')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (25, N'023', N'Nguy?n th? liên', N'thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (26, N'024', N'Dương kim liên', N'thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (27, N'025', N'V? th? liên', N'Hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (28, N'026', N'Lê ng?c long', N'Hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (29, N'027', N'Nguy?n hoàng linh', N'thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (30, N'028', N'Pham đ?nh năng', N'thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (31, N'029', N'Ph?m h?ng nhung', N'thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (32, N'030', N'Tr?n th? h?ng nga', N'thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (33, N'031', N'Nguy?n th? ninh', N'hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (34, N'032', N'Lê thu hương', N'hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (35, N'033', N'Ph?m th? phương', N'thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (36, N'034', N'Bùi ng?c thu', N'Hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (37, N'035', N'Đào thanh tâm', N'hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (38, N'036', N'Tr?n đ?nh thân', N'hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (39, N'037', N'Hoàng anh tu?n', N'thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (40, N'038', N'Phan th? thu?', N'hà n?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (41, N'039', N'Ngô th? thanh thu?', N'thanh hoá')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (42, N'040', N'Lê thanh tùng', N'nam đ?nh')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (43, N'041', N'Nguy?n Văn Hùng', N'Thái B?nh')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (44, N'042', N'Nguy?n Thanh Tùng', N'Hà Giang')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (45, N'043', N'James', N'L?ng Cú')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (46, N'044', N'Dan', N'Hà N?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (47, N'045', N'park', N'Hà N?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (48, N'046', N'Tilo', N'Hà N?i')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (49, N'047', N'Moon', N'H?i Dương')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (50, N'048', N'Martin', N'H?i Dương')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (51, N'049', N'Born', N'H?i Dương')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (52, N'050', N'Ph?m Văn Tu?n', N'H?i Dương')
INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (53, N'051', N'V? Khánh', N'Hu?')
SET IDENTITY_INSERT [dbo].[khachhang] On
insert [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) values(256,'20133',N'V? Như ?',N'Phú Yên')
select * from phong
where trangthai = N'Có ngư?i'

INSERT [dbo].[khachhang] ([idkh], [cmnd], [hoten], [diachi]) VALUES (256, N'111', N'Nguy?n Quang H?i', N'Hà N?i')
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P201', N'Vip', 2, N'Tr?ng', 200000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P202', N'Thư?ng', 2, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P203', N'Vip', 1, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P204', N'Thư?ng', 1, N'Tr?ng', 100000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P301', N'Vip', 1, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P302', N'Vip', 2, N'Tr?ng', 200000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P303', N'Thư?ng', 2, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P304', N'Thư?ng', 1, N'Tr?ng', 100000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P401', N'Vip', 2, N'Tr?ng', 200000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P402', N'Vip', 1, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P403', N'Thư?ng', 2, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P404', N'Thư?ng', 1, N'Tr?ng', 100000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P501', N'Vip', 2, N'Tr?ng', 200000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P502', N'Vip', 1, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P503', N'Thư?ng', 2, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P504', N'Thư?ng', 1, N'Tr?ng', 100000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P101', N'Thư?ng', 1, N'Tr?ng', 100000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P102', N'Vip', 1, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P103', N'Vip', 2, N'Tr?ng', 200000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P104', N'Thư?ng', 2, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P105', N'Thư?ng', 1, N'Tr?ng', 100000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P106', N'Vip', 2, N'Tr?ng', 200000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P205', N'Vip', 1, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P206', N'Thư?ng', 2, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P305', N'Thư?ng', 1, N'Tr?ng', 100000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P306', N'Thư?ng', 2, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P406', N'Thư?ng', 2, N'Tr?ng', 150000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P405', N'Vip', 2, N'Tr?ng', 200000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P506', N'Vip', 2, N'Tr?ng', 250000)
INSERT [dbo].[phong] ([idphong], [loaiphong], [sogiuong], [trangthai], [giaphong]) VALUES (N'P505', N'Thư?ng', 2, N'Tr?ng', 150000)


select * from phong
UPDATE dbo.phong SET trangthai=N'Tr?ng' WHERE idphong = 'P504'
INSERT [dbo].[thongtin] ([tenks], [tenchuks], [diachi], [sdt], [masothue], [ngaythanhlap], [logofile]) VALUES (N'', N'', N'', N'', N'', CAST(0x0000AD2000000000 AS DateTime), N'')

 SELECT hoadonphong.idphong, khachhang.hoten, hoadonphong.ngaycheckin, khachhang.cmnd  
            from hoadonphong inner join khachhang
             on hoadonphong.idkh = khachhang.idkh
             WHERE hoadonphong.idkh = 256 AND ngaycheckout IS NULL
           
             ORDER BY idphong ASC
SET IDENTITY_INSERT   [dbo].[khachhang]  off
delete  IDENTITY_INSERT khachhang  
insert into  khachhang(idkh) values(1119221)
select phong.idphong from phong where phong.trangthai =N' đặt trước'
select * from phong where phong.idphong = 'P305'
update phong 
set phong.trangthai = N'Có người' 
where phong.idphong in (select phong.idphong from hoadonphong,phong where phong.idphong = hoadonphong.idphong  and ngaycheckout is null and phong.trangthai = N' đặt trước' and (DAY(GETDATE()) - DAY(ngaycheckin) > 0))
update phong set phong.trangthai = N'Trống' where phong.idphong =N'P503'
select * from hoadonphong

Create table PhongDatTruoc 
(
[idphong] [varchar](20) NOT NULL,
[trangthai] [nvarchar](100) NULL,
)
Create table PhongDatTruoc1
(
[idkh] int ,
[idphong] [varchar](20) NOT NULL,
[trangthai] [nvarchar](100) NULL,
ngaycheckin date 
,[SoTT] [int] IDENTITY(1,1)

)
select * from hoadondv
select * from dichvu
--delete from hoadonphong where idhdp = 299
update phong set trangthai = N'Trống' where idphong = 'P206'
select *  from phong where idphong = 'P205' or idphong = 'P206' or idphong = 'P201'
select * from PhongDatTruoc1
select *  from hoadonphong 
select * from hoadondv 
update hoadonphong set tiendichvu =  null where idhdp = 298
select idhdp from hoadonphong,PhongDatTruoc1  where PhongDatTruoc1.idphong = hoadonphong.idphong and hoadonphong.idphong in (select idphong from PhongDatTruoc1  where day(PhongDatTruoc1.ngaycheckin) - day(getdate()) = 0 ) and day(PhongDatTruoc1.ngaycheckin) - day(getdate()) = 0 and ngaycheckout is null
select soTT from hoadonphong,PhongDatTruoc1 where hoadonphong.idphong = PhongDatTruoc1.idphong and ngaycheckout is null and PhongDatTruoc1.idphong = (select idphong from hoadonphong where idhdp = 257 )
INSERT INTO dbo.hoadonphong( idkh ,idphong,ngaycheckin)VALUES( (SELECT idkh FROM dbo.PhongDatTruoc1 WHERE SoTT = (select soTT from hoadonphong,PhongDatTruoc1 where hoadonphong.idphong = PhongDatTruoc1.idphong and ngaycheckout is null and PhongDatTruoc1.idphong = (select idphong from hoadonphong where idhdp = 264 ))), (SELECT idphong FROM dbo.PhongDatTruoc1 WHERE SoTT = (select soTT from hoadonphong,PhongDatTruoc1 where hoadonphong.idphong = PhongDatTruoc1.idphong and ngaycheckout is null and PhongDatTruoc1.idphong = (select idphong from hoadonphong where idhdp = 257 ))), (SELECT ngaycheckin FROM dbo.PhongDatTruoc1 WHERE SoTT = (select soTT from hoadonphong,PhongDatTruoc1 where hoadonphong.idphong = PhongDatTruoc1.idphong and ngaycheckout is null and PhongDatTruoc1.idphong = (select idphong from hoadonphong where idhdp = 257))))   
UPDATE dbo.hoadonphong SET tiendichvu = (select sum(dichvu.giadv*hoadondv.soluong) from hoadondv,dichvu where dichvu.tendv= hoadondv.tendv and idhdp = 296) where hoadonphong.idhdp = 296;
UPDATE dbo.hoadonphong SET tiendichvu = 0 where hoadonphong.idhdp = 296 and 296 not in (select idhdp from hoadondv)
ATE dbo.hoadonphong SET tiendichvu = (select sum(dichvu.giadv* 0) from hoadondv,dichvu where dichvu.tendv= hoadondv.tendv and idhdp != 89 ) where hoadonphong.idhdp = 89;
delete from hoadonphong
delete from PhongDatTruoc1
go
UPDATE dbo.hoadonphong SET tiendichvu = (select sum(dichvu.giadv*hoadondv.soluong) from hoadondv,dichvu where dichvu.tendv= hoadondv.tendv and hoadondv.idhdp = 298 ) where hoadonphong.idhdp = 298

UPDATE dbo.hoadonphong set tongtien = (select tienphong + tiendichvu from hoadonphong where hoadonphong.idhdp = 298 ) where hoadonphong.idhdp = 298
select SoTT from hoadonphong,PhongDatTruoc1 where hoadonphong.idphong = PhongDatTruoc1.idphong  and day(PhongDatTruoc1.ngaycheckin) - day(getdate()) = 0 and PhongDatTruoc1.idphong = (select idphong from hoadonphong where idhdp = 297) and hoadonphong.idhdp = 297
UPDATE dbo.hoadonphong SET tiendichvu = (select sum(giadv*soluong) as K from hoadondv,dichvu where hoadondv.idhdp = 89 and dichvu.tendv= hoadondv.tendv )
WHERE ngaycheckout is null and idhdp = 89
UPDATE dbo.hoadonphong SET tiendichvu = (select sum(giadv*soluong) as K from hoadondv,dichvu where hoadondv.idhdp != 89 and dichvu.tendv= hoadondv.tendv )
WHERE ngaycheckout is null and idhdp = 89
select * from hoadonphong
select * from dichvu
select SoTT from hoadonphong,PhongDatTruoc1 where hoadonphong.idphong = PhongDatTruoc1.idphong  and day(PhongDatTruoc1.ngaycheckin) - day(getdate()) = 0 and PhongDatTruoc1.idphong = (select idphong from hoadonphong where idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + ") and hoadonphong.idhdp = " + Convert.ToInt32(dt2.Rows[i][0]) + 