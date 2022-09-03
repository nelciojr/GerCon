SET TERM ^ ;
CREATE PROCEDURE USPMANTERRESPONSAVEL (
    ACAO integer,
    IDDORESPONSAVEL integer,
    NOMERESPONSAVEL varchar(50),
    CPFRESPONSAVEL varchar(15),
    TELFIXORESPONSAVEL varchar(15),
    TELCELRESPONSAVEL varchar(15) )
RETURNS (
    IDRESPONSAVEL integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT CPF_RESPONSAVEL FROM TBLRESPONSAVEIS WHERE upper(CPF_RESPONSAVEL) like upper(:CPFResponsavel))) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLRESPONSAVEIS
            (NOME_RESPONSAVEL, CPF_RESPONSAVEL, TEL_FIXO_RESPONSAVEL, TEL_CEL_RESPONSAVEL)
            values 
            (:NomeResponsavel, :CPFResponsavel, :TelFixoResponsavel, :TelCelResponsavel)
            returning ID_RESPONSAVEL into :IdResponsavel;
      END
    
  if (Acao = 2) then
    
    BEGIN
      IF(Exists(SELECT ID_RESPONSAVEL FROM TBLRESPONSAVEIS WHERE ID_RESPONSAVEL like :IdDoResponsavel)) then
            IF(Exists(SELECT CPF_RESPONSAVEL FROM TBLRESPONSAVEIS WHERE upper(CPF_RESPONSAVEL) like upper(:CPFResponsavel) and ID_RESPONSAVEL <> :IdDoResponsavel)) then
                exception EXC_ERRO_01;
             ELSE
                update TBLRESPONSAVEIS
                set NOME_RESPONSAVEL = :NomeResponsavel,
                    CPF_RESPONSAVEL = :CPFResponsavel,
                    TEL_FIXO_RESPONSAVEL = :TelFixoResponsavel,
                    TEL_CEL_RESPONSAVEL = :TelCelResponsavel
                where (ID_RESPONSAVEL like :IdDoResponsavel)
                returning ID_RESPONSAVEL into :IdResponsavel;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT NOME_RESPONSAVEL FROM TBLRESPONSAVEIS WHERE ID_RESPONSAVEL like :IdDoResponsavel)) then
         delete from TBLRESPONSAVEIS
         where (ID_RESPONSAVEL like :IdDoResponsavel)
        returning ID_RESPONSAVEL into :IdResponsavel;
       ELSE
        exception EXC_ERRO_02;
    END
     
  suspend; 
END^
SET TERM ; ^