
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class CapacidadesData : ICapacidadesData
    {
        private readonly IContextDb _contextDb;
        public CapacidadesData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public bool AddCapacidad(Capacidad capacidad)
        {
            _contextDb.Capacidades.Add(capacidad);
            _contextDb.SaveChanges();
            return true;
        }

        public bool DeleteCapacidad(int id)
        {
            var capacidad = _contextDb.Capacidades.Find(id);
            _contextDb.Capacidades.Remove(capacidad);
            _contextDb.SaveChanges();
            return true;
        }

        public List<Capacidad> GetAllCapacidad()
        {
            var razas = _contextDb.Capacidades.ToList();
            return razas;
        }

        public Capacidad GetCapacidad(int id)
        {
            var razas = _contextDb.Capacidades.Find(id);
            return razas;
        }

        public bool UpdateCapacidad(Capacidad capacidad)
        {
            _contextDb.Capacidades.Update(capacidad);
            _contextDb.SaveChanges();
            return true;
        }
    }
}
