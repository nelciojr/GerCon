
namespace DTO
{
    public class Contrato
    {
        public int Acao { get; set; }
        public int Id_Contrato { get; set; }
        public string Contrato_Aditivo { get; set; }
        public Modalidade ModalidadeContrato { get; set; }
        public string Numero_Contrato { get; set; }
        public string Numero_Licitacao { get; set; }
        public string Ano_Exercicio { get; set; }
        public string Data_Inicial { get; set; }
        public string  Data_Final { get; set; }
        public string  Arquivo_Contrato { get; set; }
        public string  Historico_Contrato { get; set; }
        public decimal Valor_Contrato { get; set; }
        public decimal Saldo_Contrato { get; set; }
        public Orgao OrgaoContrato { get; set; }
        public Fornecedor FornecedorContrato { get; set; }
        public Genero GeneroContrato { get; set; }
        public Usuarios UsuarioContrato { get; set; }
        public byte[] Contrato_Byte { get; set; }
    }
}
