using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class PersonajesCapacidadesData : IPersonajesCapacidadesData
    {
        private readonly IContextDb _contextDb;
        public PersonajesCapacidadesData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }

        public bool AddPersonajesCapacidades(PersonajesCapacidades personajesCapacidades)
        {
            _contextDb.PersonajesCapacidades.Add(personajesCapacidades);
            return true;
        }
        public bool DeletePersonajesCapacidades(PersonajesCapacidades personajesCapacidades)
        {
            _contextDb.PersonajesCapacidades.Remove(personajesCapacidades);
            return true;
        }
        public List<PersonajesCapacidades> GetPersonajesCapacidades(int personajeId)
        {
            var personajesCapacidades = _contextDb.PersonajesCapacidades.Where(x => x.PersonajeId == personajeId).ToList();
            return personajesCapacidades;
        }
    }
}