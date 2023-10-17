using System;

namespace CadastroContatosMVC.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }

        public Contato() { }

        public Contato(int id, string nome, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
