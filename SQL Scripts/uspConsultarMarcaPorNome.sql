SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARMARCAPORNOME (
    NOMEMARCA varchar(50) )
RETURNS (
    ID_MARCA integer,
    NOME_MARCA varchar(50) )
AS
BEGIN
  
  FOR select 
    ID_MARCA, NOME_MARCA
  from 
    TBLMARCAS
  where 
    upper(NOME_MARCA) containing upper(:NomeMarca) order by NOME_MARCA
  into :Id_Marca, :Nome_Marca
  DO
  suspend;
END^
SET TERM ; ^