using CleanArchitecture.Infrastracture.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository repository;

        public HomeController(IBookRepository repository)
        {
            this.repository = repository;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View(this.repository.Books);
        }
    }
}
