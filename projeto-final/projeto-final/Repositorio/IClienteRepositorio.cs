using projeto_final.Models;

namespace projeto_final.Repositorio
{
    public interface IClienteRepositorio
    {
        Clientes ListarPorId(int id);
        List<Clientes> ListarTodos();
        Clientes Adicionar(Clientes clientes);
        Clientes Atualizar(Clientes clientes);
        bool Apagar(int id);

    }

}
