using Muim.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Muim.Service.Contracts
{
    public interface IEquipoService
    {
        public bool AddEquipo(Equipo equipo);

        public bool DeleteEquipo(int id);

        public List<Equipo> GetEquipos(int id);

        public bool UpdateEquipo(Equipo equipo, int id);
    }
}
