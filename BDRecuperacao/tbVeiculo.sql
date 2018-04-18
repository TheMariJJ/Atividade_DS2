USE [Recuperacao]
GO

/****** Object:  Table [dbo].[tbVeiculo]    Script Date: 04/17/2018 22:31:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbVeiculo](
	[idVeiculo] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[Ano] [int] NOT NULL,
 CONSTRAINT [PK_tbVeiculo] PRIMARY KEY CLUSTERED 
(
	[idVeiculo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


