SET TERM ^ ;
CREATE PROCEDURE USPMANTERDEPARTAMENTO (
    ACAO integer,
    IDDODEPARTAMENTO integer,
    NOMEDEPARTAMENTO varchar(50),
    ENDERECODEPARTAMENTO varchar(255),
    TELFIXODEPARTAMENTO varchar(15),
    IDBAIRRO integer,
    IDCIDADE integer,
    IDESTADO integer,
    IDORGAO integer )
RETURNS (
    IDDEPARTAMENTO integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT NOME_DEPARTAMENTO FROM TBLDEPARTAMENTOS WHERE upper(NOME_DEPARTAMENTO) like upper(:NomeDepartamento))) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLDEPARTAMENTOS
            (NOME_DEPARTAMENTO, ENDERECO_DEPARTAMENTO, TEL_FIXO_DEPARTAMENTO, ID_BAIRRO, ID_CIDADE, ID_ESTADO, ID_ORGAO)
            values 
            (:NomeDepartamento, :EnderecoDepartamento, :TelFixoDepartamento, :IdBairro, :IdCidade, :IdEstado, :IdOrgao)
            returning ID_DEPARTAMENTO into :IdDepartamento;
      END
    
  if (Acao = 2) then
    
    BEGIN
      IF(Exists(SELECT ID_DEPARTAMENTO FROM TBLDEPARTAMENTOS WHERE ID_DEPARTAMENTO like :IdDoDepartamento)) then
            IF(Exists(SELECT NOME_DEPARTAMENTO FROM TBLDEPARTAMENTOS WHERE upper(NOME_DEPARTAMENTO) like upper(:NomeDepartamento) and ID_DEPARTAMENTO <> :IdDoDepartamento)) then
                exception EXC_ERRO_01;
             ELSE
                update TBLDEPARTAMENTOS
                set NOME_DEPARTAMENTO = :NomeDepartamento,
                    ENDERECO_DEPARTAMENTO = :EnderecoDepartamento,
                    TEL_FIXO_DEPARTAMENTO = :TelFixoDepartamento,
                    ID_BAIRRO = :IdBairro,
                    ID_CIDADE = :IdCidade,
                    ID_ESTADO = :IdEstado,
                    ID_ORGAO = :IdOrgao
                where (ID_Departamento like :IdDoDepartamento)
                returning ID_ORGAO into :IdDepartamento;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT NOME_DEPARTAMENTO FROM TBLDEPARTAMENTOS WHERE ID_DEPARTAMENTO like :IdDoDepartamento)) then
         delete from TBLDEPARTAMENTOS
         where (ID_DEPARTAMENTO like :IdDoDepartamento)
        returning ID_DEPARTAMENTO into :IdDepartamento;
       ELSE
        exception EXC_ERRO_02;
    END
     
  suspend; 
END^
SET TERM ; ^