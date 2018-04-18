USE [Recuperacao]
GO

/****** Object:  Table [dbo].[tbCliente]    Script Date: 04/17/2018 22:31:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbCliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [varchar](150) NOT NULL,
	[CpfCliente] [varchar](12) NOT NULL,
	[DtNascCliente] [date] NOT NULL,
	[TelCliente] [varchar](11) NOT NULL,
	[EndCliente] [varchar](80) NULL,
	[VeiculoCliente] [int] NOT NULL,
 CONSTRAINT [PK_tbCliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


