
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IPersonajeHabilidadPasivasData
    {
        public bool AddPersonajeHabilidadPasivas(PersonajeHabilidadPasivas personajeHabilidadPasivas);
        public bool DeletePersonajeHabilidadPasivas(PersonajeHabilidadPasivas personajeHabilidadPasivas);
        List<PersonajeHabilidadPasivas> GetPersonajeHabilidadPasivas(int personajeId);
    }
}
