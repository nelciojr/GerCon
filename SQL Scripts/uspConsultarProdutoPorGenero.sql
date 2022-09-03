SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARPRODUTOPORGENERO (
    IDGENERO varchar(255) )
RETURNS (
    ID_PRODUTO integer,
    PRODUTO blob sub_type 1,
    ID_GENERO varchar(255) )
AS
BEGIN 
    FOR SELECT 
        ID_PRODUTO, PRODUTO, ID_GENERO
    from
        UVWPRODUTOSITENS
    where
        upper(ID_GENERO) containing upper(:IdGenero) order by PRODUTO
        into :Id_Produto, :Produto, :Id_Genero
        DO
SUSPEND; END^
SET TERM ; ^