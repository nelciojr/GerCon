SET TERM ^ ;
CREATE PROCEDURE USPMANTERMARCA (
    ACAO integer,
    IDDAMARCA integer,
    NOMEMARCA varchar(50) )
RETURNS (
    IDMARCA integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT NOME_MARCA FROM TBLMARCAS WHERE upper(NOME_MARCA) like upper(:NomeMarca))) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLMARCAS
            (NOME_MARCA)
            values 
            (:NomeMarca)
            returning ID_MARCA into :IdMarca;
      END
    
  if (Acao = 2) then
    
    BEGIN
      IF(Exists(SELECT ID_MARCA FROM TBLMARCAS WHERE ID_MARCA like :IdDaMarca)) then
            IF (Exists(SELECT NOME_MARCA FROM TBLMARCAS WHERE upper(NOME_MARCA) like upper(:NomeMarca) and ID_MARCA <> :IdDaMarca)) then
                exception EXC_ERRO_01;
            ELSE
                update TBLMARCAS
                set NOME_MARCA = :NomeMarca
                where (ID_MARCA like :IdDaMarca)
                returning ID_MARCA into :IdMarca;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT NOME_MARCA FROM TBLMARCAS WHERE ID_MARCA like :IdDaMarca)) then
         delete from TBLMARCAS
         where (ID_MARCA like :IdDaMarca)
        returning ID_MARCA into :IdMarca;
       ELSE
        exception EXC_ERRO_02;
    END
     
  suspend; 
END^
SET TERM ; ^