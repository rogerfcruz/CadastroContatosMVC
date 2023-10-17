using System;

namespace CadastroContatosMVC.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message) { }
    }
}
