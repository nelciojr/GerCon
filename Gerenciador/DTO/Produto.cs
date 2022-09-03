

namespace DTO
{
    public class Produto
    {
        public int Acao { get; set; }
        public int Id_Produto { get; set; }
        public string Descricao { get; set; }
        public string Detalhe { get; set; }
        public UnidMedida UnidMedidaProduto { get; set; }
        public Marca MarcaProduto { get; set; }
        public Genero GeneroProduto { get; set; }

    }
}
