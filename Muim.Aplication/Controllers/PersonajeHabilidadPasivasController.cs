using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajeHabilidadPasivasController : ControllerBase
    {
        private readonly IPersonajeHabilidadPasivasService _personajeHabilidadPasivasService;

        public PersonajeHabilidadPasivasController(IPersonajeHabilidadPasivasService personajeHabilidadPasivasService)
        {
            _personajeHabilidadPasivasService = personajeHabilidadPasivasService;
        }

        // POST: api/User
        [HttpPost]
        public bool Post([FromBody] PersonajeHabilidadPasivas personajeHabilidadActiva)
        {
            return _personajeHabilidadPasivasService.AddPersonajeHabilidadPasivas(personajeHabilidadActiva);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public bool Delete([FromBody] PersonajeHabilidadPasivas personajeHabilidadActiva)
        {
            return _personajeHabilidadPasivasService.DeletePersonajeHabilidadPasivas(personajeHabilidadActiva);
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public List<PersonajeHabilidadPasivas> Get(int id)
        {
            return _personajeHabilidadPasivasService.GetPersonajeHabilidadPasivas(id);
        }
    }
}
