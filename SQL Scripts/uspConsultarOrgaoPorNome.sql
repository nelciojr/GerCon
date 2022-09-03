SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARORGAOPORNOME (
    NOMEORGAO varchar(50) )
RETURNS (
    ID_ORGAO integer,
    NOME_ORGAO varchar(100),
    ENDERECO_ORGAO varchar(255),
    TEL_FIXO_ORGAO varchar(15),
    ID_BAIRRO varchar(50),
    ID_CIDADE varchar(50),
    ID_ESTADO varchar(50),
    ID_RESPONSAVEL varchar(50) )
AS
BEGIN
  
  FOR select 
    ID_ORGAO, NOME_ORGAO, ENDERECO_ORGAO, TEL_FIXO_ORGAO, ID_BAIRRO, ID_CIDADE, ID_ESTADO, ID_RESPONSAVEL
  from 
    UVWORGAOS
  where 
    upper(NOME_ORGAO) containing upper(:NomeOrgao) order by NOME_ORGAO
  into :Id_Orgao, : Nome_Orgao, :Endereco_Orgao, :Tel_Fixo_Orgao, :Id_Bairro, :Id_Cidade, :Id_Estado, :Id_Responsavel
  DO
  suspend;
END^
SET TERM ; ^