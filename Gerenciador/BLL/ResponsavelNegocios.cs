using System;
using System.Data;
using DTO;
using DbaCon;


namespace BLL
{
    public class ResponsavelNegocios
    {
        DataConexao dataConexao = new DataConexao();
        public string ManterResponsavel(Responsavel responsavel)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", responsavel.Acao);
                dataConexao.AdicionarParametros("@Id_Responsavel", responsavel.Id_Responsavel);
                dataConexao.AdicionarParametros("@Nome_Responsavel", responsavel.Nome_Responsavel);
                dataConexao.AdicionarParametros("@DCPF_Responsavel", responsavel.CPF_Resposavel);
                dataConexao.AdicionarParametros("@Tel_Fixo_Responsavel", responsavel.Tel_Fixo_Responsavel);
                dataConexao.AdicionarParametros("@Tel_Cel_Responsavel", responsavel.Tel_Cel_Responsavel);
                
                string idResponsavel = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterResponsavel").ToString();

                return idResponsavel;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ResponsavelColecao ConsultarResponsavelPorNome(string responsaveis)
        {
            try
            {

                ResponsavelColecao responsavelColecao = new ResponsavelColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Nome_Responsavel", responsaveis);
                DataTable datatableResponsaveis = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarResponsavelPorNome");

                foreach (DataRow linha in datatableResponsaveis.Rows)
                {

                    Responsavel responsavel = new Responsavel();

                    responsavel.Id_Responsavel = Convert.ToInt32(linha["Id_Responsavel"]);
                    responsavel.Nome_Responsavel = Convert.ToString(linha["Nome_Responsavel"]);
                    responsavel.CPF_Resposavel = Convert.ToString(linha["CPF_Responsavel"]);
                    responsavel.Tel_Fixo_Responsavel = Convert.ToString(linha["Tel_Fixo_Responsavel"]);
                    responsavel.Tel_Cel_Responsavel = Convert.ToString(linha["Tel_Cel_Responsavel"]);

                   


                    responsavelColecao.Add(responsavel);

                }
                return responsavelColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
