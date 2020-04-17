using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface ITipoData
    {
        public bool AddTipo(Tipo tipo);
        public bool DeleteTipo(int id);
        public List<Tipo> GetAllTipo();
        public Tipo GetTipo(int id);
        public bool UpdateTipo(Tipo tipo);
    }
}
