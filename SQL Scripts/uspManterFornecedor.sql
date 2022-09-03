SET TERM ^ ;
CREATE PROCEDURE USPMANTERFORNECEDOR (
    ACAO integer,
    IDDOFORNECEDOR integer,
    RAZAOSOCIAL varchar(100),
    NOMEFANTASIA varchar(100),
    CPFCNPJ varchar(20),
    ENDERECOFORNECEDOR varchar(255),
    TELFIXOFORNECEDOR varchar(15),
    TELCELFORNECEDOR varchar(15),
    IDBAIRRO integer,
    IDCIDADE integer,
    IDESTADO integer,
    CONTATOFORNECEDOR varchar(100),
    EMAILFORNECEDOR varchar(100) )
RETURNS (
    IDFORNECEDOR integer )
AS
BEGIN
  if (Acao = 1) then
     
    BEGIN
        IF(Exists(SELECT CPF_CNPJ FROM TBLFORNECEDORES WHERE upper(CPF_CNPJ) like upper(:CPFCNPJ))) then
            exception EXC_ERRO_01;
        
        ELSE
			insert into TBLFORNECEDORES
            (RAZAO_SOCIAL, NOME_FANTASIA, CPF_CNPJ, ENDERECO_FORNECEDOR, TEL_FIXO_FORNECEDOR, TEL_CEL_FORNECEDOR, ID_BAIRRO, ID_CIDADE, ID_ESTADO, CONTATO, EMAIL_FORNECEDOR)
            values 
            (:RazaoSocial, :NomeFantasia, :CPFCNPJ, :EnderecoFornecedor, :TelFixoFornecedor, :TelCelFornecedor, :IdBairro, :IdCidade, :IdEstado, :ContatoFornecedor, :EmailFornecedor)
            returning ID_FORNECEDOR into :IdFornecedor;
    END
    if (Acao = 2) then
    
    BEGIN
      IF(Exists(SELECT ID_FORNECEDOR FROM TBLFORNECEDORES WHERE ID_FORNECEDOR like :IdDoFornecedor)) then
            IF(Exists(SELECT CPF_CNPJ FROM TBLFORNECEDORES WHERE upper(CPF_CNPJ) like upper(:CPFCNPJ) and ID_FORNECEDOR <> :IdDoFornecedor)) then
                exception EXC_ERRO_01;
             ELSE
                update TBLFORNECEDORES
                set RAZAO_SOCIAL = :RazaoSocial,
                    NOME_FANTASIA = :NomeFantasia,
                    CPF_CNPJ = :CPFCNPJ,
                    ENDERECO_FORNECEDOR = :EnderecoFornecedor,
                    TEL_FIXO_FORNECEDOR = :TelFixoFornecedor,
                    TEL_CEL_FORNECEDOR = :TelCelFornecedor,
                    ID_BAIRRO = :IdBairro,
                    ID_CIDADE = :IdCidade,
                    ID_ESTADO = :IdEstado,
                    CONTATO = :ContatoFornecedor,
                    EMAIL_FORNECEDOR = :EmailFornecedor
                where (ID_FORNECEDOR like :IdDoFornecedor)
                returning ID_FORNECEDOR into :IdFornecedor;
      ELSE
        exception EXC_ERRO_02;
    END
    
   if (Acao =3) then
     
    BEGIN
       IF (exists(SELECT CPF_CNPJ FROM TBLFORNECEDORES WHERE ID_FORNECEDOR like :IdDoFornecedor)) then
         delete from TBLFORNECEDORES
         where (ID_FORNECEDOR like :IdDoFornecedor)
        returning ID_FORNECEDOR into :IdFornecedor;
       ELSE
        exception EXC_ERRO_02;
    END
    
     
  suspend; 
END^
SET TERM ; ^