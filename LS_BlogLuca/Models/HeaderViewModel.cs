using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LS_BlogLuca.Models
{
    public class HeaderViewModel : LangViewModel
    {
        public string Theme
        {
            get;
            set;
        }

        public HeaderViewModel()
        {

        }
    }
}
