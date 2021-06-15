using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context : DbContext  //Context herda de DbContext
    {
        public DbSet<Categoria> Categorias { get; set; } //Tenho uma tabela chamada categorias | Basta referenciar o Context para acessá-lo
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Método de configuração do Entity, nos informa qual banco de dados usaremos
        {
            //String de conexão
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=DocManager;Integrated Security=true"); //Parâmetro opcional da string de conexão
        }
    }
}