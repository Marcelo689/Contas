
using GestaoDeContas.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace GestaoDeContas.Banco
{
    public class Conexao : DbContext
    {
        public DbSet<Conta> Conta { get; set; }

        public Conexao()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;database=Contas;uid=root;password=root";
            optionsBuilder.UseMySql(connectionString: connectionString);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
