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
    public class LanguageRepository: ILanguageRepository
    {
        WordMasterDbContext _context;
        public LanguageRepository(WordMasterDbContext context)
        {
            _context = context;
        }



        public Language GetById(int id)
        {
            return _context.Set<Language>().Find(id);
        }



        public List<Language> List()
        {
            return _context.Set<Language>().ToList();
        }



        public void Add(Language entitiy)
        {
            _context.Set<Language>().Add(entitiy);
            _context.SaveChanges();
        }



        public void Update(Language entitiy)
        {
            _context.Attach(entitiy);
            _context.Entry(entitiy).State = EntityState.Modified;
            _context.SaveChanges();
        }



        public void Delete (int id)
        {
            var silinecek = GetById(id);
            _context.Set<Language>().Remove(silinecek);
            _context.SaveChanges();
        }
    }
}
