using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projeto_Isoca_linda.Models;

namespace Projeto_Isoca_linda.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Aqui, nós dizemos como irá se chamar a tabela
            // no banco de dados
            base.OnModelCreating(builder);
            builder.Entity<Reserva>().ToTable("Reservas");
            builder.Entity<Pacote>().ToTable("Pacotes");
            builder.Entity<Cliente>().ToTable("Clientes");
            // Depois que você cria, você pode adicionar ao banco de dados
            // Utilizando as migrations do Entity Framework
        }

<<<<<<< HEAD
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Aqui, nós dizemos como irá se chamar a tabela 
            //no banco de dados 
            base.OnModelCreating(builder);
            builder.Entity<Cliente>().ToTable("Clientes");
            //Depois que voc~e cria vc pode add ao banco de dados 
            // utilizando as migrations do Entity Framework
        }
=======
>>>>>>> Ryan
    }

}
