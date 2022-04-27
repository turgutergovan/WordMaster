using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Intefaces
{
    public interface IWordDefinitionRepository:IRepositoryBase<WordDefinition>
    {
        List<WordDefinition> List(string searchKeyword, int? langId);
        //WordDefinition GetById(int id);
        //List<WordDefinition> List();
        //void Add(WordDefinition entitiy);
        //void Update(WordDefinition entitiy);
        //void Delete(int id);

    }
}
