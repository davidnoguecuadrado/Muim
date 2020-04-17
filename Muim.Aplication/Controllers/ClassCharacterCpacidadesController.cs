
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassCharacterCpacidadesController : ControllerBase
    {
        private readonly IClassCharacterCpacidadesService _classCharacterCpacidadesService;

        public ClassCharacterCpacidadesController(IClassCharacterCpacidadesService classCharacterCpacidades)
        {
            _classCharacterCpacidadesService = classCharacterCpacidades;
        }

        // POST: api/User
        [HttpPost]
        public bool Post([FromBody] ClassCharacterCpacidades classCharacterCpacidades)
        {
            return _classCharacterCpacidadesService.AddPersonajesCapacidades(classCharacterCpacidades);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public bool Delete([FromBody] ClassCharacterCpacidades personajeHabilidadActiva)
        {
            return _classCharacterCpacidadesService.DeletePersonajesCapacidades(personajeHabilidadActiva);
        }
    }
}