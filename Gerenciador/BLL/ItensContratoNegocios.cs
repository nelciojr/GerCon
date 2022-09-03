using System;
using System.Data;
using DTO;
using DbaCon;

namespace BLL
{
    public class ItensContratoNegocios
    {
        DataConexao dataConexao = new DataConexao();
        public string ManterItensContrato(ItensContrato itenscontrato)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", itenscontrato.Acao);
                dataConexao.AdicionarParametros("@Id_Item", itenscontrato.Id_Item);
                dataConexao.AdicionarParametros("@Qtde_Item", itenscontrato.Qtde_Item);
                dataConexao.AdicionarParametros("@Preco_Unitario", itenscontrato.Preco_Unitario);
                dataConexao.AdicionarParametros("@Preco_Total", itenscontrato.Preco_Total);
                dataConexao.AdicionarParametros("@Numero_Item", itenscontrato.Numero_Item);
                dataConexao.AdicionarParametros("@Data_Item", itenscontrato.Data_Item);
                dataConexao.AdicionarParametros("@Saldo_Item", itenscontrato.Saldo_Item);
                dataConexao.AdicionarParametros("@Qtde_SaldoItem", itenscontrato.Qtde_SaldoItem);
                dataConexao.AdicionarParametros("@Id_Contrato", itenscontrato.ContratoItem.Id_Contrato);
                dataConexao.AdicionarParametros("@Id_Produto", itenscontrato.ProdutoItem.Id_Produto);
                dataConexao.AdicionarParametros("@Id_Departamento", itenscontrato.DepartamentoItem.Id_Departamento);
                dataConexao.AdicionarParametros("@Id_Genero", itenscontrato.GeneroItem.Id_Genero);
                dataConexao.AdicionarParametros("@Id_Usuario", itenscontrato.UsuarioItem.Id_Usuario);

                string idItensContrato = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterItensContrato").ToString();

