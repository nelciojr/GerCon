SET TERM ^ ;
CREATE PROCEDURE USPMANTERCONTRATO (
    ACAO integer,
    IDDOCONTRATO integer,
    CONTRATOADITIVO varchar(1),
    IDMODALIDADE integer,
    NUMEROCONTRATO varchar(20),
    NUMEROLICITACAO varchar(20),
    ANOEXERCICIO varchar(4),
    DATAINICIO date,
    DATAFINAL date,
    ARQUIVOCONTRATO varchar(255),
    HISTORICOCONTRATO blob sub_type 1,
    VALORCONTRATO decimal(18,2),
    SALDOCONTRATO decimal(18,2),
    IDORGAO integer,
    IDFORNECEDOR integer,
    IDGENERO integer,
    IDUSUARIO integer,
    CONTRATOBYTE blob sub_type 0 )
RETURNS (
    IDCONTRATO integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT NUMERO_CONTRATO FROM TBLCONTRATOS WHERE ID_CONTRATO like :IdDoContrato)) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLCONTRATOS
            (CONTRATO_ADITIVO, ID_MODALIDADE, NUMERO_CONTRATO, NUMERO_LICITACAO, ANO_EXERCICIO, DATA_INICIO, DATA_FINAL,
            ARQUIVO_CONTRATO, HISTORICO_CONTRATO, VALOR_CONTRATO, SALDO_CONTRATO, ID_ORGAO, ID_FORNECEDOR,
            ID_GENERO, ID_USUARIO, CONTRATO_BYTE)
            values 
            (:ContratoAditivo, :IdModalidade, :NumeroContrato, :NumeroLicitacao, :AnoExercicio, :DataInicio, :DataFinal,
            :ArquivoContrato, :HistoricoContrato, :ValorContrato, :SaldoContrato, :IdOrgao, :IdFornecedor, :IdGenero, 
            :IdUsuario, :ContratoByte)
            returning ID_CONTRATO into :IdContrato;
      END
     if (Acao = 2) then
    
    BEGIN
     IF(Exists(SELECT ID_CONTRATO FROM TBLCONTRATOS WHERE ID_CONTRATO like :IdDoContrato)) then 
            IF(Exists(SELECT NUMERO_CONTRATO FROM TBLCONTRATOS WHERE upper(NUMERO_CONTRATO) like upper(:NumeroContrato) and ID_CONTRATO <> :IdDoContrato)) then
                exception EXC_ERRO_01;
             ELSE
                update TBLCONTRATOS
                set CONTRATO_ADITIVO = :ContratoAditivo,
                ID_MODALIDADE = :IdModalidade,
                NUMERO_CONTRATO = :NumeroContrato,
                NUMERO_LICITACAO = :NumeroLicitacao,
                ANO_EXERCICIO = :AnoExercicio,
                DATA_INICIO = :DataInicio,
                DATA_FINAL = :DataFinal,
                ARQUIVO_CONTRATO = :ArquivoContrato,
                HISTORICO_CONTRATO = :HistoricoContrato,
                VALOR_CONTRATO = :ValorContrato,
                SALDO_CONTRATO = :SaldoContrato,
                ID_ORGAO = :IdOrgao,
                ID_FORNECEDOR = :IdFornecedor,
                ID_GENERO = :IdGenero,
                ID_USUARIO = :IdUsuario,
                CONTRATO_BYTE = :ContratoByte
                where (ID_CONTRATO like :IdDoContrato)
                returning ID_CONTRATO into :IdContrato;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT NUMERO_CONTRATO FROM TBLCONTRATOS WHERE ID_CONTRATO like :IdDoContrato)) then
         delete from TBLCONTRATOS
         where (ID_CONTRATO like :IdDoContrato)
        returning ID_CONTRATO into :IdContrato;
       ELSE
        exception EXC_ERRO_02;
    END
 
     
  suspend; 
END^
SET TERM ; ^