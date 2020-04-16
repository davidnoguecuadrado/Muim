
using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Service.Implementation
{
    public class PersonajeHabilidadPasivasService : IPersonajeHabilidadPasivasService
    {
        private readonly IPersonajeHabilidadPasivasData _personajeHabilidadPasivasData;

        public PersonajeHabilidadPasivasService(IPersonajeHabilidadPasivasData personajeHabilidadPasivasData)
        {
            _personajeHabilidadPasivasData = personajeHabilidadPasivasData;

        }

        public bool AddPersonajesCapacidades(PersonajeHabilidadPasivas personajeHabilidadPasivas)
        {
            return _personajeHabilidadPasivasData.AddPersonajeHabilidadPasivas(personajeHabilidadPasivas);
        }
        public bool DeletePersonajesCapacidades(PersonajeHabilidadPasivas personajeHabilidadPasivas)
        {
            return _personajeHabilidadPasivasData.DeletePersonajeHabilidadPasivas(personajeHabilidadPasivas);
        }
    }
}
