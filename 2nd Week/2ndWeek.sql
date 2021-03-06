USE [master]
GO
/****** Object:  Database [Ornek]    Script Date: 19.01.2022 17:11:09 ******/
CREATE DATABASE [Ornek]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ornek', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ornek.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ornek_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Ornek_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ornek] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ornek].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ornek] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ornek] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ornek] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ornek] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ornek] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ornek] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ornek] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ornek] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ornek] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ornek] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ornek] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ornek] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ornek] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ornek] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ornek] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ornek] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ornek] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ornek] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ornek] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ornek] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ornek] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ornek] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ornek] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Ornek] SET  MULTI_USER 
GO
ALTER DATABASE [Ornek] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ornek] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ornek] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ornek] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ornek] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ornek] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Ornek] SET QUERY_STORE = OFF
GO
USE [Ornek]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 19.01.2022 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 19.01.2022 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Adress] [nvarchar](80) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Region] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 19.01.2022 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Adress] [nvarchar](80) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Region] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Photo] [image] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 19.01.2022 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[Price] [money] NOT NULL,
	[Quantity] [smallint] NOT NULL,
	[ProductID] [int] NOT NULL,
	[OrderID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 19.01.2022 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NOT NULL,
	[ShippedDate] [datetime] NOT NULL,
	[ShipPrice] [money] NOT NULL,
	[ShipName] [nvarchar](50) NOT NULL,
	[ShipAdress] [nvarchar](80) NOT NULL,
	[ShipCity] [nvarchar](20) NOT NULL,
	[ShipRegion] [nvarchar](20) NOT NULL,
	[ShipCountry] [nvarchar](20) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[ShipperID] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 19.01.2022 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
	[Stock] [smallint] NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[SupplierID] [int] NOT NULL,
	[StatusID] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Responsibilities]    Script Date: 19.01.2022 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Responsibilities](
	[ResponsibilityID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[EmployeeID] [int] NOT NULL,
 CONSTRAINT [PK_Responsibilities] PRIMARY KEY CLUSTERED 
(
	[ResponsibilityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shippers]    Script Date: 19.01.2022 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shippers](
	[ShipperID] [int] NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Shippers] PRIMARY KEY CLUSTERED 
(
	[ShipperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statuses]    Script Date: 19.01.2022 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statuses](
	[StatusID] [int] NOT NULL,
	[StatusType] [bit] NOT NULL,
 CONSTRAINT [PK_Statuses] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 19.01.2022 17:11:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
	[ContactName] [nvarchar](50) NOT NULL,
	[ContactTitle] [nvarchar](50) NOT NULL,
	[Adress] [nvarchar](80) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Region] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Description] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Shippers] FOREIGN KEY([ShipperID])
REFERENCES [dbo].[Shippers] ([ShipperID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Shippers]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Statuses] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Statuses] ([StatusID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Statuses]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
ALTER TABLE [dbo].[Responsibilities]  WITH CHECK ADD  CONSTRAINT [FK_Responsibilities_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Responsibilities] CHECK CONSTRAINT [FK_Responsibilities_Employees]
GO
USE [master]
GO
ALTER DATABASE [Ornek] SET  READ_WRITE 
GO
