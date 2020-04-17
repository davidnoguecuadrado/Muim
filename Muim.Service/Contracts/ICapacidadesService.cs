using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface ICapacidadesService
    {
        public bool AddCapacidades(Capacidad capacidad, int idUsuario);

        public bool DeleteCapacidades(int id, int idUsuario);

        public List<Capacidad> GetAllCapacidades();

        public Dictionary<Capacidad, int> GetCapacidades(int idPersonaje);

        public bool UpdateCapacidades(Capacidad capacidad, int idUsuario);
    }
}
