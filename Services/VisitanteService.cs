using SecureDrive.Models;

namespace SecureDrive.Services
{
    public class VisitanteService : IVisitanteService
    {
        private readonly List<Visitante> _visitantes = new List<Visitante>();

        public IEnumerable<Visitante> GetAll() => _visitantes;

        public Visitante GetById(int id) => _visitantes.FirstOrDefault(v => v.Id == id);

        public Visitante Add(Visitante visitante)
        {
            visitante.Id = _visitantes.Count + 1;
            _visitantes.Add(visitante);
            return visitante;
        }
    }
}
