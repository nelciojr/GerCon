using System;
using System.Data;
using DTO;
using DbaCon;

namespace BLL
{
    public class DepartamentoNegocios
    {
        DataConexao dataConexao = new DataConexao();
        public string ManterDepartamento(Departamento departamento)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", departamento.Acao);
                dataConexao.AdicionarParametros("@Id_Departamento", departamento.Id_Departamento);
                dataConexao.AdicionarParametros("@Nome_Departamento", departamento.Nome_Departamento);
                dataConexao.AdicionarParametros("@Endereco_Departmento", departamento.Endereco_Departamento);
                dataConexao.AdicionarParametros("@Tel_Fixo_Departamento", departamento.Tel_Fixo_Departamento);
                dataConexao.AdicionarParametros("@Id_Bairro", departamento.BairroDepartamento.Id_Bairro);
                dataConexao.AdicionarParametros("@Id_Cidade", departamento.CidadeDepartamento.Id_Cidade);
                dataConexao.AdicionarParametros("@Id_Estado", departamento.EstadoDepartamento.Id_Estado);
                dataConexao.AdicionarParametros("@Id_Orgao", departamento.OrgaoDepartamento.Id_Orgao);

                string idDepartamento = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterDepartamento").ToString();

                return idDepartamento;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public DepartamentoColecao ConsultarDepartamentoPorId(int iddepartamentos)
        {
            try
            {

                DepartamentoColecao departamentoColecao = new DepartamentoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Id_Departamento", iddepartamentos);
                DataTable datatableDepartamento = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarDepartamentoPorId");

                foreach (DataRow linha in datatableDepartamento.Rows)
                {

                    Departamento departamento = new Departamento();

                    departamento.Id_Departamento = Convert.ToInt32(linha["Id_Departamento"]);
                    departamento.Nome_Departamento = Convert.ToString(linha["Nome_Departamento"]);
                    departamento.Endereco_Departamento = Convert.ToString(linha["Endereco_Departamento"]);
                    departamento.Tel_Fixo_Departamento = Convert.ToString(linha["Tel_Fixo_Departamento"]);

                    departamento.BairroDepartamento = new Bairro();

                    departamento.BairroDepartamento.Nome_Bairro = Convert.ToString(linha["Id_Bairro"]);

                    departamento.CidadeDepartamento = new Cidade();

                    departamento.CidadeDepartamento.Nome_Cidade = Convert.ToString(linha["Id_Cidade"]);

                    departamento.EstadoDepartamento = new Estado();

                    departamento.EstadoDepartamento.Nome_Estado = Convert.ToString(linha["Id_Estado"]);

                    departamento.OrgaoDepartamento = new Orgao();

                    departamento.OrgaoDepartamento.Nome_Orgao = Convert.ToString(linha["Id_Orgao"]);


                    departamentoColecao.Add(departamento);

                }
                return departamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
        public DepartamentoColecao ConsultarDepartamentoPorNome(string departamentos)
        {
            try
            {

                DepartamentoColecao departamentoColecao = new DepartamentoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Nome_Departamento", departamentos);
                DataTable datatableDepartamento = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarDepartamentoPorNome");

                foreach (DataRow linha in datatableDepartamento.Rows)
                {

                    Departamento departamento = new Departamento();

                    departamento.Id_Departamento = Convert.ToInt32(linha["Id_Departamento"]);
                    departamento.Nome_Departamento = Convert.ToString(linha["Nome_Departamento"]);
                    departamento.Endereco_Departamento = Convert.ToString(linha["Endereco_Departamento"]);
                    departamento.Tel_Fixo_Departamento = Convert.ToString(linha["Tel_Fixo_Departamento"]);

                    departamento.BairroDepartamento = new Bairro();

                    departamento.BairroDepartamento.Nome_Bairro = Convert.ToString(linha["Id_Bairro"]);

                    departamento.CidadeDepartamento = new Cidade();

                    departamento.CidadeDepartamento.Nome_Cidade = Convert.ToString(linha["Id_Cidade"]);

                    departamento.EstadoDepartamento = new Estado();

                    departamento.EstadoDepartamento.Nome_Estado = Convert.ToString(linha["Id_Estado"]);

                    departamento.OrgaoDepartamento = new Orgao();

                    departamento.OrgaoDepartamento.Nome_Orgao= Convert.ToString(linha["Id_Orgao"]);


                    departamentoColecao.Add(departamento);

                }
                return departamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
        public DepartamentoColecao ConsultarDepartamentoPorOrgao(string orgao)
        {
            try
            {

                DepartamentoColecao departamentoColecao = new DepartamentoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Id_Orgao", orgao);
                DataTable datatableDepartamento = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarDepartPorOrgao");

                foreach (DataRow linha in datatableDepartamento.Rows)
                {

                    Departamento departamento = new Departamento();

                    departamento.Id_Departamento = Convert.ToInt32(linha["Id_Departamento"]);
                    departamento.Nome_Departamento = Convert.ToString(linha["Nome_Departamento"]);

                    departamento.OrgaoDepartamento = new Orgao();

                    departamento.OrgaoDepartamento.Nome_Orgao = Convert.ToString(linha["Id_Orgao"]);


                    departamentoColecao.Add(departamento);

                }
                return departamentoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
