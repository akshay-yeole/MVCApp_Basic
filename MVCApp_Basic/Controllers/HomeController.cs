using Microsoft.AspNetCore.Mvc;
using MVCApp_Basic.DataLayer;
using MVCApp_Basic.Models;
using System.Collections.Generic;

namespace MVCApp_Basic.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookRepository  repository= null;

        public HomeController()
        {
            repository = new BookRepository();
        }
        public IActionResult Index()
        {
            var allBooks = repository.GetAllBooks();
            return View(allBooks); 
        }

        public BookModel GetBookById(int id)
        {
            return repository.GetBookById(id);
        }

        public BookModel SearchBook(string title, string author)
        {
            return repository.SearchBook(title, author);
        }
    }
}
