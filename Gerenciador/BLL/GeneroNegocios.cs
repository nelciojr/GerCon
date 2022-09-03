using System;
using System.Data;
using DTO;
using DbaCon;


namespace BLL
{
    public class GeneroNegocios
    {

        DataConexao dataConexao = new DataConexao();
        public string ManterGenero(Genero genero)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", genero.Acao);
                dataConexao.AdicionarParametros("@Id_Genero", genero.Id_Genero);
                dataConexao.AdicionarParametros("@Genero", genero.Nome_Genero);

                string idGenero = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterGenero").ToString();

                return idGenero;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public GeneroColecao ConsultarGeneroPorNome(string generos)
        {
            try
            {

                GeneroColecao generoColecao = new GeneroColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Genero", generos);
                DataTable datatableGeneros = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarGeneroPorNome");

                foreach (DataRow linha in datatableGeneros.Rows)
                {


                    Genero genero = new Genero();

                    genero.Id_Genero = Convert.ToInt32(linha["Id_Genero"]);
                    genero.Nome_Genero = Convert.ToString(linha["Nome_Genero"]);


                    generoColecao.Add(genero);

                }
                return generoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
