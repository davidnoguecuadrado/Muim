using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class EquipoService : IEquipoService
    {
        private readonly IEquipoData _equipoData;

        public EquipoService(IEquipoData equipoData)
        {
            _equipoData = equipoData;
        }

        public bool AddEquipo(Equipo equipo)
        {
            return _equipoData.AddEquipo(equipo);
        }

        public bool DeleteEquipo(int id)
        {
            return _equipoData.DeleteEquipo(id);
        }

        public List<Equipo> GetEquipos(int id)
        {
            return _equipoData.GetEquipo(id);
        }

        public bool UpdateEquipo(Equipo equipo, int id)
        {
            equipo.EquipoId = id;
            return _equipoData.UpdateEquipo(equipo);
        }
    }
}
