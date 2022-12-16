using projeto_final.Models;

namespace projeto_final.Repositorio
{
    public interface IUtilRepositorio
    {
        //Clientes
        Clientes ListarPorId(int id);
        List<Clientes> ListarTodos();
        Clientes Adicionar(Clientes clientes);
        Clientes Atualizar(Clientes clientes);
        bool Apagar(int id);

        //Categoria
        List<Categoria> ListarCategorias();
        Categoria SelecionarId(int id);
        Categoria ListarCategoriaId(Categoria categoria);


        //Carros
        List<Carros> ListarTodosCarros();
        Carros ListarCarrosId(int id);
        Carros CadastrarCarro(Carros carro);
        Carros AtualizarCarro(Carros carro);

        //Aluguel
        Aluguel RegistraAluguel(Aluguel aluguel);
        List<Aluguel> ListarAluguel();
        Aluguel ListarAlugeulPorId(int id);
        bool ApagarAluguel(int id);

    }

}
