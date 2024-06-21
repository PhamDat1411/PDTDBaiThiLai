using Microsoft.AspNetCore.Mvc;
using PDTDBaiThiLai.Models;

namespace PDTDBaiThiLai.Controllers
{
    public class PDTD328Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PDTD328 pdtd328)
        {
            string strOutput = "Xin chào " + pdtd328.PDTD328Id + " - " + pdtd328.PDTD328Name + " đến từ " + pdtd328.PDTD328Address;
            ViewBag.Dat = strOutput;
            return View();
        }
    }
}