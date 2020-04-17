
using Muim.Domain.Models;
using System.Collections.Generic;

namespace Muim.Data.Contracts
{
    public interface IClassCharacterData
    {
        public ClassCharacter AddClassCharacter(ClassCharacter classc);
        public bool DeleteClassCharacter(int id);
        public List<ClassCharacter> GetAllClassCharacter();
        public ClassCharacter GetClassCharacter(int id);
        public bool UpdateClassCharacter(ClassCharacter cs);
    }
}
