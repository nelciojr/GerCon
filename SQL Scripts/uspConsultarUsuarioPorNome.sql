SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARUSUARIOPORNOME (
    NOMEUSUARIO varchar(100) )
RETURNS (
    ID_USUARIO integer,
    NOME_USUARIO varchar(100),
    LOGIN varchar(50),
    SENHA varchar(50),
    TIPO varchar(15) )
AS
BEGIN
  
  FOR select 
    ID_USUARIO, NOME_USUARIO, LOGIN, SENHA, TIPO
  from 
   UVWUSUARIOS
  where 
    upper(NOME_USUARIO) containing upper(:NomeUsuario) order by NOME_USUARIO
  into :Id_Usuario, :Nome_Usuario, :Login, :Senha, :Tipo
  DO
  suspend;
END^
SET TERM ; ^