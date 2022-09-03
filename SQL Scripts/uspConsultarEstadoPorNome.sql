SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARESTADOPORNOME (
    NOMEESTADO varchar(50) )
RETURNS (
    ID_ESTADO integer,
    NOME_ESTADO varchar(50),
    UF varchar(2) )
AS
BEGIN
  
  FOR select 
    ID_ESTADO, NOME_ESTADO, UF
  from 
    TBLESTADOS
  where 
    upper(NOME_ESTADO) containing upper(:NomeEstado) order by NOME_ESTADO
  into :Id_Estado,:Nome_Estado,:UF
  DO
  suspend;
END^
SET TERM ; ^