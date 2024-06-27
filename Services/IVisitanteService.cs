using SecureDrive.Models;

namespace SecureDrive.Services
{
    public interface IVisitanteService
    {
        IEnumerable<Visitante> GetAll();
        Visitante GetById(int id);
        Visitante Add(Visitante visitante);
    }
}
