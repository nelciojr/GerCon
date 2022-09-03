SET TERM ^ ;
CREATE PROCEDURE USPMANTERGENERO (
    ACAO integer,
    IDDOGENERO integer,
    NOMEGENERO varchar(50) )
RETURNS (
    IDGENERO integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT NOME_GENERO FROM TBLGENEROS WHERE upper(NOME_GENERO) like upper(:NomeGenero))) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLGENEROS
            (NOME_GENERO)
            values 
            (:NomeGenero)
            returning ID_GENERO into :IdGenero;
      END
    
  if (Acao = 2) then
    
    BEGIN
      IF(Exists(SELECT ID_GENERO FROM TBLGENEROS WHERE ID_GENERO like :IdDoGenero)) then
            IF (Exists(SELECT NOME_GENERO FROM TBLGENEROS WHERE upper(NOME_GENERO) like upper(:NomeGenero) and ID_GENERO <> :IdDoGenero)) then
                exception EXC_ERRO_01;
             ELSE
                update TBLGENEROS
                set NOME_GENERO = :NomeGenero
                where (ID_GENERO like :IdDoGenero)
                returning ID_GENERO into :IdGenero;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT NOME_GENERO FROM TBLGENEROS WHERE ID_GENERO like :IdDoGenero)) then
         delete from TBLGENEROS
         where (ID_GENERO like :IdDoGenero)
        returning ID_GENERO into :IdGenero;
       ELSE
        exception EXC_ERRO_02;
    END
     
  suspend; 
END^
SET TERM ; ^