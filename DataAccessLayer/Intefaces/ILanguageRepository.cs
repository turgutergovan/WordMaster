using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Intefaces
{
    public interface ILanguageRepository
    {
        Language GetById(int id);
        List<Language> List();
        void Add(Language entitiy);
        void Update(Language entitiy);
        void Delete(int id);
    }
}
