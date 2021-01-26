using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using IvanCastronuno.Models;

namespace IvanCastronuno.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> usermngr, SignInManager<AppUser> signInMngr)
        {
            userManager = usermngr;
            signInManager = signInMngr;
        }
        // Register login and logout methods go after here : ++++++++++++++
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult LogIn()
        {
            return View();
        }
        
        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
