
namespace DTO
{
    public class Departamento
    {
        public int Acao { get; set; }
        public int Id_Departamento { get; set; }
        public string  Nome_Departamento { get; set; }
        public string Endereco_Departamento  { get; set; }
        public string  Tel_Fixo_Departamento { get; set; }
        public Bairro BairroDepartamento { get; set; }
        public Cidade CidadeDepartamento { get; set; }
        public Estado EstadoDepartamento { get; set; }
        public Orgao OrgaoDepartamento { get; set; }

    }
}
