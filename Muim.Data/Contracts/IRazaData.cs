
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IRazaData
    {
        public bool AddRaza(Raza raza);
        public bool DeleteRaza(int id);
        public List<Raza> GetAllRaza();
        public Raza GetRaza(int id);
        public bool UpdateRaza(Raza raza);
    }
}
