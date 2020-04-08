using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddUserPartidaPasswordController : ControllerBase
    {
        private readonly IPartidaUsuarios _partidoUser;

        public AddUserPartidaPasswordController(IPartidaUsuarios partidoUser)
        {
            _partidoUser = partidoUser;
        }

        [HttpPost("{id}")]
        public bool Post([FromBody]Partida partida, int id)
        {
            return _partidoUser.AddTheUser(id, partida);
        }
    }
}