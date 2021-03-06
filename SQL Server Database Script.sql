USE [master]
GO
/****** Object:  Database [WinForm_Project]    Script Date: 11/15/2020 9:59:57 PM ******/
CREATE DATABASE [WinForm_Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WinForm_Project', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WinForm_Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WinForm_Project_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\WinForm_Project_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WinForm_Project] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WinForm_Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WinForm_Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WinForm_Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WinForm_Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WinForm_Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WinForm_Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [WinForm_Project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WinForm_Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WinForm_Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WinForm_Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WinForm_Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WinForm_Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WinForm_Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WinForm_Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WinForm_Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WinForm_Project] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WinForm_Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WinForm_Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WinForm_Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WinForm_Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WinForm_Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WinForm_Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WinForm_Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WinForm_Project] SET RECOVERY FULL 
GO
ALTER DATABASE [WinForm_Project] SET  MULTI_USER 
GO
ALTER DATABASE [WinForm_Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WinForm_Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WinForm_Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WinForm_Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WinForm_Project] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WinForm_Project', N'ON'
GO
ALTER DATABASE [WinForm_Project] SET QUERY_STORE = OFF
GO
USE [WinForm_Project]
GO
/****** Object:  Table [dbo].[AccInfo]    Script Date: 11/15/2020 9:59:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccInfo](
	[AccID] [nvarchar](4) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Tuoi] [int] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_AccInfo] PRIMARY KEY CLUSTERED 
(
	[AccID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/15/2020 9:59:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccID] [nvarchar](4) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Acctype] [int] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GenderType]    Script Date: 11/15/2020 9:59:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GenderType](
	[GenderID] [int] NULL,
	[Des] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 11/15/2020 9:59:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[BillID] [nvarchar](4) NOT NULL,
	[AccID] [nvarchar](4) NULL,
	[NgayDat] [datetime] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentInfo]    Script Date: 11/15/2020 9:59:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentInfo](
	[BillID] [nvarchar](4) NOT NULL,
	[ProductID] [nvarchar](150) NULL,
	[Amount] [int] NULL,
	[Size] [nvarchar](5) NULL,
	[TotalPrice] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/15/2020 9:59:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [nvarchar](150) NOT NULL,
	[ProductName] [nvarchar](50) NULL,
	[Price] [money] NULL,
	[Path] [nvarchar](500) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SizeInfo]    Script Date: 11/15/2020 9:59:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SizeInfo](
	[Size] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[AccInfo] ([AccID], [TenKH], [DiaChi], [Tuoi], [GioiTinh], [SDT]) VALUES (N'A01', N'Lê Anh Đức', N'Viet Nam', 20, N'Male', N'0397067907')
GO
INSERT [dbo].[Account] ([AccID], [Username], [Password], [Acctype]) VALUES (N'A01', N'1', N'1', 1)
GO
INSERT [dbo].[GenderType] ([GenderID], [Des]) VALUES (1, N'Male')
INSERT [dbo].[GenderType] ([GenderID], [Des]) VALUES (2, N'Female')
INSERT [dbo].[GenderType] ([GenderID], [Des]) VALUES (3, N'Other')
GO
INSERT [dbo].[Payment] ([BillID], [AccID], [NgayDat]) VALUES (N'B1', N'A01', CAST(N'2020-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Payment] ([BillID], [AccID], [NgayDat]) VALUES (N'B10', N'A01', CAST(N'2020-11-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Payment] ([BillID], [AccID], [NgayDat]) VALUES (N'B11', N'A01', CAST(N'2020-11-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Payment] ([BillID], [AccID], [NgayDat]) VALUES (N'B2', N'A01', CAST(N'2020-11-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Payment] ([BillID], [AccID], [NgayDat]) VALUES (N'B3', N'A01', CAST(N'2020-11-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Payment] ([BillID], [AccID], [NgayDat]) VALUES (N'B4', N'A01', CAST(N'2020-11-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Payment] ([BillID], [AccID], [NgayDat]) VALUES (N'B5', N'A01', CAST(N'2020-11-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Payment] ([BillID], [AccID], [NgayDat]) VALUES (N'B6', N'A01', CAST(N'2020-11-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Payment] ([BillID], [AccID], [NgayDat]) VALUES (N'B7', N'A01', CAST(N'2020-11-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Payment] ([BillID], [AccID], [NgayDat]) VALUES (N'B8', N'A01', CAST(N'2020-11-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Payment] ([BillID], [AccID], [NgayDat]) VALUES (N'B9', N'A01', CAST(N'2020-11-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B4', N'P12', 1, N'M', 280000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B4', N'P11', 2, N'L', 560000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B5', N'P24', 1, N'M', 680000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B5', N'P9', 1, N'M', 280000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B6', N'P6', 1, N'M', 290000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B7', N'P11', 1, N'M', 280000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B7', N'P10', 1, N'M', 280000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B8', N'P12', 1, N'L', 280000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B9', N'P24', 1, N'L', 680000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B1', N'P10', 1, N'M', 280000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B1', N'P11', 2, N'M', 560000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B2', N'P14', 3, N'M', 750000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B2', N'P15', 1, N'M', 280000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B3', N'P14', 3, N'M', 750000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B3', N'P15', 2, N'M', 560000.0000)
INSERT [dbo].[PaymentInfo] ([BillID], [ProductID], [Amount], [Size], [TotalPrice]) VALUES (N'B10', N'P11', 9, N'L', 2520000.0000)
GO
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P1', N'>STROKE< Black', 350000.0000, N'https://artistclub.vn/upload/sanpham/33e2ec95-f044-40d0-8eb0-834d66d8488b8641_323x360.jpeg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P10', N'>>FATE<< // BLACK', 280000.0000, N'https://artistclub.vn/upload/sanpham/densau0714_323x360.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P11', N'NEGATIVE // BLACK', 280000.0000, N'https://artistclub.vn/upload/sanpham/densau9980_323x360.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P12', N'>>FATE<< // WHITE', 280000.0000, N'https://artistclub.vn/upload/sanpham/trangsau7712_323x360.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P13', N'SUCCESSION', 280000.0000, N'https://artistclub.vn/upload/sanpham/densau6447_323x360.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P14', N'DAISY BLACK', 250000.0000, N'https://artistclub.vn/thumb/330x368/1/upload/sanpham/tt-1332.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P15', N'DAISY BLACK', 250000.0000, N'https://artistclub.vn/upload/sanpham/td1695_323x360.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P16', N'RELECTIVE Black', 290000.0000, N'https://artistclub.vn/upload/sanpham/den22881_323x360.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P17', N'Pharaon', 220000.0000, N'https://artistclub.vn/upload/sanpham/920b3cefd94c3f12665d6719_323x360.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P18', N'PARASITE', 250000.0000, N'https://artistclub.vn/thumb/330x368/1/upload/sanpham/50217f959b367d682427-1320.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P19', N'>HOODIE< Evolution', 500000.0000, N'https://artistclub.vn/upload/sanpham/black9519_323x360.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P2', N'>STROKE< White', 350000.0000, N'https://artistclub.vn/upload/sanpham/d3f76b8f-d53c-481b-9042-26e95513e1e03741_323x360.jpeg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P20', N'>HOODIE< Evolution', 500000.0000, N'https://artistclub.vn/upload/sanpham/bbfe8dee694d8f13d65c4849_323x360.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P21', N'>JACKET< BIG LOGO', 520000.0000, N'https://artistclub.vn/upload/sanpham/1fa67144-7959-4868-8747-b09afcc2faac2104_323x360.jpeg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P22', N'JACKET SYMMETRY', 450000.0000, N'https://artistclub.vn/upload/sanpham/z2091061449630_3676207cc8db359d528fb4e986987c569393_323x360.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P23', N'JACKET SYMMETRY', 500000.0000, N'https://artistclub.vn/thumb/330x368/1/upload/sanpham/e4eb796e-0be6-4b94-8217-4c06a0011810-0906.jpeg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P24', N'>JACKET< PEACE', 680000.0000, N'https://artistclub.vn/upload/sanpham/z2038512977330_7b245e7241c932c038fb59943cbb4c5d3300_323x360.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P25', N'JACKET CHESS PIECE', 390000.0000, N'https://artistclub.vn/upload/sanpham/840240b9ebbb16e54faa1493_323x360.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P3', N'REFLECTIVE Purple', 320000.0000, N'https://artistclub.vn/upload/sanpham/e17d9f79-1848-4f02-9dee-450a480380f23757_323x360.jpeg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P4', N'>2ouble LOGO', 350000.0000, N'https://artistclub.vn/upload/sanpham/z2091048837006_7d031bfae1d4afaca592e090824fb31e9075_323x360.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P5', N'>KOREA< WON T-Shirt', 350000.0000, N'https://artistclub.vn/upload/sanpham/2415590e-cb7f-447a-a309-869dbb6db8919814_323x360.jpeg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P6', N'REFLECTIVE Pink', 290000.0000, N'https://artistclub.vn/upload/sanpham/z1979497054065_e292ec901fb3fc9ccbad40d6f40f5b0b8822_323x360.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P7', N'CHESS PIECE', 320000.0000, N'https://artistclub.vn/upload/sanpham/9e1bbb01-0f9f-4b9f-8016-1fe3d8f1bef91307_323x360.jpeg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P8', N'HEAT - MAP', 280000.0000, N'https://artistclub.vn/upload/sanpham/f2098de65862a23cfb731983_323x360.jpg')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Price], [Path]) VALUES (N'P9', N'NEGATIVE // WHITE', 280000.0000, N'https://artistclub.vn/upload/sanpham/trangsau0092_323x360.png')
GO
INSERT [dbo].[SizeInfo] ([Size]) VALUES (N'S')
INSERT [dbo].[SizeInfo] ([Size]) VALUES (N'M')
INSERT [dbo].[SizeInfo] ([Size]) VALUES (N'L')
INSERT [dbo].[SizeInfo] ([Size]) VALUES (N'XL')
GO
ALTER TABLE [dbo].[AccInfo]  WITH CHECK ADD  CONSTRAINT [FK_AccInfo_Account] FOREIGN KEY([AccID])
REFERENCES [dbo].[Account] ([AccID])
GO
ALTER TABLE [dbo].[AccInfo] CHECK CONSTRAINT [FK_AccInfo_Account]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Account] FOREIGN KEY([AccID])
REFERENCES [dbo].[Account] ([AccID])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Account]
GO
ALTER TABLE [dbo].[PaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaymentInfo_Payment] FOREIGN KEY([BillID])
REFERENCES [dbo].[Payment] ([BillID])
GO
ALTER TABLE [dbo].[PaymentInfo] CHECK CONSTRAINT [FK_PaymentInfo_Payment]
GO
ALTER TABLE [dbo].[PaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_PaymentInfo_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[PaymentInfo] CHECK CONSTRAINT [FK_PaymentInfo_Product]
GO
USE [master]
GO
ALTER DATABASE [WinForm_Project] SET  READ_WRITE 
GO
