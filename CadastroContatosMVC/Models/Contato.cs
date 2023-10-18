using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroContatosMVC.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} tamanho deve ser entre {2} e {1}.")]
        public String Nome { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} obrigatório")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido.")]
        public String Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "{0} obrigatório")]
        [Phone(ErrorMessage = "Digite um telefone válido.")]
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
