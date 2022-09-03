using System;
using System.Data;
using DTO;
using DbaCon;

namespace BLL
{
    public class BaixaItensNegocios
    {
        DataConexao dataConexao = new DataConexao();
        
        public string ManterBaixaItens(BaixaItens baixaItens)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", baixaItens.Acao);
                dataConexao.AdicionarParametros("@Id_BaixaItem", baixaItens.Id_BaixaItem);
                dataConexao.AdicionarParametros("@Id_Item", baixaItens.Id_ItemBaixa.Id_Item);
                dataConexao.AdicionarParametros("@Numero_Nota", baixaItens.Numero_Nota);
                dataConexao.AdicionarParametros("@Data_BaixaItem", baixaItens.Data_BaixaItem);
                dataConexao.AdicionarParametros("@Qtde_BaixaItem", baixaItens.Qtde_BaixaItem);
                dataConexao.AdicionarParametros("@Valor_Baixa", baixaItens.Valor_Baixa);
                dataConexao.AdicionarParametros("@QtdeSaldo_BaixaItem", baixaItens.QtdeSaldo_BaixaItem);
                dataConexao.AdicionarParametros("@Saldo_BaixaItem", baixaItens.Saldo_BaixaItem);
                dataConexao.AdicionarParametros("@Id_Contrato", baixaItens.ContratoItem.Id_Contrato);
                dataConexao.AdicionarParametros("@Id_Departamento", baixaItens.DepartamentoItem.Id_Departamento);
                dataConexao.AdicionarParametros("@Id_Produto", baixaItens.ProdutoItem.Id_Produto);
                dataConexao.AdicionarParametros("@Id_Usuario", baixaItens.UsuarioItem.Id_Usuario);
                
                string idBaixaItens = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "USPMANTERBAIXAITEM").ToString();

                return idBaixaItens;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public BaixaItensColecao ConsultarItensporIdCont(int idcontrato, int usuario)
        {
            try
            {
             

                BaixaItensColecao baixaItensColecao = new BaixaItensColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Id_Contrato", idcontrato);
                dataConexao.AdicionarParametros("@Id_Usuario", usuario);
                dataConexao.AdicionarParametros("@Hoje", DateTime.Today);
                DataTable datatableBaixasContratos = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConBaixaItensporIds");

                foreach (DataRow linha in datatableBaixasContratos.Rows)
                {

                    BaixaItens baixaItens = new BaixaItens();

                    baixaItens.Id_BaixaItem = Convert.ToInt32(linha["Id_BaixaItem"]);

                    baixaItens.Id_ItemBaixa = new ItensContrato();

                    baixaItens.Id_ItemBaixa.Id_Item = Convert.ToInt32(linha["Id_Item"]);

                    baixaItens.Numero_Nota = Convert.ToDecimal(linha["Numero_Nota"]);
                    baixaItens.Data_BaixaItem = Convert.ToString(linha["Data_BaixaItem"]);
                    baixaItens.Qtde_BaixaItem = Convert.ToDecimal(linha["Qtde_BaixaItem"]);
                    baixaItens.Valor_Baixa = Convert.ToDecimal(linha["Valor_Baixa"]);
                    baixaItens.QtdeSaldo_BaixaItem = Convert.ToDecimal(linha["QtdeSaldo_BaixaItem"]);
                    baixaItens.Saldo_BaixaItem = Convert.ToDecimal(linha["Saldo_BaixaItem"]);

                    baixaItens.ContratoItem = new Contrato();

                    baixaItens.ContratoItem.Id_Contrato = Convert.ToInt32(linha["Id_Contrato"]);

                    baixaItens.DepartamentoItem = new Departamento();

                    baixaItens.DepartamentoItem.Nome_Departamento = Convert.ToString(linha["Id_Departamento"]);

                    baixaItens.ProdutoItem = new Produto();

                    baixaItens.ProdutoItem.Descricao = Convert.ToString(linha["Id_Produto"]);

                    baixaItens.UsuarioItem = new Usuarios();

                    baixaItens.UsuarioItem.Id_Usuario = Convert.ToInt32(linha["Id_Usuario"]);


                    baixaItensColecao.Add(baixaItens);

                }
                return baixaItensColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
    }
}
