SET TERM ^ ;
CREATE PROCEDURE USPMANTERPRODUTO (
    ACAO integer,
    IDDOPRODUTO integer,
    DESCRICAOPRODUTO varchar(255),
    DETALHEPRODUTO varchar(255),
    IDUNIDMEDIDA integer,
    IDMARCA integer,
    IDGENERO integer )
RETURNS (
    IDPRODUTO integer )
AS
BEGIN
  if (Acao = 1) then
     
      BEGIN
        IF(Exists(SELECT DESCRICAO FROM TBLPRODUTOS WHERE upper(DESCRICAO) like upper(:DescricaoProduto))) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLPRODUTOS
            (DESCRICAO, DETALHE, ID_UNIDMEDIDA, ID_MARCA, ID_GENERO)
            values 
            (:DescricaoProduto, :DetalheProduto, :IdUnidMedida, :IdMarca, :IdGenero)
            returning ID_PRODUTO into :IdProduto;
      END
    
  if (Acao = 2) then
    
    BEGIN
      IF(Exists(SELECT ID_PRODUTO FROM TBLPRODUTOS WHERE ID_PRODUTO like :IdDoProduto)) then
            IF(Exists(SELECT DESCRICAO FROM TBLPRODUTOS WHERE upper(DESCRICAO) like upper(:DescricaoProduto) and ID_PRODUTO <> :IdDoProduto)) then
                exception EXC_ERRO_01;
             ELSE
                update TBLPRODUTOS
                set DESCRICAO = :DescricaoProduto,
                    DETALHE = :DetalheProduto,
                    ID_UNIDMEDIDA = :IdUnidMedida,
                    ID_MARCA = :IdMarca,
                    ID_GENERO = :IdGenero
                    
                where (ID_PRODUTO like :IdDoProduto)
                returning ID_PRODUTO into :IdProduto;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT DESCRICAO FROM TBLPRODUTOS WHERE ID_PRODUTO like :IdDoProduto)) then
         delete from TBLPRODUTOS
         where (ID_PRODUTO like :IdDoProduto)
        returning ID_PRODUTO into :IdProduto;
       ELSE
        exception EXC_ERRO_02;
    END
     
  suspend; 
END^
SET TERM ; ^