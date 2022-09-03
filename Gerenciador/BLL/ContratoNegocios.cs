using System;
using System.Data;
using DTO;
using DbaCon;

namespace BLL
{
    public class ContratoNegocios
    {
        DataConexao dataConexao = new DataConexao();
        public string ManterContrato(Contrato contrato)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", contrato.Acao);
                dataConexao.AdicionarParametros("@Id_Contrato", contrato.Id_Contrato);
                dataConexao.AdicionarParametros("@Contrato_Aditivo", contrato.Contrato_Aditivo);
                dataConexao.AdicionarParametros("@Id_Modalidade", contrato.ModalidadeContrato.Id_Modalidade);
                dataConexao.AdicionarParametros("@Numero_Contrato", contrato.Numero_Contrato);
                dataConexao.AdicionarParametros("@Numero_Licitacao", contrato.Numero_Licitacao);
                dataConexao.AdicionarParametros("@Ano_Exercicio", contrato.Ano_Exercicio );
                dataConexao.AdicionarParametros("@Data_Inicio", contrato.Data_Inicial);
                dataConexao.AdicionarParametros("@Data_Final", contrato.Data_Final);
                dataConexao.AdicionarParametros("@Arquivo_Contrato", contrato.Arquivo_Contrato);
                dataConexao.AdicionarParametros("@Historico_Contrato", contrato.Historico_Contrato);
                dataConexao.AdicionarParametros("@Valor_Contrato", contrato.Valor_Contrato);
                dataConexao.AdicionarParametros("@Saldo_Contrato", contrato.Saldo_Contrato);
                dataConexao.AdicionarParametros("@Id_Orgao", contrato.OrgaoContrato.Id_Orgao);
                dataConexao.AdicionarParametros("@Id_Fornecedor", contrato.FornecedorContrato.Id_Fornecedor);
                dataConexao.AdicionarParametros("@Id_Genero", contrato.GeneroContrato.Id_Genero);
                dataConexao.AdicionarParametros("@Id_Usuario", contrato.UsuarioContrato.Id_Usuario);
                dataConexao.AdicionarParametros("@Contrato_Byte", contrato.Contrato_Byte);
                

                string idContrato = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterContrato").ToString();

