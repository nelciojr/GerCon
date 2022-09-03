SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARDEPARTAMENTOPORNOME (
    NOMEDEPARTAMENTO varchar(50) )
RETURNS (
    ID_DEPARTAMENTO integer,
    NOME_DEPARTAMENTO varchar(100),
    ENDERECO_DEPARTAMENTO varchar(255),
    TEL_FIXO_DEPARTAMENTO varchar(15),
    ID_BAIRRO varchar(50),
    ID_CIDADE varchar(50),
    ID_ESTADO varchar(50),
    ID_ORGAO varchar(50) )
AS
BEGIN
  
  FOR select 
   ID_DEPARTAMENTO, NOME_DEPARTAMENTO, ENDERECO_DEPARTAMENTO, TEL_FIXO_DEPARTAMENTO, ID_BAIRRO, ID_CIDADE, ID_ESTADO, ID_ORGAO
  from 
    UVWDEPARTAMENTOS
  where 
    upper(NOME_DEPARTAMENTO) containing upper(:NomeDepartamento) order by NOME_DEPARTAMENTO
  into :Id_Departamento, :Nome_Departamento, :Endereco_Departamento, :Tel_Fixo_Departamento, :Id_Bairro, :Id_Cidade, :Id_Estado, :Id_Orgao
    DO
  suspend;
END^
SET TERM ; ^