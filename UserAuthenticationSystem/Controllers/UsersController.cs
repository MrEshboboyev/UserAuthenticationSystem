using Microsoft.AspNetCore.Mvc;
using UserAuthenticationSystem.Data;
using UserAuthenticationSystem.Models;

namespace UserAuthenticationSystem.Controllers
{
    public class UsersController : Controller
    {
        private AppDbContext _context;
        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<User> objList = _context.Users.ToList(); 
            return View(objList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (user == null)
                return BadRequest();

            if(ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
