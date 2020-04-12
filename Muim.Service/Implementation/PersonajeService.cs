using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class PersonajeService : IPersonajeService
    {
        private readonly IPupData _pupdata;
        private readonly IPersonajeData _personaje;

        public PersonajeService(IPupData pupdata, IPersonajeData personaje)
        {
            _pupdata = pupdata;
            _personaje = personaje;

        }
        public bool AddPersonaje(Personaje personaje,int idUser,int idPartida)
        {
            var per = _personaje.AddPersonaje(personaje);
            PUP pup = new PUP();
            pup.PersonajeId = per.PersonajeId;
            pup.UserId = idUser;
            pup.PartidaId = idPartida;
            _pupdata.Add(pup);
            return true;
        }

        public bool DeletePersonaje(int id)
        {
            return _personaje.DeletePersonaje(id);
        }

        public List<Personaje> GetAllPersonaje()
        {
            return _personaje.GetAllPersonaje();
        }

        public Personaje GetPersonaje(int id)
        {
            return _personaje.GetPersonaje(id);
        }

        public bool UpdatePersonaje(Personaje personaje)
        {
            return _personaje.UpdatePersonaje(personaje);
        }
    }
}
