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
    public class TipoController : ControllerBase
    {
        private readonly ITipoService _serviceTipo;

        public TipoController(ITipoService serviceTipo)
        {
            _serviceTipo = serviceTipo;
        }

        // GET: api/User
        [HttpGet]
        public List<Tipo> Get()
        {
            return _serviceTipo.GetAllTipo();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public Tipo Get(int id)
        {
            return _serviceTipo.GetTipo(id);
        }

        // POST: api/User
        [HttpPost("{idUser}")]
        public bool Post([FromBody] Tipo raza, int idUser)
        {
            return _serviceTipo.AddTipo(raza, idUser);
        }

        // PUT: api/User/5
        [HttpPut("{idUser}")]
        public bool Put(int idUser, [FromBody] Tipo raza)
        {
            return _serviceTipo.UpdateTipo(raza, idUser);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id, int IdUsuario)
        {
            return _serviceTipo.DeleteTipo(id, IdUsuario);
        }
    }
}