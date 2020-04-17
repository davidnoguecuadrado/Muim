
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class HabilidadPasivaData : IHabilidadPasivaData
    {
        private readonly IContextDb _contextDb;
        public HabilidadPasivaData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public bool AddHabilidadPasiva(HabilidadPasiva habilidadPasiva)
        {
            _contextDb.HabilidadPasivas.Add(habilidadPasiva);
            _contextDb.SaveChanges();
            return true;
        }

        public bool DeleteHabilidadPasiva(int id)
        {
            var habilidadPasiva = _contextDb.HabilidadPasivas.Find(id);
            _contextDb.HabilidadPasivas.Remove(habilidadPasiva);
            _contextDb.SaveChanges();
            return true;
        }

        public List<HabilidadPasiva> GetAllHabilidadPasiva()
        {
            var habilidadPasivas = _contextDb.HabilidadPasivas.ToList();
            return habilidadPasivas;
        }

        public HabilidadPasiva GetHabilidadPasiva(int id)
        {
            var razas = _contextDb.HabilidadPasivas.Find(id);
            return razas;
        }

        public bool UpdateHabilidadPasiva(HabilidadPasiva habilidadPasiva)
        {
            _contextDb.HabilidadPasivas.Update(habilidadPasiva);
            _contextDb.SaveChanges();
            return true;
        }
    }
}
