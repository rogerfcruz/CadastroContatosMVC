using CadastroContatosMVC.Models;
using CadastroContatosMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroContatosMVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly ContatoService _contatoService;
        public ContatoController(ContatoService contatoService)
        {
            _contatoService = contatoService;
        }
        public IActionResult Index()
        {
            var list = _contatoService.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            var contatos = _contatoService.FindAll();
            return View(contatos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contato contato)
        {
            _contatoService.Insert(contato);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int? id)
        {
            var contato = _contatoService.FindById(id.Value);
            return View(contato);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Contato contato) 
        {
            _contatoService.Update(contato);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(int? id)
        {
            var obj = _contatoService.FindById(id.Value);
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _contatoService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
