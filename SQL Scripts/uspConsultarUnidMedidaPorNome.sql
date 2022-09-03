SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARUNIDMEDIDAPORNOME (
    DESCRICAOUNIDMED varchar(255) )
RETURNS (
    ID_UNIDMEDIDA integer,
    DESCRICAO varchar(255),
    LEGENDA varchar(50) )
AS
BEGIN
  
  FOR select 
    ID_UNIDMEDIDA, DESCRICAO, LEGENDA
  from 
    TBLUNIDMEDIDAS
  where 
    upper(DESCRICAO) containing upper(:DescricaoUnidMed) order by DESCRICAO
  into :Id_UnidMedida, :Descricao, :Legenda
  DO
  suspend;
END^
SET TERM ; ^