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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Método de configuração do Entity, nos informa qual banco de dados usaremos
        {
            //String de conexão
            optionsBuilder.UseSqlServer(connectionString: @"Server = (localdb)\mssqllocaldb);Database = CursoMVC;Integrated Security = True"); //Parâmetro opcional da string de conexão
        }
    }
}