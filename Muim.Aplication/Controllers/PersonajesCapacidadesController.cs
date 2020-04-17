using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

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

        // GET: api/User/5
        [HttpGet("{id}")]
        public List<PersonajesCapacidades> Get(int id)
        {
            return _personajesCapacidadesService.GetPersonajesCapacidades(id);
        }
    }
}