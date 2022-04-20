using DataAccessLayer.Entities;
using DataAccessLayer.Intefaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordMaster.Models;

namespace WordMaster.Controllers
{
    public class LanguageController : Controller
    {
        ILanguageRepository _repository;
        public LanguageController(ILanguageRepository repository)
        {
            _repository = repository;
        }
        // GET: LanguageController
        public ActionResult Index()
        {
            List<LanguageViewModel> model = new List<LanguageViewModel>();

            List<Language> liste = _repository.List();

            foreach(Language Item in liste)
            {
                LanguageViewModel lwm = new LanguageViewModel()
                {
                    Name = Item.Name,
                    Id = Item.Id,
                    Code = Item.Code,
                    
                };
                model.Add(lwm);
            }

            return View(model);
        }

        // GET: LanguageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LanguageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LanguageController/Create
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

        // GET: LanguageController/Edit/5
        public ActionResult Edit(int? id)
        {
            LanguageViewModel model = new LanguageViewModel();
            if (id.HasValue && id > 0)
            {
                Language lang = _repository.GetById(id.Value);

                model.Name = lang.Name;
                model.Id = lang.Id;
                model.Code = lang.Code;
            }
            return View(model);
            
        }

        // POST: LanguageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LanguageViewModel model)
        {
            Language entitiy = new Language() { Code = model.Code, Id =model.Id, Name=model.Name };

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
            return View();
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
