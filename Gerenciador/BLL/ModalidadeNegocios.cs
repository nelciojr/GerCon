using System;
using System.Data;
using DTO;
using DbaCon;

namespace BLL
{
    public class ModalidadeNegocios
    {
        DataConexao dataConexao = new DataConexao();
        public ModalidadeColecao ConsultarModalidadePorNome(string modalidades)
        {
            try
            {

                ModalidadeColecao modalidadeColecao = new ModalidadeColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Nome_Modalidade", modalidades);
                DataTable datatableModalidades = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarModalidadePorNome");

                foreach (DataRow linha in datatableModalidades.Rows)
                {

                    Modalidade modalidade = new Modalidade();

                    modalidade.Id_Modalidade = Convert.ToInt32(linha["Id_Modalidade"]);
                    modalidade.Nome_Modalidade = Convert.ToString(linha["Nome_Modalidade"]);


                    modalidadeColecao.Add(modalidade);

                }
                return modalidadeColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
