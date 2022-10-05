using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Dpim.Web.Controllers
{
    public class WebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string GenLeftMenu()
        {
            StringBuilder strGen = new StringBuilder();
            strGen.AppendLine("");
            return strGen.ToString();
        }
    }
}
