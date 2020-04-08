using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidaController : ControllerBase
    {

        private readonly IPartidaUsuarios _partidoUser;

        public PartidaController(IPartidaUsuarios partidoUser)
        {
            _partidoUser = partidoUser;
        }

        [HttpPost("{id}")]
        public bool Post([FromBody]Partida partida,int id)
        {
            return _partidoUser.CreatePartida(partida, id);
        }
      
    }
}