                return idItensContrato;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ItensContratoColecao ConsultarItensContratoPorNome(string itenscontratos)
        {
            try
            {

                ItensContratoColecao itenscontratoColecao = new ItensContratoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Id_Produto", itenscontratos);
                DataTable datatableItensContratos = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarItensContPorNome");

                foreach (DataRow linha in datatableItensContratos.Rows)
                {


                    ItensContrato itenscontrato = new ItensContrato();

                    itenscontrato.Id_Item = Convert.ToInt32(linha["Id_Item"]);
                    itenscontrato.Qtde_Item = Convert.ToInt32(linha["Qtde_Item"]);
                    itenscontrato.Preco_Unitario = Convert.ToDecimal(linha["Preco_Unitario"]);
                    itenscontrato.Preco_Total = Convert.ToDecimal(linha["Preco_Total"]);
                    itenscontrato.Numero_Item = Convert.ToInt32(linha["Numero_Item"]);
                    itenscontrato.Data_Item = Convert.ToString(linha["Data_Item"]);
                    itenscontrato.Saldo_Item = Convert.ToDecimal(linha["Saldo_Item"]);
                    itenscontrato.Qtde_SaldoItem = Convert.ToDecimal(linha["Qtde_SaldoItem"]);
                    
                    itenscontrato.ContratoItem = new Contrato();

                    itenscontrato.ContratoItem.Numero_Contrato = Convert.ToString(linha["Id_Contrato"]);

                    itenscontrato.ProdutoItem = new Produto();

                    itenscontrato.ProdutoItem.Descricao = Convert.ToString(linha["Id_Produto"]);

                    itenscontrato.DepartamentoItem = new Departamento();

                    itenscontrato.DepartamentoItem.Nome_Departamento = Convert.ToString(linha["Id_Departamento"]);

                    itenscontrato.GeneroItem = new Genero();

                    itenscontrato.GeneroItem.Nome_Genero = Convert.ToString(linha["Id_Genero"]);

                    itenscontrato.UsuarioItem = new Usuarios();

                    itenscontrato.UsuarioItem.Id_Usuario = Convert.ToInt32(linha["Id_Usuario"]);

                    itenscontratoColecao.Add(itenscontrato);

                }
                return itenscontratoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
        public ItensContratoColecao ConsultarItensPorIdConteDep(int idContrato, string departamento)
        {
            try
            {

                ItensContratoColecao itenscontratoColecao = new ItensContratoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Id_Contrato", idContrato);
                dataConexao.AdicionarParametros("@Id_Departamento", departamento);
                DataTable datatableItensContratos = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "USPCONITENSPORIDCONTEDEP");

                foreach (DataRow linha in datatableItensContratos.Rows)
                {


                    ItensContrato itenscontrato = new ItensContrato();

                    itenscontrato.Id_Item = Convert.ToInt32(linha["Id_Item"]);
                    itenscontrato.Qtde_Item = Convert.ToInt32(linha["Qtde_Item"]);
                    itenscontrato.Preco_Unitario = Convert.ToDecimal(linha["Preco_Unitario"]);
                    itenscontrato.Preco_Total = Convert.ToDecimal(linha["Preco_Total"]);
                    itenscontrato.Numero_Item = Convert.ToInt32(linha["Numero_Item"]);
                    itenscontrato.Data_Item = Convert.ToString(linha["Data_Item"]);
                    itenscontrato.Saldo_Item = Convert.ToDecimal(linha["Saldo_Item"]);
                    itenscontrato.Qtde_SaldoItem = Convert.ToDecimal(linha["Qtde_SaldoItem"]);

                    itenscontrato.ContratoItem = new Contrato();

                    itenscontrato.ContratoItem.Numero_Contrato = Convert.ToString(linha["Id_Contrato"]);

                    itenscontrato.ProdutoItem = new Produto();

                    itenscontrato.ProdutoItem.Descricao = Convert.ToString(linha["Id_Produto"]);

                    itenscontrato.DepartamentoItem = new Departamento();

                    itenscontrato.DepartamentoItem.Nome_Departamento = Convert.ToString(linha["Id_Departamento"]);

                    itenscontrato.GeneroItem = new Genero();

                    itenscontrato.GeneroItem.Nome_Genero = Convert.ToString(linha["Id_Genero"]);

                    itenscontrato.UsuarioItem = new Usuarios();

                    itenscontrato.UsuarioItem.Id_Usuario = Convert.ToInt32(linha["Id_Usuario"]);

                    itenscontratoColecao.Add(itenscontrato);

                }
                return itenscontratoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
        public ItensContratoColecao ConsultarItensPorIdCont(int idContrato, string departamento)
        {
            try
            {

                ItensContratoColecao itenscontratoColecao = new ItensContratoColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Id_Contrato", idContrato);
                dataConexao.AdicionarParametros("@Id_Departamento", departamento);
                DataTable datatableItensContratos = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "USPCONITENSCONTPORIDCONT");

                foreach (DataRow linha in datatableItensContratos.Rows)
                {


                    ItensContrato itenscontrato = new ItensContrato();

                    itenscontrato.Id_Item = Convert.ToInt32(linha["Id_Item"]);
                    itenscontrato.Qtde_Item = Convert.ToInt32(linha["Qtde_Item"]);
                    itenscontrato.Preco_Unitario = Convert.ToDecimal(linha["Preco_Unitario"]);
                    itenscontrato.Preco_Total = Convert.ToDecimal(linha["Preco_Total"]);
                    itenscontrato.Numero_Item = Convert.ToInt32(linha["Numero_Item"]);
                    itenscontrato.Data_Item = Convert.ToString(linha["Data_Item"]);
                    itenscontrato.Saldo_Item = Convert.ToDecimal(linha["Saldo_Item"]);
                    itenscontrato.Qtde_SaldoItem = Convert.ToDecimal(linha["Qtde_SaldoItem"]);

                    itenscontrato.ContratoItem = new Contrato();

                    itenscontrato.ContratoItem.Id_Contrato = Convert.ToInt32(linha["Id_Contrato"]);

                    itenscontrato.ProdutoItem = new Produto();

                    itenscontrato.ProdutoItem.Descricao = Convert.ToString(linha["Id_Produto"]);

                    itenscontrato.DepartamentoItem = new Departamento();

                    itenscontrato.DepartamentoItem.Nome_Departamento = Convert.ToString(linha["Id_Departamento"]);

                    itenscontrato.GeneroItem = new Genero();

                    itenscontrato.GeneroItem.Nome_Genero = Convert.ToString(linha["Id_Genero"]);

                    itenscontrato.UsuarioItem = new Usuarios();

                    itenscontrato.UsuarioItem.Id_Usuario = Convert.ToInt32(linha["Id_Usuario"]);

                    itenscontratoColecao.Add(itenscontrato);

                }
                return itenscontratoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
