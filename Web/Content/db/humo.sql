USE [humo]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/22/2017 15:43:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UsersName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[ClassesId] [int] NULL,
	[RolesId] [int] NULL,
	[IsShow] [bit] NULL,
	[Email] [nvarchar](50) NULL,
	[TelePhone] [nvarchar](50) NULL,
	[Gender] [nvarchar](10) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
