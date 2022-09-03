SET TERM ^ ;
CREATE PROCEDURE USPCONBAIXAITENSPORIDS (
    IDCONTRATO integer,
    IDUSUARIO integer,
    HOJE date )
RETURNS (
    ID_BAIXAITEM integer,
    ID_ITEM integer,
    NUMERO_NOTA decimal(18,2),
    DATA_BAIXAITEM date,
    QTDE_BAIXAITEM decimal(18,2),
    VALOR_BAIXA decimal(18,2),
    QTDESALDO_BAIXAITEM decimal(18,2),
    SALDO_BAIXAITEM decimal(18,2),
    ID_CONTRATO integer,
    ID_DEPARTAMENTO varchar(100),
    ID_PRODUTO varchar(255),
    ID_USUARIO integer )
AS
BEGIN
    IF(HOJE LIKE current_date) then
       BEGIN
         select 
           ID_BAIXAITEM, ID_ITEM, NUMERO_NOTA, DATA_BAIXAITEM, QTDE_BAIXAITEM, VALOR_BAIXA, QTDESALDO_BAIXAITEM,
           SALDO_BAIXAITEM, ID_CONTRATO, ID_DEPARTAMENTO, ID_PRODUTO, ID_USUARIO
          from 
            UVWBAIXAITENSPORIDS
          where 
            ID_CONTRATO like :IdContrato and ID_USUARIO like :IdUsuario and VALOR_BAIXA > 0 order by ID_PRODUTO
          into :Id_BaixaItem, :Id_Item, :Numero_Nota, :Data_BaixaItem, :Qtde_BaixaItem, :Valor_Baixa, QtdeSaldo_BaixaItem,
          :Saldo_BaixaItem, :Id_Contrato, :Id_Departamento, :Id_Produto, :Id_Usuario;
      END
  
  suspend;
END^
SET TERM ; ^