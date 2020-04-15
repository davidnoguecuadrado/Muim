using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabilidadActivaController : ControllerBase
    {
        private readonly IHabilidadActivaService _habilidadActivaService;

        public HabilidadActivaController(IHabilidadActivaService habilidadActivaService)
        {
            _habilidadActivaService = habilidadActivaService;
        }

        // GET: api/User
        [HttpGet]
        public List<HabilidadActiva> Get()
        {
            return _habilidadActivaService.GetAllHabilidadActiva();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public HabilidadActiva Get(int id)
        {
            return _habilidadActivaService.GetHabilidadActiva(id);

        }

        // POST: api/User
        [HttpPost("{idUser}")]
        public bool Post([FromBody] HabilidadActiva habilidadPasiva, int idUser)
        {
            return _habilidadActivaService.AddHabilidadActiva(habilidadPasiva, idUser);
        }

        // PUT: api/User/5
        [HttpPut("{idUser}")]
        public bool Put(int idUser, [FromBody] HabilidadActiva habilidadPasiva)
        {
            return _habilidadActivaService.UpdateHabilidadActiva(habilidadPasiva, idUser);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id, int IdUsuario)
        {
            return _habilidadActivaService.DeleteHabilidadActiva(id, IdUsuario);
        }
    }
}