using SecureDrive.Models;

namespace SecureDrive.Services
{
    public class MoradorService : IMoradorService
    {
        private readonly List<Morador> _moradores = new List<Morador>();

        public IEnumerable<Morador> GetAll() => _moradores;

        public Morador GetById(int id) => _moradores.FirstOrDefault(m => m.Id == id);

        public Morador Add(Morador morador)
        {
            morador.Id = _moradores.Count + 1;
            _moradores.Add(morador);
            return morador;
        }

        public void AddVeiculo(string cpf, Veiculo veiculo)
        {
            var morador = _moradores.FirstOrDefault(m => m.CPF == cpf);
            if (morador != null)
            {
                veiculo.Id = morador.Veiculos.Count + 1;
                veiculo.CPFProprietario = cpf;
                morador.Veiculos.Add(veiculo);
            }
        }

        public void AddVisitante(string cpf, Visitante visitante)
        {
            var morador = _moradores.FirstOrDefault(m => m.CPF == cpf);
            if (morador != null)
            {
                visitante.Id = morador.Visitantes.Count + 1;
                visitante.CPFDoMorador = cpf;
                morador.Visitantes.Add(visitante);
            }
        }
    }
}
