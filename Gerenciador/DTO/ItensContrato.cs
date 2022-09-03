
namespace DTO
{
    public class ItensContrato
    {
        public int Acao { get; set; }
        public int Id_Item { get; set; }
        public decimal Qtde_Item { get; set; }
        public decimal Preco_Unitario { get; set; }
        public decimal Preco_Total { get; set; }
        public int Numero_Item { get; set; }
        public string Data_Item { get; set; }
        public decimal Saldo_Item { get; set; }
        public decimal Qtde_SaldoItem { get; set; }
        public Contrato ContratoItem { get; set; }
        public Produto ProdutoItem { get; set; }
        public Departamento DepartamentoItem { get; set; }
        public Genero GeneroItem { get; set; }
        public Usuarios UsuarioItem { get; set; }
    }
}
