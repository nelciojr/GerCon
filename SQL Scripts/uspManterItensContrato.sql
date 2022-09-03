SET TERM ^ ;
CREATE PROCEDURE USPMANTERITENSCONTRATO (
    ACAO integer,
    IDDOITEM integer,
    QTDEITEM decimal(18,2),
    PRECOUNITARIO decimal(18,4),
    PRECOTOTAL decimal(18,2),
    NUMEROITEM integer,
    DATAITEM date,
    SALDOITEM decimal(18,2),
    QTDESALDOITEM decimal(18,2),
    IDCONTRATO integer,
    IDPRODUTO integer,
    IDDEPARTAMENTO integer,
    IDGENERO integer,
    IDUSUARIO integer )
RETURNS (
    IDITEM integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT ID_PRODUTO FROM TBLITENSCONTRATOS WHERE ID_PRODUTO like :IdProduto and ID_CONTRATO like :IdContrato)) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLITENSCONTRATOS
            (QTDE_ITEM, PRECO_UNITARIO, PRECO_TOTAL, NUMERO_ITEM, DATA_ITEM, SALDO_ITEM, QTDE_SALDOITEM, ID_CONTRATO,
            ID_PRODUTO, ID_DEPARTAMENTO, ID_GENERO, ID_USUARIO)
            values 
            (:QtdeItem, :PrecoUnitario, :PrecoTotal, :NumeroItem, :DataItem, :SaldoItem, :QtdeSaldoItem, :IdContrato,
            :IdProduto, :IdDepartamento, :IdGenero, :IdUsuario)
            returning ID_ITEM into :IdItem;
      END
     if (Acao = 2) then
    
    BEGIN
     IF(Exists(SELECT ID_ITEM FROM TBLITENSCONTRATOS WHERE ID_ITEM like :IdDoItem)) then 
            IF(Exists(SELECT ID_PRODUTO FROM TBLITENSCONTRATOS WHERE ID_PRODUTO like :IdProduto and ID_CONTRATO like :IdContrato and ID_ITEM <> :IdItem)) then
                exception EXC_ERRO_01;
             ELSE
                update TBLITENSCONTRATOS
                set QTDE_ITEM = :QtdeItem,
                    PRECO_UNITARIO = :PrecoUnitario,
                    PRECO_TOTAL = :PrecoTotal,
                    NUMERO_ITEM = :NumeroItem,
                    DATA_ITEM = :DataItem,
                    SALDO_ITEM = :SaldoItem,
                    QTDE_SALDOITEM = :QtdeSaldoItem,
                    ID_CONTRATO = :IdContrato,
                    ID_PRODUTO = :IdProduto,
                    ID_DEPARTAMENTO = :IdDepartamento,
                    ID_GENERO = :IdGenero,
                    ID_USUARIO = :IdUsuario
                where (ID_ITEM like :IdDoItem)
                returning ID_ITEM into :IdItem;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT ID_PRODUTO FROM TBLITENSCONTRATOS WHERE ID_ITEM like :IdDoItem)) then
         delete from TBLITENSCONTRATOS
         where (ID_ITEM like :IdDoItem)
        returning ID_ITEM into :IdItem;
       ELSE
        exception EXC_ERRO_02;
    END
 
     
  suspend; 
END^
SET TERM ; ^