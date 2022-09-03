using System;
using System.Data;
using DTO;
using DbaCon;

namespace BLL
{
    public class TipoNegocios
    {
        DataConexao dataConexao = new DataConexao();
        public TipoColecao ConsultarTipoPorNome(string tipos)
        {
            try
            {

                TipoColecao tipoColecao = new TipoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Nome_Tipo", tipos);
                DataTable datatableTipos = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarTipoPorNome");

                foreach (DataRow linha in datatableTipos.Rows)
                {

                    Tipo tipo = new Tipo();

                    tipo.Id_Tipo = Convert.ToInt32(linha["Id_Tipo"]);
                    tipo.Nome_Tipo = Convert.ToString(linha["Nome_Tipo"]);


                    tipoColecao.Add(tipo);

                }
                return tipoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
