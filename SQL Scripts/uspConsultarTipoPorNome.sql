SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARTIPOPORNOME (
    NOMETIPO varchar(15) )
RETURNS (
    ID_TIPO integer,
    NOME_TIPO varchar(15) )
AS
BEGIN
  
  FOR select 
    ID_TIPO, NOME_TIPO
  from 
    TBLTIPOS
  where 
    upper(NOME_TIPO) containing upper(:NomeTipo) order by NOME_TIPO
  into :Id_Tipo, :Nome_Tipo
  DO
  suspend;
END^
SET TERM ; ^
