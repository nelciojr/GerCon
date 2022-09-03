using System;

namespace DTO
{
    public class BaixaItens
    {
        public int Acao { get; set; }
        public int Id_BaixaItem { get; set; }
        public ItensContrato Id_ItemBaixa { get; set; }
        public decimal Numero_Nota { get; set; }
        public string Data_BaixaItem { get; set; }
        public decimal Qtde_BaixaItem { get; set; }
        public decimal Valor_Baixa { get; set; }
        public decimal QtdeSaldo_BaixaItem { get; set; }
        public decimal Saldo_BaixaItem { get; set; }
        public Contrato ContratoItem { get; set; }
        public Departamento DepartamentoItem { get; set; }
        public Produto ProdutoItem { get; set; }
        public Usuarios UsuarioItem { get; set; }
    }
}
