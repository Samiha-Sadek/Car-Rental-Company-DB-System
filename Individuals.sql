USE [master]
GO
/****** Object:  Database [RentalCompanyDB]    Script Date: 09-Jan-22 2:22:48 PM ******/
CREATE DATABASE [RentalCompanyDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentalCompanyDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RentalCompanyDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentalCompanyDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RentalCompanyDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [RentalCompanyDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentalCompanyDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentalCompanyDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentalCompanyDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentalCompanyDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentalCompanyDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentalCompanyDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RentalCompanyDB] SET  MULTI_USER 
GO
ALTER DATABASE [RentalCompanyDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentalCompanyDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentalCompanyDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentalCompanyDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RentalCompanyDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RentalCompanyDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'RentalCompanyDB', N'ON'
GO
ALTER DATABASE [RentalCompanyDB] SET QUERY_STORE = OFF
GO
USE [RentalCompanyDB]
GO
/****** Object:  Table [dbo].[Offer_List]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Offer_List](
	[Offer_ID] [int] NOT NULL,
	[Department_Number] [int] NOT NULL,
	[No_of_Vehicle] [int] NOT NULL,
	[Vehicle_Type] [varchar](10) NOT NULL,
	[Percentage_Discount] [float] NOT NULL,
	[Description] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_Offer_List] PRIMARY KEY CLUSTERED 
(
	[Offer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Cars_Offer_List]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Cars_Offer_List]
AS
SELECT Offer_ID, Percentage_Discount, Description
FROM     dbo.Offer_List
WHERE  (Vehicle_Type = 'Car')
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[VehiclePlateNumber] [varchar](10) NOT NULL,
	[Brand] [varchar](100) NOT NULL,
	[Model] [varchar](100) NOT NULL,
	[Type] [varchar](10) NOT NULL,
	[Insurance_Price] [int] NOT NULL,
	[Vehicle_Availability] [varchar](50) NOT NULL,
	[Parked_in] [varchar](100) NULL,
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[VehiclePlateNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Cars]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Cars]
AS
SELECT Brand, Model, VehiclePlateNumber, Insurance_Price, Parked_in, Vehicle_Availability
FROM     dbo.Vehicles
WHERE  (Type = 'Car')
GO
/****** Object:  Table [dbo].[Tracks]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracks](
	[Plate_Number] [varchar](10) NOT NULL,
	[Rent_Date] [datetime] NOT NULL,
	[Booking_Date] [datetime] NOT NULL,
	[Return_Date] [datetime] NOT NULL,
	[Employee_ID] [int] NULL,
	[Price] [int] NOT NULL,
	[Organization_ID] [int] NULL,
	[Individual_ID] [int] NULL,
 CONSTRAINT [PK_Tracks] PRIMARY KEY CLUSTERED 
(
	[Plate_Number] ASC,
	[Rent_Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Car_Tracks]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Car_Tracks]
AS
SELECT Plate_Number, Rent_Date, Return_Date
FROM     dbo.Tracks
GO
/****** Object:  Table [dbo].[Booking_History]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking_History](
	[Booking_ID] [int] NOT NULL,
	[Employee_ID] [int] NOT NULL,
	[Rent_Date] [datetime] NOT NULL,
	[Return_Date] [datetime] NOT NULL,
	[Rent_Price] [int] NOT NULL,
	[Vehicle_State] [varchar](50) NOT NULL,
	[Customer_ID] [int] NOT NULL,
	[VehiclePlateNumber] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Booking_History] PRIMARY KEY CLUSTERED 
(
	[Booking_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Department_Number] [int] NOT NULL,
	[Department_Name] [varchar](100) NOT NULL,
	[Manager_ID] [int] NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Department_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[SSN] [int] NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[Salary] [int] NOT NULL,
	[Dno] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Financial_History]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Financial_History](
	[Record_Year] [int] NOT NULL,
	[Utilities] [int] NOT NULL,
	[Rentals] [int] NOT NULL,
 CONSTRAINT [PK_Financial_History] PRIMARY KEY CLUSTERED 
(
	[Record_Year] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Individual_Suggestions]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Individual_Suggestions](
	[Department_Number] [int] NOT NULL,
	[Individual_ID] [int] NOT NULL,
 CONSTRAINT [PK_Individual_Suggestions] PRIMARY KEY CLUSTERED 
(
	[Department_Number] ASC,
	[Individual_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Individual_Suggestions_List]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Individual_Suggestions_List](
	[Department_Number] [int] NOT NULL,
	[Individual_ID] [int] NOT NULL,
	[Comment] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_Individual_Suggestions_List] PRIMARY KEY CLUSTERED 
(
	[Department_Number] ASC,
	[Individual_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Individuals]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Individuals](
	[ID] [int] NOT NULL,
	[First_Name] [varchar](50) NOT NULL,
	[Last_Name] [varchar](50) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Is_Premium_Account] [varchar](1) NOT NULL,
	[Individual_Balance] [int] NOT NULL,
	[Contact_Number] [varchar](11) NOT NULL,
	[Email] [varchar](100) NULL,
 CONSTRAINT [PK_Individuals] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Individuals_Review]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Individuals_Review](
	[VehiclePlateNumber] [varchar](10) NOT NULL,
	[Individual_ID] [int] NOT NULL,
 CONSTRAINT [PK_Individuals_Review] PRIMARY KEY CLUSTERED 
(
	[VehiclePlateNumber] ASC,
	[Individual_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Indvidual_Review_List]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Indvidual_Review_List](
	[VehiclePlateNumber] [varchar](10) NOT NULL,
	[Indvidual_ID] [int] NOT NULL,
	[Rating] [int] NOT NULL,
	[Comment] [varchar](1000) NULL,
 CONSTRAINT [PK_Indvidual_Review_List] PRIMARY KEY CLUSTERED 
(
	[VehiclePlateNumber] ASC,
	[Indvidual_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organization]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organization](
	[Organization_ID] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Representative] [varchar](100) NOT NULL,
	[Organization_Balance] [int] NOT NULL,
	[Is_Premium_Account] [varchar](5) NOT NULL,
	[Contact_Number] [varchar](11) NOT NULL,
	[Email] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED 
(
	[Organization_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organization_Review_List]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organization_Review_List](
	[VehiclePlateNumber] [varchar](10) NOT NULL,
	[Organization_ID] [int] NOT NULL,
	[Rating] [int] NOT NULL,
	[Comment] [varchar](1000) NULL,
 CONSTRAINT [PK_Organization_Review_List] PRIMARY KEY CLUSTERED 
(
	[VehiclePlateNumber] ASC,
	[Organization_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organization_Suggestions]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organization_Suggestions](
	[Department_Number] [int] NOT NULL,
	[Organization_ID] [int] NOT NULL,
 CONSTRAINT [PK_Organization_Suggestions] PRIMARY KEY CLUSTERED 
(
	[Department_Number] ASC,
	[Organization_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organization_Suggstions_List]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organization_Suggstions_List](
	[Department_Number] [int] NOT NULL,
	[Organization_ID] [int] NOT NULL,
	[Comment] [varchar](1000) NOT NULL,
 CONSTRAINT [PK_Organization_Suggstions_List] PRIMARY KEY CLUSTERED 
(
	[Department_Number] ASC,
	[Organization_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organizations_Review]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organizations_Review](
	[VehiclePlateNumber] [varchar](10) NOT NULL,
	[OrganizationID] [int] NOT NULL,
 CONSTRAINT [PK_Organizations_Review_1] PRIMARY KEY CLUSTERED 
(
	[VehiclePlateNumber] ASC,
	[OrganizationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parking]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parking](
	[Location] [varchar](100) NOT NULL,
	[Current_No_of_Vehicles] [int] NOT NULL,
	[Capacity] [int] NOT NULL,
 CONSTRAINT [PK_Parking] PRIMARY KEY CLUSTERED 
(
	[Location] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Records_in]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Records_in](
	[Booking_ID] [int] NOT NULL,
	[Employee_ID] [int] NOT NULL,
	[VehiclePlateNumber] [varchar](10) NOT NULL,
	[Organisation_ID] [int] NULL,
	[Individual_ID] [int] NULL,
 CONSTRAINT [PK_Records_in] PRIMARY KEY CLUSTERED 
(
	[Booking_ID] ASC,
	[Employee_ID] ASC,
	[VehiclePlateNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_SSN_Employee_ManagerID_Department] FOREIGN KEY([Manager_ID])
REFERENCES [dbo].[Employee] ([SSN])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_SSN_Employee_ManagerID_Department]
GO
ALTER TABLE [dbo].[Individual_Suggestions]  WITH CHECK ADD  CONSTRAINT [FK_Department_DepartmentNo_IndividualSuggest_DepartmentNo] FOREIGN KEY([Department_Number])
REFERENCES [dbo].[Departments] ([Department_Number])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Individual_Suggestions] CHECK CONSTRAINT [FK_Department_DepartmentNo_IndividualSuggest_DepartmentNo]
GO
ALTER TABLE [dbo].[Individual_Suggestions]  WITH CHECK ADD  CONSTRAINT [FK_Individuals_IndividualID_IndividualSuggest_IndividualID] FOREIGN KEY([Individual_ID])
REFERENCES [dbo].[Individuals] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Individual_Suggestions] CHECK CONSTRAINT [FK_Individuals_IndividualID_IndividualSuggest_IndividualID]
GO
ALTER TABLE [dbo].[Individual_Suggestions_List]  WITH CHECK ADD  CONSTRAINT [FK_Departments_DepartmentNo_IndividualSuggestionsList_DepartmentNo] FOREIGN KEY([Department_Number])
REFERENCES [dbo].[Departments] ([Department_Number])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Individual_Suggestions_List] CHECK CONSTRAINT [FK_Departments_DepartmentNo_IndividualSuggestionsList_DepartmentNo]
GO
ALTER TABLE [dbo].[Individual_Suggestions_List]  WITH CHECK ADD  CONSTRAINT [FK_Individuals_ID_IndividualSuggestionsList_IndividualID] FOREIGN KEY([Individual_ID])
REFERENCES [dbo].[Individuals] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Individual_Suggestions_List] CHECK CONSTRAINT [FK_Individuals_ID_IndividualSuggestionsList_IndividualID]
GO
ALTER TABLE [dbo].[Individuals_Review]  WITH CHECK ADD  CONSTRAINT [FK_Individuals_ID_IndividualsReview_IndividualID] FOREIGN KEY([Individual_ID])
REFERENCES [dbo].[Individuals] ([ID])
GO
ALTER TABLE [dbo].[Individuals_Review] CHECK CONSTRAINT [FK_Individuals_ID_IndividualsReview_IndividualID]
GO
ALTER TABLE [dbo].[Individuals_Review]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_VehiclePlateNumber_IndividualsReview_VehiclePlateNumber] FOREIGN KEY([VehiclePlateNumber])
REFERENCES [dbo].[Vehicles] ([VehiclePlateNumber])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Individuals_Review] CHECK CONSTRAINT [FK_Vehicles_VehiclePlateNumber_IndividualsReview_VehiclePlateNumber]
GO
ALTER TABLE [dbo].[Indvidual_Review_List]  WITH CHECK ADD  CONSTRAINT [FK_Indvidual_Review_List_Individuals] FOREIGN KEY([Indvidual_ID])
REFERENCES [dbo].[Individuals] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Indvidual_Review_List] CHECK CONSTRAINT [FK_Indvidual_Review_List_Individuals]
GO
ALTER TABLE [dbo].[Indvidual_Review_List]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_VehiclePlateNumber_IndvidualReviewList_VehiclePlateNumber] FOREIGN KEY([VehiclePlateNumber])
REFERENCES [dbo].[Vehicles] ([VehiclePlateNumber])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Indvidual_Review_List] CHECK CONSTRAINT [FK_Vehicles_VehiclePlateNumber_IndvidualReviewList_VehiclePlateNumber]
GO
ALTER TABLE [dbo].[Offer_List]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentNumber_OfferList_DepartmentNumber_Departments] FOREIGN KEY([Department_Number])
REFERENCES [dbo].[Departments] ([Department_Number])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Offer_List] CHECK CONSTRAINT [FK_DepartmentNumber_OfferList_DepartmentNumber_Departments]
GO
ALTER TABLE [dbo].[Organization_Review_List]  WITH CHECK ADD  CONSTRAINT [FK_Organization_OrganizationID_OrganizationReviewList_OrganizationID] FOREIGN KEY([Organization_ID])
REFERENCES [dbo].[Organization] ([Organization_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Organization_Review_List] CHECK CONSTRAINT [FK_Organization_OrganizationID_OrganizationReviewList_OrganizationID]
GO
ALTER TABLE [dbo].[Organization_Review_List]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_VehiclePlateNumber_OrganizationReviewList_VehiclePlateNumber] FOREIGN KEY([VehiclePlateNumber])
REFERENCES [dbo].[Vehicles] ([VehiclePlateNumber])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Organization_Review_List] CHECK CONSTRAINT [FK_Vehicles_VehiclePlateNumber_OrganizationReviewList_VehiclePlateNumber]
GO
ALTER TABLE [dbo].[Organization_Suggestions]  WITH CHECK ADD  CONSTRAINT [FK_Departments_DepartmentNo_OrganizationSuggest_DepartmentNo] FOREIGN KEY([Department_Number])
REFERENCES [dbo].[Departments] ([Department_Number])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Organization_Suggestions] CHECK CONSTRAINT [FK_Departments_DepartmentNo_OrganizationSuggest_DepartmentNo]
GO
ALTER TABLE [dbo].[Organization_Suggestions]  WITH CHECK ADD  CONSTRAINT [FK_Organization_OrganizationID_OrganizationSuggest_OrganizationID] FOREIGN KEY([Organization_ID])
REFERENCES [dbo].[Organization] ([Organization_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Organization_Suggestions] CHECK CONSTRAINT [FK_Organization_OrganizationID_OrganizationSuggest_OrganizationID]
GO
ALTER TABLE [dbo].[Organization_Suggstions_List]  WITH CHECK ADD  CONSTRAINT [FK_Departments_DepartmentNo_OrganizationSuggstionsList_DepartmentNo] FOREIGN KEY([Department_Number])
REFERENCES [dbo].[Departments] ([Department_Number])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Organization_Suggstions_List] CHECK CONSTRAINT [FK_Departments_DepartmentNo_OrganizationSuggstionsList_DepartmentNo]
GO
ALTER TABLE [dbo].[Organization_Suggstions_List]  WITH CHECK ADD  CONSTRAINT [FK_Organization_OrganizationID_OrganizationSuggstionsList_OrganizationID] FOREIGN KEY([Organization_ID])
REFERENCES [dbo].[Organization] ([Organization_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Organization_Suggstions_List] CHECK CONSTRAINT [FK_Organization_OrganizationID_OrganizationSuggstionsList_OrganizationID]
GO
ALTER TABLE [dbo].[Organizations_Review]  WITH CHECK ADD  CONSTRAINT [FK_Organizations_OrganizationID_OrganizationReview_OrganizationID] FOREIGN KEY([OrganizationID])
REFERENCES [dbo].[Organization] ([Organization_ID])
GO
ALTER TABLE [dbo].[Organizations_Review] CHECK CONSTRAINT [FK_Organizations_OrganizationID_OrganizationReview_OrganizationID]
GO
ALTER TABLE [dbo].[Organizations_Review]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_VehiclesPlateNumber_OrganizationsReview_VehiclesPlateNumber] FOREIGN KEY([VehiclePlateNumber])
REFERENCES [dbo].[Vehicles] ([VehiclePlateNumber])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Organizations_Review] CHECK CONSTRAINT [FK_Vehicles_VehiclesPlateNumber_OrganizationsReview_VehiclesPlateNumber]
GO
ALTER TABLE [dbo].[Records_in]  WITH CHECK ADD  CONSTRAINT [FK_BookingHistory_BookingID_RecordsIn_BookingID] FOREIGN KEY([Booking_ID])
REFERENCES [dbo].[Booking_History] ([Booking_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Records_in] CHECK CONSTRAINT [FK_BookingHistory_BookingID_RecordsIn_BookingID]
GO
ALTER TABLE [dbo].[Records_in]  WITH CHECK ADD  CONSTRAINT [FK_Employee_SSN_RecordsIn_EmployeeID] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employee] ([SSN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Records_in] CHECK CONSTRAINT [FK_Employee_SSN_RecordsIn_EmployeeID]
GO
ALTER TABLE [dbo].[Records_in]  WITH CHECK ADD  CONSTRAINT [FK_Individuals_ID_RecordsIn_IndividualsID] FOREIGN KEY([Individual_ID])
REFERENCES [dbo].[Individuals] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Records_in] CHECK CONSTRAINT [FK_Individuals_ID_RecordsIn_IndividualsID]
GO
ALTER TABLE [dbo].[Records_in]  WITH CHECK ADD  CONSTRAINT [FK_Organization_OrganizationID_Records_in_OrganizationID] FOREIGN KEY([Organisation_ID])
REFERENCES [dbo].[Organization] ([Organization_ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Records_in] CHECK CONSTRAINT [FK_Organization_OrganizationID_Records_in_OrganizationID]
GO
ALTER TABLE [dbo].[Records_in]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_VehiclePlateNumber_RecordsIn_VehiclePlateNumber] FOREIGN KEY([VehiclePlateNumber])
REFERENCES [dbo].[Vehicles] ([VehiclePlateNumber])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Records_in] CHECK CONSTRAINT [FK_Vehicles_VehiclePlateNumber_RecordsIn_VehiclePlateNumber]
GO
ALTER TABLE [dbo].[Tracks]  WITH CHECK ADD  CONSTRAINT [FK_Employee_SSN_Tracks_EmployeeID] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employee] ([SSN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Tracks] CHECK CONSTRAINT [FK_Employee_SSN_Tracks_EmployeeID]
GO
ALTER TABLE [dbo].[Tracks]  WITH CHECK ADD  CONSTRAINT [FK_Individuals_ID_Tracks_IndividualsID] FOREIGN KEY([Individual_ID])
REFERENCES [dbo].[Individuals] ([ID])
GO
ALTER TABLE [dbo].[Tracks] CHECK CONSTRAINT [FK_Individuals_ID_Tracks_IndividualsID]
GO
ALTER TABLE [dbo].[Tracks]  WITH CHECK ADD  CONSTRAINT [FK_Organization_OrganizationID_Tracks_OrganizationID] FOREIGN KEY([Organization_ID])
REFERENCES [dbo].[Organization] ([Organization_ID])
GO
ALTER TABLE [dbo].[Tracks] CHECK CONSTRAINT [FK_Organization_OrganizationID_Tracks_OrganizationID]
GO
ALTER TABLE [dbo].[Tracks]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_VehiclePlateNumber_Tracks_PlateNumber] FOREIGN KEY([Plate_Number])
REFERENCES [dbo].[Vehicles] ([VehiclePlateNumber])
GO
ALTER TABLE [dbo].[Tracks] CHECK CONSTRAINT [FK_Vehicles_VehiclePlateNumber_Tracks_PlateNumber]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_Parkedin_Parking_Locations] FOREIGN KEY([Parked_in])
REFERENCES [dbo].[Parking] ([Location])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_Parkedin_Parking_Locations]
GO
/****** Object:  StoredProcedure [dbo].[InsertIndividual]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertIndividual] @ID int, @fname varchar(50),  @lname varchar(50), @address varchar(100), @premium varchar(1), @balance int, @number int , @email varchar(100)
AS
BEGIN
INSERT INTO Individuals (ID, First_Name, Last_Name, Address, Is_Premium_Account, Individual_Balance, Contact_Number, Email)
Values (@ID, @fname, @lname, @address, @premium, @balance, @number, @email)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertIndividual1]    Script Date: 09-Jan-22 2:22:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertIndividual1] @ID int, @fname varchar(50),  @lname varchar(50), @address varchar(100), @premium varchar(1), @balance int, @number varchar(11) , @email varchar(100)
AS
BEGIN
INSERT INTO Individuals (ID, First_Name, Last_Name, Address, Is_Premium_Account, Individual_Balance, Contact_Number, Email)
Values (@ID, @fname, @lname, @address, @premium, @balance, @number, @email)
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Tracks"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 289
               Right = 250
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Car_Tracks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Car_Tracks'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Vehicles"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 258
               Right = 278
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Cars'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Cars'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Offer_List"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 270
               Right = 283
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Cars_Offer_List'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Cars_Offer_List'
GO
USE [master]
GO
ALTER DATABASE [RentalCompanyDB] SET  READ_WRITE 
GO
