using SecureDrive.Models;

namespace SecureDrive.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly List<Veiculo> _veiculos = new List<Veiculo>();

        public IEnumerable<Veiculo> GetAll() => _veiculos;

        public Veiculo GetById(int id) => _veiculos.FirstOrDefault(v => v.Id == id);

        public Veiculo Add(Veiculo veiculo)
        {
            veiculo.Id = _veiculos.Count + 1;
            _veiculos.Add(veiculo);
            return veiculo;
        }
    }
}
