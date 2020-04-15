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

        public CapacidadesService(IUserData dataUser, ICapacidadesData capacidadesData)
        {
            _dataUser = dataUser;
            _dataCapacidades = capacidadesData;

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

        public Capacidad GetCapacidades(int id)
        {
            var capacidad = _dataCapacidades.GetCapacidad(id);
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
