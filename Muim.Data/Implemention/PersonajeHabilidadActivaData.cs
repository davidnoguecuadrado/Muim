
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;

namespace Muim.Data.Implemention
{
    public class PersonajeHabilidadActivaData : IPersonajeHabilidadActivaData
    {
        private readonly IContextDb _contextDb;
        public PersonajeHabilidadActivaData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }

        public bool AddPersonajeHabilidadActiva(PersonajeHabilidadActiva personajeHabilidadActiva)
        {
            _contextDb.PersonajeHabilidadActiva.Add(personajeHabilidadActiva);
            return true;
        }
        public bool DeletePersonajeHabilidadActiva(PersonajeHabilidadActiva personajeHabilidadActiva)
        {
            _contextDb.PersonajeHabilidadActiva.Remove(personajeHabilidadActiva);
            return true;
        }
    }
}
