
using Muim.Data.Contracts;
using Muim.Domain.Context;
using Muim.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Muim.Data.Implemention
{
    public class ClassCharacterData : IClassCharacterData
    {
        private readonly IContextDb _contextDb;
        public ClassCharacterData(IContextDb contextDb)
        {
            _contextDb = contextDb;
        }

        public ClassCharacter AddClassCharacter(ClassCharacter classc)
        {
            var cs = _contextDb.ClassCharacter.Add(classc);
            _contextDb.SaveChanges();
            return cs.Entity;
        }

        public bool DeleteClassCharacter(int id)
        {
            var cs = _contextDb.ClassCharacter.Find(id);
            _contextDb.ClassCharacter.Remove(cs);
            _contextDb.SaveChanges();
            return true;
        }

        public List<ClassCharacter> GetAllClassCharacter()
        {
            var css = _contextDb.ClassCharacter.ToList();
            return css;
        }

        public ClassCharacter GetClassCharacter(int id)
        {
            var cs = _contextDb.ClassCharacter.Find(id);
            return cs;
        }

        public bool UpdateClassCharacter(ClassCharacter cs)
        {
            _contextDb.ClassCharacter.Update(cs);
            _contextDb.SaveChanges();
            return true;
        }
    }
}
