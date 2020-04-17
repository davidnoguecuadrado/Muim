using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System;
using System.Collections.Generic;


namespace Muim.Service.Implementation
{
    public class MagiaPersonajesService : IMagiaPersonajesService
    {
        private readonly IMagiaPersonajesData _partidaPersonajeData;
        public MagiaPersonajesService(IMagiaPersonajesData partidaPersonajeData)
        {
            _partidaPersonajeData = partidaPersonajeData;
        }
        public bool AddMagiaPersonajes(MagiaPersonajes magiaPersonajes)
        {
            return _partidaPersonajeData.AddMagiaPersonajes(magiaPersonajes);
        }

        public bool DeleteMagiaPersonajes(MagiaPersonajes magiaPersonajes)
        {
            return _partidaPersonajeData.DeleteMagiaPersonajes(magiaPersonajes);

        }

        public List<MagiaPersonajes> GetMagiaPersonajes(int personajeId)
        {
            return _partidaPersonajeData.GetMagiaPersonajes(personajeId);
        }
    }
}
