using CadastroContatosMVC.Data;
using CadastroContatosMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CadastroContatosMVC.Services
{
    public class ContatoService
    {
        private readonly CadastroContatosMVCContext _context;
        public ContatoService(CadastroContatosMVCContext context)
        {
            _context = context;
        }
        public List<Contato> FindAll()
        {
            return _context.Contato.ToList();
        }
        public void Insert(Contato obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Contato FindById(int id)
        {
            return _context.Contato.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Contato.Find(id);
            _context.Contato.Remove(obj);
            _context.SaveChanges();
        }
        public void Update(Contato obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }
    }
}
