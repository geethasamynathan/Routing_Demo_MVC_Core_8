using Microsoft.AspNetCore.Mvc;
using Routing_Demo_MVC_Core_8.Models;

namespace Routing_Demo_MVC_Core_8.Controllers
{
    //token replacement
    [Route("[controller]/[action]")]
    public class BookController : Controller
    {
        static List<Book> BookList;
        static BookController()
        {
            BookList = new List<Book>(){
                new Book{BookId=1,Title="React Js",Description="Intermediate Level",Author="peter"} 
            };
        }
        //[Route("")]
        //[Route("Index")]
        public IActionResult Index()
        {
            if (BookList.Count == 0)
            {
                return NotFound();
            }
            else             {
                return View(BookList);
            }
        }
        //when we are using Toke replacement
        [Route("{id:int}")]
        //[Route("Books/Details/{id:int}")]
        public IActionResult Details(int id)
        {
            return View();
        }
        [HttpGet("/books")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("/books")]
        public IActionResult Create(Book book)
        {
            BookList.Add(book);
            return RedirectToAction("Index");
        }
      
    }
}
