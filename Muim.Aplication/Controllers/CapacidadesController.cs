using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CapacidadesController : ControllerBase
    {
        private readonly ICapacidadesService _capacidadesService;

        public CapacidadesController(ICapacidadesService serviceTipo)
        {
            _capacidadesService = serviceTipo;
        }

        // GET: api/User
        [HttpGet]
        public List<Capacidad> Get()
        {
            return _capacidadesService.GetAllCapacidades();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public Capacidad Get(int id)
        {
            return _capacidadesService.GetCapacidades(id);
        }

        // POST: api/User
        [HttpPost("{idUser}")]
        public bool Post([FromBody] Capacidad capacidad, int idUser)
        {
            return _capacidadesService.AddCapacidades(capacidad, idUser);
        }

        // PUT: api/User/5
        [HttpPut("{idUser}")]
        public bool Put(int idUser, [FromBody] Capacidad capacidad)
        {
            return _capacidadesService.UpdateCapacidades(capacidad, idUser);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id, int IdUsuario)
        {
            return _capacidadesService.DeleteCapacidades(id, IdUsuario);
        }
    }
}