using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagiaPersonajesController : ControllerBase
    {
        private readonly IMagiaPersonajesService _magiaPersonajesService;

        public MagiaPersonajesController(IMagiaPersonajesService magiaPersonajesService)
        {
            _magiaPersonajesService = magiaPersonajesService;
        }


        // GET: api/User/5
        [HttpGet("{id}")]
        public List<MagiaPersonajes> Get(int id)
        {
            return _magiaPersonajesService.GetMagiaPersonajes(id);
        }

        // POST: api/User
        [HttpPost]
        public bool Post([FromBody] MagiaPersonajes magiaPersonajes)
        {
            return _magiaPersonajesService.AddMagiaPersonajes(magiaPersonajes);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete([FromBody] MagiaPersonajes magiaPersonajes)
        {
            return _magiaPersonajesService.DeleteMagiaPersonajes(magiaPersonajes);
        } 
    }
}