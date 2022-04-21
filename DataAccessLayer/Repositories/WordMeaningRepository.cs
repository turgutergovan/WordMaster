﻿using DataAccessLayer.Entities;
using DataAccessLayer.Intefaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class WordMeaningRepository: RepositoryBase<WordMeaning>, IWordMeaningRepository
    {

        
        public WordMeaningRepository(WordMasterDbContext context):base(context)
        {
            
        }



        //public WordMeaning GetById(int id)
        //{
        //    return _context.Set<WordMeaning>().Find(id);
        //}

        //public List<WordMeaning> List()
        //{
        //    return _context.Set<WordMeaning>().ToList();
        //}

        //public void Add(WordMeaning entitiy)
        //{
        //    _context.Set<WordMeaning>().Add(entitiy);
        //    _context.SaveChanges();
        //}



        //public void Update(WordMeaning entitiy)
        //{
        //    _context.Attach(entitiy);
        //    _context.Entry(entitiy).State = EntityState.Modified;
        //    _context.SaveChanges();
        //}



        //public void Delete(int id)
        //{
        //    var silinecek = GetById(id);
        //    _context.Set<WordMeaning>().Remove(silinecek);
        //    _context.SaveChanges();
        //}

        
    }
}
