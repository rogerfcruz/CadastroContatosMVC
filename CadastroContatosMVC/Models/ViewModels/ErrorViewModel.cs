using System;

namespace CadastroContatosMVC.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public String Message { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId); 
    }
}
