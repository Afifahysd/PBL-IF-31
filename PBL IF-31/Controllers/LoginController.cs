using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace PBL_IF_31.Controllers

{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            if (Username == "admin" && Password == "123")
            {
                HttpContext.Session.SetString("Role", "Admin");
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Username atau password salah!";
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
