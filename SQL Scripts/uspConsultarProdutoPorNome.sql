SET TERM ^ ;
CREATE PROCEDURE USPCONSULTARPRODUTOPORNOME (
    DESCRICAOPRODUTO varchar(50) )
RETURNS (
    ID_PRODUTO integer,
    DESCRICAO varchar(255),
    DETALHE varchar(255),
    ID_UNIDMEDIDA varchar(255),
    ID_MARCA varchar(255),
    ID_GENERO varchar(255) )
AS
BEGIN 
    FOR SELECT 
        ID_PRODUTO, DESCRICAO, DETALHE, ID_UNIDMEDIDA, ID_MARCA, ID_GENERO
    from
        UVWPRODUTOS
    where
        upper(DESCRICAO) containing upper(:DescricaoProduto) order by DESCRICAO
        into :Id_Produto, :Descricao, :Detalhe, :Id_UnidMedida, :Id_Marca, :Id_Genero
        DO
SUSPEND; END^
SET TERM ; ^