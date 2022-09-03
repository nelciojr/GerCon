using System;
using System.Data;
using DTO;
using DbaCon;


namespace BLL
{
    public class UnidMedidaNegocios
    {
        DataConexao dataConexao = new DataConexao();

        public string ManterUnidMedida(UnidMedida unidMedida)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", unidMedida.Acao);
                dataConexao.AdicionarParametros("@Id_UnidMedida", unidMedida.Id_UnidMedida);
                dataConexao.AdicionarParametros("@Descricao", unidMedida.Descricao);
                dataConexao.AdicionarParametros("@Legenda", unidMedida.Legenda);

                string idUnidMedida = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterUnidMedida").ToString();

                return idUnidMedida;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public UnidMedidaColecao ConsultarUnidMedidaPorNome(string unidMedidas)
        {
            try
            {

                UnidMedidaColecao unidMedidaColecao = new UnidMedidaColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Descricao", unidMedidas);
                DataTable datatableUnidMedidas = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarUnidMedidaPorNome");

                foreach (DataRow linha in datatableUnidMedidas.Rows)
                {
                    UnidMedida unidMedida = new UnidMedida();

                    unidMedida.Id_UnidMedida = Convert.ToInt32(linha["Id_UnidMedida"]);
                    unidMedida.Descricao = Convert.ToString(linha["Descricao"]);
                    unidMedida.Legenda = Convert.ToString(linha["Legenda"]);


                    unidMedidaColecao.Add(unidMedida);

                }
                return unidMedidaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}


