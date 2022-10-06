using Microsoft.AspNetCore.Mvc;
using MyMVCApp.Models;

namespace MyMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {

        private static List<BookViewModel> books = new List<BookViewModel>();

        public IActionResult Index()
        {
            return View(books);
        }

        public IActionResult Create()
        {
            var bookVm = new BookViewModel();
            return View(bookVm);
        }

        public IActionResult CreateBook(BookViewModel bookViewModel)
        {
            books.Add(bookViewModel);
            return RedirectToAction(nameof(Index));
        }

        public string Hello()
        {
            return "Who's there?";
        }
    }
}
