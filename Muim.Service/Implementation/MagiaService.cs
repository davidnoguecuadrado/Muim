using Muim.Data.Contracts;
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public class MagiaService : IMagicService
    {
        private readonly IUserData _dataUser;
        private readonly IMagiaData _dataMagia;
        private readonly IMagiaPersonajesService _magiaPersonajesService;

        public MagiaService(IUserData dataUser, IMagiaData magiaData,IMagiaPersonajesService magiaPersonajesService)
        {
            _dataUser = dataUser;
            _dataMagia = magiaData;
            _magiaPersonajesService = magiaPersonajesService;
        }
        public bool AddMagia(Magia magia,int idUsuario)
        {
            var user=_dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                 _dataMagia.AddMagia(magia);
                return true;
            }
            return false;
        }

        public bool DeleteMagia(int id, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _dataMagia.DeleteMagia(id);
                return true;
            }
            return false;
        }

        public List<Magia> GetAllMagia()
        {
            var magia = _dataMagia.GetAllMagias();
            return magia;
        }

        public Dictionary<Magia, int> GetMagia(int idPersonaje)
        {
           Dictionary<Magia, int> magias = new Dictionary<Magia, int>();
            var magiaspersonajes=_magiaPersonajesService.GetMagiaPersonajes(idPersonaje);
            foreach (var magic in magiaspersonajes) {
                var ma=_dataMagia.GetMagia(magic.MagiaId);
                magias.Add(ma,magic.Nivel);
            }
            return magias;
        }

        public bool UpdateMagia(Magia magia, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                return _dataMagia.UpdateMagia(magia);
            }
            return false;
        }
    }
}
