CREATE TABLE TBLRESPONSAVEIS
(
  ID_RESPONSAVEL integer generated by default as identity primary key,
  NOME_RESPONSAVEL varchar(255),
  CPF_RESPONSAVEL varchar(15),
  TEL_FIXO_RESPONSAVEL varchar(15),
  TEL_CEL_RESPONSAVEL varchar(15)
);