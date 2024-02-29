using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
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

        #region Create User
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

        #endregion

        #region Edit User
        [HttpGet]
        public IActionResult Edit(int id)
        {
            User obj = _context.Users.Find(id);

            if(obj == null)
                return BadRequest();

            return View(obj);
        }
        
        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (user == null)
                return BadRequest();

            if(ModelState.IsValid)
            {
                _context.Users.Update(user);
                _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
        #endregion

        #region Delete User
        [HttpGet]
        public IActionResult Delete(int id)
        {
            User obj = _context.Users.Find(id);

            if (obj == null)
                return BadRequest();

            return View(obj);
        }
        
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int id)
        {
            User obj = _context.Users.Find(id);

            if (obj == null)
                return BadRequest();

            _context.Users.Remove(obj);
            _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        #endregion

        #region Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if(!ModelState.IsValid)
                return View(model);

            var obj = _context.Users.FirstOrDefault(u => u.Email == model.Email);
            if(obj != null && VerifyPassword(model.Password, obj.PasswordHash))
            {
                // Manually set authentication status using a cookie
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, obj.Email),
                    // Add other claims as needed
                };

                var identity = new ClaimsIdentity(claims, "custom");
                var principal = new ClaimsPrincipal(identity);

                HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Invalid email or password");
            return View();
        }
        #endregion

        #region Logout
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (!ModelState.IsValid)
                return View(user);

            _context.Users.Add(user);
            _context.SaveChangesAsync();
            // Manually set authentication status using a cookie
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Email),
                    // Add other claims as needed
                };

            var identity = new ClaimsIdentity(claims, "custom");
            var principal = new ClaimsPrincipal(identity);

            HttpContext.SignInAsync(principal);

            return RedirectToAction("Index", "Home");
        }
        #endregion

        private bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            if(string.IsNullOrEmpty(storedPasswordHash) || string.IsNullOrEmpty(enteredPassword))
                return false;

            if (enteredPassword == storedPasswordHash) return true;

            return false;
        }
    }
}
