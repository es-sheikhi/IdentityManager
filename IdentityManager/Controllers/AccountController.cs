using IdentityManager.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {

            }
            return View(registerViewModel);
        }
    }
}
