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
    }
}
