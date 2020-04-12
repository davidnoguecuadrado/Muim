using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RazaController : ControllerBase
    {
        private readonly IRazaService _serviceRaza;

        public RazaController(IRazaService serviceRaza)
        {
            _serviceRaza = serviceRaza;
        }

        // GET: api/User
        [HttpGet]
        public List<Raza> Get()
        {
            return _serviceRaza.GetAllRaza();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public Raza Get(int id)
        {
            return _serviceRaza.GetRaza(id);
        }

        // POST: api/User
        [HttpPost("{idUser}")]
        public bool Post([FromBody] Raza raza, int idUser)
        {
            return _serviceRaza.AddRaza(raza, idUser);
        }

        // PUT: api/User/5
        [HttpPut("{idUser}")]
        public bool Put(int idUser, [FromBody] Raza raza)
        {
            return _serviceRaza.UpdateRaza(raza, idUser);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id, int IdUsuario)
        {
            return _serviceRaza.DeleteRaza(id, IdUsuario);
        }
    }
}