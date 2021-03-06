/****** Object:  ForeignKey [FK_OrderItem_Order]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem] DROP CONSTRAINT [FK_OrderItem_Order]
GO
/****** Object:  ForeignKey [FK_OrderItem_OrderItem]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_OrderItem]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem] DROP CONSTRAINT [FK_OrderItem_OrderItem]
GO
/****** Object:  StoredProcedure [dbo].[Order_Delete]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order_Delete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Order_Delete]
GO
/****** Object:  StoredProcedure [dbo].[OrderItem_AddOrUpdate]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItem_AddOrUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[OrderItem_AddOrUpdate]
GO
/****** Object:  StoredProcedure [dbo].[OrderItem_Remove]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItem_Remove]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[OrderItem_Remove]
GO
/****** Object:  StoredProcedure [dbo].[OrderItem_Select]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItem_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[OrderItem_Select]
GO
/****** Object:  StoredProcedure [dbo].[Order_Select]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Order_Select]
GO
/****** Object:  StoredProcedure [dbo].[Order_Update]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order_Update]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Order_Update]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItem]') AND type in (N'U'))
DROP TABLE [dbo].[OrderItem]
GO
/****** Object:  StoredProcedure [dbo].[Order_Create]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order_Create]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Order_Create]
GO
/****** Object:  StoredProcedure [dbo].[Product_Select]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Product_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Product_Select]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Product]') AND type in (N'U'))
DROP TABLE [dbo].[Product]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order]') AND type in (N'U'))
DROP TABLE [dbo].[Order]
GO
/****** Object:  Default [DF_Order_UserIP]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_UserIP]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_UserIP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] DROP CONSTRAINT [DF_Order_UserIP]
END


End
GO
/****** Object:  Default [DF_Order_OrderedOn]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_OrderedOn]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_OrderedOn]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] DROP CONSTRAINT [DF_Order_OrderedOn]
END


End
GO
/****** Object:  Default [DF_Order_CustomerName]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_CustomerName]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_CustomerName]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] DROP CONSTRAINT [DF_Order_CustomerName]
END


End
GO
/****** Object:  Default [DF_Order_EmailAddress]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_EmailAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_EmailAddress]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] DROP CONSTRAINT [DF_Order_EmailAddress]
END


End
GO
/****** Object:  Default [DF_Order_ShippingAddress]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_ShippingAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_ShippingAddress]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] DROP CONSTRAINT [DF_Order_ShippingAddress]
END


End
GO
/****** Object:  Default [DF_Order_PhoneNumber]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_PhoneNumber]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_PhoneNumber]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] DROP CONSTRAINT [DF_Order_PhoneNumber]
END


End
GO
/****** Object:  Default [DF_OrderItem_quantity]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderItem_quantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_OrderItem_quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[OrderItem] DROP CONSTRAINT [DF_OrderItem_quantity]
END


End
GO
/****** Object:  Default [DF_item_name]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_item_name]') AND parent_object_id = OBJECT_ID(N'[dbo].[Product]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_item_name]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [DF_item_name]
END


End
GO
/****** Object:  Default [DF_item_price]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_item_price]') AND parent_object_id = OBJECT_ID(N'[dbo].[Product]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_item_price]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [DF_item_price]
END


End
GO
/****** Object:  Default [DF_item_description]    Script Date: 11/25/2014 19:13:36 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_item_description]') AND parent_object_id = OBJECT_ID(N'[dbo].[Product]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_item_description]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Product] DROP CONSTRAINT [DF_item_description]
END


End
GO
/****** Object:  Role [KCStoreUser]    Script Date: 11/25/2014 19:13:36 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'KCStoreUser')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'KCStoreUser' AND type = 'R')
CREATE ROLE [KCStoreUser]

END
GO
/****** Object:  Table [dbo].[Order]    Script Date: 11/25/2014 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Order](
	[UserIP] [nchar](16) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[OrderedOn] [date] NOT NULL,
	[CustomerName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[EmailAddress] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ShippingAddress] [nvarchar](256) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PhoneNumber] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Order] ON
INSERT [dbo].[Order] ([UserIP], [OrderedOn], [CustomerName], [EmailAddress], [ShippingAddress], [PhoneNumber], [id]) VALUES (N'::1             ', CAST(0x49390B00 AS Date), N'', N'', N'', N'', 109)
INSERT [dbo].[Order] ([UserIP], [OrderedOn], [CustomerName], [EmailAddress], [ShippingAddress], [PhoneNumber], [id]) VALUES (N'::1             ', CAST(0x49390B00 AS Date), N'Glenda Jones', N'glenda@alt.com', N'8765 Elm St NE', N'(206) 777-0099', 110)
INSERT [dbo].[Order] ([UserIP], [OrderedOn], [CustomerName], [EmailAddress], [ShippingAddress], [PhoneNumber], [id]) VALUES (N'::1             ', CAST(0x49390B00 AS Date), N'Dave Hallberg', N'dave@gmail.com', N'1232 4th Ave SW, Renton WA, 98144', N'(206) 367-8789', 111)
INSERT [dbo].[Order] ([UserIP], [OrderedOn], [CustomerName], [EmailAddress], [ShippingAddress], [PhoneNumber], [id]) VALUES (N'::1             ', CAST(0x49390B00 AS Date), N'Yuri Gregarin', N'YuriG@nasa.gov', N'896 Fern Way, Federal Way, WA', N'999.777.9999', 112)
SET IDENTITY_INSERT [dbo].[Order] OFF
/****** Object:  Table [dbo].[Product]    Script Date: 11/25/2014 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Product]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Product](
	[name] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[price] [decimal](10, 2) NOT NULL,
	[description] [nvarchar](512) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT [dbo].[Product] ([name], [price], [description], [id]) VALUES (N'Mekk Poggio', CAST(799.99 AS Decimal(10, 2)), N'Named after an ascent famed in Euro pro cycling lore and legend, the Mekk Poggio fully delivers on such lofty ambitions. At its core is a 3K Monocoque carbon frame for the ultimate in stiffness and lightweight while its classic geometry means you will have the perfect all-rounder to handle any route''s challenges with verve and panache.', 1)
INSERT [dbo].[Product] ([name], [price], [description], [id]) VALUES (N'Ciocc San Cristobal Frameset', CAST(1599.99 AS Decimal(10, 2)), N'Beautiful to look at, and amazing to ride, The Ciocc San Cristobal Frameset is made from Columbus double butted drawn tubing, with micro fused brazing, Silva rear dropouts and investment cast lugs.', 2)
INSERT [dbo].[Product] ([name], [price], [description], [id]) VALUES (N'Pearl Izumi Select Thermal Barrier Jacket', CAST(99.49 AS Decimal(10, 2)), N'Give the elements a kick with the Pearl Izumi Select Thermal Barrier cycling jacket. It has some light insulation to keep you warm on colder days, and the wind and water-resistant construction help keep the elements out so you can keep riding harder for longer.', 3)
INSERT [dbo].[Product] ([name], [price], [description], [id]) VALUES (N'Guerciotti Record Road Frameset', CAST(899.99 AS Decimal(10, 2)), N'Since the 1960s Guerciotti has been renowned and revered for their frame building prowess and they''ve provided a thoroughly modern take on steel with Dedacciai ZeroUno tubing throughout the Record.', 4)
INSERT [dbo].[Product] ([name], [price], [description], [id]) VALUES (N'Cannondale Metro Pants', CAST(69.99 AS Decimal(10, 2)), N'Cannondale Metro Pants got their name because they''re made to pull on over your street duds so you can get where you need to and be dry as a bone when you get there. With all taped seams you get 100% weather protection, 2 zip front pockets to protect your phone, wallet, sandwich...whatever. ', 5)
INSERT [dbo].[Product] ([name], [price], [description], [id]) VALUES (N'GT Avalanche', CAST(159.99 AS Decimal(10, 2)), N'TIG welded Triple Butted 6061 aluminum with a hydroformed downtube and toptube, so it''s light and very strong, and it''s got perfectly engineered cross-country/all mountain geometry so you can dominate all kinds of trails and up your game.', 6)
INSERT [dbo].[Product] ([name], [price], [description], [id]) VALUES (N'GORE BIKE WEAR Phantom 2.0 SO Jacket', CAST(119.99 AS Decimal(10, 2)), N'It''s tough to beat a softshell when it comes to all-weather comfort. And in that department, the Gore Bike Wear Phantom 2.0 SO cycling jacket wins by a TKO. It''s made with Gore''s own windstopper fabric to give you the ultimate in 4-seaon comfort. ', 7)
INSERT [dbo].[Product] ([name], [price], [description], [id]) VALUES (N'Nashbar Brunswick Rain Jacket', CAST(1599.99 AS Decimal(10, 2)), N'Want an awesome rain jacket without shelling out a lotta dough? Check out the Brunswick. It''s made with a 2-layer, breathable design and sealed seams for complete waterproof protection.', 8)
SET IDENTITY_INSERT [dbo].[Product] OFF
/****** Object:  StoredProcedure [dbo].[Product_Select]    Script Date: 11/25/2014 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Product_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Product_Select]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   SELECT [name]
      ,[price]
      ,[id]
      ,[description]
  FROM [KCStore].[dbo].[Product]
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Order_Create]    Script Date: 11/25/2014 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order_Create]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Create a shell of an order.  This is called when the user first adds
-- an item to the cart. 
-- =============================================
CREATE PROCEDURE [dbo].[Order_Create] 
	-- Add the parameters for the stored procedure here
	@ipAddress nchar(16)
AS
BEGIN
	SET NOCOUNT ON;

   INSERT INTO [KCStore].[dbo].[Order]
           ([UserIP])
     VALUES
           (@ipAddress)

SELECT CAST (SCOPE_IDENTITY() AS INT)
END
' 
END
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 11/25/2014 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[OrderItem](
	[quantity] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[orderID] [int] NOT NULL,
	[productID] [int] NOT NULL,
 CONSTRAINT [PK_OrderItem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[OrderItem] ON
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 177, 109, 3)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 178, 109, 8)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 179, 110, 8)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 180, 110, 7)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 181, 110, 6)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 182, 110, 5)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 183, 110, 3)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 184, 110, 2)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 185, 110, 1)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (2, 186, 111, 4)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 187, 111, 8)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 188, 112, 2)
INSERT [dbo].[OrderItem] ([quantity], [id], [orderID], [productID]) VALUES (1, 189, 112, 1)
SET IDENTITY_INSERT [dbo].[OrderItem] OFF
/****** Object:  StoredProcedure [dbo].[Order_Update]    Script Date: 11/25/2014 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order_Update]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'


CREATE PROCEDURE [dbo].[Order_Update]
	-- Add the parameters for the stored procedure here
	@orderID int,
	@customerName nvarchar(50), 
	@emailAddress nvarchar(256),
	@shippingAddress nvarchar(256),
	@phoneNumber nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    UPDATE [KCStore].[dbo].[Order]
   SET [OrderedOn] = GETDATE()
      ,[CustomerName] = @customerName
      ,[EmailAddress] = @emailAddress
      ,[ShippingAddress] = @shippingAddress
      ,[PhoneNumber] = @phoneNumber
      
 WHERE [id] = @orderID
 
 SELECT @@IDENTITY 

END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[Order_Select]    Script Date: 11/25/2014 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'


CREATE PROCEDURE [dbo].[Order_Select]
	@orderID int 
AS
BEGIN
	SET NOCOUNT ON;

SELECT [UserIP]
      ,[OrderedOn]
      ,[CustomerName]
      ,[EmailAddress]
      ,[ShippingAddress]
      ,[PhoneNumber]
      ,[id]
  FROM [KCStore].[dbo].[Order]
  WHERE id = @orderID


END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[OrderItem_Select]    Script Date: 11/25/2014 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItem_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[OrderItem_Select] 
	@orderID int
AS
BEGIN
	SET NOCOUNT ON;

   SELECT ordItem.[quantity]
      ,ordItem.[id]
      ,ordItem.[orderID]
      ,ordItem.[productID],
      prod.name as ''productName'',
      prod.price as ''price''
      
  FROM [KCStore].[dbo].[OrderItem] ordItem, 
		[KCStore].[dbo].[Product] prod
  WHERE ordItem.orderID = @orderID
		AND prod.id = ordItem.productID


END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[OrderItem_Remove]    Script Date: 11/25/2014 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItem_Remove]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[OrderItem_Remove]

	@productID int,
	@orderID int
AS
BEGIN
	SET NOCOUNT ON;
	
	DELETE FROM [KCStore].[dbo].[OrderItem]
	WHERE  [productID] = @productID
     AND [orderID] = @orderID

	SELECT SCOPE_IDENTITY()

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[OrderItem_AddOrUpdate]    Script Date: 11/25/2014 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[OrderItem_AddOrUpdate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

/*
EXEC OrderItem_AddOrUpdate 2, 1, 12
*/
CREATE PROCEDURE [dbo].[OrderItem_AddOrUpdate]
	@productID int,
	@quantity int,
	@orderID int
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE [KCStore].[dbo].[OrderItem]
	SET [productID] = @productID,
		[quantity] =  @quantity,
		[orderID] = @orderID
     
	WHERE [KCStore].[dbo].[OrderItem].productID = @productID
	AND [KCStore].[dbo].[OrderItem].orderID = @orderID
	


	IF @@ROWCOUNT=0
	BEGIN
		INSERT INTO [KCStore].[dbo].[OrderItem]
			   ([productID]
			   ,[quantity]
			   ,[orderID] )
	          
		 VALUES
			  ( @productID
			   ,@quantity
			   ,@orderID)
	
				   
	END

	SELECT CAST(SCOPE_IDENTITY() AS INT)

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Order_Delete]    Script Date: 11/25/2014 19:13:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Order_Delete]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[Order_Delete]
	@ID INT
