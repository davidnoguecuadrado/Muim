using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassCharacterController : ControllerBase
    {
        private readonly IClassCharacterService _serviceCharacterService;

        public ClassCharacterController(IClassCharacterService serviceCharacterService)
        {
            _serviceCharacterService = serviceCharacterService;
        }

        // GET: api/User
        [HttpGet]
        public List<ClassCharacter> Get()
        {
            return _serviceCharacterService.GetAllClassCharacter();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public ClassCharacter Get(int id)
        {
            return _serviceCharacterService.GetClassCharacter(id);
        }

        // POST: api/User
        [HttpPost("{idUser}")]
        public bool Post([FromBody] ClassCharacter classCharacter, int idUser)
        {
            return _serviceCharacterService.AddClassCharacter(classCharacter, idUser);
        }

        // PUT: api/User/5
        [HttpPut("{idUser}")]
        public bool Put(int idUser, [FromBody] ClassCharacter classCharacter)
        {
            return _serviceCharacterService.UpdateClassCharacter(classCharacter, idUser);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id, int IdUsuario)
        {
            return _serviceCharacterService.DeleteClassCharacter(id, IdUsuario);
        }
    }
}