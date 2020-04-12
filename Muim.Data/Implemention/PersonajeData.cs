using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class PersonajeData : IPersonajeData
    {
        private readonly IContextDb _contextDb;
        public PersonajeData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }

        public Personaje AddPersonaje(Personaje personaje)
        {
            var per = _contextDb.Personajes.Add(personaje);
            _contextDb.SaveChanges();
            return per.Entity;
        }

        public bool DeletePersonaje(int id)
        {
            var per = _contextDb.Personajes.Find(id);
            _contextDb.Personajes.Remove(per);
            _contextDb.SaveChanges();
            return true;
        }

        public List<Personaje> GetAllPersonaje()
        {
            var personajes = _contextDb.Personajes.ToList();
            return personajes;
        }

        public Personaje GetPersonaje(int id)
        {
            var personaje = _contextDb.Personajes.Find(id);
            return personaje;
        }

        public bool UpdatePersonaje(Personaje personaje)
        {
            _contextDb.Personajes.Update(personaje);
            _contextDb.SaveChanges();
            return true;
        }
    }
}
