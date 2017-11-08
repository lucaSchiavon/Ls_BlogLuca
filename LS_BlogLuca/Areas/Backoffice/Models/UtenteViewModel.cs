using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LS_BlogLuca.Models.Backoffice
{
    public class UtenteViewModel 
    {
        public UtenteViewModel()
        {
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ErrorMessage { get; set; }
    }
}

