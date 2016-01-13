using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ContosoBooks.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Data.Entity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoBooks.Controllers
{
    public class BookController : Controller
    {
        [FromServices]
        public BookContext BookContext { get; set; }

        [FromServices]
        public ILogger<BookController> Logger { get; set; }

        // GET: /Book/
        public IActionResult Index()
        {
            var books = BookContext.Books.Include(b => b.Author);
            return View(books);
        }
    }
}
