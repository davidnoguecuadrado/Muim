using Microsoft.EntityFrameworkCore;
using Muim.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Muim.Domain.Context
{
    public interface IContextDb
    {
        DbSet<Capacidad> Canciones { get; set; }
        DbSet<Equipo> Equipos { get; set; }
        DbSet<PersonajeHabilidadActiva> PersonajeHabilidadActiva { get; set; }
        DbSet<HabilidadActiva> HabilidadActivas { get; set; }
        DbSet<HabilidadPasiva> HabilidadPasivas { get; set; }
        DbSet<Magia> Magias { get; set; }
        DbSet<Personaje> Personajes { get; set; }
        DbSet<Raza> Razas { get; set; }
        DbSet<Tipo> Tipos { get; set; }
        DbSet<PartidaUsuario> PartidaUsuario { get; set; }

        int SaveChanges();
    
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        

    }
}
