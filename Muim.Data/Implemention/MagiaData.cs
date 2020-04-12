
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class MagiaData : IMagiaData
    {
        private readonly IContextDb _contextDb;
        public MagiaData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public bool AddMagia(Magia magia)
        {
            _contextDb.Magias.Add(magia);
            _contextDb.SaveChanges();
            return true;
        }

        public bool DeleteMagia(int id)
        {
            var magia = _contextDb.Magias.Find(id);
            _contextDb.Magias.Remove(magia);
            _contextDb.SaveChanges();
            return true;
        }

        public List<Magia> GetAllMagias()
        {
            var magias = _contextDb.Magias.ToList();
            return magias;
        }

        public Magia GetMagia(int id)
        {
            var magia = _contextDb.Magias.Find(id);
            return magia;
        }

        public bool UpdateMagia(Magia magia)
        {
            _contextDb.Magias.Update(magia);
            _contextDb.SaveChanges();
            return true;
        }
    }
}
