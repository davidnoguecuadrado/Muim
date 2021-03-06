﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajeHabilidadActivaController : ControllerBase
    {
        private readonly IPersonajeHabilidadActivaService _personajeHabilidadActivaService;

        public PersonajeHabilidadActivaController(IPersonajeHabilidadActivaService personajeHabilidadActivaService)
        {
            _personajeHabilidadActivaService = personajeHabilidadActivaService;
        }

        // POST: api/User
        [HttpPost]
        public bool Post([FromBody] PersonajeHabilidadActiva personajeHabilidadActiva)
        {
            return _personajeHabilidadActivaService.AddPersonajesCapacidades(personajeHabilidadActiva);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public bool Delete([FromBody] PersonajeHabilidadActiva personajeHabilidadActiva)
        {
            return _personajeHabilidadActivaService.DeletePersonajesCapacidades(personajeHabilidadActiva);
        }


        // GET: api/User/5
        [HttpGet("{id}")]
        public List<PersonajeHabilidadActiva> Get(int id)
        {
            return _personajeHabilidadActivaService.GetPersonajeHabilidadActiva(id);
        }
    }
}