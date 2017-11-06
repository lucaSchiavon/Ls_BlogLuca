
using System.Security.Claims;
using System.Threading.Tasks;


namespace LS_BlogLuca.Models
{
    // È possibile aggiungere dati di profilo dell'utente specificando altre proprietà della classe ApplicationUser. Per ulteriori informazioni, visitare http://go.microsoft.com/fwlink/?LinkID=317594.
    public class BaseViewModel : LangViewModel
    {
        public HeaderViewModel HeaderVM
        {
            get;
            set;
        }

        public FooterViewModel FooterVM
        {
            get;
            set;
        }

        public NavigationViewModel NavigationVM
        {
            get;
            set;
        }

        public BaseViewModel()
        {
            //
            // TODO: aggiungere qui la logica del costruttore
            //
        }
        public BaseViewModel(string currentLangCode)
            : base(currentLangCode)
        {
            //
            // TODO: aggiungere qui la logica del costruttore
            //
        }
    }
}