using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LS_BlogLuca.Models
{
    public class LangViewModel
    {
        public string DefaultLangCode
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["CultureDefault"].ToString().Substring(0, 2);
            }
        }

        public string CurrentLangCode
        {
            get;
            set;
        }



        public LangViewModel()
        {

        }

        public LangViewModel(string currentLangCode)
        {
            CurrentLangCode = CurrentLangCode;
        }
    }
}
