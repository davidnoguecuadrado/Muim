using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class CapacidadesService : ICapacidadesService
    {
        private readonly IUserData _dataUser;
        private readonly ICapacidadesData _dataCapacidades;
        private readonly IPersonajesCapacidadesData _personajesCapacidadesData;

        public CapacidadesService(IUserData dataUser, ICapacidadesData capacidadesData, IPersonajesCapacidadesData personajesCapacidadesData)
        {
            _dataUser = dataUser;
            _dataCapacidades = capacidadesData;
            _personajesCapacidadesData = personajesCapacidadesData;
        }
        public bool AddCapacidades(Capacidad capacidad, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _dataCapacidades.AddCapacidad(capacidad);
                return true;
            }
            return false;
        }

        public bool DeleteCapacidades(int id, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _dataCapacidades.DeleteCapacidad(id);
                return true;
            }
            return false;
        }

        public List<Capacidad> GetAllCapacidades()
        {
            var capacidads = _dataCapacidades.GetAllCapacidad();
            return capacidads;
        }

        public Dictionary<Capacidad, int> GetCapacidades(int idPersonaje)
        {
            Dictionary<Capacidad, int> capacidad = new Dictionary<Capacidad, int>();
            var capacidadPersonase = _personajesCapacidadesData.GetPersonajesCapacidades(idPersonaje);
            foreach (var hab in capacidadPersonase)
            {
                var ma = _dataCapacidades.GetCapacidad(hab.CapacidadId);
                capacidad.Add(ma, hab.Nivel);
            }
            return capacidad;
        }

        public bool UpdateCapacidades(Capacidad capacidad, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                return _dataCapacidades.UpdateCapacidad(capacidad);
            }
            return false;
        }
    }
}
