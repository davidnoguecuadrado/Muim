using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class TipoService : ITipoService
    {
        private readonly IUserData _dataUser;
        private readonly ITipoData _dataTipo;

        public TipoService(IUserData dataUser, ITipoData dataTipo)
        {
            _dataUser = dataUser;
            _dataTipo = dataTipo;

        }
        public bool AddTipo(Tipo tipo, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _dataTipo.AddTipo(tipo);
                return true;
            }
            return false;
        }

        public bool DeleteTipo(int id, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _dataTipo.DeleteTipo(id);
                return true;
            }
            return false;
        }

        public List<Tipo> GetAllTipo()
        {
            var tipos = _dataTipo.GetAllTipo();
            return tipos;
        }

        public Tipo GetTipo(int id)
        {
            var tipo = _dataTipo.GetTipo(id);
            return tipo;
        }

        public bool UpdateTipo(Tipo tipo, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                return _dataTipo.UpdateTipo(tipo);
            }
            return false;
        }
    }
}
