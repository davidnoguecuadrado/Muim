using Microsoft.AspNetCore.Mvc;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddAdminUserPartidaController : ControllerBase
    {
        private readonly IPartidaUsuarios _partidoUser;

        public AddAdminUserPartidaController(IPartidaUsuarios partidoUser)
        {
            _partidoUser = partidoUser;
        }

        [HttpPost("{id}")]
        public bool Post([FromBody]List<int> datos)
        {
            return _partidoUser.AddAdmin(datos[0], datos[1], datos[2]);
        }
    }
}