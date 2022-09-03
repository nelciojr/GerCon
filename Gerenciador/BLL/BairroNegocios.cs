using System;
using System.Data;
using DTO;
using DbaCon;

namespace BLL
{
   public class BairroNegocios
    {
        DataConexao dataConexao = new DataConexao();
        public string ManterBairro(Bairro bairro)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", bairro.Acao);
                dataConexao.AdicionarParametros("@Id_Bairro", bairro.Id_Bairro);
                dataConexao.AdicionarParametros("@Nome_Bairro", bairro.Nome_Bairro);

                string idBairro = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterBairro").ToString();

                return idBairro;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public BairroColecao ConsultarBairroPorNome(string bairros)
        {
            try
            {

                BairroColecao bairroColecao = new BairroColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Nome_Bairro", bairros);
                DataTable datatableBairros = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarBairroPorNome");

                foreach (DataRow linha in datatableBairros.Rows)
                {

                    Bairro bairro = new Bairro();

                    bairro.Id_Bairro = Convert.ToInt32(linha["Id_Bairro"]);
                    bairro.Nome_Bairro = Convert.ToString(linha["Nome_Bairro"]);


                    bairroColecao.Add(bairro);

                }
                return bairroColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
