using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabilidadPasivaController : ControllerBase
    {
        
        private readonly IHabilidadPasivaService _habilidadPasiva;

        public HabilidadPasivaController(IHabilidadPasivaService habilidadPasiva)
        {
            _habilidadPasiva = habilidadPasiva;
        }

        // GET: api/User
        [HttpGet]
        public List<HabilidadPasiva> Get()
        {
            return _habilidadPasiva.GetAllHabilidadPasiva();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public Dictionary<HabilidadPasiva, int> Get(int id)
        {
            return _habilidadPasiva.GetHabilidadPasiva(id);

        }

        // POST: api/User
        [HttpPost("{idUser}")]
        public bool Post([FromBody] HabilidadPasiva habilidadPasiva, int idUser)
        {
            return _habilidadPasiva.AddHabilidadPasiva(habilidadPasiva, idUser);
        }

        // PUT: api/User/5
        [HttpPut("{idUser}")]
        public bool Put(int idUser, [FromBody] HabilidadPasiva habilidadPasiva)
        {
            return _habilidadPasiva.UpdateHabilidadPasiva(habilidadPasiva, idUser);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id, int IdUsuario)
        {
            return _habilidadPasiva.DeleteHabilidadPasiva(id, IdUsuario);
        }
    }
}