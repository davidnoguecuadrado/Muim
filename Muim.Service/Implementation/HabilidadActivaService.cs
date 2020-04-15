
using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class HabilidadActivaService : IHabilidadActivaService
    {
        private readonly IUserData _dataUser;
        private readonly IHabilidadActivaData _habilidadActivaData;

        public HabilidadActivaService(IUserData dataUser, IHabilidadActivaData habilidadActivaData)
        {
            _dataUser = dataUser;
            _habilidadActivaData = habilidadActivaData;

        }
        public bool AddHabilidadActiva(HabilidadActiva habilidadActiva, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _habilidadActivaData.AddHabilidadActiva(habilidadActiva);
                return true;
            }
            return false;
        }

        public bool DeleteHabilidadActiva(int id, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _habilidadActivaData.DeleteHabilidadActiva(id);
                return true;
            }
            return false;
        }

        public List<HabilidadActiva> GetAllHabilidadActiva()
        {
            var habilidadActivas = _habilidadActivaData.GetAllHabilidadActiva();
            return habilidadActivas;
        }

        public HabilidadActiva GetHabilidadActiva(int id)
        {
            var habilidadActiva = _habilidadActivaData.GetHabilidadActiva(id);
            return habilidadActiva;
        }

        public bool UpdateHabilidadActiva(HabilidadActiva habilidadActiva, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                return _habilidadActivaData.UpdateHabilidadActiva(habilidadActiva);
            }
            return false;
        }
    }
}
