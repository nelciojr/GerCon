
namespace DTO
{
    public class Orgao
    {
        public int Acao { get; set; }
        public int Id_Orgao { get; set; }
        public string Nome_Orgao { get; set; }
        public string Endereco_Orgao { get; set; }
        public string Tel_Fixo_Orgao { get; set; }
        public Bairro BairroOrgao { get; set; }
        public Cidade CidadeOrgao { get; set; }
        public Estado EstadoOrgao { get; set; }
        public Responsavel ResponsavelOrgao { get; set; }
    }
}
