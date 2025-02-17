using Microsoft.AspNetCore.Mvc;

namespace Bookchive.Controllers
{
    [Route("Book")]
    public class BookController : Controller
    {
        private const string _viewPath = "~/Pages/Book";

        [Route("List")]
        public ActionResult List()
        {
            return View($"{_viewPath}/Index",null);
        }


        [Route("register")]
        public ActionResult Register()
        {
            return View($"{_viewPath}/Register",null);
        }
    }
}