AS
BEGIN

   DELETE FROM [KCStore].[dbo].[OrderItem]
      WHERE orderID = @ID

	DELETE FROM [KCStore].[dbo].[Order]
      WHERE ID = @ID

END
' 
END
GO
/****** Object:  Default [DF_Order_UserIP]    Script Date: 11/25/2014 19:13:36 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_UserIP]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_UserIP]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_UserIP]  DEFAULT ('') FOR [UserIP]
END


End
GO
/****** Object:  Default [DF_Order_OrderedOn]    Script Date: 11/25/2014 19:13:36 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_OrderedOn]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_OrderedOn]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_OrderedOn]  DEFAULT (getdate()) FOR [OrderedOn]
END


End
GO
/****** Object:  Default [DF_Order_CustomerName]    Script Date: 11/25/2014 19:13:36 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_CustomerName]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_CustomerName]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_CustomerName]  DEFAULT ('') FOR [CustomerName]
END


End
GO
/****** Object:  Default [DF_Order_EmailAddress]    Script Date: 11/25/2014 19:13:36 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_EmailAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_EmailAddress]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_EmailAddress]  DEFAULT ('') FOR [EmailAddress]
END


End
GO
/****** Object:  Default [DF_Order_ShippingAddress]    Script Date: 11/25/2014 19:13:36 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_ShippingAddress]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_ShippingAddress]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_ShippingAddress]  DEFAULT ('') FOR [ShippingAddress]
END


End
GO
/****** Object:  Default [DF_Order_PhoneNumber]    Script Date: 11/25/2014 19:13:36 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Order_PhoneNumber]') AND parent_object_id = OBJECT_ID(N'[dbo].[Order]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Order_PhoneNumber]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Order] ADD  CONSTRAINT [DF_Order_PhoneNumber]  DEFAULT ('') FOR [PhoneNumber]
END


End
GO
/****** Object:  Default [DF_OrderItem_quantity]    Script Date: 11/25/2014 19:13:36 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_OrderItem_quantity]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_OrderItem_quantity]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[OrderItem] ADD  CONSTRAINT [DF_OrderItem_quantity]  DEFAULT ((1)) FOR [quantity]
END


End
GO
/****** Object:  Default [DF_item_name]    Script Date: 11/25/2014 19:13:36 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_item_name]') AND parent_object_id = OBJECT_ID(N'[dbo].[Product]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_item_name]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_item_name]  DEFAULT ('') FOR [name]
END


End
GO
/****** Object:  Default [DF_item_price]    Script Date: 11/25/2014 19:13:36 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_item_price]') AND parent_object_id = OBJECT_ID(N'[dbo].[Product]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_item_price]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_item_price]  DEFAULT ((0)) FOR [price]
END


End
GO
/****** Object:  Default [DF_item_description]    Script Date: 11/25/2014 19:13:36 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_item_description]') AND parent_object_id = OBJECT_ID(N'[dbo].[Product]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_item_description]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_item_description]  DEFAULT ('') FOR [description]
END


End
GO
/****** Object:  ForeignKey [FK_OrderItem_Order]    Script Date: 11/25/2014 19:13:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY([orderID])
REFERENCES [dbo].[Order] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_Order]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Order]
GO
/****** Object:  ForeignKey [FK_OrderItem_OrderItem]    Script Date: 11/25/2014 19:13:36 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_OrderItem]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_OrderItem] FOREIGN KEY([productID])
REFERENCES [dbo].[Product] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_OrderItem_OrderItem]') AND parent_object_id = OBJECT_ID(N'[dbo].[OrderItem]'))
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_OrderItem]
GO
