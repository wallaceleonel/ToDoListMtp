using Microsoft.EntityFrameworkCore;

namespace TodoList.Models
{
    public class Context : DbContext

    {
       public DbSet<Tarefa> Tarefas { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}

