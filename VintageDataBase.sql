USE [1950sWardrobe]
GO
/****** Object:  Table [dbo].[AccessTable]    Script Date: 11/7/2017 1:49:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccessTable](
	[AccessoriesID] [int] IDENTITY(1,1) NOT NULL,
	[AccessName] [varchar](50) NOT NULL,
	[AccessPhoto] [nvarchar](50) NOT NULL,
	[AccessType] [varchar](50) NOT NULL,
	[AccessColor] [varchar](50) NOT NULL,
	[AccessSeason] [varchar](50) NOT NULL,
	[AccessOccasion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AccessTable] PRIMARY KEY CLUSTERED 
(
	[AccessoriesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BottomsTable]    Script Date: 11/7/2017 1:49:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BottomsTable](
	[BottomsID] [int] IDENTITY(1,1) NOT NULL,
	[BottomsName] [varchar](50) NOT NULL,
	[BottomsPhoto] [nvarchar](50) NOT NULL,
	[BottomsType] [varchar](50) NOT NULL,
	[BottomsColor] [varchar](50) NOT NULL,
	[BottomsSeason] [varchar](50) NOT NULL,
	[BottomsOccasion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_BottomsTable] PRIMARY KEY CLUSTERED 
(
	[BottomsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DressesTable]    Script Date: 11/7/2017 1:49:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DressesTable](
	[DressesID] [int] IDENTITY(1,1) NOT NULL,
	[DressesName] [varchar](50) NOT NULL,
	[DressesPhoto] [nvarchar](50) NOT NULL,
	[DressesType] [varchar](50) NOT NULL,
	[DressesColor] [varchar](50) NOT NULL,
	[DressesSeason] [varchar](50) NOT NULL,
	[DressesOccasion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DressesTable] PRIMARY KEY CLUSTERED 
(
	[DressesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ShoesTable]    Script Date: 11/7/2017 1:49:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ShoesTable](
	[ShoesID] [int] IDENTITY(1,1) NOT NULL,
	[ShoesName] [varchar](50) NOT NULL,
	[ShoesPhoto] [nvarchar](50) NOT NULL,
	[ShoesType] [varchar](50) NOT NULL,
	[ShoesColor] [varchar](50) NOT NULL,
	[ShoesSeason] [varchar](50) NOT NULL,
	[ShoesOccasion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ShoesTable] PRIMARY KEY CLUSTERED 
(
	[ShoesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SwimTable]    Script Date: 11/7/2017 1:49:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SwimTable](
	[SwimID] [int] IDENTITY(1,1) NOT NULL,
	[SwimName] [varchar](50) NOT NULL,
	[SwimPhoto] [nvarchar](50) NOT NULL,
	[SwimType] [varchar](50) NULL,
	[SwimColor] [varchar](50) NOT NULL,
	[SwimSeason] [varchar](50) NOT NULL,
	[SwimOccasion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SwimTable] PRIMARY KEY CLUSTERED 
(
	[SwimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TopsTable]    Script Date: 11/7/2017 1:49:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TopsTable](
	[TopsID] [int] IDENTITY(1,1) NOT NULL,
	[TopsName] [varchar](50) NOT NULL,
	[TopsPhoto] [nvarchar](50) NOT NULL,
	[TopsType] [varchar](50) NOT NULL,
	[TopsColor] [varchar](50) NOT NULL,
	[TopsSeason] [varchar](50) NOT NULL,
	[TopsOccasion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TopsTable] PRIMARY KEY CLUSTERED 
(
	[TopsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
