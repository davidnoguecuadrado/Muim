﻿
using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System.Collections.Generic;

namespace Muim.Service.Implementation
{
    public class HabilidadActivaService : IHabilidadActivaService
    {
        private readonly IUserData _dataUser;
        private readonly IHabilidadActivaData _habilidadActivaData;
        private readonly IPersonajeHabilidadActivaData _personajeHabilidadActivaData;

        public HabilidadActivaService(IUserData dataUser, IHabilidadActivaData habilidadActivaData, IPersonajeHabilidadActivaData personajeHabilidadActivaData)
        {
            _dataUser = dataUser;
            _habilidadActivaData = habilidadActivaData;
            _personajeHabilidadActivaData = personajeHabilidadActivaData;

        }
        public bool AddHabilidadActiva(HabilidadActiva habilidadActiva, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _habilidadActivaData.AddHabilidadActiva(habilidadActiva);
                return true;
            }
            return false;
        }

        public bool DeleteHabilidadActiva(int id, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _habilidadActivaData.DeleteHabilidadActiva(id);
                return true;
            }
            return false;
        }

        public List<HabilidadActiva> GetAllHabilidadActiva()
        {
            var habilidadActivas = _habilidadActivaData.GetAllHabilidadActiva();
            return habilidadActivas;
        }

        public Dictionary<HabilidadActiva, int> GetHabilidadActiva(int idPersonaje)
        {
            Dictionary<HabilidadActiva, int> habilidades = new Dictionary<HabilidadActiva, int>();
            var habilidadesPersonase = _personajeHabilidadActivaData.GetPersonajeHabilidadActiva(idPersonaje);
            foreach (var hab in habilidadesPersonase)
            {
                var ma = _habilidadActivaData.GetHabilidadActiva(hab.HabilidadActivaInt);
                habilidades.Add(ma, hab.Nivel);
            }
            return habilidades;
        }

        public bool UpdateHabilidadActiva(HabilidadActiva habilidadActiva, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                return _habilidadActivaData.UpdateHabilidadActiva(habilidadActiva);
            }
            return false;
        }
    }
}
