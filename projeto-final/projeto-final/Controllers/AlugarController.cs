using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using projeto_final.Models;
using projeto_final.Repositorio;
using System.Diagnostics;
namespace projeto_final.Controllers
{
    public class AlugarController : Controller
    {
        private readonly IUtilRepositorio _utilRepositorio;

        public AlugarController(IUtilRepositorio utilRepositorio)
        {
            _utilRepositorio = utilRepositorio;
        }
        public IActionResult Alugar()
        {
            AlugarModel model = new AlugarModel();
            List<Categoria> listaCategorias = _utilRepositorio.ListarCategorias();
            List<Clientes> listaCLientes = _utilRepositorio.ListarTodos();

            model.listaCategorias = listaCategorias;
            model.listaClientes = listaCLientes;

            return View(model);
        }
                
        [HttpPost]
        public IActionResult Simular(Aluguel aluguel)
        {
            _utilRepositorio.RegistraAluguel(aluguel);
                        
            return View();
        }

        public IActionResult Listar()
        {            
            AlugarModel model= new AlugarModel();
            List<Aluguel> listaAluguelDB = _utilRepositorio.ListarAluguel();
            List<Clientes> listaClientesDB = _utilRepositorio.ListarTodos();
            List<Categoria> listaCategorias = _utilRepositorio.ListarCategorias();
            model.listaAluguel = listaAluguelDB;
            model.listaClientes= listaClientesDB;
            model.listaCategorias=listaCategorias;

            return View(model);
        }

        public IActionResult Finalizar(int id)
        {
            _utilRepositorio.ApagarAluguel(id);
            return RedirectToAction("Listar");
        }
    }
}