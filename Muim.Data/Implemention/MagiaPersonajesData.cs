
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class MagiaPersonajesData : IMagiaPersonajesData
    {
        private readonly IContextDb _contextDb;
        public MagiaPersonajesData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }
        public bool AddMagiaPersonajes(MagiaPersonajes magiaPersonajes)
        {
            _contextDb.MagiaPersonajes.Add(magiaPersonajes);
            _contextDb.SaveChanges();
            return true;
        }

        public bool DeleteMagiaPersonajes(MagiaPersonajes magiaPersonajes)
        {
            _contextDb.MagiaPersonajes.Remove(magiaPersonajes);
            _contextDb.SaveChanges();
            return true;
        }

        public List<MagiaPersonajes> GetMagiaPersonajes(int personajeId)
        {
            var magias = _contextDb.MagiaPersonajes.Where(x=> x.PersonajeId == personajeId).ToList();
            return magias;
        }
    }
}
