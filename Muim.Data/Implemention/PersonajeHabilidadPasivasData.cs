
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;

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
    }
}
