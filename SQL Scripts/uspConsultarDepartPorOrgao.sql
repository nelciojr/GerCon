SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARDEPARTPORORGAO (
    IDDOORGAO varchar(100) )
RETURNS (
    ID_DEPARTAMENTO integer,
    NOME_DEPARTAMENTO varchar(100),
    ID_ORGAO varchar(100) )
AS
BEGIN
  
  FOR select 
   ID_DEPARTAMENTO, NOME_DEPARTAMENTO, ID_ORGAO
  from 
   UVWDEPARTPORORGAO
  where 
    upper(ID_ORGAO) containing upper(:IdDoOrgao) order by NOME_DEPARTAMENTO
  into :Id_Departamento, :Nome_Departamento, :Id_Orgao
    DO
  suspend;
END^
SET TERM ; ^