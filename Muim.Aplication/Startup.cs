using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Muim.Data;
using Muim.Data.Contracts;
using Muim.Data.Implemention;
using Muim.Domain.Context;
using Muim.Service.Contracts;
using Muim.Service.Implementation;
using System.Text;

namespace Muim.Aplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });

            services.AddTransient<IContextDb, ContextoDb>();
            services.AddTransient<IUserData, UserData>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IPartidaData, PartidaData>();
            services.AddTransient<IUserPartida, UserPartida>();
            services.AddTransient<IPartidaUsuarios, PartidaUsuarios>();
            services.AddTransient<IPupData, PupData>();
            services.AddTransient<IPersonajeData, PersonajeData>();
            services.AddTransient<IPersonajeService, PersonajeService>();
            services.AddTransient<IMagiaData, MagiaData>();
            services.AddTransient<IMagicService, MagiaService>();
            services.AddTransient<IMagiaPersonajesData, MagiaPersonajesData>();
            services.AddTransient<IMagiaPersonajesService, MagiaPersonajesService>();
            services.AddTransient<IRazaData, RazaData>();
            services.AddTransient<IRazaService, RazaService>();
            services.AddTransient<ITipoData, TipoData>();
            services.AddTransient<ITipoService, TipoService>();
            services.AddTransient<IClassCharacterData, ClassCharacterData>();
            services.AddTransient<IClassCharacterService, ClassCharacterService>();
            services.AddTransient<ICapacidadesData, CapacidadesData>();
            services.AddTransient<ICapacidadesService, CapacidadesService>();
            services.AddTransient<IHabilidadPasivaData, HabilidadPasivaData>();
            services.AddTransient<IHabilidadPasivaService, HabilidadPasivaService>();
            services.AddTransient<IHabilidadActivaData, HabilidadActivaData>();
            services.AddTransient<IHabilidadActivaService, HabilidadActivaService>();
            services.AddTransient<IEquipoData, EquipoData>();
            services.AddTransient<IEquipoService, EquipoService>();
            services.AddTransient<IPersonajesCapacidadesData, PersonajesCapacidadesData>();
            services.AddTransient<IPersonajesCapacidadesService, PersonajesCapacidadesService>();
            services.AddTransient<IPersonajeHabilidadActivaData, PersonajeHabilidadActivaData>();
            services.AddTransient<IPersonajeHabilidadActivaService, PersonajeHabilidadActivaService>();
            services.AddTransient<IPersonajeHabilidadPasivasData, PersonajeHabilidadPasivasData>();
            services.AddTransient<IPersonajeHabilidadPasivasService, PersonajeHabilidadPasivasService>();
            services.AddTransient<IClassCharacterCpacidadesData, ClassCharacterCpacidadesData>();
            services.AddTransient<IClassCharacterCpacidadesService, ClassCharacterCpacidadesService>();

            

            services.AddDbContext<ContextoDb>(o => o.UseSqlServer("Server = tcp:muimdbserver.database.windows.net, 1433; Initial Catalog = muimDb; Persist Security Info = False; User ID = david; Password =Pass(!)Word; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;"));
            
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
