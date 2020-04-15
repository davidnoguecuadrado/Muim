using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class HabilidadPasivaService : IHabilidadPasivaService
    {
        private readonly IUserData _dataUser;
        private readonly IHabilidadPasivaData _habilidadPasivaData;

        public HabilidadPasivaService(IUserData dataUser, IHabilidadPasivaData habilidadPasivaData)
        {
            _dataUser = dataUser;
            _habilidadPasivaData = habilidadPasivaData;

        }
        public bool AddHabilidadPasiva(HabilidadPasiva habilidadPasiva, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _habilidadPasivaData.AddHabilidadPasiva(habilidadPasiva);
                return true;
            }
            return false;
        }

        public bool DeleteHabilidadPasiva(int id, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _habilidadPasivaData.DeleteHabilidadPasiva(id);
                return true;
            }
            return false;
        }

        public List<HabilidadPasiva> GetAllHabilidadPasiva()
        {
            var habilidadPasivas = _habilidadPasivaData.GetAllHabilidadPasiva();
            return habilidadPasivas;
        }

        public HabilidadPasiva GetHabilidadPasiva(int id)
        {
            var habilidadPasiva = _habilidadPasivaData.GetHabilidadPasiva(id);
            return habilidadPasiva;
        }

        public bool UpdateHabilidadPasiva(HabilidadPasiva habilidadPasiva, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                return _habilidadPasivaData.UpdateHabilidadPasiva(habilidadPasiva);
            }
            return false;
        }
    }
}
