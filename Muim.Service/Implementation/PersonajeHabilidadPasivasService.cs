
using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class PersonajeHabilidadPasivasService : IPersonajeHabilidadPasivasService
    {
        private readonly IPersonajeHabilidadPasivasData _personajeHabilidadPasivasData;

        public PersonajeHabilidadPasivasService(IPersonajeHabilidadPasivasData personajeHabilidadPasivasData)
        {
            _personajeHabilidadPasivasData = personajeHabilidadPasivasData;

        }

        public bool AddPersonajeHabilidadPasivas(PersonajeHabilidadPasivas personajeHabilidadPasivas)
        {
            return _personajeHabilidadPasivasData.AddPersonajeHabilidadPasivas(personajeHabilidadPasivas);
        }
        public bool DeletePersonajeHabilidadPasivas(PersonajeHabilidadPasivas personajeHabilidadPasivas)
        {
            return _personajeHabilidadPasivasData.DeletePersonajeHabilidadPasivas(personajeHabilidadPasivas);
        }
        public List<PersonajeHabilidadPasivas> GetPersonajeHabilidadPasivas(int personajeId)
        {
            return _personajeHabilidadPasivasData.GetPersonajeHabilidadPasivas(personajeId);
        }
    }
}
