using System;
using System.Data;
using DTO;
using DbaCon;


namespace BLL
{
    public class FornecedorNegocios
    {
        DataConexao dataConexao = new DataConexao();
        public string ManterFornecedor(Fornecedor fornecedor)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", fornecedor.Acao);
                dataConexao.AdicionarParametros("@Id_Fornecedor", fornecedor.Id_Fornecedor);
                dataConexao.AdicionarParametros("@Razao_Social", fornecedor.Razao_Social);
                dataConexao.AdicionarParametros("@Nome_Fantasia", fornecedor.Nome_Fantasia);
                dataConexao.AdicionarParametros("@CPF_CNPJ", fornecedor.CPF_CNPJ);
                dataConexao.AdicionarParametros("@Endereco_Fornecedor", fornecedor.Endereco_Fornecedor);
                dataConexao.AdicionarParametros("@Tel_Fixo_Fornecedor", fornecedor.Tel_Fixo_Fornecedor);
                dataConexao.AdicionarParametros("@Tel_Cel_Fornecedor", fornecedor.Tel_Cel_Fornecedor);
                dataConexao.AdicionarParametros("@Id_Bairro", fornecedor.BairroFornecedor.Id_Bairro);
                dataConexao.AdicionarParametros("@Id_Cidade", fornecedor.CidadeFornecedor.Id_Cidade);
                dataConexao.AdicionarParametros("@Id_Estado", fornecedor.EstadoFornecedor.Id_Estado);
                dataConexao.AdicionarParametros("@Contato", fornecedor.Contato);
                dataConexao.AdicionarParametros("@Email_Fornecedor", fornecedor.Email_Fornecedor);

                string idFornecedor = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterFornecedor").ToString();

                return idFornecedor;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public FornecedorColecao ConsultarFornecedorPorNome(string fornecedores)
        {
            try
            {

                FornecedorColecao fornecedorColecao = new FornecedorColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Nome_Fornecedor", fornecedores);
                DataTable datatableFornecedor = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarFornecedorPorNome");

                foreach (DataRow linha in datatableFornecedor.Rows)
                {

                    Fornecedor fornecedor = new Fornecedor();

                    fornecedor.Id_Fornecedor = Convert.ToInt32(linha["Id_Fornecedor"]);
                    fornecedor.Razao_Social = Convert.ToString(linha["Razao_Social"]);
                    fornecedor.Nome_Fantasia = Convert.ToString(linha["Nome_Fantasia"]);
                    fornecedor.CPF_CNPJ = Convert.ToString(linha["CPF_CNPJ"]);
                    fornecedor.Endereco_Fornecedor = Convert.ToString(linha["Endereco_Fornecedor"]);
                    fornecedor.Tel_Fixo_Fornecedor = Convert.ToString(linha["Tel_Fixo_Fornecedor"]);
                    fornecedor.Tel_Cel_Fornecedor = Convert.ToString(linha["Tel_Cel_Fornecedor"]);

                    fornecedor.BairroFornecedor = new Bairro();

                    fornecedor.BairroFornecedor.Nome_Bairro = Convert.ToString(linha["Id_Bairro"]);

                    fornecedor.CidadeFornecedor = new Cidade();

                    fornecedor.CidadeFornecedor.Nome_Cidade = Convert.ToString(linha["Id_Cidade"]);

                    fornecedor.EstadoFornecedor = new Estado();

                    fornecedor.EstadoFornecedor.Nome_Estado= Convert.ToString(linha["Id_Estado"]);
                                 
                    fornecedor.Contato= Convert.ToString(linha["Contato"]);
                    fornecedor.Email_Fornecedor = Convert.ToString(linha["Email_Fornecedor"]);
                    


                    fornecedorColecao.Add(fornecedor);

                }
                return fornecedorColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
