using System;
using System.Data;
using DTO;
using DbaCon;


namespace BLL
{
    public class OrgaoNegocios
    {
        DataConexao dataConexao = new DataConexao();
        public string ManterOrgao(Orgao orgao)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", orgao.Acao);
                dataConexao.AdicionarParametros("@Id_Orgao", orgao.Id_Orgao);
                dataConexao.AdicionarParametros("@Nome_Orgao", orgao.Nome_Orgao);
                dataConexao.AdicionarParametros("@Endereco_Orgao", orgao.Endereco_Orgao);
                dataConexao.AdicionarParametros("@Tel_Fixo_Orgao", orgao.Tel_Fixo_Orgao);
                dataConexao.AdicionarParametros("@Id_Bairro", orgao.BairroOrgao.Id_Bairro);
                dataConexao.AdicionarParametros("@Id_Cidade", orgao.CidadeOrgao.Id_Cidade);
                dataConexao.AdicionarParametros("@Id_Estado", orgao.EstadoOrgao.Id_Estado);
                dataConexao.AdicionarParametros("@Id_Responsavel", orgao.ResponsavelOrgao.Id_Responsavel);

                string idOrgao = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterOrgao").ToString();

                return idOrgao;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public OrgaoColecao ConsultarOrgaoPorNome(string orgaos)
        {
            try
            {

                OrgaoColecao orgaoColecao = new OrgaoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Nome_Orgao", orgaos);
                DataTable datatableOrgao = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarOrgaoPorNome");

                foreach (DataRow linha in datatableOrgao.Rows)
                {

                    Orgao orgao = new Orgao();

                    orgao.Id_Orgao = Convert.ToInt32(linha["Id_Orgao"]);
                    orgao.Nome_Orgao = Convert.ToString(linha["Nome_Orgao"]);
                    orgao.Endereco_Orgao = Convert.ToString(linha["Endereco_Orgao"]);
                    orgao.Tel_Fixo_Orgao = Convert.ToString(linha["Tel_Fixo_Orgao"]);

                    orgao.BairroOrgao = new Bairro();

                    orgao.BairroOrgao.Nome_Bairro = Convert.ToString(linha["Id_Bairro"]);

                    orgao.CidadeOrgao = new Cidade();

                    orgao.CidadeOrgao.Nome_Cidade = Convert.ToString(linha["Id_Cidade"]);

                    orgao.EstadoOrgao = new Estado();

                    orgao.EstadoOrgao.Nome_Estado = Convert.ToString(linha["Id_Estado"]);

                    orgao.ResponsavelOrgao = new Responsavel();

                    orgao.ResponsavelOrgao.Nome_Responsavel = Convert.ToString(linha["Id_Responsavel"]);


                    orgaoColecao.Add(orgao);

                }
                return orgaoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
