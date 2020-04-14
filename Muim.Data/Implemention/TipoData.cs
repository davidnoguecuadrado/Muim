using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class TipoData : ITipoData
    {
        private readonly IContextDb _contextDb;
        public TipoData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public bool AddTipo(Tipo tipo)
        {
            _contextDb.Tipos.Add(tipo);
            _contextDb.SaveChanges();
            return true;
        }

        public bool DeleteTipo(int id)
        {
            var tipo = _contextDb.Tipos.Find(id);
            _contextDb.Tipos.Remove(tipo);
            _contextDb.SaveChanges();
            return true;
        }

        public List<Tipo> GetAllTipo()
        {
            var tipos = _contextDb.Tipos.ToList();
            return tipos;
        }

        public Tipo GetTipo(int id)
        {
            var tipo = _contextDb.Tipos.Find(id);
            return tipo;
        }

        public bool UpdateTipo(Tipo tipo)
        {
            _contextDb.Tipos.Update(tipo);
            _contextDb.SaveChanges();
            return true;
        }
    }
}
