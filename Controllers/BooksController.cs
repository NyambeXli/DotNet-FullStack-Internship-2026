using Microsoft.AspNetCore.Mvc;
using CodVeda_FullStack_Intern.Data;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace CodVeda_FullStack_Intern.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var currentUser = HttpContext.Session.GetString("UserName");

       
            var books = (currentUser == "System Admin")
                        ? _context.Books.ToList()
                        : _context.Books.Where(b => !b.IsHidden).ToList();

            return View(books);
        }
    }
}