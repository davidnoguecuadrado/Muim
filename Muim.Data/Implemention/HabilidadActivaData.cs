
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class HabilidadActivaData : IHabilidadActivaData
    {
        private readonly IContextDb _contextDb;
        public HabilidadActivaData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public bool AddHabilidadActiva(HabilidadActiva habilidadActiva)
        {
            _contextDb.HabilidadActivas.Add(habilidadActiva);
            _contextDb.SaveChanges();
            return true;
        }

        public bool DeleteHabilidadActiva(int id)
        {
            var habilidadActiva = _contextDb.HabilidadActivas.Find(id);
            _contextDb.HabilidadActivas.Remove(habilidadActiva);
            _contextDb.SaveChanges();
            return true;
        }

        public List<HabilidadActiva> GetAllHabilidadActiva()
        {
            var habilidadActiva = _contextDb.HabilidadActivas.ToList();
            return habilidadActiva;
        }

        public HabilidadActiva GetHabilidadActiva(int id)
        {
            var habilidadActiva = _contextDb.HabilidadActivas.Find(id);
            return habilidadActiva;
        }

        public bool UpdateHabilidadActiva(HabilidadActiva habilidadActiva)
        {
            _contextDb.HabilidadActivas.Update(habilidadActiva);
            _contextDb.SaveChanges();
            return true;
        }
    }
}
