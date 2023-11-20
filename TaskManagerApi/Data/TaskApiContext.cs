using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TaskManagerApi.Models;

namespace TaskManagerApi.Data
{
    public class TaskApiContext : DbContext
    {
        public TaskApiContext(DbContextOptions<TaskApiContext> options) : base(options) { }

        public DbSet<EntityTask> Tasks { get; set;}
    }
}
