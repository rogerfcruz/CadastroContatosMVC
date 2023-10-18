using CadastroContatosMVC.Models;
using CadastroContatosMVC.Models.ViewModels;
using CadastroContatosMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System;
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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Contato contato)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var viewModel = new ContatoFormViewModel { Contato = contato };
                    return View(viewModel);
                }
                _contatoService.Insert(contato);
                TempData["MensagemSucesso"] = "Contato cadastrado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao cadastrar o contato. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Edit(int? id)
        {
            var contato = _contatoService.FindById(id.Value);
            ContatoFormViewModel viewModel = new ContatoFormViewModel { Contato = contato };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Contato contato) 
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var viewModel = new ContatoFormViewModel { Contato = contato };
                    return View(viewModel);
                }
                _contatoService.Update(contato);
                TempData["MensagemSucesso"] = "Contato alterado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao atualizar o contato. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
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
            try
            {
                _contatoService.Remove(id);
                TempData["MensagemSucesso"] = "Contato apagado com sucesso!";
                return RedirectToAction(nameof(Index));
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Erro a apagar o contato. Detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
