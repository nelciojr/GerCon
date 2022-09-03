using System;
using System.Data;
using DTO;
using DbaCon;

namespace DTO
{
    public class MarcaNegocios
    {
        DataConexao dataConexao = new DataConexao();
        public string ManterMarca(Marca marca)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", marca.Acao);
                dataConexao.AdicionarParametros("@Id_Marca", marca.Id_Marca);
                dataConexao.AdicionarParametros("@Nome_Marca", marca.Nome_Marca);

                string idMarca = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterMarca").ToString();

                return idMarca;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public MarcaColecao ConsultarMarcaPorNome(string marcas)
        {
            try
            {

                MarcaColecao marcaColecao = new MarcaColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Nome_Marca", marcas);
                DataTable datatableMarcas = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarMarcaPorNome");

                foreach (DataRow linha in datatableMarcas.Rows)
                {

                    Marca marca = new Marca();

                    marca.Id_Marca = Convert.ToInt32(linha["Id_Marca"]);
                    marca.Nome_Marca = Convert.ToString(linha["Nome_Marca"]);


                    marcaColecao.Add(marca);

                }
                return marcaColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
