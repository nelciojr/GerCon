CREATE TABLE TBLHISTORICOITENSCONTRATOS
(
  ID_ITEM integer,
  QTDE_ITEM decimal(18,2),
  PRECO_UNITARIO decimal(18,4),
  PRECO_TOTAL decimal(18,2),
  NUMERO_ITEM integer,
  DATA_ITEM date,
  SALDO_ITEM decimal(18,2),
  QTDE_SALDOITEM decimal(18,2),
  ID_CONTRATO integer,
  ID_PRODUTO integer,
  ID_DEPARTAMENTO integer,
  ID_GENERO integer,
  ID_USUARIO integer,
  ACAO varchar(1),
  DATA_MODIFICACAO date,
  HORA_MODIFICACAO time
);