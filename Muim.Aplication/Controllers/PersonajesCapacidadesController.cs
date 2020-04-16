using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Contracts
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajesCapacidadesController : ControllerBase
    {
        private readonly IPersonajesCapacidadesService _personajesCapacidadesService;

        public PersonajesCapacidadesController(IPersonajesCapacidadesService personajesCapacidadesService)
        {
            _personajesCapacidadesService = personajesCapacidadesService;
        }

        // POST: api/User
        [HttpPost]
        public bool Post([FromBody] PersonajesCapacidades personajesCapacidades)
        {
            return _personajesCapacidadesService.AddPersonajesCapacidades(personajesCapacidades);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public bool Delete([FromBody] PersonajesCapacidades personajesCapacidades)
        {
            return _personajesCapacidadesService.DeletePersonajesCapacidades(personajesCapacidades);
        }
    }
}