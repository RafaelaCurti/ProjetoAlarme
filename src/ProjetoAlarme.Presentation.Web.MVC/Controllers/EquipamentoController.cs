using AutoMapper;
using ProjetoAlarme.Application.Interface;
using ProjetoAlarme.Application.ViewModels;
using ProjetoAlarme.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoEquipamento.Presentation.Web.MVC.Controllers
{
    public class EquipamentoController : Controller
    {
        private readonly IAppServiceBase<EquipamentoViewModel> _appServiceBase;

        public EquipamentoController(IAppServiceBase<EquipamentoViewModel> appServiceBase)
        {
            _appServiceBase = appServiceBase;
        }

        public ActionResult Index()
        {
            var equipamentoViewModel = Mapper.Map<IEnumerable<EquipamentoViewModel>, IEnumerable<Equipamento>>(_appServiceBase.GetAll());
            return View(equipamentoViewModel);
        }
        // GET: Equipamento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Equipamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipamento/Create
        [HttpPost]
        public ActionResult Create(EquipamentoViewModel equipamento)
        {
            if (ModelState.IsValid)
            {
                //var equipamentoDomain = Mapper.Map<EquipamentoViewModel, Equipamento>(equipamento);
                _appServiceBase.Add(equipamento);
                return RedirectToAction("Index");
            }

            return View(equipamento);
        }

        public ActionResult Editar(Guid id)
        {
            var equipamento = _appServiceBase.GetById(id);
            var equipamentoViewModel = Mapper.Map<EquipamentoViewModel, Equipamento>(equipamento);
            return View(equipamentoViewModel);
        }

        [HttpPost]
        public ActionResult Editar(int id, EquipamentoViewModel equipamento)
        {
            if (ModelState.IsValid)
            {
                //var equipamentoDomain = Mapper.Map<EquipamentoViewModel, Equipamento>(equipamento);
                _appServiceBase.Update(equipamento);
                return RedirectToAction("Index");
            }
            return View(equipamento);
        }

        public ActionResult Excluir(Guid id)
        {
            return View(_appServiceBase.GetById(id));
        }

        [HttpPost, ActionName ("Excluir")]
        public ActionResult Excluir(Guid id, EquipamentoViewModel equipamentoViewModel)
        {
            var equipamento = _appServiceBase.GetById(id);
            _appServiceBase.Delete(equipamento);
            return RedirectToAction("Index");
        }
    }
}
