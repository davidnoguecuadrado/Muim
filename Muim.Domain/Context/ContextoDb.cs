using Microsoft.EntityFrameworkCore;
using Muim.Domain.Models;

namespace Muim.Domain.Context
{
    public class ContextoDb : DbContext, IContextDb
    {
        public ContextoDb(DbContextOptions<ContextoDb> options) : base(options)
        {

        }

        public DbSet<Capacidad> Canciones {get; set;}
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<HabilidadActiva> HabilidadActivas { get; set; }
        public DbSet<HabilidadPasiva> HabilidadPasivas { get; set; }
        public DbSet<Magia> Magias { get; set; }
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Raza> Razas { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Partida> Partidas { get; set; }
        public DbSet<PUP> Pup { get; set; }
        public DbSet<PersonajeHabilidadActiva> PersonajeHabilidadActiva { get; set; }
        public DbSet<PersonajeHabilidadPasivas> PersonajeHabilidadPasivas { get; set; }
        public DbSet<PersonajesCapacidades> PersonajesCapacidades { get; set; }
        public DbSet<MagiaPersonajes> MagiaPersonajes { get; set; }
        public DbSet<PartidaUsuario> PartidaUsuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<PersonajeHabilidadActiva>().HasKey(x=> new {x.HabilidadActivaInt,x.PersonajeId });
            modelBuilder.Entity<PersonajeHabilidadPasivas>().HasKey(x => new { x.HabilidadPasivaId, x.PersonajeId });
            modelBuilder.Entity<PersonajesCapacidades>().HasKey(x => new { x.CapacidadId, x.PersonajeId });
            modelBuilder.Entity<MagiaPersonajes>().HasKey(x => new { x.PersonajeId, x.MagiaId });
            modelBuilder.Entity<PartidaUsuario>().HasKey(x => new { x.UserId, x.ParitdaId });
            modelBuilder.Entity<PUP>().HasKey(x => new { x.ParitdaId, x.PersonajeId,x.UserId });

        }
    }
}
