SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARRESPONSAVELPORNOME (
    NOMERESPONSAVEL varchar(50) )
RETURNS (
    ID_RESPONSAVEL integer,
    NOME_RESPONSAVEL varchar(50),
    CPF_RESPONSAVEL varchar(15),
    TEL_FIXO_RESPONSAVEL varchar(15),
    TEL_CEL_RESPONSAVEL varchar(15) )
AS
BEGIN
  
  FOR select 
    ID_RESPONSAVEL, NOME_RESPONSAVEL, CPF_RESPONSAVEL, TEL_FIXO_RESPONSAVEL, TEL_CEL_RESPONSAVEL
  from 
    TBLRESPONSAVEIS
  where 
    upper(NOME_RESPONSAVEL) containing upper(:NomeResponsavel) order by NOME_RESPONSAVEL
  into :Id_Responsavel, :Nome_Responsavel, :CPF_Responsavel, :Tel_Fixo_Responsavel, :Tel_Cel_Responsavel
  DO
  suspend;
END^
SET TERM ; ^