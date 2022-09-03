SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARBAIRROPORNOME (
    NOMEBAIRRO varchar(50) )
RETURNS (
    ID_BAIRRO integer,
    NOME_BAIRRO varchar(50) )
AS
BEGIN
  
  FOR select 
    ID_BAIRRO, NOME_BAIRRO
  from 
    TBLBAIRROS
  where 
    upper(NOME_BAIRRO) containing upper(:NomeBairro) order by NOME_BAIRRO
  into :Id_Bairro, :Nome_Bairro
  DO
  suspend;
END^
SET TERM ; ^