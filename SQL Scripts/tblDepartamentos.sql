CREATE TABLE TBLDEPARTAMENTOS
(
  ID_DEPARTAMENTO integer generated by default as identity primary key,
  NOME_DEPARTAMENTO varchar(100),
  ENDERECO_DEPARTAMENTO varchar(255),
  TEL_FIXO_DEPARTAMENTO varchar(15),
  ID_BAIRRO integer references TBLBAIRROS(ID_BAIRRO),
  ID_CIDADE integer REFERENCES TBLCIDADES(ID_CIDADE),
  ID_ESTADO integer REFERENCES TBLESTADOS (ID_ESTADO),
  ID_ORGAO integer REFERENCES TBLORGAOS(ID_ORGAO)
);