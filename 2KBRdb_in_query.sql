USE [master]
GO
/****** Object:  Database [2KBR]    Script Date: 28.01.2022 18:19:56 ******/
CREATE DATABASE [2KBR]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'2KBR', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\2KBR.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'2KBR_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\2KBR_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [2KBR] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [2KBR].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [2KBR] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [2KBR] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [2KBR] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [2KBR] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [2KBR] SET ARITHABORT OFF 
GO
ALTER DATABASE [2KBR] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [2KBR] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [2KBR] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [2KBR] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [2KBR] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [2KBR] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [2KBR] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [2KBR] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [2KBR] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [2KBR] SET  ENABLE_BROKER 
GO
ALTER DATABASE [2KBR] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [2KBR] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [2KBR] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [2KBR] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [2KBR] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [2KBR] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [2KBR] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [2KBR] SET RECOVERY FULL 
GO
ALTER DATABASE [2KBR] SET  MULTI_USER 
GO
ALTER DATABASE [2KBR] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [2KBR] SET DB_CHAINING OFF 
GO
ALTER DATABASE [2KBR] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [2KBR] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [2KBR] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [2KBR] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'2KBR', N'ON'
GO
ALTER DATABASE [2KBR] SET QUERY_STORE = OFF
GO
USE [2KBR]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 28.01.2022 18:19:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[FoilID] [int] NULL,
	[Color] [varchar](50) NULL,
	[FoilType] [varchar](50) NULL,
	[AdditionalPrice] [decimal](5, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 28.01.2022 18:19:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] NOT NULL,
	[CustomerFirstName] [varchar](100) NULL,
	[CustomerLastName] [varchar](100) NULL,
	[CustomerTel] [varchar](9) NULL,
	[CustomerCityAdress] [varchar](50) NULL,
	[CustomerStreetAdress] [varchar](50) NULL,
	[CustomerBuildingAdress] [varchar](50) NULL,
	[CustomerApartmentAdress] [varchar](50) NULL,
	[CustomerPostalCode] [varchar](6) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thicknesses]    Script Date: 28.01.2022 18:19:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thicknesses](
	[ThicknessID] [int] NOT NULL,
	[Thickness] [int] NULL,
	[Information] [varchar](50) NULL,
	[Price] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ThicknessID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WindowsillsModels]    Script Date: 28.01.2022 18:19:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WindowsillsModels](
	[WindowsillID] [int] NOT NULL,
	[ModelName] [varchar](20) NOT NULL,
	[Desciption] [varchar](50) NULL,
	[Price] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[WindowsillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [2KBR] SET  READ_WRITE 
GO

INSERT INTO Colors (FoilID, Color, FoilType, AdditionalPrice)
VALUES (2, 'Kremowy', 'Jednobarwna', 0.00)

INSERT INTO Colors (FoilID, Color, FoilType, AdditionalPrice)
VALUES (5, 'Brzoza Rose', 'Matowa', 0.00)

INSERT INTO Colors (FoilID, Color, FoilType, AdditionalPrice)
VALUES (10, 'Bia造', 'Jednobarwna', 0.00)

INSERT INTO Colors (FoilID, Color, FoilType, AdditionalPrice)
VALUES (28, 'Olcha', 'Jednobarwna', 0.00)

INSERT INTO Colors (FoilID, Color, FoilType, AdditionalPrice)
VALUES (33, 'D鉉 czarny', 'Drewnopodobna', 0.00)

INSERT INTO Colors (FoilID, Color, FoilType, AdditionalPrice)
VALUES (46, 'Fino Bronze', 'Drewnopodobna', 0.00)

INSERT INTO Colors (FoilID, Color, FoilType, AdditionalPrice)
VALUES (50, 'Orzech w這ski', 'Matowa', 0.00)

INSERT INTO Colors (FoilID, Color, FoilType, AdditionalPrice)
VALUES 51, 'Orzech w這ski', 'Matowa', 0.00

INSERT INTO Colors (FoilID, Color, FoilType, AdditionalPrice)
VALUES 55, 'Lancelot', 'Matowa', 0.00

INSERT INTO Colors (FoilID, Color, FoilType, AdditionalPrice)
VALUES 56, 'D鉉 mat', 'Matowa', 0.00

INSERT INTO Thicknesses (ThicknessID, Thickness, Information, Price)
VALUES (1, 18, 'MDF Zwyk造', 225.00)

INSERT INTO Thicknesses (ThicknessID, Thickness, Information, Price)
VALUES (2, 19, 'Finsa Wilgocioodporna', 275.00)

INSERT INTO Thicknesses (ThicknessID, Thickness, Information, Price)
VALUES (3, 22, 'MDF Zwyk造', 235.00)

INSERT INTO Thicknesses (ThicknessID, Thickness, Information, Price)
VALUES (4, 25, 'Finsa Wilgocioodporna', 310.00)

INSERT INTO Thicknesses (ThicknessID, Thickness, Information, Price)
VALUES (5, 28, 'MDF Zwyk造', 260.00)

INSERT INTO Thicknesses (ThicknessID, Thickness, Information, Price)
VALUES (6, 30, 'Finsa Wilgocioodporna', 345.00)

INSERT INTO WindowsillsModels (WindowsillID, ModelName, Desciption, Price)
VALUES (1, 'B', 'Wyko鎍zenie B', 0.00)

INSERT INTO WindowsillsModels (WindowsillID, ModelName, Desciption, Price)
VALUES (2, 'C', 'Wyko鎍zenie C', 0.00)

INSERT INTO WindowsillsModels (WindowsillID, ModelName, Desciption, Price)
VALUES (3, 'E', 'Wyko鎍zenie E', 0.00)

INSERT INTO WindowsillsModels (WindowsillID, ModelName, Desciption, Price)
VALUES (4, 'F', 'Wyko鎍zenie F', 0.00)

INSERT INTO WindowsillsModels (WindowsillID, ModelName, Desciption, Price)
VALUES (5, 'G', 'Wyko鎍zenie G', 0.00)

INSERT INTO WindowsillsModels (WindowsillID, ModelName, Desciption, Price)
VALUES (6, 'I', 'Wyko鎍zenie I', 0.00)