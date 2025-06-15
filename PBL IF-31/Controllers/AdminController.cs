using Microsoft.AspNetCore.Mvc;

namespace PBL_IF_31.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Mahasiswa()
        {
            return View();
        }
        public IActionResult Dosen()
        {
            return View();
        }
        public IActionResult Divisi()
        {
            return View();
        }
        public IActionResult Dokter()
        {
            return View();
        }
    }

}
