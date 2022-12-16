using Microsoft.AspNetCore.Mvc;
using projeto_final.Models;
using System.Diagnostics;
using Castle.Components.DictionaryAdapter;
using Microsoft.EntityFrameworkCore;
using projeto_final.Repositorio;

namespace projeto_final.Controllers
{
    public class CarroController : Controller
    {
        private readonly IUtilRepositorio _utilRepositorio;
        public CarroController(IUtilRepositorio utilRepositorio)
        {
            _utilRepositorio = utilRepositorio;
        }

        public async Task<IActionResult> CadastrarCarro()
        {
            CarrosModel model = new CarrosModel();
            model.ListaCategorias = _utilRepositorio.ListarCategorias();

            return View(model);
        }

        public IActionResult Listar()
        {
            CarrosModel model = new CarrosModel();
            List<Carros> listaCarros = _utilRepositorio.ListarTodosCarros();
            List<Categoria> listarCategorias = _utilRepositorio.ListarCategorias();

            model.ListaCarros = listaCarros;
            model.ListaCategorias = listarCategorias;
            return View(model);
        }


        public IActionResult Editar(int id)
        {            
            CarrosModel model = new CarrosModel();
            List<Categoria> listarCategorias = _utilRepositorio.ListarCategorias();

            model.ListaCategorias = listarCategorias;
            
            Carros carro = _utilRepositorio.ListarCarrosId(id);
            string[] arrayCarro = { carro.marca, carro.modelo, carro.categoriaId.ToString(), carro.id.ToString()};

            model.arrayCarro = arrayCarro;



            return View(model);
        }

        public IActionResult Apagar(int id)
        {
            _utilRepositorio.Apagar(id);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Cadastrar(Carros carro)
        {
            try
            {
                _utilRepositorio.CadastrarCarro(carro);
                return RedirectToAction("CadastrarCarro");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

            return RedirectToAction("CadastrarCarro");
        }

        [HttpPost]
        public IActionResult SalvarEdicao(Carros carro)
        {

            _utilRepositorio.AtualizarCarro(carro);
            return RedirectToAction("Listar");
        }

    }
}