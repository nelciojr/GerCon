SET TERM ^ ;
CREATE PROCEDURE USPMANTERBAIRRO (
    ACAO integer,
    IDDOBAIRRO integer,
    NOMEBAIRRO varchar(50) )
RETURNS (
    IDBAIRRO integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT NOME_BAIRRO FROM TBLBAIRROS WHERE upper(NOME_BAIRRO) like upper(:NomeBairro))) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLBAIRROS
            (NOME_BAIRRO)
            values 
            (:NomeBairro)
            returning ID_BAIRRO into :IdBairro;
      END
    
  if (Acao = 2) then
    
    BEGIN
     IF(Exists(SELECT ID_BAIRRO FROM TBLBAIRROS WHERE ID_BAIRRO like :IdDoBairro)) then
            IF(Exists(SELECT NOME_BAIRRO FROM TBLBAIRROS WHERE upper(NOME_BAIRRO) like upper(:NomeBairro) and ID_BAIRRO <> :IdDoBairro)) then
                exception EXC_ERRO_01;
             ELSE
                update TBLBAIRROS
                set NOME_BAIRRO = :NomeBairro
                where (ID_BAIRRO like :IdDoBairro)
                returning ID_BAIRRO into :IdBairro;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT NOME_BAIRRO FROM TBLBAIRROS WHERE ID_BAIRRO like :IdDoBairro)) then
         delete from TBLBAIRROS
         where (ID_BAIRRO like :IdDoBairro)
        returning ID_BAIRRO into :IdBairro;
       ELSE
        exception EXC_ERRO_02;
    END
     
  suspend; 
END^
SET TERM ; ^