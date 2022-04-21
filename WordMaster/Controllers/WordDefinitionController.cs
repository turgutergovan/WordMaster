using DataAccessLayer.Entities;
using DataAccessLayer.Intefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordMaster.Models;

namespace WordMaster.Controllers
{
    public class WordDefinitionController : Controller
    {
        IWordDefinitionRepository _repository;
        ILanguageRepository _langRepository;
        public WordDefinitionController(IWordDefinitionRepository repository,ILanguageRepository langRepository)
        {
            _repository = repository;
            _langRepository = langRepository;
        }
        // GET: LanguageController
        public ActionResult Index()
        {
            List<WordDefinitionViewModel> model = new List<WordDefinitionViewModel>();

            List<WordDefinition> liste = _repository.List();

            foreach(WordDefinition Item in liste)
            {
                WordDefinitionViewModel wdm = new WordDefinitionViewModel()
                {
                    Word = Item.Word,
                    Id = Item.Id,
                    LangId = Item.LangId,
                    LangCode =Item.Lang.Code,
                    LangName = Item.Lang.Name,
                    
                };
                model.Add(wdm);
            }

            return View(model);
        }

        

        

        // GET: LanguageController/Edit/5
        public ActionResult Edit(int? id)
        {
            WordDefinitionViewModel model = new WordDefinitionViewModel();
            if (id.HasValue && id > 0)
            {
                WordDefinition def = _repository.GetById(id.Value);

                model.Word = def.Word;
                model.Id = def.Id;
                model.LangId = def.LangId;
            }
            ViewBag.Langs = _langRepository.List();
            return View(model);
            
        }

        // POST: LanguageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WordDefinitionViewModel model)
        {
            WordDefinition entitiy = new WordDefinition() 
            { 
                LangId = model.LangId, 
                Id =model.Id,
                Word = model.Word
            };

            if (entitiy.Id>0)
            {
                _repository.Update(entitiy);
            }
            else
            {
                _repository.Add(entitiy);
            }
            return RedirectToAction("Index");
        }



        // GET: LanguageController/Delete/5
        public ActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
            
        }



        // POST: LanguageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
