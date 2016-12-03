using System.Web.Mvc;
using Blog.SlightEdgeCoder.NinjectHttpContext.Dal;
using Blog.SlightEdgeCoder.NinjectHttpContext.WebSite.Models;

namespace Blog.SlightEdgeCoder.NinjectHttpContext.WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(new HomeIndexViewModel(_repository.ConnectionString));
        }
    }
}