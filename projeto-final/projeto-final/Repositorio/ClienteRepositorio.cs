using projeto_final.Models;

namespace projeto_final.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly Contexto _contexto;
        public ClienteRepositorio(Contexto contexto)
        {
            _contexto = contexto;


        }
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
    }
}
