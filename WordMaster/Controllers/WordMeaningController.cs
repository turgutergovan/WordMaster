using DataAccessLayer.Entities;
using DataAccessLayer.Intefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordMaster.Models;

namespace WordMaster.Controllers
{
    public class WordMeaningController : Controller
    {
        IWordMeaningRepository _repository;

        public WordMeaningController(IWordMeaningRepository repository)
        {
            _repository = repository;
        }


        // GET: WordMeaningController
        public ActionResult Index()
        {
            List<WordMeaningViewModel> model = new List<WordMeaningViewModel>();

            List<WordMeaning> liste = _repository.List();

            foreach (WordMeaning Item in liste)
            {
                WordMeaningViewModel lwm = new WordMeaningViewModel()
                {
                    Id = Item.Id,
                    Meaning = Item.Meaning,
                    LangId = Item.LangId,
                    WordDefinitionId = Item.WordDefinitionId,

                };
                model.Add(lwm);
            }

            return View(model);
        }

        // GET: WordMeaningController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WordMeaningController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WordMeaningController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WordMeaningController/Edit/5
        public ActionResult Edit(int? id)
        {
            WordMeaningViewModel model = new WordMeaningViewModel();
            if (id.HasValue && id > 0)
            {
                WordMeaning lang = _repository.GetById(id.Value);

                model.Meaning = lang.Meaning;
                model.Id = lang.Id;
                model.LangId = lang.LangId;
                model.WordDefinitionId = lang.WordDefinitionId;
            }
            return View(model);

        }

        // POST: WordMeaningController/Edit/5


        // GET: WordMeaningController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WordMeaningViewModel model)
        {
            WordMeaning entitiy = new WordMeaning()
            {
                Meaning = model.Meaning,
                Id = model.Id,
                LangId = model.LangId,
                WordDefinitionId = model.WordDefinitionId
            };

            if (entitiy.Id > 0)
            {
                _repository.Update(entitiy);
            }
            else
            {
                _repository.Add(entitiy);
            }
            return RedirectToAction("Index");
        }

       
        
        public ActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
            return View();
        }
    }
}
