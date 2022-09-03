SET TERM ^ ;
CREATE PROCEDURE USPMANTERBAIXAITEM (
    ACAO integer,
    IDDABAIXAITEM integer,
    IDITEM integer,
    NUMERONOTA decimal(18,2),
    DATABAIXAITEM date,
    QTDEBAIXAITEM decimal(18,2),
    VALORBAIXA decimal(18,2),
    QTDESALDOBAIXAITEM decimal(18,2),
    SALDOBAIXAITEM decimal(18,2),
    IDCONTRATO integer,
    IDDEPARTAMENTO integer,
    IDPRODUTO integer,
    IDUSUARIO integer )
RETURNS (
    IDBAIXAITEM integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT ID_BAIXAITEM FROM TBLBAIXAITENS WHERE ID_BAIXAITEM like :IdDaBaixaItem )) then
            exception EXC_ERRO_01;
        
        ELSE
            update TBLCONTRATOS
            set SALDO_CONTRATO = (SALDO_CONTRATO - :ValorBaixa)
            where (ID_CONTRATO like :IdContrato);
            
            update TBLITENSCONTRATOS
            set SALDO_ITEM = :SaldoBaixaItem,
            QTDE_SALDOITEM = :QtdeSaldoBaixaItem
            where (ID_ITEM like :IdItem);
             
			insert into TBLBAIXAITENS
            (ID_ITEM, NUMERO_NOTA, DATA_BAIXAITEM, QTDE_BAIXAITEM, VALOR_BAIXA, QTDESALDO_BAIXAITEM, 
            SALDO_BAIXAITEM, ID_CONTRATO, ID_DEPARTAMENTO, ID_PRODUTO, ID_USUARIO)
            values 
            (:IdItem, :NumeroNota, :DataBaixaItem, :QtdeBaixaItem, :ValorBaixa, :QtdeSaldoBaixaItem,
            :SaldoBaixaItem, :IdContrato, :IdDepartamento, :IdProduto, :IdUsuario)
            returning ID_BAIXAITEM into :IdBaixaItem;
      END
    if (Acao = 2) then
    
    BEGIN
      IF(Exists(SELECT ID_BAIXAITEM FROM TBLBAIXAITENS WHERE ID_BAIXAITEM like :IdDaBaixaItem )) then
            update TBLCONTRATOS
            set SALDO_CONTRATO = (SALDO_CONTRATO + :ValorBaixa)
            where (ID_CONTRATO like :IdContrato);
                
            update TBLITENSCONTRATOS
            set SALDO_ITEM = (SALDO_ITEM + :ValorBaixa),
            QTDE_SALDOITEM = (QTDE_SALDOITEM + :QtdeBaixaItem)
            where (ID_ITEM like :IdItem);
                
            update TBLBAIXAITENS
            set QTDE_BAIXAITEM = (QTDE_BAIXAITEM - :QtdeBaixaItem),
            VALOR_BAIXA = (VALOR_BAIXA - :ValorBaixa),
            QTDESALDO_BAIXAITEM = (QTDESALDO_BAIXAITEM + :QtdeBaixaItem),
            SALDO_BAIXAITEM = (SALDO_BAIXAITEM + :ValorBaixa)
            where (ID_BAIXAITEM like :IdDaBaixaItem)
            returning ID_BAIXAITEM into :IdBaixaItem;
     
    END
  if (Acao =3) then   
    BEGIN
        IF(Exists(SELECT ID_BAIXAITEM FROM TBLBAIXAITENS WHERE ID_BAIXAITEM like :IdDaBaixaItem )) then
         delete from TBLBAIXAITENS
         where (ID_BAIXAITEM like :IdDaBaixaItem)
         returning ID_BAIXAITEM into :IdBaixaItem;
       ELSE
        exception EXC_ERRO_02;
    END
     
  suspend; 
END^
SET TERM ; ^