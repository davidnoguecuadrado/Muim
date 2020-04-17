using Muim.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Muim.Service.Contracts
{
    public interface ITipoService
    {
        public bool AddTipo(Tipo tipo, int idUsuario);
        public bool DeleteTipo(int id, int idUsuario);
        public List<Tipo> GetAllTipo();
        public Tipo GetTipo(int id);
        public bool UpdateTipo(Tipo tipo, int idUsuario);
    }
}
