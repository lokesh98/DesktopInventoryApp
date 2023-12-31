USE [BrodwayJuly]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/9/2023 11:19:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NULL,
	[CategoryDesc] [varchar](100) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/9/2023 11:19:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Price] [decimal](18, 2) NULL,
	[Quantity] [int] NULL,
	[CategoryID] [int] NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 7/9/2023 11:19:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserRoles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](50) NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 7/9/2023 11:19:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserTable](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](60) NOT NULL,
	[UserRole] [varchar](20) NULL,
	[Address] [varchar](70) NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_UserTable] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDesc]) VALUES (1, N'TV', N'Samsung TV')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDesc]) VALUES (2, N'Mobile', NULL)
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDesc]) VALUES (3, N'T-shirts', N'T-shirts')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [Name], [Price], [Quantity], [CategoryID], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (1, N'22'' TV', CAST(1000.00 AS Decimal(18, 2)), 2, 1, 1, CAST(N'2023-07-09 00:00:00.000' AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [Name], [Price], [Quantity], [CategoryID], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (3, N'gionee s6', CAST(20000.00 AS Decimal(18, 2)), 2, 2, 1, CAST(N'2023-07-09 11:12:04.037' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[UserRoles] ON 

INSERT [dbo].[UserRoles] ([RoleID], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[UserRoles] ([RoleID], [RoleName]) VALUES (2, N'Maker')
INSERT [dbo].[UserRoles] ([RoleID], [RoleName]) VALUES (3, N'Checker')
SET IDENTITY_INSERT [dbo].[UserRoles] OFF
SET IDENTITY_INSERT [dbo].[UserTable] ON 

INSERT [dbo].[UserTable] ([UserID], [FirstName], [LastName], [Email], [UserRole], [Address], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (1, N'Rohit', N'Poudel', N'rohit@gmail.com', N'Maker', N'Kathmandu', 1, CAST(N'2023-07-02 00:00:00.000' AS DateTime), 1, CAST(N'2023-07-07 10:52:38.663' AS DateTime))
INSERT [dbo].[UserTable] ([UserID], [FirstName], [LastName], [Email], [UserRole], [Address], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (6, N'SABIN', N'SHRESTHA', N'rohit@gmail.com', N'Checker', N'test222', 2, CAST(N'2023-07-03 10:53:36.440' AS DateTime), 1, CAST(N'2023-07-04 10:57:29.930' AS DateTime))
INSERT [dbo].[UserTable] ([UserID], [FirstName], [LastName], [Email], [UserRole], [Address], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (8, N'test ', N'user 5', N'someone@yahoo.com', N'Maker', N'ktm', 1, CAST(N'2023-07-04 10:58:46.270' AS DateTime), NULL, NULL)
INSERT [dbo].[UserTable] ([UserID], [FirstName], [LastName], [Email], [UserRole], [Address], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (9, N'bhim', N'bhatta', N'testuser@gmail.com', N'Maker', N'pokhara', 0, CAST(N'2023-07-07 11:01:31.930' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[UserTable] OFF
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Category]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllProducts]    Script Date: 7/9/2023 11:19:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetAllProducts]
AS
BEGIN
		SELECT p.ProductID, p.Name, p.Price, p.Quantity, p.CategoryID,
		c.CategoryName FROM Products AS p 
		INNER JOIN Category AS c
		ON p.CategoryID = c.CategoryID
END


GO
/****** Object:  StoredProcedure [dbo].[sp_SaveProducts]    Script Date: 7/9/2023 11:19:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SaveProducts]
(
	@Name			VARCHAR(50),
	@Quantity		INT,
	@Price			DECIMAL(18,2),
	@CategoryID		INT,
	@CreatedBy		INT
)
AS
BEGIN
	INSERT INTO Products(Name,Price, Quantity, CategoryID, CreatedBy, CreatedDate)
				VALUES(@Name,@Price,@Quantity, @CategoryID, @CreatedBy, GETDATE())

END
GO
