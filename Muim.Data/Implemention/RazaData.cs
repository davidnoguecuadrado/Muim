
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class RazaData : IRazaData
    {
        private readonly IContextDb _contextDb;
        public RazaData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public bool AddRaza(Raza raza)
        {
            _contextDb.Razas.Add(raza);
            _contextDb.SaveChanges();
            return true;
        }

        public bool DeleteRaza(int id)
        {
            var raza = _contextDb.Razas.Find(id);
            _contextDb.Razas.Remove(raza);
            _contextDb.SaveChanges();
            return true;
        }

        public List<Raza> GetAllRaza()
        {
            var razas = _contextDb.Razas.ToList();
            return razas;
        }

        public Raza GetRaza(int id)
        {
            var razas = _contextDb.Razas.Find(id);
            return razas;
        }

        public bool UpdateRaza(Raza raza)
        {
            _contextDb.Razas.Update(raza);
            _contextDb.SaveChanges();
            return true;
        }
    }
}
