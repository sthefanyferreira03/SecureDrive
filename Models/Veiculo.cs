namespace SecureDrive.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string CPFProprietario { get; set; }

        // Construtor para inicializar propriedades
        public Veiculo()
        {
            Placa = string.Empty;
            CPFProprietario = string.Empty;
            Modelo = string.Empty;
        }
    }
}
