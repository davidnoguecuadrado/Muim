using System;
using System.Collections.Generic;
using System.Text;

namespace Muim.Domain.Models
{
    public class PartidaUsuario
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Partida Partida { get; set; }
        public int PartidaId { get; set; }
        public int Rol { get; set;}
    }
}
