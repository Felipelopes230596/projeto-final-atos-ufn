using Microsoft.AspNetCore.Mvc;
using projeto_final.Models;
using projeto_final.Repositorio;
using System.Diagnostics;
namespace projeto_final.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IUtilRepositorio _utilRepositorio;
        public ClienteController(IUtilRepositorio utilRepositorio)
        {
            _utilRepositorio = utilRepositorio;
        }
        public IActionResult CadastroCliente()
        {
            return View();
        }

        public IActionResult Listar()
        {
           List<Clientes> clientes = _utilRepositorio.ListarTodos();
            return View(clientes);
        }


        public IActionResult Editar(int id)
        {
            Clientes cliente = _utilRepositorio.ListarPorId(id);
            return View(cliente);
        }

        public IActionResult Apagar(int id)
        {
            _utilRepositorio.Apagar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Cadastrar(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                _utilRepositorio.Adicionar(cliente);
                return RedirectToAction("Listar");
            }
            return RedirectToAction("CadastroCliente", cliente);
        }

        [HttpPost]
        public IActionResult SalvarEdicao(Clientes cliente)
        {
            _utilRepositorio.Atualizar(cliente);
            return RedirectToAction("Listar");
        }
    }
}
