using System;
using System.Data;
using DTO;
using DbaCon;


namespace BLL
{
    public class CidadeNegocios
    {
        //Conexão Banco de Dados

        DataConexao dataConexao = new DataConexao();
        public string ManterCidade(Cidade cidade)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", cidade.Acao);
                dataConexao.AdicionarParametros("@Id_Bairro", cidade.Id_Cidade);
                dataConexao.AdicionarParametros("@Nome_Cidade", cidade.Nome_Cidade);
                dataConexao.AdicionarParametros("@Estado", cidade.EstadoCidade.Id_Estado);

                string idCidade = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterCidade").ToString();

                return idCidade;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public CidadeColecao ConsultarCidadePorNome(string cidades)
        {
            try
            {

                CidadeColecao cidadeColecao = new CidadeColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Nome_Cidade", cidades);
                DataTable datatableCidades = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarCidadePorNome");

                foreach (DataRow linha in datatableCidades.Rows)
                {

                    Cidade cidade = new Cidade();

                    cidade.Id_Cidade = Convert.ToInt32(linha["Id_Cidade"]);
                    cidade.Nome_Cidade = Convert.ToString(linha["Nome_Cidade"]);

                    Estado estado = new Estado();

                    estado.UF = Convert.ToString(linha["UF"]);

                    cidadeColecao.Add(cidade);

                }
                return cidadeColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
        public CidadeColecao ConsultarCidadePorIdEstado(int idEstado)
        {
            try
            {

                CidadeColecao cidadeColecao = new CidadeColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Id_Estado", idEstado);
                DataTable datatableCidades = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarCidadePorIdEstado");

                foreach (DataRow linha in datatableCidades.Rows)
                {

                    Cidade cidade = new Cidade();

                    cidade.Id_Cidade = Convert.ToInt32(linha["Id_Cidade"]);
                    cidade.Nome_Cidade = Convert.ToString(linha["Nome_Cidade"]);

                    cidade.EstadoCidade = new Estado();

                    cidade.EstadoCidade.Id_Estado = Convert.ToInt32(linha["Id_Estado"]);

                    cidadeColecao.Add(cidade);

                }
                return cidadeColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
