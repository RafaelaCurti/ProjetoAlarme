using AutoMapper;
using ProjetoAlarme.Application.Interface;
using ProjetoAlarme.Application.ViewModels;
using ProjetoAlarme.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoAlarme.Presentation.Web.MVC.Controllers
{
    public class AlarmeController : Controller
    {
        private readonly IAppServiceBase<AlarmeViewModel> _appServiceBase;

        public AlarmeController(IAppServiceBase<AlarmeViewModel> appServiceBase)
        {
            _appServiceBase = appServiceBase;
        }

        public ActionResult Index()
        {
            var AlarmeViewModel = Mapper.Map<IEnumerable<AlarmeViewModel>, IEnumerable<Alarme>>(_appServiceBase.GetAll());
            return View(AlarmeViewModel);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(AlarmeViewModel alarme)
        {
            if (ModelState.IsValid)
            {
                //var alarmeDomain = Mapper.Map<AlarmeViewModel, Alarme>(alarme);
                _appServiceBase.Add(alarme);
                return RedirectToAction("Index");
            }

            return View(alarme);
        }

        public ActionResult Editar(Guid id)
        {
            var alarme = _appServiceBase.GetById(id);
            var alarmeViewModel = Mapper.Map<AlarmeViewModel, Alarme>(alarme);
            return View(alarmeViewModel);
        }

        [HttpPost]
        public ActionResult Editar(int id, AlarmeViewModel alarme)
        {
            if (ModelState.IsValid)
            {
                //var alarmeDomain = Mapper.Map<AlarmeViewModel, Alarme>(alarme);
                _appServiceBase.Update(alarme);
                return RedirectToAction("Index");
            }
            return View(alarme);
        }

        public ActionResult Delete(Guid id)
        {
            var alarme = _appServiceBase.GetById(id);
            var alarmeViewModel = Mapper.Map<AlarmeViewModel, Alarme>(alarme);
            return View(alarmeViewModel);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(Guid id, AlarmeViewModel alarmeViewModel)
        {
            var alarme = _appServiceBase.GetById(id);
            _appServiceBase.Delete(alarme);
            return RedirectToAction("Index");
        }

    }
}
