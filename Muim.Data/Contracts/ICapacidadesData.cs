
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface ICapacidadesData
    {

        public bool AddCapacidad(Capacidad capacidad);

        public bool DeleteCapacidad(int id);

        public List<Capacidad> GetAllCapacidad();

        public Capacidad GetCapacidad(int id);

        public bool UpdateCapacidad(Capacidad capacidad);
    }
}

