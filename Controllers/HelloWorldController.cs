using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace PetShopApp.Controllers
{

    public class HelloWorldController : Controller
    {

        public string Index()
        {
            return "Essa é minha ação padrão..";
        }
        public string Welcome()
        {
            return "Essa é a ação do método Welcome";
        }
    }
}
