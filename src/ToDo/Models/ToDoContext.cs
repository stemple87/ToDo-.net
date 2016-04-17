using Microsoft.Data.Entity;
using ToDo.Models;

namespace ToDo.Models
{
    public class ToDoContext : DbContext
    {
        public virtual DbSet<Item> Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ToDo;integrated security = True");
        }
    }
}