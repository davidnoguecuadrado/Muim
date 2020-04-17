using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagiaController : ControllerBase
    {
        private readonly IMagicService _serviceMagia;

        public MagiaController(IMagicService serviceMagia)
        {
            _serviceMagia = serviceMagia;
        }

        // GET: api/User
        [HttpGet]
        public List<Magia> Get()
        {
            return _serviceMagia.GetAllMagia();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public Dictionary<Magia, int> Get(int idPersonaje)
        {
            return _serviceMagia.GetMagia(idPersonaje);

        }

        // POST: api/User
        [HttpPost("{idUser}")]
        public bool Post([FromBody] Magia magia, int idUser)
        {
            return _serviceMagia.AddMagia(magia, idUser);
        }

        // PUT: api/User/5
        [HttpPut("{idUser}")]
        public bool Put(int idUser, [FromBody] Magia magia)
        {
            return _serviceMagia.UpdateMagia(magia, idUser);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id, int IdUsuario)
        {
            return _serviceMagia.DeleteMagia(id, IdUsuario);
        }
    }
}