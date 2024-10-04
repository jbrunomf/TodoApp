using Microsoft.EntityFrameworkCore;

namespace TodoApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<TodoApp.API.Model.TaskModel> TaskModel { get; set; } = default!;
    }
}
