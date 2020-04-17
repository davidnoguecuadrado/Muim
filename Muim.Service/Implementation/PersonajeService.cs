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
        private readonly IClassCharacterCpacidadesData _classCharacterCpacidadesData;
        private readonly IPersonajesCapacidadesData _personajesCapacidadesData;

        public PersonajeService(IPupData pupdata, IPersonajeData personaje, IClassCharacterCpacidadesData classCharacterCpacidadesData, IPersonajesCapacidadesData personajesCapacidadesData)
        {
            _pupdata = pupdata;
            _personaje = personaje;
            _classCharacterCpacidadesData = classCharacterCpacidadesData;
            _personajesCapacidadesData = personajesCapacidadesData;
        }
        public bool AddPersonaje(Personaje personaje,int idUser,int idPartida)
        {
            var per = _personaje.AddPersonaje(personaje);
            PUP pup = new PUP();
            PersonajesCapacidades personajesCapacidades = new PersonajesCapacidades();
            pup.PersonajeId = per.PersonajeId;
            pup.UserId = idUser;
            pup.PartidaId = idPartida;
            var classCharacterCpacidades=_classCharacterCpacidadesData.GetClassCharacterCapacidades(per.ClassCharacterId.GetValueOrDefault());
            foreach (var clases in classCharacterCpacidades) {
                personajesCapacidades.CapacidadId = clases.CapacidadId;
                personajesCapacidades.PersonajeId = per.PersonajeId;
                personajesCapacidades.Nivel = 1;
                _personajesCapacidadesData.AddPersonajesCapacidades(personajesCapacidades);
            }
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
