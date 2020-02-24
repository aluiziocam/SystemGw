using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemGw.Models;

namespace SystemGw.Data
{
    public class SystemContext : DbContext

    {
        public  DbSet<QuadroServico> QuadroServicos {get; set;}
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Regiao> Regioes { get; set; }
        public DbSet<StatusDoServico> StatusDoServicos { get; set; }
        public DbSet<SetorMecanico> SetorMecanicos { get; set; }
        public DbSet<TipoOs> TipoOs { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=admin123;Persist Security Info=True;User ID=sa;Initial Catalog=dbSystem;Data Source=NOTALUIZIO");
        }
      
    }
}
