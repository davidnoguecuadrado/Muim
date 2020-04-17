
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Service.Contracts
{
    public interface IClassCharacterService
    {
        public bool AddClassCharacter(ClassCharacter classCharacter, int idUsuario);

        public bool DeleteClassCharacter(int id, int idUsuario);

        public List<ClassCharacter> GetAllClassCharacter();

        public ClassCharacter GetClassCharacter(int id);

        public bool UpdateClassCharacter(ClassCharacter classCharacter, int idUsuario);
    }
}
