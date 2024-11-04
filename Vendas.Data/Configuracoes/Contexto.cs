using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Model;
using Vendas.Model.Entidade;

namespace Vendas.Data.Configuracoes
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
            try
            {
                //Garante que o banco foi criado
                Database.EnsureCreated();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception("Falha ao conectar com o banco de dados! " + ex.Message);
            }

        }

        // Mapea as tabelas
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cidade> Cidade { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //usar o banco que está nesse caminho
            optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=root;Database=Loja");

        }

    }
}
