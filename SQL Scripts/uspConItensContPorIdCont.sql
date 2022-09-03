SET TERM ^ ;
CREATE PROCEDURE USPCONITENSCONTPORIDCONT (
    IDCONTRATO integer,
    IDDEPARTAMENTO varchar(50) )
RETURNS (
    ID_ITEM integer,
    QTDE_ITEM decimal(18,2),
    PRECO_UNITARIO decimal(18,4),
    PRECO_TOTAL decimal(18,2),
    NUMERO_ITEM integer,
    DATA_ITEM date,
    SALDO_ITEM decimal(18,2),
    QTDE_SALDOITEM decimal(18,2),
    ID_CONTRATO integer,
    ID_PRODUTO varchar(255),
    ID_DEPARTAMENTO varchar(100),
    ID_GENERO varchar(100),
    ID_USUARIO integer )
AS
BEGIN
  
  FOR select 
   ID_ITEM, QTDE_ITEM, PRECO_UNITARIO, PRECO_TOTAL, NUMERO_ITEM, DATA_ITEM, SALDO_ITEM, QTDE_SALDOITEM,
   ID_CONTRATO, ID_PRODUTO, ID_DEPARTAMENTO, ID_GENERO, ID_USUARIO
  from 
    UVWITENSPORIDCONTEDEP
  where 
    ID_CONTRATO like :IdContrato and upper(ID_DEPARTAMENTO) containing upper(:IdDepartamento) and SALDO_ITEM > 0 order by ID_PRODUTO
  into :Id_Item, :Qtde_Item, :Preco_Unitario, :Preco_Total, :Numero_Item, :Data_Item, :Saldo_Item, 
  :Qtde_SaldoItem, Id_Contrato, Id_Produto, Id_Departamento, Id_Genero, :Id_Usuario
  DO
  suspend;
END^
SET TERM ; ^