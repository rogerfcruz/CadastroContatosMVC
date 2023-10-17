using CadastroContatosMVC.Models;
using CadastroContatosMVC.Services;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contato contato)
        {
            _contatoService.Insert(contato);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}
