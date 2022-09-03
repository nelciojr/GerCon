SET TERM ^ ;
CREATE TRIGGER UTRITENSCONTRATOS FOR TBLITENSCONTRATOS
ACTIVE
BEFORE insert OR update OR delete POSITION 0
AS
BEGIN
Insert into TBLHISTORICOITENSCONTRATOS(Id_Item, Qtde_Item, Preco_Unitario, Preco_Total, Numero_Item, Data_Item,
Saldo_Item, Qtde_SaldoItem, Id_Contrato, Id_Produto, Id_Departamento, Id_Genero, Id_Usuario, Acao, 
Data_Modificacao, Hora_Modificacao)
    values(
    case when inserting or updating then new.ID_ITEM else old.ID_ITEM end,
    case when inserting or updating then new.QTDE_ITEM else old.QTDE_ITEM end,
    case when inserting or updating then new.PRECO_UNITARIO else old.PRECO_UNITARIO end,
    case when inserting or updating then new.PRECO_TOTAL else old.PRECO_TOTAL end,
    case when inserting or updating then new.NUMERO_ITEM else old.NUMERO_ITEM end,
    case when inserting or updating then new.DATA_ITEM else old.DATA_ITEM end,
    case when inserting or updating then new.SALDO_ITEM else old.SALDO_ITEM end,
    case when inserting or updating then new.QTDE_SALDOITEM else old.QTDE_SALDOITEM end,
    case when inserting or updating then new.ID_CONTRATO else old.ID_CONTRATO end,
    case when inserting or updating then new.ID_PRODUTO else old.ID_PRODUTO end,
    case when inserting or updating then new.ID_DEPARTAMENTO else old.ID_DEPARTAMENTO end,
    case when inserting or updating then new.ID_GENERO else old.ID_GENERO end,
    case when inserting or updating then new.ID_USUARIO else old.ID_USUARIO end,
    case
    when inserting then 'I'
    when updating then 'U'
    else 'D'
    end,
    current_date,
    current_time);
END^
SET TERM ; ^
