using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        
        // GET
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Item Item)
        {
            _context.Items.Add(Item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            // _context.Items.Add(Id)
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
