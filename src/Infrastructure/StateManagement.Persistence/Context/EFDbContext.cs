using Microsoft.EntityFrameworkCore;
using StateManagement.Domain.Entities;

namespace StateManagement.Persistence.Context
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions options) : base(options)
        {
        
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Flow> Flows { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<FlowState> FlowStates { get; set; }
    }
}
