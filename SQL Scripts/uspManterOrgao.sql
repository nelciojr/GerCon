SET TERM ^ ;
CREATE PROCEDURE USPMANTERORGAO (
    ACAO integer,
    IDDOORGAO integer,
    NOMEORGAO varchar(100),
    ENDERECOORGAO varchar(255),
    TELFIXOORGAO varchar(15),
    IDBAIRRO integer,
    IDCIDADE integer,
    IDESTADO integer,
    IDRESPONSAVEL integer )
RETURNS (
    IDORGAO integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT NOME_ORGAO FROM TBLORGAOS WHERE upper(NOME_ORGAO) like upper(:NomeOrgao))) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLORGAOS
            (NOME_ORGAO, ENDERECO_ORGAO, TEL_FIXO_ORGAO, ID_BAIRRO, ID_CIDADE, ID_ESTADO, ID_RESPONSAVEL)
            values 
            (:NomeOrgao, :EnderecoOrgao, :TelFixoOrgao, :IdBairro, :IdCidade, :IdEstado, :IdResponsavel)
            returning ID_ORGAO into :IdOrgao;
      END
    
  if (Acao = 2) then
    
    BEGIN
      IF(Exists(SELECT ID_ORGAO FROM TBLORGAOS WHERE ID_ORGAO like :IdDoOrgao)) then
            IF(Exists(SELECT NOME_ORGAO FROM TBLORGAOS WHERE upper(NOME_ORGAO) like upper(:NomeOrgao) and ID_ORGAO <> :IdDoOrgao )) then
                exception EXC_ERRO_01;
             ELSE
                update TBLORGAOS
                set NOME_ORGAO = :NomeOrgao,
                    ENDERECO_ORGAO = :EnderecoOrgao,
                    TEL_FIXO_ORGAO = :TelFixoOrgao,
                    ID_BAIRRO = :IdBairro,
                    ID_CIDADE = :IdCidade,
                    ID_ESTADO = :IdEstado,
                    ID_RESPONSAVEL = :IdResponsavel
                where (ID_ORGAO like :IdDoOrgao)
                returning ID_ORGAO into :IdOrgao;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT NOME_ORGAO FROM TBLORGAOS WHERE ID_ORGAO like :IdDoOrgao)) then
         delete from TBLORGAOS
         where (ID_ORGAO like :IdDoOrgao)
        returning ID_ORGAO into :IdOrgao;
       ELSE
        exception EXC_ERRO_02;
    END
     
  suspend; 
END^
SET TERM ; ^