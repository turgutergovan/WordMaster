using DataAccessLayer.Entities;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Intefaces
{
    public interface IWordMeaningRepository:IRepositoryBase<WordMeaning>
    {
        List<WordMeaning> ListByDefId(int defId);
        //WordMeaning GetById(int id);
        //List<WordMeaning> List();
        //void Add(WordMeaning entitiy);
        //void Update(WordMeaning entitiy);
        //void Delete(int id);

    }
}
