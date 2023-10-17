using CadastroContatosMVC.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;

namespace CadastroContatosMVC.Data
{
    public class SeedingService
    {
        private CadastroContatosMVCContext _context;
        public SeedingService(CadastroContatosMVCContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if (_context.Contato.Any())
            {
                return; // O banco já está populado.
            }

            Contato c1 = new Contato(1, "Roger Ferreira da Cruz", "roger.fc@outlook.com", "31999999999");
            Contato c2 = new Contato(2, "Daniela dos Santos Lana", "daniela.lana@outlook.com", "31988888888");
            Contato c3 = new Contato(3, "Rosângela de Fátima Oliveira", "rosangela.oliveira@outlook.com", "31977777777");
            Contato c4 = new Contato(4, "Maria Aparecida dos Santos", "maria.santos@outlook.com", "31966666666");

            _context.Contato.AddRange(c1, c2, c3, c4);
            _context.SaveChanges();
        }
    }
}
