using SecureDrive.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecureDrive.Services
{
    public class EntradaSaidaService : IEntradaSaidaService
    {
        private readonly List<EntradaSaida> _entradasSaidas = new List<EntradaSaida>();

        public IEnumerable<EntradaSaida> GetAll() => _entradasSaidas;

        public EntradaSaida GetById(int id)
        {
            // Utiliza o operador ?? para garantir que não retorne nulo
            return _entradasSaidas.FirstOrDefault(e => e.Id == id) ?? throw new ArgumentException("Entrada ou saída não encontrada.");
        }

        public EntradaSaida Add(EntradaSaida entradaSaida)
        {
            entradaSaida.Id = _entradasSaidas.Count + 1;
            _entradasSaidas.Add(entradaSaida);
            return entradaSaida;
        }
    }
}
