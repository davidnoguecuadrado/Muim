using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class RazaService : IRazaService
    {
        private readonly IUserData _dataUser;
        private readonly IRazaData _dataRaza;

        public RazaService(IUserData dataUser, IRazaData magiaData)
        {
            _dataUser = dataUser;
            _dataRaza = magiaData;

        }
        public bool AddRaza(Raza raza, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _dataRaza.AddRaza(raza);
                return true;
            }
            return false;
        }

        public bool DeleteRaza(int id, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _dataRaza.DeleteRaza(id);
                return true;
            }
            return false;
        }

        public List<Raza> GetAllRaza()
        {
            var razas = _dataRaza.GetAllRaza();
            return razas;
        }

        public Raza GetRaza(int id)
        {
            var raza = _dataRaza.GetRaza(id);
            return raza;
        }

        public bool UpdateRaza(Raza raza,int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                return _dataRaza.UpdateRaza(raza);
            }
            return false;
        }
    }
}
