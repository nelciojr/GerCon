using System;
using System.Data;
using DTO;
using DbaCon;


namespace BLL
{
    public class EstadoNegocios
    {
        DataConexao dataConexao = new DataConexao();

        public string ManterEstado(Estado estado)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", estado.Acao);
                dataConexao.AdicionarParametros("@Id_Estado", estado.Id_Estado);
                dataConexao.AdicionarParametros("@Nome_Estado", estado.Nome_Estado);
                dataConexao.AdicionarParametros("@UF", estado.UF);

                string idEstado = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterEstado").ToString();

                return idEstado;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public EstadoColecao ConsultarEstadosPorNome(string estados)
        {
            try
            {

                EstadoColecao estadoColecao = new EstadoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("Nome_Estado", estados);
                DataTable datatableEstados = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarEstadoPorNome");

                foreach (DataRow linha in datatableEstados.Rows)
                {

                    Estado estado = new Estado();

                    estado.Id_Estado = Convert.ToInt32(linha["Id_Estado"]);
                    estado.Nome_Estado = Convert.ToString(linha["Nome_Estado"]);
                    estado.UF = Convert.ToString(linha["UF"]);

                    estadoColecao.Add(estado);

                }
                return estadoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
