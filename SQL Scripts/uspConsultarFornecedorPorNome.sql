SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARFORNECEDORPORNOME (
    RAZAOSOCIAL varchar(50) )
RETURNS (
    ID_FORNECEDOR integer,
    RAZAO_SOCIAL varchar(100),
    NOME_FANTASIA varchar(100),
    CPF_CNPJ varchar(20),
    ENDERECO_FORNECEDOR varchar(255),
    TEL_FIXO_FORNECEDOR varchar(15),
    TEL_CEL_FORNECEDOR varchar(15),
    ID_BAIRRO varchar(50),
    ID_CIDADE varchar(50),
    ID_ESTADO varchar(50),
    CONTATO varchar(100),
    EMAIL_FORNECEDOR varchar(100) )
AS
BEGIN
  
  FOR select 
    ID_FORNECEDOR, RAZAO_SOCIAL, NOME_FANTASIA, CPF_CNPJ, ENDERECO_FORNECEDOR, TEL_FIXO_FORNECEDOR, TEL_CEL_FORNECEDOR, ID_BAIRRO, ID_CIDADE, ID_ESTADO, CONTATO, EMAIL_FORNECEDOR
  from 
    UVWFORNECEDORES
  where 
    upper(RAZAO_SOCIAL) containing upper(:RazaoSocial) order by RAZAO_SOCIAL
  into :Id_Fornecedor, :Razao_Social, :Nome_Fantasia, :CPF_CNPJ, :Endereco_Fornecedor, :Tel_Fixo_Fornecedor, :Tel_Cel_Fornecedor, :Id_Bairro, :Id_Cidade, :Id_Estado, :Contato, :Email_Fornecedor
  DO
  suspend;
END^
SET TERM ; ^