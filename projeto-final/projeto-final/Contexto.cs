using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using projeto_final.Models;

namespace projeto_final
{
    public class Contexto : DbContext
    {
        public DbSet<Carros> Carros { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Aluguel> Aluguel { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { 
        }

        public Contexto()
        {
        }
    }
}
