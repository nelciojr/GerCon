SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARMODALIDADEPORNOME (
    NOMEMODALIDADE varchar(100) )
RETURNS (
    ID_MODALIDADE integer,
    NOME_MODALIDADE varchar(100) )
AS
BEGIN
  
  FOR select 
    ID_MODALIDADE, NOME_MODALIDADE
  from 
    TBLMODALIDADES
  where 
    upper(NOME_MODALIDADE) containing upper(:NomeModalidade)
  into :Id_Modalidade, :Nome_Modalidade
  DO
  suspend;
END^
SET TERM ; ^