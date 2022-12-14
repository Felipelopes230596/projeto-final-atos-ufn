using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using projeto_final.Models;
using System.Diagnostics;
namespace projeto_final.Controllers
{
    public class AlugarController : Controller
    {
        public IActionResult Alugar()
        {
            return View();
        }

        public IActionResult Simulacao()
        {
            return View();
        }
    }
}