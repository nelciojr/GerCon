
namespace DTO
{
    public class Fornecedor
    {
        public int Acao { get; set; }
        public int Id_Fornecedor { get; set; }
        public string Razao_Social { get; set; }
        public string Nome_Fantasia { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Endereco_Fornecedor { get; set; }
        public string Tel_Fixo_Fornecedor { get; set; }
        public string Tel_Cel_Fornecedor { get; set; }
        public Bairro BairroFornecedor { get; set; }
        public Cidade CidadeFornecedor { get; set; }
        public Estado EstadoFornecedor { get; set; }
        public string Contato { get; set; }
        public string Email_Fornecedor { get; set; }
    }
}
