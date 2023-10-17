using CadastroContatosMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroContatosMVC.Data
{
    public class CadastroContatosMVCContext : DbContext
    {
        public CadastroContatosMVCContext(DbContextOptions<CadastroContatosMVCContext> options) : base(options)
        {
        }
        public DbSet<Contato> Contato { get; set; }
    }
}
