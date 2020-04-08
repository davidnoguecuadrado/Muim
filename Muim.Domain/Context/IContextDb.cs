using Microsoft.EntityFrameworkCore;
using Muim.Domain.Models;
using System.Threading;
using System.Threading.Tasks;

namespace Muim.Domain.Context
{
    public interface IContextDb
    {
        DbSet<Capacidad> Capacidades { get; set; }
        DbSet<Equipo> Equipos { get; set; }
        DbSet<HabilidadActiva> HabilidadActivas { get; set; }
        DbSet<HabilidadPasiva> HabilidadPasivas { get; set; }
        DbSet<Magia> Magias { get; set; }
        DbSet<Personaje> Personajes { get; set; }
        DbSet<Raza> Razas { get; set; }
        DbSet<Tipo> Tipos { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Partida> Partidas { get; set; }
        DbSet<PUP> Pup { get; set; }
        DbSet<PersonajeHabilidadActiva> PersonajeHabilidadActiva { get; set; }
        DbSet<PersonajeHabilidadPasivas> PersonajeHabilidadPasivas { get; set; }
        DbSet<PersonajesCapacidades> PersonajesCapacidades { get; set; }
        DbSet<MagiaPersonajes> MagiaPersonajes { get; set; }
        DbSet<PartidaUsuario> PartidaUsuario { get; set; }
        DbSet<ClassCharacter> ClassCharacter { get; set; }

        public DbSet<ClassCharacterCpacidades> ClassCharacterCpacidades { get; set; }

        int SaveChanges();
    
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);
        

    }
}
