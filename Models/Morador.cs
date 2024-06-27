namespace SecureDrive.Models
{
    public class Morador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Bloco { get; set; }
        public string Andar { get; set; }
        public string Apartamento { get; set; }
        public List<Veiculo> Veiculos { get; set; } = new List<Veiculo>();
        public List<Visitante> Visitantes { get; set; } = new List<Visitante>();

        // Construtor para inicializar propriedades
        public Morador()
        {
            Nome = string.Empty;
            CPF = string.Empty;
            Bloco = string.Empty;
            Andar = string.Empty;
            Apartamento = string.Empty;
        }
    }
}
