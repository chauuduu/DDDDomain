USE [master]
GO
/****** Object:  Database [ClothesShop]    Script Date: 24/02/2023 2:51:04 CH ******/
CREATE DATABASE [ClothesShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ClothesShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ClothesShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ClothesShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ClothesShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ClothesShop] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClothesShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClothesShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ClothesShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ClothesShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ClothesShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ClothesShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [ClothesShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ClothesShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ClothesShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ClothesShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ClothesShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ClothesShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ClothesShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ClothesShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ClothesShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ClothesShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ClothesShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ClothesShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ClothesShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ClothesShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ClothesShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ClothesShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ClothesShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ClothesShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ClothesShop] SET  MULTI_USER 
GO
ALTER DATABASE [ClothesShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ClothesShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ClothesShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ClothesShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ClothesShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ClothesShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ClothesShop] SET QUERY_STORE = ON
GO
ALTER DATABASE [ClothesShop] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ClothesShop]
GO
/****** Object:  Table [dbo].[Clothes]    Script Date: 24/02/2023 2:51:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clothes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[Size] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[RentalTime] [int] NULL,
	[RentalPrice] [int] NULL,
	[TypeClothesId] [int] NULL,
	[OriginId] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Clothes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 24/02/2023 2:51:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailInvoice]    Script Date: 24/02/2023 2:51:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailInvoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDInvoice] [int] NULL,
	[IDClothes] [int] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_DetailInvoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailInvoiceLaundry]    Script Date: 24/02/2023 2:51:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailInvoiceLaundry](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDLaundryInvoice] [int] NULL,
	[IDClothes] [int] NULL,
	[Price] [int] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_DetailInvoiceLaundry] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 24/02/2023 2:51:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[IDCustomer] [int] NULL,
	[IDStaff] [int] NULL,
	[Discount] [int] NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Laundry]    Script Date: 24/02/2023 2:51:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laundry](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Rate] [int] NULL,
 CONSTRAINT [PK_Laundry] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LaundryInvoice]    Script Date: 24/02/2023 2:51:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LaundryInvoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[IDLaundry] [int] NULL,
	[IDStaff] [int] NULL,
	[Total] [int] NULL,
 CONSTRAINT [PK_LaundryInvoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Origin]    Script Date: 24/02/2023 2:51:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Origin](
	[OriginId] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Origin] PRIMARY KEY CLUSTERED 
(
	[OriginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleStaff]    Script Date: 24/02/2023 2:51:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleStaff](
	[IDRole] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_RoleStaff] PRIMARY KEY CLUSTERED 
(
	[IDRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 24/02/2023 2:51:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CCCD] [nvarchar](50) NULL,
	[FullName] [nvarchar](50) NULL,
	[Birthday] [date] NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[IDRole] [int] NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeClothes]    Script Date: 24/02/2023 2:51:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeClothes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Limit] [int] NULL,
 CONSTRAINT [PK_TypeClothes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clothes] ON 

INSERT [dbo].[Clothes] ([Id], [Name], [Description], [Size], [Price], [RentalTime], [RentalPrice], [TypeClothesId], [OriginId], [Status]) VALUES (1, N'Đầm hoa', N'đẹp', 1, CAST(500000 AS Decimal(18, 0)), 0, 100000, 2, 2, 0)
INSERT [dbo].[Clothes] ([Id], [Name], [Description], [Size], [Price], [RentalTime], [RentalPrice], [TypeClothesId], [OriginId], [Status]) VALUES (2, N'Quần tây', N'Nam tính lắm', 2, CAST(325000 AS Decimal(18, 0)), 0, 32000, 1, 1, 0)
SET IDENTITY_INSERT [dbo].[Clothes] OFF
GO
INSERT [dbo].[Origin] ([OriginId], [Name], [Address]) VALUES (1, N'Lancome', N'US')
INSERT [dbo].[Origin] ([OriginId], [Name], [Address]) VALUES (2, N'Uniqlo', N'Japan')
GO
SET IDENTITY_INSERT [dbo].[TypeClothes] ON 

INSERT [dbo].[TypeClothes] ([Id], [Name], [Limit]) VALUES (1, N'Quần', 15)
INSERT [dbo].[TypeClothes] ([Id], [Name], [Limit]) VALUES (2, N'Dress', 10)
INSERT [dbo].[TypeClothes] ([Id], [Name], [Limit]) VALUES (3, N'Shirt', 15)
INSERT [dbo].[TypeClothes] ([Id], [Name], [Limit]) VALUES (4, N'Skirt', 15)
INSERT [dbo].[TypeClothes] ([Id], [Name], [Limit]) VALUES (5, N'Shoes', 16)
SET IDENTITY_INSERT [dbo].[TypeClothes] OFF
GO
ALTER TABLE [dbo].[Clothes]  WITH CHECK ADD  CONSTRAINT [FK_Clothes_Origin] FOREIGN KEY([OriginId])
REFERENCES [dbo].[Origin] ([OriginId])
GO
ALTER TABLE [dbo].[Clothes] CHECK CONSTRAINT [FK_Clothes_Origin]
GO
ALTER TABLE [dbo].[Clothes]  WITH CHECK ADD  CONSTRAINT [FK_Clothes_TypeClothes1] FOREIGN KEY([TypeClothesId])
REFERENCES [dbo].[TypeClothes] ([Id])
GO
ALTER TABLE [dbo].[Clothes] CHECK CONSTRAINT [FK_Clothes_TypeClothes1]
GO
ALTER TABLE [dbo].[DetailInvoice]  WITH CHECK ADD  CONSTRAINT [FK_DetailInvoice_Clothes] FOREIGN KEY([IDClothes])
REFERENCES [dbo].[Clothes] ([Id])
GO
ALTER TABLE [dbo].[DetailInvoice] CHECK CONSTRAINT [FK_DetailInvoice_Clothes]
GO
ALTER TABLE [dbo].[DetailInvoice]  WITH CHECK ADD  CONSTRAINT [FK_DetailInvoice_Invoice] FOREIGN KEY([IDInvoice])
REFERENCES [dbo].[Invoice] ([ID])
GO
ALTER TABLE [dbo].[DetailInvoice] CHECK CONSTRAINT [FK_DetailInvoice_Invoice]
GO
ALTER TABLE [dbo].[DetailInvoiceLaundry]  WITH CHECK ADD  CONSTRAINT [FK_DetailInvoiceLaundry_Clothes] FOREIGN KEY([IDClothes])
REFERENCES [dbo].[Clothes] ([Id])
GO
ALTER TABLE [dbo].[DetailInvoiceLaundry] CHECK CONSTRAINT [FK_DetailInvoiceLaundry_Clothes]
GO
ALTER TABLE [dbo].[DetailInvoiceLaundry]  WITH CHECK ADD  CONSTRAINT [FK_DetailInvoiceLaundry_LaundryInvoice] FOREIGN KEY([IDLaundryInvoice])
REFERENCES [dbo].[LaundryInvoice] ([ID])
GO
ALTER TABLE [dbo].[DetailInvoiceLaundry] CHECK CONSTRAINT [FK_DetailInvoiceLaundry_LaundryInvoice]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Customer] FOREIGN KEY([IDCustomer])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Customer]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Staff] FOREIGN KEY([IDStaff])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Staff]
GO
ALTER TABLE [dbo].[LaundryInvoice]  WITH CHECK ADD  CONSTRAINT [FK_LaundryInvoice_Laundry] FOREIGN KEY([IDLaundry])
REFERENCES [dbo].[Laundry] ([ID])
GO
ALTER TABLE [dbo].[LaundryInvoice] CHECK CONSTRAINT [FK_LaundryInvoice_Laundry]
GO
ALTER TABLE [dbo].[LaundryInvoice]  WITH CHECK ADD  CONSTRAINT [FK_LaundryInvoice_Staff] FOREIGN KEY([IDStaff])
REFERENCES [dbo].[Staff] ([ID])
GO
ALTER TABLE [dbo].[LaundryInvoice] CHECK CONSTRAINT [FK_LaundryInvoice_Staff]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_RoleStaff] FOREIGN KEY([IDRole])
REFERENCES [dbo].[RoleStaff] ([IDRole])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_RoleStaff]
GO
USE [master]
GO
ALTER DATABASE [ClothesShop] SET  READ_WRITE 
GO
