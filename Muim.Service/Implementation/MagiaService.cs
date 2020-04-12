using Muim.Data.Contracts;
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public class MagiaService : IMagicService
    {
        private readonly IUserData _dataUser;
        private readonly IMagiaData _dataMagia;

        public MagiaService(IUserData dataUser, IMagiaData magiaData)
        {
            _dataUser = dataUser;
            _dataMagia = magiaData;

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

        public Magia GetMagia(int id)
        {
            var magia = _dataMagia.GetMagia(id);
            return magia;
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
