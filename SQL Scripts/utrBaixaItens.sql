SET TERM ^ ;
CREATE TRIGGER UTRBAIXAITENS FOR TBLBAIXAITENS ACTIVE 
BEFORE insert OR update OR delete POSITION 0
AS
BEGIN
Insert into TBLHISTORICOBAIXAITENS(Id_BaixaItem, Id_Item, Numero_Nota, Data_BaixaItem, Qtde_BaixaItem, 
Valor_Baixa, QtdeSaldo_BaixaItem, Saldo_BaixaItem, Id_Contrato, Id_Departamento, Id_Produto, Id_Usuario, 
Acao, Data_Modificacao, Hora_Modificacao)
    values(
    case when inserting or updating then new.ID_BAIXAITEM else old.ID_BAIXAITEM end,
    case when inserting or updating then new.ID_ITEM else old.ID_ITEM end,
    case when inserting or updating then new.NUMERO_NOTA else old.NUMERO_NOTA end,
    case when inserting or updating then new.DATA_BAIXAITEM else old.DATA_BAIXAITEM end,
    case when inserting or updating then new.QTDE_BAIXAITEM else old.QTDE_BAIXAITEM end,
    case when inserting or updating then new.VALOR_BAIXA else old.VALOR_BAIXA end,
    case when inserting or updating then new.QTDESALDO_BAIXAITEM else old.QTDESALDO_BAIXAITEM end,
    case when inserting or updating then new.SALDO_BAIXAITEM else old.SALDO_BAIXAITEM end,
    case when inserting or updating then new.ID_CONTRATO else old.ID_CONTRATO end,
    case when inserting or updating then new.ID_DEPARTAMENTO else old.ID_DEPARTAMENTO end,
    case when inserting or updating then new.ID_PRODUTO else old.ID_PRODUTO end,
    Case when inserting or updating then new.ID_USUARIO else old.ID_USUARIO end,
    case
    when inserting then 'I'
    when updating then 'U'
    else 'D'
    end,
    current_date,
    current_time);
END^
SET TERM ; ^
