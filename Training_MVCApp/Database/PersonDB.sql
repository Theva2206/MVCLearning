USE [PersonDB]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 1/6/2022 1:47:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonID] [int] NOT NULL,
	[LastName] [varchar](255) NOT NULL,
	[FirstName] [varchar](255) NOT NULL,
	[Age] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Person] ([PersonID], [LastName], [FirstName], [Age]) VALUES (1, N'Thavamani', N'Thevan', 30)
INSERT [dbo].[Person] ([PersonID], [LastName], [FirstName], [Age]) VALUES (2, N'UserFN', N'UserLN', 10)
