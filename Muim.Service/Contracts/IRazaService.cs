using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface IRazaService
    {
        public bool AddRaza(Raza raza, int idUsuario);
        public bool DeleteRaza(int id, int idUsuario);
        public List<Raza> GetAllRaza();
        public Raza GetRaza(int id);
        public bool UpdateRaza(Raza raza, int idUsuario);
    }
}
