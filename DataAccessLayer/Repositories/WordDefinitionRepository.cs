using DataAccessLayer.Entities;
using DataAccessLayer.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class WordDefinitionRepository: RepositoryBase<WordDefinition>, IWordDefinitionRepository
    {
        
        public WordDefinitionRepository(WordMasterDbContext context):base(context)
        {
            
        }

        public override List<WordDefinition> List()
        {
            var liste = _context.Set<WordDefinition>().Include(c=>c.Lang).ToList();
            return liste;
        }


        //public WordDefinition GetById(int id)
        //{
        //    return _context.Set<WordDefinition>().Find(id);
        //}



        //public List<WordDefinition> List()
        //{
        //    return _context.Set<WordDefinition>().ToList();
        //}



        //public void Add(WordDefinition entitiy)
        //{
        //    _context.Set<WordDefinition>().Add(entitiy);
        //    _context.SaveChanges();
        //}



        //public void Update(WordDefinition entitiy)
        //{
        //    _context.Attach(entitiy);
        //    _context.Entry(entitiy).State = EntityState.Modified;
        //    _context.SaveChanges();
        //}



        //public void Delete (int id)
        //{
        //    var silinecek = GetById(id);
        //    _context.Set<WordDefinition>().Remove(silinecek);
        //    _context.SaveChanges();
        //}

    }
}
