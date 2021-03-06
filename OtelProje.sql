USE [master]
GO
/****** Object:  Database [OtelProje]    Script Date: 01/05/2017 15:28:33 ******/
CREATE DATABASE [OtelProje] ON  PRIMARY 
( NAME = N'OtelProje', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\OtelProje.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OtelProje_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\OtelProje_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OtelProje] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OtelProje].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OtelProje] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [OtelProje] SET ANSI_NULLS OFF
GO
ALTER DATABASE [OtelProje] SET ANSI_PADDING OFF
GO
ALTER DATABASE [OtelProje] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [OtelProje] SET ARITHABORT OFF
GO
ALTER DATABASE [OtelProje] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [OtelProje] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [OtelProje] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [OtelProje] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [OtelProje] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [OtelProje] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [OtelProje] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [OtelProje] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [OtelProje] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [OtelProje] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [OtelProje] SET  DISABLE_BROKER
GO
ALTER DATABASE [OtelProje] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [OtelProje] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [OtelProje] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [OtelProje] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [OtelProje] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [OtelProje] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [OtelProje] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [OtelProje] SET  READ_WRITE
GO
ALTER DATABASE [OtelProje] SET RECOVERY FULL
GO
ALTER DATABASE [OtelProje] SET  MULTI_USER
GO
ALTER DATABASE [OtelProje] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [OtelProje] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'OtelProje', N'ON'
GO
USE [OtelProje]
GO
/****** Object:  Table [dbo].[KutberkOdaDurum]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KutberkOdaDurum](
	[KutberkOdaID] [int] IDENTITY(1,1) NOT NULL,
	[OdaIsmi] [nvarchar](50) NULL,
	[OdaDurumu] [bit] NULL,
	[OdaResim] [nvarchar](max) NULL,
 CONSTRAINT [PK_KutberkOdaDurum] PRIMARY KEY CLUSTERED 
(
	[KutberkOdaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KutberkOdaDurum] ON
INSERT [dbo].[KutberkOdaDurum] ([KutberkOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (1, N'Oda 1', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/kutberknormal.jpg')
INSERT [dbo].[KutberkOdaDurum] ([KutberkOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (2, N'Oda 2', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/kutberknormal.jpg')
INSERT [dbo].[KutberkOdaDurum] ([KutberkOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (3, N'Oda 3', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/kutberknormal.jpg')
INSERT [dbo].[KutberkOdaDurum] ([KutberkOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (4, N'Oda 4', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/kutberknormal.jpg')
INSERT [dbo].[KutberkOdaDurum] ([KutberkOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (5, N'Oda 5', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/kutberknormal.jpg')
INSERT [dbo].[KutberkOdaDurum] ([KutberkOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (6, N'Oda 6', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/kutberknormal.jpg')
INSERT [dbo].[KutberkOdaDurum] ([KutberkOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (7, N'Oda 7', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/kutberknormal.jpg')
INSERT [dbo].[KutberkOdaDurum] ([KutberkOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (8, N'Oda 8', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/kutberknormal.jpg')
INSERT [dbo].[KutberkOdaDurum] ([KutberkOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (9, N'Oda 9', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/kutberknormal.jpg')
INSERT [dbo].[KutberkOdaDurum] ([KutberkOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (10, N'Oda 10', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/kutberknormal.jpg')
SET IDENTITY_INSERT [dbo].[KutberkOdaDurum] OFF
/****** Object:  Table [dbo].[KutberkMusteriBilgileri]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KutberkMusteriBilgileri](
	[KutberkMusteriID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [int] NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[BabaAdi] [nvarchar](50) NULL,
	[AnneAdi] [nvarchar](50) NULL,
	[DogumTarihi] [nvarchar](50) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
	[MedeniHali] [nvarchar](50) NULL,
	[CepTel] [nvarchar](50) NULL,
	[EvTel] [nvarchar](50) NULL,
	[IsTel] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Meslek] [nvarchar](50) NULL,
	[Adres] [nvarchar](50) NULL,
	[KutberkOdaID] [int] NULL,
	[RezBaslangic] [nvarchar](50) NULL,
	[RezBitis] [nvarchar](50) NULL,
	[OdemeTuru] [nvarchar](50) NULL,
	[Ucret] [int] NULL,
	[MusteriResim] [nvarchar](max) NULL,
 CONSTRAINT [PK_KutberkMusteriBilgileri] PRIMARY KEY CLUSTERED 
(
	[KutberkMusteriID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KutberkMusteriBilgileri] ON
INSERT [dbo].[KutberkMusteriBilgileri] ([KutberkMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [KutberkOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (1, 3241, N'serhan', N'duyar', N'asd', N'asd', N'25.09.1997', N'Bay', N'Bekar', N'123', N'123', N'123', N'asd', N'asd', N'asd', 10, N'19.12.2016 13:47:22', N'22.12.2016 13:47:22', N'Nakit', 768, NULL)
INSERT [dbo].[KutberkMusteriBilgileri] ([KutberkMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [KutberkOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (2, 12413, N'murat', N'asd', N'asd', N'asd', N'19.12.2016', N'Bay', N'Bekar', N'123', N'123', N'123', N'asd', N'asd', N'asd', 7, N'19.12.2016 00:00:00', N'20.12.2016 14:18:08', N'Kredi Kartı', 256, NULL)
INSERT [dbo].[KutberkMusteriBilgileri] ([KutberkMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [KutberkOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (3, 48532, N'Selim', N'Celik', N'asd', N'asd', N'20.12.2016', N'Bay', N'Bekar', N'123', N'2312', N'312', N'asd', N'asd', N'asd', 9, N'20.12.2016', N'22.12.2016', N'Nakit', 530, NULL)
INSERT [dbo].[KutberkMusteriBilgileri] ([KutberkMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [KutberkOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (4, 4123, N'tugce', N'kocccc', N'asd', N'asd', N'4.07.2001', N'Bayan', N'Bekar', N'123', N'132', N'213134', N'asd', N'asd', N'asd', 9, N'20.12.2016', N'23.12.2016', N'Nakit', 513, NULL)
INSERT [dbo].[KutberkMusteriBilgileri] ([KutberkMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [KutberkOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (5, 4132, N'deneme', N'deneme', N'asd', N'asd', N'24.12.2016', N'Bay', N'Evli ', N'123', N'123', N'213', N'asd', N'asd', N'asd', 10, N'24.12.2016', N'28.12.2016', N'Nakit', 513, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources\dasdas.jpg')
SET IDENTITY_INSERT [dbo].[KutberkMusteriBilgileri] OFF
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[TC] [int] NOT NULL,
	[Adi] [nvarchar](50) NULL,
	[Soyadi] [nvarchar](50) NULL,
	[Telefonu] [nvarchar](50) NULL,
	[Mail] [nvarchar](50) NULL,
	[Sehir] [nvarchar](50) NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[Sifre] [nvarchar](50) NULL,
	[KullaniciTipi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[TC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Kullanicilar] ([TC], [Adi], [Soyadi], [Telefonu], [Mail], [Sehir], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (123, N'Furkan', N'KOC', N'123', N'asd', N'asd', N'admin', N'123', N'1')
INSERT [dbo].[Kullanicilar] ([TC], [Adi], [Soyadi], [Telefonu], [Mail], [Sehir], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (132, N'asd', N'asd', N'asd', N'asd', N'asd', N'uye', N'123', N'0')
INSERT [dbo].[Kullanicilar] ([TC], [Adi], [Soyadi], [Telefonu], [Mail], [Sehir], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (134, N'gfds', N'nbvc', N'321', N'vcds', N'fds', N'adminreyiz', N'123', N'1')
INSERT [dbo].[Kullanicilar] ([TC], [Adi], [Soyadi], [Telefonu], [Mail], [Sehir], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (54361, N'selim', N'salladım', N'123', N'asd', N'asd', N'yeniuye', N'1323', N'0')
INSERT [dbo].[Kullanicilar] ([TC], [Adi], [Soyadi], [Telefonu], [Mail], [Sehir], [KullaniciAdi], [Sifre], [KullaniciTipi]) VALUES (123754, N'serhan', N'duyar', N'1234', N'asd', N'asdas', N'kullanici', N'1313', N'0')
/****** Object:  Table [dbo].[KonaklamaTipi]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KonaklamaTipi](
	[KonaklamaTipiID] [int] IDENTITY(1,1) NOT NULL,
	[ApartHotel] [bit] NULL,
	[Resort] [bit] NULL,
	[Yazlik] [bit] NULL,
	[Otel] [bit] NULL,
 CONSTRAINT [PK_KonaklamaTipi] PRIMARY KEY CLUSTERED 
(
	[KonaklamaTipiID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[KonaklamaTipi] ON
INSERT [dbo].[KonaklamaTipi] ([KonaklamaTipiID], [ApartHotel], [Resort], [Yazlik], [Otel]) VALUES (1, 1, 0, 0, 0)
INSERT [dbo].[KonaklamaTipi] ([KonaklamaTipiID], [ApartHotel], [Resort], [Yazlik], [Otel]) VALUES (5, 1, 1, 0, 0)
INSERT [dbo].[KonaklamaTipi] ([KonaklamaTipiID], [ApartHotel], [Resort], [Yazlik], [Otel]) VALUES (6, 0, 0, 0, 1)
INSERT [dbo].[KonaklamaTipi] ([KonaklamaTipiID], [ApartHotel], [Resort], [Yazlik], [Otel]) VALUES (7, 0, 0, 1, 0)
INSERT [dbo].[KonaklamaTipi] ([KonaklamaTipiID], [ApartHotel], [Resort], [Yazlik], [Otel]) VALUES (8, 1, 0, 0, 0)
INSERT [dbo].[KonaklamaTipi] ([KonaklamaTipiID], [ApartHotel], [Resort], [Yazlik], [Otel]) VALUES (9, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[KonaklamaTipi] OFF
/****** Object:  Table [dbo].[HiltonOdaDurum]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HiltonOdaDurum](
	[HiltonOdaID] [int] IDENTITY(1,1) NOT NULL,
	[OdaIsmi] [nvarchar](50) NULL,
	[OdaDurumu] [bit] NULL,
	[OdaResim] [nvarchar](max) NULL,
 CONSTRAINT [PK_HiltonOdaDurum] PRIMARY KEY CLUSTERED 
(
	[HiltonOdaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HiltonOdaDurum] ON
INSERT [dbo].[HiltonOdaDurum] ([HiltonOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (1, N'Oda 1', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/hiltonnormal.jpg')
INSERT [dbo].[HiltonOdaDurum] ([HiltonOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (2, N'Oda 2', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/hiltonnormal.jpg')
INSERT [dbo].[HiltonOdaDurum] ([HiltonOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (3, N'Oda 3', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/hiltonnormal.jpg')
INSERT [dbo].[HiltonOdaDurum] ([HiltonOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (4, N'Oda 4', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/hiltonnormal.jpg')
INSERT [dbo].[HiltonOdaDurum] ([HiltonOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (5, N'Oda 5', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/hiltonnormal.jpg')
INSERT [dbo].[HiltonOdaDurum] ([HiltonOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (6, N'Oda 6', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/hiltonsuit.jpg')
INSERT [dbo].[HiltonOdaDurum] ([HiltonOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (7, N'Oda 7', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/hiltonsuit.jpg')
INSERT [dbo].[HiltonOdaDurum] ([HiltonOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (8, N'Oda 8', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/hiltonsuit.jpg')
INSERT [dbo].[HiltonOdaDurum] ([HiltonOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (9, N'Oda 9', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/hiltonkral.jpg')
INSERT [dbo].[HiltonOdaDurum] ([HiltonOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (10, N'Oda 10', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/hiltonkral.jpg')
SET IDENTITY_INSERT [dbo].[HiltonOdaDurum] OFF
/****** Object:  Table [dbo].[HiltonMusteriBilgileri]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HiltonMusteriBilgileri](
	[HiltonMusteriID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [int] NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[BabaAdi] [nvarchar](50) NULL,
	[AnneAdi] [nvarchar](50) NULL,
	[DogumTarihi] [nvarchar](50) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
	[MedeniHali] [nvarchar](50) NULL,
	[CepTel] [nvarchar](50) NULL,
	[EvTel] [nvarchar](50) NULL,
	[IsTel] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Meslek] [nvarchar](50) NULL,
	[Adres] [nvarchar](50) NULL,
	[HiltonOdaID] [int] NULL,
	[RezBaslangic] [nvarchar](50) NULL,
	[RezBitis] [nvarchar](50) NULL,
	[OdemeTuruID] [int] NULL,
	[Ucret] [int] NULL,
	[MusteriResim] [nvarchar](max) NULL,
 CONSTRAINT [PK_HiltonMusteriBilgileri_1] PRIMARY KEY CLUSTERED 
(
	[HiltonMusteriID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HiltonMusteriBilgileri] ON
INSERT [dbo].[HiltonMusteriBilgileri] ([HiltonMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [HiltonOdaID], [RezBaslangic], [RezBitis], [OdemeTuruID], [Ucret], [MusteriResim]) VALUES (1, 3241, N'serhan', N'duyar', N'asd', N'asd', N'25.09.1997', N'Bay', N'Bekar', N'123', N'123', N'123', N'asd', N'asd', N'asd', 10, N'19.12.2016 13:47:22', N'22.12.2016 13:47:22', 0, 768, NULL)
INSERT [dbo].[HiltonMusteriBilgileri] ([HiltonMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [HiltonOdaID], [RezBaslangic], [RezBitis], [OdemeTuruID], [Ucret], [MusteriResim]) VALUES (2, 12413, N'murat', N'asd', N'asd', N'asd', N'19.12.2016', N'Bay', N'Bekar', N'123', N'123', N'123', N'asd', N'asd', N'asd', 7, N'19.12.2016 00:00:00', N'20.12.2016 14:18:08', 0, 256, NULL)
INSERT [dbo].[HiltonMusteriBilgileri] ([HiltonMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [HiltonOdaID], [RezBaslangic], [RezBitis], [OdemeTuruID], [Ucret], [MusteriResim]) VALUES (4, 48532, N'Selim', N'Celik', N'asd', N'asd', N'20.12.2016', N'Bay', N'Bekar', N'123', N'2312', N'312', N'asd', N'asd', N'asd', 9, N'20.12.2016', N'22.12.2016', 0, 530, NULL)
INSERT [dbo].[HiltonMusteriBilgileri] ([HiltonMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [HiltonOdaID], [RezBaslangic], [RezBitis], [OdemeTuruID], [Ucret], [MusteriResim]) VALUES (5, 123, N'deneme', N'deneme', N'asd', N'asd', N'24.12.2016', N'Bayan', N'Evli ', N'13', N'3123', N'3213', N'asd', N'asd', N'asd', 9, N'24.12.2016', N'28.12.2016', 0, 795, NULL)
SET IDENTITY_INSERT [dbo].[HiltonMusteriBilgileri] OFF
/****** Object:  Table [dbo].[Erisebilirlik]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Erisebilirlik](
	[ErisilebilirlikID] [int] IDENTITY(1,1) NOT NULL,
	[EngelliOtoparki] [bit] NULL,
	[EngellilereOzelOda] [bit] NULL,
	[EngellilereOzelYol] [bit] NULL,
	[TekerlekliSandalye] [bit] NULL,
 CONSTRAINT [PK_Erisebilirlik] PRIMARY KEY CLUSTERED 
(
	[ErisilebilirlikID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Erisebilirlik] ON
INSERT [dbo].[Erisebilirlik] ([ErisilebilirlikID], [EngelliOtoparki], [EngellilereOzelOda], [EngellilereOzelYol], [TekerlekliSandalye]) VALUES (1, 1, 1, 1, 1)
INSERT [dbo].[Erisebilirlik] ([ErisilebilirlikID], [EngelliOtoparki], [EngellilereOzelOda], [EngellilereOzelYol], [TekerlekliSandalye]) VALUES (2, 0, 0, 0, 0)
INSERT [dbo].[Erisebilirlik] ([ErisilebilirlikID], [EngelliOtoparki], [EngellilereOzelOda], [EngellilereOzelYol], [TekerlekliSandalye]) VALUES (3, 0, 1, 0, 0)
SET IDENTITY_INSERT [dbo].[Erisebilirlik] OFF
/****** Object:  Table [dbo].[EceSarayOdaDurum]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EceSarayOdaDurum](
	[EceSarayOdaID] [int] IDENTITY(1,1) NOT NULL,
	[OdaIsmi] [nvarchar](50) NULL,
	[OdaDurumu] [bit] NULL,
	[OdaResim] [nvarchar](max) NULL,
 CONSTRAINT [PK_EceSarayOdaDurum] PRIMARY KEY CLUSTERED 
(
	[EceSarayOdaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EceSarayOdaDurum] ON
INSERT [dbo].[EceSarayOdaDurum] ([EceSarayOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (1, N'Oda 1', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/ecesaraynormal.jpg')
INSERT [dbo].[EceSarayOdaDurum] ([EceSarayOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (2, N'Oda 2', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/ecesaraynormal.jpg')
INSERT [dbo].[EceSarayOdaDurum] ([EceSarayOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (3, N'Oda 3', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/ecesaraynormal.jpg')
INSERT [dbo].[EceSarayOdaDurum] ([EceSarayOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (4, N'Oda 4', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/ecesaraynormal.jpg')
INSERT [dbo].[EceSarayOdaDurum] ([EceSarayOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (5, N'Oda 5', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/ecesaraynormal.jpg')
INSERT [dbo].[EceSarayOdaDurum] ([EceSarayOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (6, N'Oda 6', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/ecesaraynormal.jpg')
INSERT [dbo].[EceSarayOdaDurum] ([EceSarayOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (7, N'Oda 7', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/ecesaraysuit.jpg')
INSERT [dbo].[EceSarayOdaDurum] ([EceSarayOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (8, N'Oda 8', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/ecesaraysuit.jpg')
INSERT [dbo].[EceSarayOdaDurum] ([EceSarayOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (9, N'Oda 9', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/ecesaraysuit.jpg')
INSERT [dbo].[EceSarayOdaDurum] ([EceSarayOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (10, N'Oda 10', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/ecesaraysuit.jpg')
SET IDENTITY_INSERT [dbo].[EceSarayOdaDurum] OFF
/****** Object:  Table [dbo].[EceSarayMusteriBilgileri]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EceSarayMusteriBilgileri](
	[EceSarayMusteriID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [int] NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[BabaAdi] [nvarchar](50) NULL,
	[AnneAdi] [nvarchar](50) NULL,
	[DogumTarihi] [nvarchar](50) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
	[MedeniHali] [nvarchar](50) NULL,
	[CepTel] [nvarchar](50) NULL,
	[EvTel] [nvarchar](50) NULL,
	[IsTel] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Meslek] [nvarchar](50) NULL,
	[Adres] [nvarchar](50) NULL,
	[EceSarayOdaID] [int] NULL,
	[RezBaslangic] [nvarchar](50) NULL,
	[RezBitis] [nvarchar](50) NULL,
	[OdemeTuru] [nvarchar](50) NULL,
	[Ucret] [int] NULL,
	[MusteriResim] [nvarchar](max) NULL,
 CONSTRAINT [PK_EceSarayMusteriBilgileri] PRIMARY KEY CLUSTERED 
(
	[EceSarayMusteriID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EceSarayMusteriBilgileri] ON
INSERT [dbo].[EceSarayMusteriBilgileri] ([EceSarayMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [EceSarayOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (1, 123, N'furkan', N'koc', N'asd', N'asd', N'24.12.2016', N'Bay', N'Bekar', N'12312', N'312', N'123', N'asd', N'asd', N'asd', 2, N'24.12.2016', N'26.12.2016', N'Nakit', 225, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources\denemeee.jpg')
SET IDENTITY_INSERT [dbo].[EceSarayMusteriBilgileri] OFF
/****** Object:  Table [dbo].[DedemanOdaDurum]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DedemanOdaDurum](
	[DedemanOdaID] [int] IDENTITY(1,1) NOT NULL,
	[OdaIsmi] [nvarchar](50) NULL,
	[OdaDurumu] [bit] NULL,
	[OdaResim] [nvarchar](max) NULL,
 CONSTRAINT [PK_DedemanOdaDurum] PRIMARY KEY CLUSTERED 
(
	[DedemanOdaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DedemanOdaDurum] ON
INSERT [dbo].[DedemanOdaDurum] ([DedemanOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (1, N'Oda 1', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/dedemannormal.jpg')
INSERT [dbo].[DedemanOdaDurum] ([DedemanOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (2, N'Oda 2', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/dedemannormal.jpg')
INSERT [dbo].[DedemanOdaDurum] ([DedemanOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (3, N'Oda 3', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/dedemannormal.jpg')
INSERT [dbo].[DedemanOdaDurum] ([DedemanOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (4, N'Oda 4', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/dedemannormal.jpg')
INSERT [dbo].[DedemanOdaDurum] ([DedemanOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (5, N'Oda 5', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/dedemannormal.jpg')
INSERT [dbo].[DedemanOdaDurum] ([DedemanOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (6, N'Oda 6', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/dedemansuite.jpg')
INSERT [dbo].[DedemanOdaDurum] ([DedemanOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (7, N'Oda 7', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/dedemansuite.jpg')
INSERT [dbo].[DedemanOdaDurum] ([DedemanOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (8, N'Oda 8', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/dedemansuite.jpg')
INSERT [dbo].[DedemanOdaDurum] ([DedemanOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (9, N'Oda 9', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/dedemankral.jpg')
INSERT [dbo].[DedemanOdaDurum] ([DedemanOdaID], [OdaIsmi], [OdaDurumu], [OdaResim]) VALUES (10, N'Oda 10', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/dedemankral.jpg')
SET IDENTITY_INSERT [dbo].[DedemanOdaDurum] OFF
/****** Object:  Table [dbo].[DedemanMusteriBilgileri]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DedemanMusteriBilgileri](
	[DedemanMusteriID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [int] NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[BabaAdi] [nvarchar](50) NULL,
	[AnneAdi] [nvarchar](50) NULL,
	[DogumTarihi] [nvarchar](50) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
	[MedeniHali] [nvarchar](50) NULL,
	[CepTel] [nvarchar](50) NULL,
	[EvTel] [nvarchar](50) NULL,
	[IsTel] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Meslek] [nvarchar](50) NULL,
	[Adres] [nvarchar](50) NULL,
	[DedemanOdaID] [int] NULL,
	[RezBaslangic] [nvarchar](50) NULL,
	[RezBitis] [nvarchar](50) NULL,
	[OdemeTuru] [nvarchar](50) NULL,
	[Ucret] [int] NULL,
	[MusteriResim] [nvarchar](max) NULL,
 CONSTRAINT [PK_DedemanMusteriBilgileri] PRIMARY KEY CLUSTERED 
(
	[DedemanMusteriID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DedemanMusteriBilgileri] ON
INSERT [dbo].[DedemanMusteriBilgileri] ([DedemanMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [DedemanOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (5, 3241, N'serhan', N'duyar', N'asd', N'asd', N'25.09.1997', N'Bay', N'Bekar', N'123', N'123', N'123', N'asd', N'asd', N'asd', 10, N'19.12.2016 13:47:22', N'22.12.2016 13:47:22', N'0', 768, NULL)
INSERT [dbo].[DedemanMusteriBilgileri] ([DedemanMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [DedemanOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (8, 12413, N'murat', N'asd', N'asd', N'asd', N'19.12.2016', N'Bay', N'Bekar', N'123', N'123', N'123', N'asd', N'asd', N'asd', 7, N'19.12.2016 00:00:00', N'20.12.2016 14:18:08', N'0', 256, NULL)
INSERT [dbo].[DedemanMusteriBilgileri] ([DedemanMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [DedemanOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (10, 12413, N'furkan', N'koc', N'asd', N'asd', N'1.03.1997', N'Bay', N'Bekar', N'1', N'2', N'3', N'asd@gmail.com', N'asd', N'asd', 10, N'19.12.2016', N'20.12.2016', N'0', 256, NULL)
INSERT [dbo].[DedemanMusteriBilgileri] ([DedemanMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [DedemanOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (12, 2112, N'selim', N'celik', N'asd', N'asd', N'15.10.1998', N'Bay', N'Bekar', N'123', N'321', N'123', N'asd', N'asd', N'asd', 1, N'23.12.2016', N'25.12.2016', N'0', 384, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources\sadasd.jpg')
INSERT [dbo].[DedemanMusteriBilgileri] ([DedemanMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [DedemanOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (14, 1235, N'furkan', N'koc', N'dursun', N'altun', N'1.03.1997', N'Bay', N'Bekar', N'05312132123', N'5215', N'2318', N'eposta@gmail.com', N'ogrenci', N'asd', 1, N'27.12.2016', N'29.12.2016', N'Nakit', 150, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources\dedemanfurkan.jpg')
SET IDENTITY_INSERT [dbo].[DedemanMusteriBilgileri] OFF
/****** Object:  Table [dbo].[AntalyaSuOdaDurum]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AntalyaSuOdaDurum](
	[AntalyaSuOdaID] [int] IDENTITY(1,1) NOT NULL,
	[OdaIsmi] [nvarchar](50) NULL,
	[OdaDurum] [bit] NULL,
	[OdaResim] [nvarchar](max) NULL,
 CONSTRAINT [PK_AntalyaSuOdaDurum] PRIMARY KEY CLUSTERED 
(
	[AntalyaSuOdaID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AntalyaSuOdaDurum] ON
INSERT [dbo].[AntalyaSuOdaDurum] ([AntalyaSuOdaID], [OdaIsmi], [OdaDurum], [OdaResim]) VALUES (1, N'Oda 1', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/antalyasunormal.jpg')
INSERT [dbo].[AntalyaSuOdaDurum] ([AntalyaSuOdaID], [OdaIsmi], [OdaDurum], [OdaResim]) VALUES (2, N'Oda 2', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/antalyasunormal.jpg')
INSERT [dbo].[AntalyaSuOdaDurum] ([AntalyaSuOdaID], [OdaIsmi], [OdaDurum], [OdaResim]) VALUES (3, N'Oda 3', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/antalyasunormal.jpg')
INSERT [dbo].[AntalyaSuOdaDurum] ([AntalyaSuOdaID], [OdaIsmi], [OdaDurum], [OdaResim]) VALUES (4, N'Oda 4', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/antalyasunormal.jpg')
INSERT [dbo].[AntalyaSuOdaDurum] ([AntalyaSuOdaID], [OdaIsmi], [OdaDurum], [OdaResim]) VALUES (5, N'Oda 5', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/antalyasunormal.jpg')
INSERT [dbo].[AntalyaSuOdaDurum] ([AntalyaSuOdaID], [OdaIsmi], [OdaDurum], [OdaResim]) VALUES (6, N'Oda 6', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/antalyasuasuit.jpg')
INSERT [dbo].[AntalyaSuOdaDurum] ([AntalyaSuOdaID], [OdaIsmi], [OdaDurum], [OdaResim]) VALUES (7, N'Oda 7', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/antalyasuasuit.jpg')
INSERT [dbo].[AntalyaSuOdaDurum] ([AntalyaSuOdaID], [OdaIsmi], [OdaDurum], [OdaResim]) VALUES (8, N'Oda 8', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/antalyasuasuit.jpg')
INSERT [dbo].[AntalyaSuOdaDurum] ([AntalyaSuOdaID], [OdaIsmi], [OdaDurum], [OdaResim]) VALUES (9, N'Oda 9', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/antalyasusuit.jpg')
INSERT [dbo].[AntalyaSuOdaDurum] ([AntalyaSuOdaID], [OdaIsmi], [OdaDurum], [OdaResim]) VALUES (10, N'Oda 10', NULL, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources/antalyasusuit.jpg')
SET IDENTITY_INSERT [dbo].[AntalyaSuOdaDurum] OFF
/****** Object:  Table [dbo].[AntalyaSuMusteriBilgileri]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AntalyaSuMusteriBilgileri](
	[AntalyaSuMusteriID] [int] IDENTITY(1,1) NOT NULL,
	[TC] [int] NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[BabaAdi] [nvarchar](50) NULL,
	[AnneAdi] [nvarchar](50) NULL,
	[DogumTarihi] [nvarchar](50) NULL,
	[Cinsiyet] [nvarchar](50) NULL,
	[MedeniHali] [nvarchar](50) NULL,
	[CepTel] [nvarchar](50) NULL,
	[EvTel] [nvarchar](50) NULL,
	[IsTel] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Meslek] [nvarchar](50) NULL,
	[Adres] [nvarchar](50) NULL,
	[AntalyaSuOdaID] [int] NULL,
	[RezBaslangic] [nvarchar](50) NULL,
	[RezBitis] [nvarchar](50) NULL,
	[OdemeTuru] [nvarchar](50) NULL,
	[Ucret] [int] NULL,
	[MusteriResim] [nvarchar](max) NULL,
 CONSTRAINT [PK_AntalyaSuMusteriBilgileri] PRIMARY KEY CLUSTERED 
(
	[AntalyaSuMusteriID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AntalyaSuMusteriBilgileri] ON
INSERT [dbo].[AntalyaSuMusteriBilgileri] ([AntalyaSuMusteriID], [TC], [Ad], [Soyad], [BabaAdi], [AnneAdi], [DogumTarihi], [Cinsiyet], [MedeniHali], [CepTel], [EvTel], [IsTel], [Email], [Meslek], [Adres], [AntalyaSuOdaID], [RezBaslangic], [RezBitis], [OdemeTuru], [Ucret], [MusteriResim]) VALUES (1, 3124, N'furkannnnn', N'koc', N'asd', N'asd', N'24.12.2016', N'Bay', N'Bekar', N'132', N'213', N'123', N'asd', N'asd', N'asd', 9, N'24.12.2016', N'26.12.2016', N'Kredi Kartı', 309, N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources\denemeeee.jpg')
SET IDENTITY_INSERT [dbo].[AntalyaSuMusteriBilgileri] OFF
/****** Object:  Table [dbo].[YildizSayisi]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[YildizSayisi](
	[YildizSayisiID] [int] IDENTITY(1,1) NOT NULL,
	[YildizSayisi] [int] NULL,
 CONSTRAINT [PK_YildizSayisi] PRIMARY KEY CLUSTERED 
(
	[YildizSayisiID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[YildizSayisi] ON
INSERT [dbo].[YildizSayisi] ([YildizSayisiID], [YildizSayisi]) VALUES (2, 5)
INSERT [dbo].[YildizSayisi] ([YildizSayisiID], [YildizSayisi]) VALUES (3, 4)
INSERT [dbo].[YildizSayisi] ([YildizSayisiID], [YildizSayisi]) VALUES (4, 3)
INSERT [dbo].[YildizSayisi] ([YildizSayisiID], [YildizSayisi]) VALUES (5, 2)
INSERT [dbo].[YildizSayisi] ([YildizSayisiID], [YildizSayisi]) VALUES (6, 1)
SET IDENTITY_INSERT [dbo].[YildizSayisi] OFF
/****** Object:  Table [dbo].[Uygunluk]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uygunluk](
	[UygunlukID] [int] IDENTITY(1,1) NOT NULL,
	[Aileler] [bit] NULL,
	[BalayiCiftleri] [bit] NULL,
	[Bekarlar] [bit] NULL,
 CONSTRAINT [PK_Uygunluk] PRIMARY KEY CLUSTERED 
(
	[UygunlukID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Uygunluk] ON
INSERT [dbo].[Uygunluk] ([UygunlukID], [Aileler], [BalayiCiftleri], [Bekarlar]) VALUES (1, 1, 1, 1)
INSERT [dbo].[Uygunluk] ([UygunlukID], [Aileler], [BalayiCiftleri], [Bekarlar]) VALUES (2, 0, 1, 1)
SET IDENTITY_INSERT [dbo].[Uygunluk] OFF
/****** Object:  Table [dbo].[OtelTemasi]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OtelTemasi](
	[OtelTemasiID] [int] IDENTITY(1,1) NOT NULL,
	[LuksOtel] [bit] NULL,
	[SehirOteli] [bit] NULL,
	[DogaOteli] [bit] NULL,
	[SaglikOteli] [bit] NULL,
 CONSTRAINT [PK_OtelTemasi] PRIMARY KEY CLUSTERED 
(
	[OtelTemasiID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OtelTemasi] ON
INSERT [dbo].[OtelTemasi] ([OtelTemasiID], [LuksOtel], [SehirOteli], [DogaOteli], [SaglikOteli]) VALUES (1, 0, 1, 0, 0)
INSERT [dbo].[OtelTemasi] ([OtelTemasiID], [LuksOtel], [SehirOteli], [DogaOteli], [SaglikOteli]) VALUES (2, 0, 0, 1, 0)
INSERT [dbo].[OtelTemasi] ([OtelTemasiID], [LuksOtel], [SehirOteli], [DogaOteli], [SaglikOteli]) VALUES (3, 1, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[OtelTemasi] OFF
/****** Object:  Table [dbo].[OtelSecimi]    Script Date: 01/05/2017 15:28:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OtelSecimi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OtelIsmı] [nvarchar](50) NULL,
	[KonaklamaTipiID] [int] NULL,
	[OtelTemasiID] [int] NULL,
	[UygunlukID] [int] NULL,
	[ErisebilirlikID] [int] NULL,
	[YildizSayisiID] [int] NULL,
	[Fiyat] [int] NULL,
	[OtelAciklama] [nvarchar](max) NULL,
	[OtelResim] [nvarchar](max) NULL,
	[OdaID] [int] NULL,
 CONSTRAINT [PK_OtelSecimi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[OtelSecimi] ON
INSERT [dbo].[OtelSecimi] ([ID], [OtelIsmı], [KonaklamaTipiID], [OtelTemasiID], [UygunlukID], [ErisebilirlikID], [YildizSayisiID], [Fiyat], [OtelAciklama], [OtelResim], [OdaID]) VALUES (9, N'Dedeman', 6, 1, 1, 1, 2, 256, N'İstanbul, Taksim Meydanı:3,6 km Puan:84/100', N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources\dedemantaksim.jpg', NULL)
INSERT [dbo].[OtelSecimi] ([ID], [OtelIsmı], [KonaklamaTipiID], [OtelTemasiID], [UygunlukID], [ErisebilirlikID], [YildizSayisiID], [Fiyat], [OtelAciklama], [OtelResim], [OdaID]) VALUES (10, N'Hilton', 9, 1, 1, 1, 2, 265, N'İstanbul, Şehir Merkezi:9,4 km Puan:86/100', N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources\hiltonyenisahra.jpg', NULL)
INSERT [dbo].[OtelSecimi] ([ID], [OtelIsmı], [KonaklamaTipiID], [OtelTemasiID], [UygunlukID], [ErisebilirlikID], [YildizSayisiID], [Fiyat], [OtelAciklama], [OtelResim], [OdaID]) VALUES (11, N'Kutberk Butik', 1, 2, 2, 2, 4, 171, N'Kemer,Şehir Merkezi:0,6 km Puan:77/100', N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources\kutberkbutik.jpg', NULL)
INSERT [dbo].[OtelSecimi] ([ID], [OtelIsmı], [KonaklamaTipiID], [OtelTemasiID], [UygunlukID], [ErisebilirlikID], [YildizSayisiID], [Fiyat], [OtelAciklama], [OtelResim], [OdaID]) VALUES (12, N'Ece Saray Marina', 6, 3, 1, 3, 3, 270, N'Fethiye, Şehir Merkezi:3,7 km Puan 83/100', N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources\ecesaray.jpg', NULL)
INSERT [dbo].[OtelSecimi] ([ID], [OtelIsmı], [KonaklamaTipiID], [OtelTemasiID], [UygunlukID], [ErisebilirlikID], [YildizSayisiID], [Fiyat], [OtelAciklama], [OtelResim], [OdaID]) VALUES (13, N'Antalya Su', 6, 1, 1, 1, 2, 235, N'Antalya, ŞehirMerkezi:5,0 km Puan:84/100', N'C:\Users\Furkan KOÇ\Desktop\projem\projem\Resources\antalyasu.jpg', NULL)
SET IDENTITY_INSERT [dbo].[OtelSecimi] OFF
/****** Object:  Default [DF_Kullanicilar_KullaniciTipi]    Script Date: 01/05/2017 15:28:34 ******/
ALTER TABLE [dbo].[Kullanicilar] ADD  CONSTRAINT [DF_Kullanicilar_KullaniciTipi]  DEFAULT ((0)) FOR [KullaniciTipi]
GO
/****** Object:  ForeignKey [FK_OtelSecimi_Erisebilirlik]    Script Date: 01/05/2017 15:28:34 ******/
ALTER TABLE [dbo].[OtelSecimi]  WITH CHECK ADD  CONSTRAINT [FK_OtelSecimi_Erisebilirlik] FOREIGN KEY([ErisebilirlikID])
REFERENCES [dbo].[Erisebilirlik] ([ErisilebilirlikID])
GO
ALTER TABLE [dbo].[OtelSecimi] CHECK CONSTRAINT [FK_OtelSecimi_Erisebilirlik]
GO
/****** Object:  ForeignKey [FK_OtelSecimi_KonaklamaTipi]    Script Date: 01/05/2017 15:28:34 ******/
ALTER TABLE [dbo].[OtelSecimi]  WITH CHECK ADD  CONSTRAINT [FK_OtelSecimi_KonaklamaTipi] FOREIGN KEY([KonaklamaTipiID])
REFERENCES [dbo].[KonaklamaTipi] ([KonaklamaTipiID])
GO
ALTER TABLE [dbo].[OtelSecimi] CHECK CONSTRAINT [FK_OtelSecimi_KonaklamaTipi]
GO
/****** Object:  ForeignKey [FK_OtelSecimi_OtelTemasi]    Script Date: 01/05/2017 15:28:34 ******/
ALTER TABLE [dbo].[OtelSecimi]  WITH CHECK ADD  CONSTRAINT [FK_OtelSecimi_OtelTemasi] FOREIGN KEY([OtelTemasiID])
REFERENCES [dbo].[OtelTemasi] ([OtelTemasiID])
GO
ALTER TABLE [dbo].[OtelSecimi] CHECK CONSTRAINT [FK_OtelSecimi_OtelTemasi]
GO
/****** Object:  ForeignKey [FK_OtelSecimi_Uygunluk]    Script Date: 01/05/2017 15:28:34 ******/
ALTER TABLE [dbo].[OtelSecimi]  WITH CHECK ADD  CONSTRAINT [FK_OtelSecimi_Uygunluk] FOREIGN KEY([UygunlukID])
REFERENCES [dbo].[Uygunluk] ([UygunlukID])
GO
ALTER TABLE [dbo].[OtelSecimi] CHECK CONSTRAINT [FK_OtelSecimi_Uygunluk]
GO
/****** Object:  ForeignKey [FK_OtelSecimi_YildizSayisi]    Script Date: 01/05/2017 15:28:34 ******/
ALTER TABLE [dbo].[OtelSecimi]  WITH CHECK ADD  CONSTRAINT [FK_OtelSecimi_YildizSayisi] FOREIGN KEY([YildizSayisiID])
REFERENCES [dbo].[YildizSayisi] ([YildizSayisiID])
GO
ALTER TABLE [dbo].[OtelSecimi] CHECK CONSTRAINT [FK_OtelSecimi_YildizSayisi]
GO
