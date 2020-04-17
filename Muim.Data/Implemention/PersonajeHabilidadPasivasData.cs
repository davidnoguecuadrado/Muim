
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class PersonajeHabilidadPasivasData : IPersonajeHabilidadPasivasData
    {
        private readonly IContextDb _contextDb;
        public PersonajeHabilidadPasivasData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }

        public bool AddPersonajeHabilidadPasivas(PersonajeHabilidadPasivas personajeHabilidadPasivas)
        {
            _contextDb.PersonajeHabilidadPasivas.Add(personajeHabilidadPasivas);
            return true;
        }
        public bool DeletePersonajeHabilidadPasivas(PersonajeHabilidadPasivas personajeHabilidadPasivas)
        {
            _contextDb.PersonajeHabilidadPasivas.Remove(personajeHabilidadPasivas);
            return true;
        }
        public List<PersonajeHabilidadPasivas> GetPersonajeHabilidadPasivas(int personajeId)
        {
            var magias = _contextDb.PersonajeHabilidadPasivas.Where(x => x.PersonajeId == personajeId).ToList();
            return magias;
        }
    }
}
