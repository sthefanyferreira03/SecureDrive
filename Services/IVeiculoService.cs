using SecureDrive.Models;

namespace SecureDrive.Services
{
    public interface IVeiculoService
    {
        IEnumerable<Veiculo> GetAll();
        Veiculo GetById(int id);
        Veiculo Add(Veiculo veiculo);
    }
}
