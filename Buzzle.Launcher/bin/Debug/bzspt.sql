USE [master]
GO

EXEC xp_instance_regwrite N'HKEY_LOCAL_MACHINE', N'Software\Microsoft\MSSQLServer\MSSQLServer', N'LoginMode', REG_DWORD, 2
GO

/****** Object:  Database [Buzzle]    Script Date: 05/21/2015 19:22:28 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'Buzzle')
BEGIN
 CREATE DATABASE [Buzzle]
END
GO

USE [Buzzle]
GO

CREATE LOGIN [Buzzle] WITH PASSWORD=N'b422l3', DEFAULT_DATABASE=[Buzzle], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

CREATE USER [Buzzle] FOR LOGIN [buzzle] 
GO

EXEC sp_addrolemember N'db_owner', N'Buzzle'

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[PassWord] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[DateCreated] [datetime] NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsAdministrator] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JobItemTypes]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobItemTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[JobItemTypes](
	[ItemTypeID] [int] NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[Notes] [nchar](10) NULL,
 CONSTRAINT [PK_ItemTypes] PRIMARY KEY CLUSTERED 
(
	[ItemTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FaultTypes]    Script Date: 05/21/2015 19:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FaultTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FaultTypes](
	[FaultTypeID] [int] IDENTITY(1,1) NOT NULL,
	[FaultName] [varchar](50) NOT NULL,
	[Notes] [varchar](max) NULL,
 CONSTRAINT [PK_FaultTypes] PRIMARY KEY CLUSTERED 
(
	[FaultTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Jobs]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Jobs](
	[JobID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[ItemTypeID] [int] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[Notes] [varchar](max) NULL,
	[ItemDescription] [varchar](max) NULL,
	[FaultTypeID] [int] NOT NULL,
	[FaultDescription] [varchar](max) NULL,
	[CustomerPhoneNumber] [int] NULL,
	[IsPaid] [bit] NOT NULL,
	[IsCollected] [bit] NOT NULL,
	[IsFixed] [bit] NOT NULL,
	[IsCancel] [bit] NOT NULL,
	[CreatorUserID] [int] NOT NULL,
 CONSTRAINT [PK_RepairJobs] PRIMARY KEY CLUSTERED 
(
	[JobID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 05/21/2015 19:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Accounts]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[AccountName] [varchar](50) NOT NULL,
	[Description] [varchar](max) NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON
INSERT [dbo].[Accounts] ([AccountID], [AccountName], [Description]) VALUES (3, N'Sales Account', NULL)
SET IDENTITY_INSERT [dbo].[Accounts] OFF
/****** Object:  Table [dbo].[TransactionTypes]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TransactionTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TransactionTypes](
	[TransactionTypeID] [int] IDENTITY(1,1) NOT NULL,
	[TransactionName] [varchar](50) NOT NULL,
	[DeductionAccountID] [int] NULL,
	[IncreasingAccountID] [int] NULL,
 CONSTRAINT [PK_TransactionTypes] PRIMARY KEY CLUSTERED 
(
	[TransactionTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TransactionTypes] ON
INSERT [dbo].[TransactionTypes] ([TransactionTypeID], [TransactionName], [DeductionAccountID], [IncreasingAccountID]) VALUES (1, N'New Sale', NULL, 3)
SET IDENTITY_INSERT [dbo].[TransactionTypes] OFF
/****** Object:  Table [dbo].[Transactions]    Script Date: 05/21/2015 19:22:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Transactions]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Transactions](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[TransactionTypeID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Notes] [varchar](max) NULL,
	[RecordedByUserID] [int] NULL,
	[DateRecorded] [datetime] NOT NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JobPayments]    Script Date: 05/21/2015 19:22:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobPayments]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[JobPayments](
	[JobID] [int] NOT NULL,
	[TransactionID] [int] NOT NULL,
	[Notes] [varchar](max) NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[GetJobPaymentAmount]    Script Date: 05/21/2015 19:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetJobPaymentAmount]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE Procedure [dbo].[GetJobPaymentAmount] 
@JobID int 
AS
Begin
declare @TotalAmount int = 0

Select @TotalAmount = SUM(Amount) from JobPayments Join Transactions 
on JobPayments.TransactionID = Transactions.TransactionID
where JobID = @JobID

Select IsNull(@TotalAmount, 0)
End' 
END
GO
/****** Object:  Table [dbo].[AccountPostings]    Script Date: 05/21/2015 19:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AccountPostings]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AccountPostings](
	[PostingID] [int] IDENTITY(1,1) NOT NULL,
	[TransactionID] [int] NOT NULL,
	[AccountID] [int] NOT NULL,
	[PostingType] [int] NOT NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_AccountPostings] PRIMARY KEY CLUSTERED 
(
	[PostingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  View [dbo].[AccountStats]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[AccountStats]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[AccountStats]
AS
SELECT     acc.AccountID, acc.AccountName, SUM(ap.Amount * ap.PostingType) AS amount
FROM         dbo.AccountPostings AS ap INNER JOIN
                      dbo.Accounts AS acc ON ap.AccountID = acc.AccountID
GROUP BY acc.AccountName, acc.AccountID
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'AccountStats', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[16] 2[25] 3) )"
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
         Begin Table = "ap"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 245
               Right = 264
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "acc"
            Begin Extent = 
               Top = 21
               Left = 306
               Bottom = 254
               Right = 645
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
      Begin ColumnWidths = 12
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AccountStats'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'AccountStats', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AccountStats'
GO
/****** Object:  Table [dbo].[Company]    Script Date: 05/21/2015 19:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Company]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Company](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](150) NOT NULL,
	[CompanyLogo] [varbinary](max) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BuzzleSettings]    Script Date: 05/21/2015 19:22:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BuzzleSettings]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BuzzleSettings](
	[SettingName] [varchar](50) NOT NULL,
	[SettingValue] [varchar](50) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BuzzleSettings] ([SettingName], [SettingValue]) VALUES (N'SalesTransactionTypeID', N'1')
/****** Object:  Table [dbo].[LookupData]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LookupData]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LookupData](
	[TableNumber] [tinyint] NOT NULL,
	[TableData] [varchar](50) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StockItemTypes]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockItemTypes]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StockItemTypes](
	[StockItemTypeID] [int] IDENTITY(1,1) NOT NULL,
	[StockItemName] [varchar](50) NOT NULL,
	[UnitSellingPrice] [int] NOT NULL,
	[Notes] [varchar](max) NULL,
	[Model] [varchar](50) NULL,
	[UnitPurchasePrice] [int] NULL,
 CONSTRAINT [PK_StockItems] PRIMARY KEY CLUSTERED 
(
	[StockItemTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Trigger [AFTER_NEW_TRANSACTION_ENTERED]    Script Date: 05/21/2015 19:22:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[AFTER_NEW_TRANSACTION_ENTERED]'))
EXEC dbo.sp_executesql @statement = N'CREATE TRIGGER [dbo].[AFTER_NEW_TRANSACTION_ENTERED]
ON [dbo].[Transactions]
AFTER INSERT
AS
BEGIN TRANSACTION
SET NOCOUNT ON

--DECLARE VARIABLES TO HOLD THE INSERTED DATA SO WE CAN REUSE IT
DECLARE @transactionID INT 
DECLARE @transactionTypeID INT
DECLARE @amount INT
DECLARE @notes VARCHAR(MAX)= ''No notes provided''

--DECLARE NEW VARIABLES TO BE USED IN OTHER INSERT STATEMENTS
DECLARE @deductAccountID INT = NULL
DECLARE @incrementAccountID INT = NULL
DECLARE @postingType_increment INT = 1
DECLARE @postingType_decrement INT = -1

--GET ALL INSERTED INFO INTO OUR DECLARED VARIABLES
SELECT 
@transactionID = TransactionID,
@transactionTypeID = TransactionTypeID,
@amount = Amount,
@notes = Notes
FROM INSERTED

--GET ID''S OF ACCOUTS INVOLVED WITH THE TRANSACTION
SELECT 
@deductAccountID = DeductionAccountID, 
@incrementAccountID = IncreasingAccountID 
FROM dbo.TransactionTypes 
WHERE TransactionTypeID = @transactionTypeID

--INSERT TWO POSTINGS INTO THE POSTING TABLE FOR THE 
--DECREMENT AND INCREMENT ACCOUNTS
IF @deductAccountID IS NOT NULL
INSERT INTO dbo.AccountPostings
        ( TransactionID ,
          AccountID ,
          PostingType,
          Amount
        )
VALUES  ( @transactionID,
          @deductAccountID,
          @postingType_decrement,          
          @amount
        )
        
IF @incrementAccountID IS NOT NULL      
INSERT INTO dbo.AccountPostings
        ( TransactionID ,
          AccountID ,
          PostingType,
          Amount
        )
VALUES  ( @transactionID,
          @incrementAccountID,
          @postingType_increment,
          @amount
        )

COMMIT TRANSACTION
'
GO
/****** Object:  Table [dbo].[StockItemMovements]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockItemMovements]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StockItemMovements](
	[MovementID] [int] IDENTITY(1,1) NOT NULL,
	[StockItemTypeID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[MovementType] [int] NOT NULL,
	[CalculatedValue]  AS ([Quantity]*[MovementType]),
	[Description] [varchar](max) NULL,
	[SerialNumber] [varchar](50) NULL,
	[UnitPurchasePrice] [int] NOT NULL,
	[MovementReason] [varchar](50) NOT NULL,
	[DateRecorded] [datetime] NULL,
 CONSTRAINT [PK_StockItemMovements] PRIMARY KEY CLUSTERED 
(
	[MovementID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Purchases]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Purchases]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Purchases](
	[PurchaseID] [int] IDENTITY(1,1) NOT NULL,
	[DateRecorded] [datetime] NOT NULL,
	[CreatedByUserID] [int] NOT NULL,
	[Status] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Purchases] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sales]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Sales](
	[SaleID] [bigint] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](50) NULL,
	[DateRecorded] [datetime] NULL,
	[RecordedByUserID] [int] NOT NULL,
	[CustomerDetails] [varchar](max) NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SaleItems]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SaleItems]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SaleItems](
	[SaleItemID] [bigint] IDENTITY(1,1) NOT NULL,
	[SaleID] [bigint] NOT NULL,
	[StockItemTypeID] [int] NOT NULL,
	[UnitSoldPrice] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[TotalSoldPrice]  AS ([UnitSoldPrice]*[Quantity]),
	[UnitPurchasePrice] [int] NOT NULL,
 CONSTRAINT [PK_SaleItems] PRIMARY KEY CLUSTERED 
(
	[SaleItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PurchaseItems]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PurchaseItems]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PurchaseItems](
	[PurchaseItemID] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [int] NOT NULL,
	[StockItemTypeID] [int] NOT NULL,
	[ProposedUnitPrice] [int] NOT NULL,
	[Notes] [varchar](max) NULL,
	[Quantity] [int] NOT NULL,
	[TotalProposedPrice]  AS ([ProposedUnitPrice]*[Quantity]),
	[IsSupplied] [bit] NOT NULL,
 CONSTRAINT [PK_PurchaseItems] PRIMARY KEY CLUSTERED 
(
	[PurchaseItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[JobHistories]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[JobHistories]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[JobHistories](
	[JobID] [int] NOT NULL,
	[HistoryNote] [varchar](max) NOT NULL,
	[DateInserted] [datetime] NOT NULL,
	[RecordedByUserID] [int] NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[FindSales]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FindSales]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'Create Procedure [dbo].[FindSales]
@StartDate DateTime = null,
@EndDate DateTime = null,
@RecordedByUserID int = null
AS
Begin
Select * from Sales where 
DateRecorded >= ISNULL(@StartDate, DateRecorded)AND
DateRecorded <= ISNULL(@EndDate, DateRecorded) AND
RecordedByUserID = ISNULL(@RecordedByUserID, RecordedByUserID)
End' 
END
GO
/****** Object:  View [dbo].[StockItemBalances]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[StockItemBalances]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[StockItemBalances]
AS
SELECT     SI.StockItemTypeID, SI.StockItemName, SI.Model, SM.SerialNumber, SM.UnitPurchasePrice, SI.UnitSellingPrice, SUM(SM.CalculatedValue) AS QuantityInStock
FROM         dbo.StockItemMovements AS SM INNER JOIN
                      dbo.StockItemTypes AS SI ON SM.StockItemTypeID = SI.StockItemTypeID
GROUP BY SI.StockItemTypeID, SI.StockItemName, SM.UnitPurchasePrice, SI.UnitSellingPrice, SM.SerialNumber, SI.Model
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'StockItemBalances', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[25] 4[38] 2[37] 3) )"
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
         Begin Table = "SM"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 193
               Right = 219
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "SI"
            Begin Extent = 
               Top = 6
               Left = 257
               Bottom = 126
               Right = 445
            End
            DisplayFlags = 280
            TopColumn = 3
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
      Begin ColumnWidths = 12
         Column = 1995
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StockItemBalances'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'StockItemBalances', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'StockItemBalances'
GO
/****** Object:  Table [dbo].[Supplies]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Supplies]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Supplies](
	[SupplyID] [int] IDENTITY(1,1) NOT NULL,
	[DateRecorded] [datetime] NOT NULL,
	[RecordedByUserID] [int] NOT NULL,
	[Notes] [varchar](max) NULL,
	[PurchaseID] [int] NOT NULL,
 CONSTRAINT [PK_Supplies] PRIMARY KEY CLUSTERED 
(
	[SupplyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SupplyItems]    Script Date: 05/21/2015 19:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SupplyItems]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SupplyItems](
	[SupplyItemID] [int] IDENTITY(1,1) NOT NULL,
	[SupplyID] [int] NOT NULL,
	[PurchaseItemID] [int] NOT NULL,
	[PurchasedUnitPrice] [int] NOT NULL,
	[PurchasedQuantity] [int] NOT NULL,
	[TotalSpent]  AS ([PurchasedUnitPrice]*[PurchasedQuantity]),
	[StockItemTypeID] [int] NOT NULL,
 CONSTRAINT [PK_SupplyItems] PRIMARY KEY CLUSTERED 
(
	[SupplyItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Trigger [AFTER_INSERT_SUPPLYITEM]    Script Date: 05/21/2015 19:22:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[dbo].[AFTER_INSERT_SUPPLYITEM]'))
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		Yusinyu Titus Nsami
-- Create date: February 22, 2015
-- =============================================
CREATE TRIGGER [dbo].[AFTER_INSERT_SUPPLYITEM]
ON [dbo].[SupplyItems]
AFTER INSERT 
AS
BEGIN TRANSACTION

INSERT INTO StockItemMovements (
StockItemTypeID,
Quantity,
MovementType,
UnitPurchasePrice,
MovementReason,
DateRecorded)

Select StockItemTypeID, PurchasedQuantity, 1, PurchasedUnitPrice, ''Incoming_Stock'', GETDATE() from inserted

COMMIT TRANSACTION
'
GO
/****** Object:  Default [DF_Transactions_DateRecorded]    Script Date: 05/21/2015 19:22:31 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Transactions_DateRecorded]') AND parent_object_id = OBJECT_ID(N'[dbo].[Transactions]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Transactions_DateRecorded]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Transactions] ADD  CONSTRAINT [DF_Transactions_DateRecorded]  DEFAULT (getdate()) FOR [DateRecorded]
END


End
GO
/****** Object:  Default [DF_Users_DateCreated]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Users_DateCreated]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Users_DateCreated]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
END


End
GO
/****** Object:  Default [DF_Users_IsDeleted]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Users_IsDeleted]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Users_IsDeleted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
END


End
GO
/****** Object:  Default [DF_Users_IsAdministrator]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Users_IsAdministrator]') AND parent_object_id = OBJECT_ID(N'[dbo].[Users]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Users_IsAdministrator]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsAdministrator]  DEFAULT ((0)) FOR [IsAdministrator]
END


End
GO
/****** Object:  Default [DF_Sales_DateRecorded]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Sales_DateRecorded]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Sales_DateRecorded]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Sales] ADD  CONSTRAINT [DF_Sales_DateRecorded]  DEFAULT (getdate()) FOR [DateRecorded]
END


End
GO
/****** Object:  Default [DF_RepairJobs_DateCreated]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_RepairJobs_DateCreated]') AND parent_object_id = OBJECT_ID(N'[dbo].[Jobs]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_RepairJobs_DateCreated]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Jobs] ADD  CONSTRAINT [DF_RepairJobs_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
END


End
GO
/****** Object:  Default [DF_Jobs_IsPaid]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Jobs_IsPaid]') AND parent_object_id = OBJECT_ID(N'[dbo].[Jobs]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Jobs_IsPaid]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Jobs] ADD  CONSTRAINT [DF_Jobs_IsPaid]  DEFAULT ((0)) FOR [IsPaid]
END


End
GO
/****** Object:  Default [DF_Jobs_IsCollected]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Jobs_IsCollected]') AND parent_object_id = OBJECT_ID(N'[dbo].[Jobs]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Jobs_IsCollected]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Jobs] ADD  CONSTRAINT [DF_Jobs_IsCollected]  DEFAULT ((0)) FOR [IsCollected]
END


End
GO
/****** Object:  Default [DF_Jobs_IsFixed]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Jobs_IsFixed]') AND parent_object_id = OBJECT_ID(N'[dbo].[Jobs]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Jobs_IsFixed]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Jobs] ADD  CONSTRAINT [DF_Jobs_IsFixed]  DEFAULT ((0)) FOR [IsFixed]
END


End
GO
/****** Object:  Default [DF_Jobs_IsCancel]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Jobs_IsCancel]') AND parent_object_id = OBJECT_ID(N'[dbo].[Jobs]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Jobs_IsCancel]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Jobs] ADD  CONSTRAINT [DF_Jobs_IsCancel]  DEFAULT ((0)) FOR [IsCancel]
END


End
GO
/****** Object:  Default [DF_Purchases_DateRecorded]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Purchases_DateRecorded]') AND parent_object_id = OBJECT_ID(N'[dbo].[Purchases]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Purchases_DateRecorded]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Purchases] ADD  CONSTRAINT [DF_Purchases_DateRecorded]  DEFAULT (getdate()) FOR [DateRecorded]
END


End
GO
/****** Object:  Default [DF_StockItemMovements_DateRecorded]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_StockItemMovements_DateRecorded]') AND parent_object_id = OBJECT_ID(N'[dbo].[StockItemMovements]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_StockItemMovements_DateRecorded]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[StockItemMovements] ADD  CONSTRAINT [DF_StockItemMovements_DateRecorded]  DEFAULT (getdate()) FOR [DateRecorded]
END


End
GO
/****** Object:  Default [DF_PurchaseItems_IsSupplied]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_PurchaseItems_IsSupplied]') AND parent_object_id = OBJECT_ID(N'[dbo].[PurchaseItems]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_PurchaseItems_IsSupplied]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[PurchaseItems] ADD  CONSTRAINT [DF_PurchaseItems_IsSupplied]  DEFAULT ((0)) FOR [IsSupplied]
END


End
GO
/****** Object:  Default [DF_JobHistories_DateInserted]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_JobHistories_DateInserted]') AND parent_object_id = OBJECT_ID(N'[dbo].[JobHistories]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_JobHistories_DateInserted]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[JobHistories] ADD  CONSTRAINT [DF_JobHistories_DateInserted]  DEFAULT (getdate()) FOR [DateInserted]
END


End
GO
/****** Object:  Default [DF_Supplies_SupplyDate]    Script Date: 05/21/2015 19:22:42 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Supplies_SupplyDate]') AND parent_object_id = OBJECT_ID(N'[dbo].[Supplies]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Supplies_SupplyDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Supplies] ADD  CONSTRAINT [DF_Supplies_SupplyDate]  DEFAULT (getdate()) FOR [DateRecorded]
END


End
GO
/****** Object:  ForeignKey [FK_JobPayments_Jobs]    Script Date: 05/21/2015 19:22:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JobPayments_Jobs]') AND parent_object_id = OBJECT_ID(N'[dbo].[JobPayments]'))
ALTER TABLE [dbo].[JobPayments]  WITH CHECK ADD  CONSTRAINT [FK_JobPayments_Jobs] FOREIGN KEY([JobID])
REFERENCES [dbo].[Jobs] ([JobID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JobPayments_Jobs]') AND parent_object_id = OBJECT_ID(N'[dbo].[JobPayments]'))
ALTER TABLE [dbo].[JobPayments] CHECK CONSTRAINT [FK_JobPayments_Jobs]
GO
/****** Object:  ForeignKey [FK_JobPayments_Transactions]    Script Date: 05/21/2015 19:22:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JobPayments_Transactions]') AND parent_object_id = OBJECT_ID(N'[dbo].[JobPayments]'))
ALTER TABLE [dbo].[JobPayments]  WITH CHECK ADD  CONSTRAINT [FK_JobPayments_Transactions] FOREIGN KEY([TransactionID])
REFERENCES [dbo].[Transactions] ([TransactionID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JobPayments_Transactions]') AND parent_object_id = OBJECT_ID(N'[dbo].[JobPayments]'))
ALTER TABLE [dbo].[JobPayments] CHECK CONSTRAINT [FK_JobPayments_Transactions]
GO
/****** Object:  ForeignKey [FK_Transactions_TransactionTypes]    Script Date: 05/21/2015 19:22:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Transactions_TransactionTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Transactions]'))
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_TransactionTypes] FOREIGN KEY([TransactionTypeID])
REFERENCES [dbo].[TransactionTypes] ([TransactionTypeID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Transactions_TransactionTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Transactions]'))
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_TransactionTypes]
GO
/****** Object:  ForeignKey [FK_Transactions_Users]    Script Date: 05/21/2015 19:22:31 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Transactions_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Transactions]'))
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Users] FOREIGN KEY([RecordedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Transactions_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Transactions]'))
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Users]
GO
/****** Object:  ForeignKey [FK_AccountPostings_Accounts]    Script Date: 05/21/2015 19:22:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AccountPostings_Accounts]') AND parent_object_id = OBJECT_ID(N'[dbo].[AccountPostings]'))
ALTER TABLE [dbo].[AccountPostings]  WITH CHECK ADD  CONSTRAINT [FK_AccountPostings_Accounts] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Accounts] ([AccountID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AccountPostings_Accounts]') AND parent_object_id = OBJECT_ID(N'[dbo].[AccountPostings]'))
ALTER TABLE [dbo].[AccountPostings] CHECK CONSTRAINT [FK_AccountPostings_Accounts]
GO
/****** Object:  ForeignKey [FK_AccountPostings_Transactions]    Script Date: 05/21/2015 19:22:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AccountPostings_Transactions]') AND parent_object_id = OBJECT_ID(N'[dbo].[AccountPostings]'))
ALTER TABLE [dbo].[AccountPostings]  WITH CHECK ADD  CONSTRAINT [FK_AccountPostings_Transactions] FOREIGN KEY([TransactionID])
REFERENCES [dbo].[Transactions] ([TransactionID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AccountPostings_Transactions]') AND parent_object_id = OBJECT_ID(N'[dbo].[AccountPostings]'))
ALTER TABLE [dbo].[AccountPostings] CHECK CONSTRAINT [FK_AccountPostings_Transactions]
GO
/****** Object:  ForeignKey [FK_TransactionTypes_Accounts]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TransactionTypes_Accounts]') AND parent_object_id = OBJECT_ID(N'[dbo].[TransactionTypes]'))
ALTER TABLE [dbo].[TransactionTypes]  WITH CHECK ADD  CONSTRAINT [FK_TransactionTypes_Accounts] FOREIGN KEY([DeductionAccountID])
REFERENCES [dbo].[Accounts] ([AccountID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TransactionTypes_Accounts]') AND parent_object_id = OBJECT_ID(N'[dbo].[TransactionTypes]'))
ALTER TABLE [dbo].[TransactionTypes] CHECK CONSTRAINT [FK_TransactionTypes_Accounts]
GO
/****** Object:  ForeignKey [FK_TransactionTypes_Accounts1]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TransactionTypes_Accounts1]') AND parent_object_id = OBJECT_ID(N'[dbo].[TransactionTypes]'))
ALTER TABLE [dbo].[TransactionTypes]  WITH CHECK ADD  CONSTRAINT [FK_TransactionTypes_Accounts1] FOREIGN KEY([IncreasingAccountID])
REFERENCES [dbo].[Accounts] ([AccountID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_TransactionTypes_Accounts1]') AND parent_object_id = OBJECT_ID(N'[dbo].[TransactionTypes]'))
ALTER TABLE [dbo].[TransactionTypes] CHECK CONSTRAINT [FK_TransactionTypes_Accounts1]
GO
/****** Object:  ForeignKey [FK_Sales_Users]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_Sales_Users] FOREIGN KEY([RecordedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Sales_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Sales]'))
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_Sales_Users]
GO
/****** Object:  ForeignKey [FK_Jobs_FaultTypes]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Jobs_FaultTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Jobs]'))
ALTER TABLE [dbo].[Jobs]  WITH CHECK ADD  CONSTRAINT [FK_Jobs_FaultTypes] FOREIGN KEY([FaultTypeID])
REFERENCES [dbo].[FaultTypes] ([FaultTypeID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Jobs_FaultTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Jobs]'))
ALTER TABLE [dbo].[Jobs] CHECK CONSTRAINT [FK_Jobs_FaultTypes]
GO
/****** Object:  ForeignKey [FK_Jobs_ItemTypes]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Jobs_ItemTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Jobs]'))
ALTER TABLE [dbo].[Jobs]  WITH CHECK ADD  CONSTRAINT [FK_Jobs_ItemTypes] FOREIGN KEY([ItemTypeID])
REFERENCES [dbo].[JobItemTypes] ([ItemTypeID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Jobs_ItemTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[Jobs]'))
ALTER TABLE [dbo].[Jobs] CHECK CONSTRAINT [FK_Jobs_ItemTypes]
GO
/****** Object:  ForeignKey [FK_Jobs_Users]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Jobs_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Jobs]'))
ALTER TABLE [dbo].[Jobs]  WITH CHECK ADD  CONSTRAINT [FK_Jobs_Users] FOREIGN KEY([CreatorUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Jobs_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Jobs]'))
ALTER TABLE [dbo].[Jobs] CHECK CONSTRAINT [FK_Jobs_Users]
GO
/****** Object:  ForeignKey [FK_Purchases_Users]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Purchases_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Purchases]'))
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_Purchases_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Purchases_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Purchases]'))
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_Purchases_Users]
GO
/****** Object:  ForeignKey [FK_StockItemMovements_StockItems]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StockItemMovements_StockItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[StockItemMovements]'))
ALTER TABLE [dbo].[StockItemMovements]  WITH CHECK ADD  CONSTRAINT [FK_StockItemMovements_StockItems] FOREIGN KEY([StockItemTypeID])
REFERENCES [dbo].[StockItemTypes] ([StockItemTypeID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StockItemMovements_StockItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[StockItemMovements]'))
ALTER TABLE [dbo].[StockItemMovements] CHECK CONSTRAINT [FK_StockItemMovements_StockItems]
GO
/****** Object:  ForeignKey [FK_PurchaseItems_Purchases]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PurchaseItems_Purchases]') AND parent_object_id = OBJECT_ID(N'[dbo].[PurchaseItems]'))
ALTER TABLE [dbo].[PurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseItems_Purchases] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[Purchases] ([PurchaseID])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PurchaseItems_Purchases]') AND parent_object_id = OBJECT_ID(N'[dbo].[PurchaseItems]'))
ALTER TABLE [dbo].[PurchaseItems] CHECK CONSTRAINT [FK_PurchaseItems_Purchases]
GO
/****** Object:  ForeignKey [FK_PurchaseItems_StockItemTypes]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PurchaseItems_StockItemTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[PurchaseItems]'))
ALTER TABLE [dbo].[PurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseItems_StockItemTypes] FOREIGN KEY([StockItemTypeID])
REFERENCES [dbo].[StockItemTypes] ([StockItemTypeID])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PurchaseItems_StockItemTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[PurchaseItems]'))
ALTER TABLE [dbo].[PurchaseItems] CHECK CONSTRAINT [FK_PurchaseItems_StockItemTypes]
GO
/****** Object:  ForeignKey [FK_JobHistories_RepairJobs]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JobHistories_RepairJobs]') AND parent_object_id = OBJECT_ID(N'[dbo].[JobHistories]'))
ALTER TABLE [dbo].[JobHistories]  WITH CHECK ADD  CONSTRAINT [FK_JobHistories_RepairJobs] FOREIGN KEY([JobID])
REFERENCES [dbo].[Jobs] ([JobID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JobHistories_RepairJobs]') AND parent_object_id = OBJECT_ID(N'[dbo].[JobHistories]'))
ALTER TABLE [dbo].[JobHistories] CHECK CONSTRAINT [FK_JobHistories_RepairJobs]
GO
/****** Object:  ForeignKey [FK_JobHistories_Users]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JobHistories_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[JobHistories]'))
ALTER TABLE [dbo].[JobHistories]  WITH CHECK ADD  CONSTRAINT [FK_JobHistories_Users] FOREIGN KEY([RecordedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_JobHistories_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[JobHistories]'))
ALTER TABLE [dbo].[JobHistories] CHECK CONSTRAINT [FK_JobHistories_Users]
GO
/****** Object:  ForeignKey [FK_Supplies_Purchases]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Supplies_Purchases]') AND parent_object_id = OBJECT_ID(N'[dbo].[Supplies]'))
ALTER TABLE [dbo].[Supplies]  WITH CHECK ADD  CONSTRAINT [FK_Supplies_Purchases] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[Purchases] ([PurchaseID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Supplies_Purchases]') AND parent_object_id = OBJECT_ID(N'[dbo].[Supplies]'))
ALTER TABLE [dbo].[Supplies] CHECK CONSTRAINT [FK_Supplies_Purchases]
GO
/****** Object:  ForeignKey [FK_Supplies_Users]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Supplies_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Supplies]'))
ALTER TABLE [dbo].[Supplies]  WITH CHECK ADD  CONSTRAINT [FK_Supplies_Users] FOREIGN KEY([RecordedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Supplies_Users]') AND parent_object_id = OBJECT_ID(N'[dbo].[Supplies]'))
ALTER TABLE [dbo].[Supplies] CHECK CONSTRAINT [FK_Supplies_Users]
GO
/****** Object:  ForeignKey [FK_SaleItems_Sales]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleItems_Sales]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleItems]'))
ALTER TABLE [dbo].[SaleItems]  WITH CHECK ADD  CONSTRAINT [FK_SaleItems_Sales] FOREIGN KEY([SaleID])
REFERENCES [dbo].[Sales] ([SaleID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleItems_Sales]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleItems]'))
ALTER TABLE [dbo].[SaleItems] CHECK CONSTRAINT [FK_SaleItems_Sales]
GO
/****** Object:  ForeignKey [FK_SaleItems_StockItems]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleItems_StockItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleItems]'))
ALTER TABLE [dbo].[SaleItems]  WITH CHECK ADD  CONSTRAINT [FK_SaleItems_StockItems] FOREIGN KEY([StockItemTypeID])
REFERENCES [dbo].[StockItemTypes] ([StockItemTypeID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SaleItems_StockItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[SaleItems]'))
ALTER TABLE [dbo].[SaleItems] CHECK CONSTRAINT [FK_SaleItems_StockItems]
GO
/****** Object:  ForeignKey [FK_SupplyItems_PurchaseItems]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SupplyItems_PurchaseItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[SupplyItems]'))
ALTER TABLE [dbo].[SupplyItems]  WITH CHECK ADD  CONSTRAINT [FK_SupplyItems_PurchaseItems] FOREIGN KEY([PurchaseItemID])
REFERENCES [dbo].[PurchaseItems] ([PurchaseItemID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SupplyItems_PurchaseItems]') AND parent_object_id = OBJECT_ID(N'[dbo].[SupplyItems]'))
ALTER TABLE [dbo].[SupplyItems] CHECK CONSTRAINT [FK_SupplyItems_PurchaseItems]
GO
/****** Object:  ForeignKey [FK_SupplyItems_StockItemTypes]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SupplyItems_StockItemTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[SupplyItems]'))
ALTER TABLE [dbo].[SupplyItems]  WITH CHECK ADD  CONSTRAINT [FK_SupplyItems_StockItemTypes] FOREIGN KEY([StockItemTypeID])
REFERENCES [dbo].[StockItemTypes] ([StockItemTypeID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SupplyItems_StockItemTypes]') AND parent_object_id = OBJECT_ID(N'[dbo].[SupplyItems]'))
ALTER TABLE [dbo].[SupplyItems] CHECK CONSTRAINT [FK_SupplyItems_StockItemTypes]
GO
/****** Object:  ForeignKey [FK_SupplyItems_Supplies]    Script Date: 05/21/2015 19:22:42 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SupplyItems_Supplies]') AND parent_object_id = OBJECT_ID(N'[dbo].[SupplyItems]'))
ALTER TABLE [dbo].[SupplyItems]  WITH CHECK ADD  CONSTRAINT [FK_SupplyItems_Supplies] FOREIGN KEY([SupplyID])
REFERENCES [dbo].[Supplies] ([SupplyID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_SupplyItems_Supplies]') AND parent_object_id = OBJECT_ID(N'[dbo].[SupplyItems]'))
ALTER TABLE [dbo].[SupplyItems] CHECK CONSTRAINT [FK_SupplyItems_Supplies]
GO
