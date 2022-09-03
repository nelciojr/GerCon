using System;
using System.Data;
using DTO;
using DbaCon;

namespace BLL
{
    public class ProdutoNegocios
    {
        DataConexao dataConexao = new DataConexao();
        public string ManterProduto(Produto produto)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", produto.Acao);
                dataConexao.AdicionarParametros("@Id_Produto", produto.Id_Produto);
                dataConexao.AdicionarParametros("@Decricao", produto.Descricao);
                dataConexao.AdicionarParametros("@Detalhe", produto.Detalhe);
                dataConexao.AdicionarParametros("@Id_UnidMedida", produto.UnidMedidaProduto.Id_UnidMedida);
                dataConexao.AdicionarParametros("@Id_Marca", produto.MarcaProduto.Id_Marca);
                dataConexao.AdicionarParametros("@Id_Genero",produto.GeneroProduto.Id_Genero);

                string idProduto = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterProduto").ToString();

                return idProduto;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ProdutoColecao ConsultarProdutoPorNome(string produtos)
        {
            try
            {

                ProdutoColecao produtoColecao = new ProdutoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Descricao", produtos);
                DataTable datatableProdutos = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarProdutoPorNome");

                foreach (DataRow linha in datatableProdutos.Rows)
                {

                    Produto produto = new Produto();

                    produto.Id_Produto = Convert.ToInt32(linha["Id_produto"]);
                    produto.Descricao = Convert.ToString(linha["Descricao"]);
                    produto.Detalhe = Convert.ToString(linha["Detalhe"]);

                    produto.UnidMedidaProduto = new UnidMedida();

                    produto.UnidMedidaProduto.Descricao = Convert.ToString(linha["Id_UnidMedida"]);

                    produto.MarcaProduto = new Marca();
                   
                    produto.MarcaProduto.Nome_Marca = Convert.ToString(linha["Id_Marca"]);

                    produto.GeneroProduto = new Genero();

                    produto.GeneroProduto.Nome_Genero = Convert.ToString(linha["Id_Genero"]);


                    produtoColecao.Add(produto);

                }
                return produtoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
        public ProdutoColecao ConsultarProdutoPorGenero(string genero)
        {
            try
            {

                ProdutoColecao produtoColecao = new ProdutoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Id_Genero", genero);
                DataTable datatableProdutos = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarProdutoPorGenero");

                foreach (DataRow linha in datatableProdutos.Rows)
                {

                    Produto produto = new Produto();

                    produto.Id_Produto = Convert.ToInt32(linha["Id_produto"]);
                    produto.Descricao = Convert.ToString(linha["Produto"]);
                   
                    produto.GeneroProduto = new Genero();

                    produto.GeneroProduto.Nome_Genero = Convert.ToString(linha["Id_Genero"]);


                    produtoColecao.Add(produto);

                }
                return produtoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
