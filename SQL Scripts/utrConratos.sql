SET TERM ^ ;
CREATE TRIGGER UTRCONTRATOS FOR TBLCONTRATOS
ACTIVE
BEFORE insert OR update OR delete POSITION 0
AS
BEGIN
Insert into TBLHISTORICOCONTRATOS(Id_Contrato, Contrato_Aditivo, Id_Modalidade, Numero_Contrato, Numero_Licitacao, 
Ano_Exercicio, Data_Inicio, Data_Final, Arquivo_Contrato, Historico_Contrato, Valor_Contrato, Saldo_Contrato, 
Id_Orgao, Id_Fornecedor, Id_Genero, Id_Usuario, Acao, Data_Modificacao, Hora_Modificacao)
    values(
    case when inserting or updating then new.ID_CONTRATO else old.ID_CONTRATO end,
    case when inserting or updating then new.CONTRATO_ADITIVO else old.CONTRATO_ADITIVO end,
    case when inserting or updating then new.ID_MODALIDADE else old.ID_MODALIDADE end,
    case when inserting or updating then new.NUMERO_CONTRATO else old.NUMERO_CONTRATO end,
    case when inserting or updating then new.NUMERO_LICITACAO else old.NUMERO_LICITACAO end,
    case when inserting or updating then new.ANO_EXERCICIO else old.ANO_EXERCICIO end,
    case when inserting or updating then new.DATA_INICIO else old.DATA_INICIO end,
    case when inserting or updating then new.DATA_FINAL else old.DATA_FINAL end,
    case when inserting or updating then new.ARQUIVO_CONTRATO else old.ARQUIVO_CONTRATO end,
    case when inserting or updating then new.HISTORICO_CONTRATO else old.HISTORICO_CONTRATO end,
    case when inserting or updating then new.VALOR_CONTRATO else old.VALOR_CONTRATO end,
    case when inserting or updating then new.SALDO_CONTRATO else old.SALDO_CONTRATO end,
    case when inserting or updating then new.ID_ORGAO else old.ID_ORGAO end,
    case when inserting or updating then new.ID_FORNECEDOR else old.ID_FORNECEDOR end,
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
