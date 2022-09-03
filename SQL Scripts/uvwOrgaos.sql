CREATE VIEW UVWORGAOS (ID_ORGAO, NOME_ORGAO, ENDERECO_ORGAO, TEL_FIXO_ORGAO, ID_BAIRRO,
 ID_CIDADE, ID_ESTADO, ID_RESPONSAVEL)
AS select o.ID_ORGAO, o.NOME_ORGAO, o.ENDERECO_ORGAO, o.TEL_FIXO_ORGAO, b.NOME_BAIRRO, 
c.NOME_CIDADE, e.NOME_ESTADO, r.NOME_RESPONSAVEL
from TBLORGAOS o, TBLBAIRROS b, TBLCIDADES c, TBLESTADOS e, TBLRESPONSAVEIS r
where O.ID_BAIRRO like b.ID_BAIRRO and o.ID_CIDADE like c.ID_CIDADE and o.ID_ESTADO like e.ID_ESTADO and 
o.ID_RESPONSAVEL like r.ID_RESPONSAVEL;
