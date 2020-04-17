
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface IPersonajeHabilidadPasivasService
    {
        public bool AddPersonajeHabilidadPasivas(PersonajeHabilidadPasivas personajeHabilidadPasivas);
        public bool DeletePersonajeHabilidadPasivas(PersonajeHabilidadPasivas personajeHabilidadPasivas);
        List<PersonajeHabilidadPasivas> GetPersonajeHabilidadPasivas(int personajeId);
    }
}
