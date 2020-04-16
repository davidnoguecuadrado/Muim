using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Muim.Domain.Models;
using Muim.Service.Contracts;

namespace Muim.Aplication.Contracts
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipoController : ControllerBase
    {
        private readonly IEquipoService _equipoService;

        public EquipoController(IEquipoService equipoService)
        {
            _equipoService = equipoService;
        }


        // GET: api/User/5
        [HttpGet("{id}")]
        public List<Equipo> Get(int id)
        {
            return _equipoService.GetEquipos(id);

        }

        // POST: api/User
        [HttpPost]
        public bool Post([FromBody] Equipo equipo)
        {
            return _equipoService.AddEquipo(equipo);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public bool Put([FromBody] Equipo equipo,int id)
        {
            return _equipoService.UpdateEquipo(equipo,id);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _equipoService.DeleteEquipo(id);
        }
    }
}