                return idContrato;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ContratoColecao ConsultarContratoPorID(int idcontratos)
        {
            try
            {

                ContratoColecao contratoColecao = new ContratoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Id_Contrato", idcontratos);
                DataTable datatableContratos = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarContratosPorId");

                foreach (DataRow linha in datatableContratos.Rows)
                {


                    Contrato contrato = new Contrato();

                    contrato.Id_Contrato = Convert.ToInt32(linha["Id_Contrato"]);
                    contrato.Contrato_Aditivo = Convert.ToString(linha["Contrato_Aditivo"]);


                    contrato.ModalidadeContrato = new Modalidade();

                    contrato.ModalidadeContrato.Nome_Modalidade = Convert.ToString(linha["Id_Modalidade"]);

                    contrato.Numero_Contrato = Convert.ToString(linha["Numero_Contrato"]);
                    contrato.Numero_Licitacao = Convert.ToString(linha["Numero_Licitacao"]);
                    contrato.Ano_Exercicio = Convert.ToString(linha["Ano_Exercicio"]);
                    contrato.Data_Inicial = Convert.ToString(linha["Data_Inicio"]);
                    contrato.Data_Final = Convert.ToString(linha["Data_Final"]);
                    contrato.Arquivo_Contrato = Convert.ToString(linha["Arquivo_Contrato"]);
                    contrato.Historico_Contrato = Convert.ToString(linha["Historico_Contrato"]);
                    contrato.Valor_Contrato = Convert.ToDecimal(linha["Valor_Contrato"]);
                    contrato.Saldo_Contrato = Convert.ToDecimal(linha["Saldo_Contrato"]);

                    contrato.OrgaoContrato = new Orgao();

                    contrato.OrgaoContrato.Nome_Orgao = Convert.ToString(linha["Id_Orgao"]);

                    contrato.FornecedorContrato = new Fornecedor();

                    contrato.FornecedorContrato.Razao_Social = Convert.ToString(linha["Id_Fornecedor"]);

                    contrato.GeneroContrato = new Genero();

                    contrato.GeneroContrato.Nome_Genero = Convert.ToString(linha["Id_Genero"]);

                    contrato.UsuarioContrato = new Usuarios();

                    contrato.UsuarioContrato.Nome_Usuario = Convert.ToString(linha["Id_Usuario"]);

                    contratoColecao.Add(contrato);

                }
                return contratoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
        public ContratoColecao ConsultarContratoPorNumero(string contratos)
        {
            try
            {

                ContratoColecao contratoColecao = new ContratoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Numero_Contrato", contratos);
                DataTable datatableContratos = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarContratosPorNumero");

                foreach (DataRow linha in datatableContratos.Rows)
                {


                    Contrato contrato = new Contrato();

                    contrato.Id_Contrato = Convert.ToInt32(linha["Id_Contrato"]);
                    contrato.Contrato_Aditivo = Convert.ToString(linha["Contrato_Aditivo"]);
                    
                    contrato.ModalidadeContrato = new Modalidade();

                    contrato.ModalidadeContrato.Nome_Modalidade = Convert.ToString(linha["Id_Modalidade"]);

                    contrato.Numero_Contrato = Convert.ToString(linha["Numero_Contrato"]);
                    contrato.Numero_Licitacao = Convert.ToString(linha["Numero_Licitacao"]);
                    contrato.Ano_Exercicio = Convert.ToString(linha["Ano_Exercicio"]);
                    contrato.Data_Inicial = Convert.ToString(linha["Data_Inicio"]);
                    contrato.Data_Final = Convert.ToString(linha["Data_Final"]);
                    contrato.Arquivo_Contrato = Convert.ToString(linha["Arquivo_Contrato"]);
                    contrato.Historico_Contrato = Convert.ToString(linha["Historico_Contrato"]);
                    contrato.Valor_Contrato = Convert.ToDecimal(linha["Valor_Contrato"]);
                    contrato.Saldo_Contrato = Convert.ToDecimal(linha["Saldo_Contrato"]);

                    contrato.OrgaoContrato = new Orgao();

                    contrato.OrgaoContrato.Nome_Orgao = Convert.ToString(linha["Id_Orgao"]);

                    contrato.FornecedorContrato = new Fornecedor();

                    contrato.FornecedorContrato.Razao_Social = Convert.ToString(linha["Id_Fornecedor"]);

                    contrato.GeneroContrato = new Genero();

                    contrato.GeneroContrato.Nome_Genero = Convert.ToString(linha["Id_Genero"]);

                    contrato.UsuarioContrato = new Usuarios();

                    contrato.UsuarioContrato.Nome_Usuario = Convert.ToString(linha["Id_Usuario"]);

                    if (!Convert.IsDBNull(linha["Contrato_Byte"]))
                    {
                        contrato.Contrato_Byte = (byte[])(linha["Contrato_Byte"]);
                    }

                }
                return contratoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }

        public ContratoColecao ConsultarContratoPorFornecedor(string contratos)
        {
            try
            {

                ContratoColecao contratoColecao = new ContratoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Id_Fornecedor", contratos);
                DataTable datatableContratos = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarContratosPorFornec");

                foreach (DataRow linha in datatableContratos.Rows)
                {


                    Contrato contrato = new Contrato();

                    contrato.Id_Contrato = Convert.ToInt32(linha["Id_Contrato"]);
                    contrato.Contrato_Aditivo = Convert.ToString(linha["Contrato_Aditivo"]);
                    
                    contrato.ModalidadeContrato = new Modalidade();

                    contrato.ModalidadeContrato.Nome_Modalidade = Convert.ToString(linha["Id_Modalidade"]);

                    contrato.Numero_Contrato = Convert.ToString(linha["Numero_Contrato"]);
                    contrato.Numero_Licitacao = Convert.ToString(linha["Numero_Licitacao"]);
                    contrato.Ano_Exercicio = Convert.ToString(linha["Ano_Exercicio"]);
                    contrato.Data_Inicial = Convert.ToString(linha["Data_Inicio"]);
                    contrato.Data_Final = Convert.ToString(linha["Data_Final"]);
                    contrato.Arquivo_Contrato = Convert.ToString(linha["Arquivo_Contrato"]);
                    contrato.Historico_Contrato = Convert.ToString(linha["Historico_Contrato"]);
                    contrato.Valor_Contrato = Convert.ToDecimal(linha["Valor_Contrato"]);
                    contrato.Saldo_Contrato = Convert.ToDecimal(linha["Saldo_Contrato"]);

                    contrato.OrgaoContrato = new Orgao();

                    contrato.OrgaoContrato.Nome_Orgao = Convert.ToString(linha["Id_Orgao"]);

                    contrato.FornecedorContrato = new Fornecedor();

                    contrato.FornecedorContrato.Razao_Social = Convert.ToString(linha["Id_Fornecedor"]);

                    contrato.GeneroContrato = new Genero();

                    contrato.GeneroContrato.Nome_Genero = Convert.ToString(linha["Id_Genero"]);

                    contrato.UsuarioContrato = new Usuarios();

                    contrato.UsuarioContrato.Nome_Usuario = Convert.ToString(linha["Id_Usuario"]);

                    if (!Convert.IsDBNull(linha["Contrato_Byte"]))
                    {
                        contrato.Contrato_Byte = (byte[])(linha["Contrato_Byte"]);
                    }
                    

                     
                    contratoColecao.Add(contrato);

                }
                return contratoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
        public ContratoColecao ConsultarContValoreSaldo(int idContrato)
        {
            try
            {

                ContratoColecao contratoColecao = new ContratoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Id_Contrato", idContrato);
                DataTable datatableContratos = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "USPCONSULCONTVALORESALDO");

                foreach (DataRow linha in datatableContratos.Rows)
                {


                    Contrato contrato = new Contrato();

                    contrato.Id_Contrato = Convert.ToInt32(linha["Id_Contrato"]);
                    contrato.Contrato_Aditivo = Convert.ToString(linha["Contrato_Aditivo"]);
                    contrato.Valor_Contrato = Convert.ToDecimal(linha["Valor_Contrato"]);
                    contrato.Saldo_Contrato = Convert.ToDecimal(linha["Saldo_Contrato"]);
                    contratoColecao.Add(contrato);

                }
                return contratoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
