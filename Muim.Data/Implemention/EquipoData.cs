using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class EquipoData : IEquipoData
    {
        private readonly IContextDb _contextDb;
        public EquipoData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public bool AddEquipo(Equipo equipo)
        {
            _contextDb.Equipos.Add(equipo);
            _contextDb.SaveChanges();
            return true;
        }

        public bool DeleteEquipo(int id)
        {
            var equipo = _contextDb.Equipos.Find(id);
            _contextDb.Equipos.Remove(equipo);
            _contextDb.SaveChanges();
            return true;
        }

        public List<Equipo> GetEquipo(int id)
        {
            var equipos = _contextDb.Equipos.Where(x=>x.PersonajeId == id).ToList();
            return equipos;
        }

        public bool UpdateEquipo(Equipo equipo)
        {
            _contextDb.Equipos.Update(equipo);
            _contextDb.SaveChanges();
            return true;
        }
    }
}
