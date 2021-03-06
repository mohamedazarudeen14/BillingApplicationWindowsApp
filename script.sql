USE [Store_Billing]
GO
/****** Object:  Table [dbo].[AdminDetails]    Script Date: 12/29/19 05:25:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdminName] [nvarchar](50) NOT NULL,
	[UserId] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Last LoggedIn Time] [datetime] NULL,
	[Last LoggedOut Time] [datetime] NULL,
 CONSTRAINT [PK_AdminDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CashierDetails]    Script Date: 12/29/19 05:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CashierDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CashierName] [nvarchar](50) NOT NULL,
	[CashierID] [int] NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[MobileNumber] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Last LoggedIn Time] [datetime] NULL,
	[Last LoggedOut Time] [datetime] NULL,
 CONSTRAINT [PK_CashierDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesDetails]    Script Date: 12/29/19 05:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesDetails](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[BillNos] [bigint] NOT NULL,
	[TotalBillAmount] [money] NOT NULL,
	[TotalCostPrice] [money] NOT NULL,
	[ProfitAmount] [money] NOT NULL,
	[SalesDate] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SalesDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockDetails]    Script Date: 12/29/19 05:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockDetails](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[QuantityAvailable] [bigint] NOT NULL,
	[BuyingPrice] [money] NOT NULL,
	[MRP] [money] NOT NULL,
	[SellingPrice] [money] NOT NULL,
	[ProductDescription] [nvarchar](50) NULL,
 CONSTRAINT [PK_StockDetails_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AdminDetails] ON 

INSERT [dbo].[AdminDetails] ([Id], [AdminName], [UserId], [Password], [Last LoggedIn Time], [Last LoggedOut Time]) VALUES (1, N'Azar', N'111', N'MTEx', CAST(N'2019-12-29T05:05:14.957' AS DateTime), CAST(N'2019-12-29T02:23:16.137' AS DateTime))
SET IDENTITY_INSERT [dbo].[AdminDetails] OFF
SET IDENTITY_INSERT [dbo].[CashierDetails] ON 

INSERT [dbo].[CashierDetails] ([Id], [CashierName], [CashierID], [Password], [MobileNumber], [IsActive], [Last LoggedIn Time], [Last LoggedOut Time]) VALUES (1, N'Azar', 100, N'MTAw', N'9944662192', 0, CAST(N'2019-12-29T04:19:13.650' AS DateTime), CAST(N'2019-12-29T04:19:14.527' AS DateTime))
SET IDENTITY_INSERT [dbo].[CashierDetails] OFF
