USE [Recuperacao]
GO

/****** Object:  Table [dbo].[tbFuncionario]    Script Date: 04/17/2018 22:30:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbFuncionario](
	[idFuncionario] [int] IDENTITY(1,1) NOT NULL,
	[NomeFun] [varchar](150) NOT NULL,
	[CPF] [varchar](12) NOT NULL,
	[DtNascFun] [date] NOT NULL,
	[EndFun] [varchar](80) NOT NULL,
	[TelFun] [varchar](11) NOT NULL,
	[Cargo] [varchar](20) NULL,
 CONSTRAINT [PK_tbFuncionario] PRIMARY KEY CLUSTERED 
(
	[idFuncionario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


