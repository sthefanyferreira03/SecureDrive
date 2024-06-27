using System.Numerics;
using System.Reflection;

namespace SecureDrive.Models
{
    public class Visitante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string TipoVisita { get; set; }
        public DateTime HorarioPrevisto { get; set; }
        public bool EstaAPe { get; set; }
        public string PlacaVeiculo { get; set; }
        public string CPFDoMorador { get; set; }

        // Construtor para inicializar propriedades
        public Visitante()
        {
            Nome = string.Empty;
            CPF = string.Empty;
            TipoVisita = string.Empty;
            PlacaVeiculo = string.Empty;
            CPFDoMorador = string.Empty;
        }
    }
}