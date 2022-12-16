using AngleSharp.Dom;
using Microsoft.EntityFrameworkCore;
using projeto_final.Models;
using SharpCompress.Common;

namespace projeto_final.Repositorio
{
    public class UtilRepositorio : IUtilRepositorio
    {
        private readonly Contexto _contexto;
        public UtilRepositorio(Contexto contexto)
        {
            _contexto = contexto;


        }

        //Clientes
        public Clientes ListarPorId(int id)
        {
            return _contexto.Clientes.FirstOrDefault(x => x.id == id); ;
        }

        public List<Clientes> ListarTodos()
        {
            return _contexto.Clientes.ToList();
        }

        public Clientes Adicionar(Clientes cliente)
        {
            _contexto.Clientes.Add(cliente);
            _contexto.SaveChanges();

            return cliente;
        }

        public Clientes Atualizar(Clientes clientes)
        {
            Clientes clientesDB = ListarPorId(clientes.id);

            if (clientesDB == null) throw new Exception("Houve um erro na atualização do cadastro!");

            clientesDB.nome = clientes.nome;
            clientesDB.cpf = clientes.cpf;
            clientesDB.telefone = clientes.telefone;

            _contexto.Clientes.Update(clientesDB);
            _contexto.SaveChanges();

            return clientesDB;

        }

        public bool Apagar(int id)
        {
            Clientes clientesDB = ListarPorId(id);

            if (clientesDB == null) throw new Exception("Houve um erro ao deletar o cadastro!");

            _contexto.Clientes.Remove(clientesDB);
            _contexto.SaveChanges();

            return true;
        }

        //Categoria
        public List<Categoria> ListarCategorias()
        {
            return _contexto.Categoria.ToList();
        }

        public Categoria ListarCategoriaId(Categoria categoria)
        {
            Categoria categoriaDB = SelecionarId(categoria.id);
            return categoriaDB;
        }

        public Categoria selecionarId(int id)
        {
            return _contexto.Categoria.FirstOrDefault(x => x.id == id); ;
        }

        //Carros
        public List<Carros> ListarTodosCarros()
        {
            return _contexto.Carros.ToList();
        }

        public Carros CadastrarCarro(Carros carro)
        {
            _contexto.Carros.Add(carro);
            _contexto.SaveChanges();

            return carro;
        }
        public Carros ListarCarrosId(int id)
        {
            return _contexto.Carros.FirstOrDefault(x => x.id == id); 
        }

        public Carros AtualizarCarro(Carros carro)
        {
            Carros carrosDB = ListarCarrosId(carro.id);

            if (carrosDB == null) throw new Exception("Houve um erro na atualização do cadastro!");

            carrosDB.marca = carro.marca;
            carrosDB.modelo = carro.modelo;
            carrosDB.categoriaId = carro.categoriaId;

            _contexto.Carros.Update(carrosDB);
            _contexto.SaveChanges();

            return carrosDB;
        }

        public Categoria SelecionarId(int id)
        {
            return _contexto.Categoria.FirstOrDefault(x => x.id == id);
        }

        //Aluguel
        public Aluguel RegistraAluguel(Aluguel aluguel)
        {
            Categoria categoria = selecionarId(aluguel.Categoria.id);
            aluguel.valorTotal = categoria.valorDiaria * Convert.ToInt32(aluguel.quantidadeDiarias);
            _contexto.Aluguel.Add(aluguel);
            _contexto.SaveChanges();

            return aluguel;
        }

        public List<Aluguel> ListarAluguel()
        {
            return _contexto.Aluguel.ToList();
        }
        public Aluguel ListarAlugeulPorId(int id)
        {
            return _contexto.Aluguel.FirstOrDefault(x => x.id == id); ;
        }

        public bool ApagarAluguel(int id)
        {
            Aluguel aluguelDB = ListarAlugeulPorId(id);

            if (aluguelDB == null) throw new Exception("Houve um erro ao deletar o cadastro!");

            _contexto.Aluguel.Remove(aluguelDB);
            _contexto.SaveChanges();

            return true;
        }
    }
}
