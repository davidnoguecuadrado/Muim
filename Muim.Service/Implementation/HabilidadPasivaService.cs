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
        private readonly IPersonajeHabilidadPasivasData _personajeHabilidadPasivasData;

        public HabilidadPasivaService(IUserData dataUser, IHabilidadPasivaData habilidadPasivaData, IPersonajeHabilidadPasivasData personajeHabilidadPasivasData)
        {
            _dataUser = dataUser;
            _habilidadPasivaData = habilidadPasivaData;
            _personajeHabilidadPasivasData = personajeHabilidadPasivasData;
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

        public Dictionary<HabilidadPasiva, int> GetHabilidadPasiva(int idPersonaje)
        {
            Dictionary<HabilidadPasiva, int> habilidades = new Dictionary<HabilidadPasiva, int>();
            var habilidadesPersonase = _personajeHabilidadPasivasData.GetPersonajeHabilidadPasivas(idPersonaje);
            foreach (var hab in habilidadesPersonase)
            {
                var ma = _habilidadPasivaData.GetHabilidadPasiva(hab.HabilidadPasivaId);
                habilidades.Add(ma, hab.Nivel);
            }
            return habilidades;
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
