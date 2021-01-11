using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain.Entidades;
using System.Collections.Generic;

namespace Infrastructure.DBConfiguration.EFCore
{
    public class ApplicationContext : DbContext
    {
        /* Creating DatabaseContext without Dependency Injection */
        public ApplicationContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(DatabaseConnection.ConnectionConfiguration
                                                    .GetConnectionString("DefaultConnection"));
            }
        }

        /* Creating DatabaseContext configured outside with Dependency Injection */
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.Migrate();           
            //Cria a base de dados e suas respectivas tabelas se não existir.
            //Database.EnsureCreated();
            //Exclui a base de dados se existir.
            //Database.EnsureDeleted();            
            //Database.Log = instrucao => System.Diagnostics.Debug.WriteLine(instrucao);

            //PM > Add-Migration NewMigration - Project WAPP_ECommerce_BancoDados_V3
            //Microsoft.EntityFrameworkCore.Infrastructure[10403]
            //Entity Framework Core 2.2.6 - servicing - 10079 initialized 'BancoDadosCoreContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer' with options: MigrationsAssembly = WAPP_ECommerce_BancoDados_V3
            //To undo this action, use Remove-Migration.
            //PM >
            //Remove-Migration
            //Update-Database LastGoodMigration
            //Script-Migration 20190725054716_Add_new_tables
            //Add-Migration NewCampoPessoaConvenio
        }

        public DbSet<Pessoa> People { get; set; }
        public DbSet<PessoaEndereco> PeopleAddresses { get; set; }
        public DbSet<PessoaMeioContato> PessoaMeiosContato { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoPreco> ProdutosPreco { get; set; }
        public DbSet<ProdutoCodigo> ProdutosCodigo { get; set; }
        public DbSet<ProdutoImagem> ProdutosImagens { get; set; }
        public DbSet<ProdutoCategoria> ProdutosCategoria { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CEP> CEPs { get; set; }
        public DbSet<TipoEndereco> TiposEndereco { get; set; }
        public DbSet<Regiao> Regioes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<MainMenu> MainMenus { get; set; }
    }
}
