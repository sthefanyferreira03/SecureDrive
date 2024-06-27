using SecureDrive.Models;

namespace SecureDrive.Services
{
    public interface IEntradaSaidaService
    {
        IEnumerable<EntradaSaida> GetAll();
        EntradaSaida GetById(int id);
        EntradaSaida Add(EntradaSaida entradaSaida);
    }
}
