using Muim.Data.Contracts;
using Muim.Domain.Models;
using Muim.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Muim.Service.Implementation
{
    public class ClassCharacterService : IClassCharacterService
    {
        private readonly IUserData _dataUser;
        private readonly IClassCharacterData _dataCharacterData;

        public ClassCharacterService(IUserData dataUser, IClassCharacterData characterData)
        {
            _dataUser = dataUser;
            _dataCharacterData = characterData;

        }
        public bool AddClassCharacter(ClassCharacter classCharacter, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _dataCharacterData.AddClassCharacter(classCharacter);
                return true;
            }
            return false;
        }

        public bool DeleteClassCharacter(int id, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                _dataCharacterData.DeleteClassCharacter(id);
                return true;
            }
            return false;
        }

        public List<ClassCharacter> GetAllClassCharacter()
        {
            var razas = _dataCharacterData.GetAllClassCharacter();
            return razas;
        }

        public ClassCharacter GetClassCharacter(int id)
        {
            var raza = _dataCharacterData.GetClassCharacter(id);
            return raza;
        }

        public bool UpdateClassCharacter(ClassCharacter classCharacter, int idUsuario)
        {
            var user = _dataUser.GetUser(idUsuario);
            if (user.Tipo == 0)
            {
                return _dataCharacterData.UpdateClassCharacter(classCharacter);
            }
            return false;
        }
    }
}
