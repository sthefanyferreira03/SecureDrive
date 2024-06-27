using SecureDrive.Models;

namespace SecureDrive.Services
{
    public interface IMoradorService
    {
        IEnumerable<Morador> GetAll();
        Morador GetById(int id);
        Morador Add(Morador morador);
        void AddVeiculo(string cpf, Veiculo veiculo);
        void AddVisitante(string cpf, Visitante visitante);
    }
}
