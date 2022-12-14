using Microsoft.AspNetCore.Mvc;
using projeto_final.Models;
using projeto_final.Repositorio;
using System.Diagnostics;
namespace projeto_final.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public IActionResult CadastroCliente()
        {
            return View();
        }

        public IActionResult Listar()
        {
           List<Clientes> clientes =  _clienteRepositorio.ListarTodos();
            return View(clientes);
        }

        public IActionResult Editar(int id)
        {
            Clientes cliente = _clienteRepositorio.ListarPorId(id);
            return View(cliente);
        }

        public IActionResult Apagar(int id)
        {
            _clienteRepositorio.Apagar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Cadastrar(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteRepositorio.Adicionar(cliente);
                return RedirectToAction("Listar");
            }
            return RedirectToAction("CadastroCliente", cliente);
        }

        [HttpPost]
        public IActionResult SalvarEdicao(Clientes cliente)
        {
            _clienteRepositorio.Atualizar(cliente);
            return RedirectToAction("Listar");
        }
    }
}
