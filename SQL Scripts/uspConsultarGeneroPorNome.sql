SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARGENEROPORNOME (
    NOMEGENERO varchar(50) )
RETURNS (
    ID_GENERO integer,
    NOME_GENERO varchar(255) )
AS
BEGIN
  
  FOR select 
    ID_GENERO, NOME_GENERO
  from 
    TBLGENEROS
  where 
    upper(NOME_GENERO) containing upper(:NomeGenero) order by NOME_GENERO
  into :Id_Genero, :Nome_Genero
  DO
  suspend;
END^
SET TERM ; ^