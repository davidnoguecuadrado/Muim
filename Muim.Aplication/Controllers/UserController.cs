using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Muim.Aplication.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase,IUserController
    {
        private readonly IUserService _serviceUser;

        public UserController(IUserService serviceUser)
        {
            _serviceUser = serviceUser;
        }

        // GET: api/User
        [HttpGet]
        public List<User> Get()
        {
            return _serviceUser.GetAllUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return _serviceUser.GetUser(id);

        }

        // POST: api/User
        [HttpPost]
        public bool Post([FromBody] User user)
        {
            return _serviceUser.AddUser(user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] User user)
        {
            return _serviceUser.UpdateUser(user,id);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _serviceUser.DeleteUser(id);
        }
    }
}
