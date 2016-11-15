USE [BlocoNotas]
GO

/****** Object:  Table [dbo].[TB_TEXTO]    Script Date: 13/11/2016 15:59:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_TEXTO](
	[TEXTO_PK] [int] IDENTITY(1,1) NOT NULL,
	[TEXTO] [text] NULL,
	[TEXTO_ID] [nvarchar](100) NOT NULL,
	[DATA] [datetime] NULL,
 CONSTRAINT [PK_TB_TEXTO] PRIMARY KEY CLUSTERED 
(
	[TEXTO_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
