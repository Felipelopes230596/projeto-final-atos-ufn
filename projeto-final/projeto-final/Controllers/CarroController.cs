using Microsoft.AspNetCore.Mvc;
using projeto_final.Models;
using System.Diagnostics;
using Castle.Components.DictionaryAdapter;
using Microsoft.EntityFrameworkCore;

namespace projeto_final.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult CadastrarCarro()
        {
            
            return View();
        }

            
            
        

    }
}