
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IEquipoData
    {
        public bool AddEquipo(Equipo equipo);

        public bool DeleteEquipo(int id);

        public List<Equipo> GetEquipo(int id);

        public bool UpdateEquipo(Equipo equipo);
    }
}
