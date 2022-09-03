SET TERM ^ ;
CREATE PROCEDURE USPMANTERUSUARIO (
    ACAO integer,
    IDDOUSUARIO integer,
    NOMEUSUARIO varchar(100),
    LOGINUSUARIO varchar(20),
    SENHAUSUARIO varchar(8),
    TIPOUSUARIO integer )
RETURNS (
    IDUSUARIO integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT LOGIN FROM TBLUSUARIOS WHERE upper(LOGIN) like upper(:LoginUsuario))) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLUSUARIOS
            (NOME_USUARIO, LOGIN, SENHA, TIPO)
            values 
            (:NomeUsuario, :LoginUsuario, :SenhaUsuario, :TipoUsuario)
            returning ID_USUARIO into :IdUsuario;
      END
    
  if (Acao = 2) then
    
    BEGIN
      IF(Exists(SELECT ID_USUARIO FROM TBLUSUARIOS WHERE ID_USUARIO like :IdDoUsuario)) then
            IF(Exists(SELECT LOGIN FROM TBLUSUARIOS WHERE upper(LOGIN) like upper(:LoginUsuario) and ID_USUARIO <> :IdDoUsuario)) then
                exception EXC_ERRO_01;
             ELSE
                update TBLUSUARIOS
                set NOME_USUARIO  = :NomeUsuario,
                    LOGIN         = :LoginUsuario,
                    SENHA         = :SenhaUsuario,
                    TIPO          = :TipoUsuario
                where (ID_USUARIO like :IdDoUsuario)
                returning ID_USUARIO into :IdUsuario;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT LOGIN FROM TBLUSUARIOS WHERE ID_USUARIO like :IdDoUsuario)) then
         delete from TBLUSUARIOS
         where (ID_USUARIO like :IdDoUsuario)
        returning ID_USUARIO into :IdUsuario;
       ELSE
        exception EXC_ERRO_02;
    END
     
  suspend; 
END^
SET TERM ; ^