USE [BlocoNotas]
GO

/****** Object:  Trigger [dbo].[TGR_TBTEXTO_AI]    Script Date: 13/11/2016 15:59:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[TGR_TBTEXTO_AI]
ON [dbo].[TB_TEXTO]
FOR INSERT
AS
BEGIN
  DELETE FROM TB_TEXTO WHERE DATA < (GETDATE()-2);
END;

GO

