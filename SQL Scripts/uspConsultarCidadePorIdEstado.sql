SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARCIDADEPORIDESTADO (
    IDESTADO integer )
RETURNS (
    ID_CIDADE integer,
    NOME_CIDADE varchar(50),
    ID_ESTADO integer )
AS
BEGIN
  
  FOR select 
    ID_CIDADE, NOME_CIDADE, ID_ESTADO
  from 
    TBLCIDADES
  where ID_ESTADO like :IdEstado order by NOME_CIDADE
  into :Id_Cidade, :Nome_Cidade, :Id_Estado
  DO
  suspend;
END^
SET TERM ; ^