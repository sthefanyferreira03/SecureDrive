namespace SecureDrive.Models
{
    public class EntradaSaida
    {
        public int Id { get; set; }
        public int MoradorId { get; set; }
        public int? VisitanteId { get; set; }
        public DateTime DataHoraEntrada { get; set; }
        public DateTime? DataHoraSaida { get; set; }
    }
}
