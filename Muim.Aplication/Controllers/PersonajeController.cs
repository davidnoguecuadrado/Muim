using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonajeController : ControllerBase
    {
        private readonly IPersonajeService _servicePersonaje;

        public PersonajeController(IPersonajeService servicePersonaje)
        {
            _servicePersonaje = servicePersonaje;
        }

        // GET: api/User
        [HttpGet]
        public List<Personaje> Get()
        {
            return _servicePersonaje.GetAllPersonaje();
        }
        
       [HttpGet("{id}")]
       public Personaje Get(int id)
       {
           return _servicePersonaje.GetPersonaje(id);

       }

       // POST: api/User
       
       [HttpPost]
       public bool Post([FromBody] Personaje user,int idUser,int idPartida)
       {
           return _servicePersonaje.AddPersonaje(user,idUser,idPartida);
       }
       
        // PUT: api/User/5
        [HttpPut]
        public bool Put(int id, [FromBody] Personaje per)
        {
            return _servicePersonaje.UpdatePersonaje(per);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _servicePersonaje.DeletePersonaje(id);
        }
    }
}