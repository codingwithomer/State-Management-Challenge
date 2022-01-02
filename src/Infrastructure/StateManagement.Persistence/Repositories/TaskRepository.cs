using StateManagement.Application.Interfaces.Repositories;
using StateManagement.Domain.Entities;
using StateManagement.Persistence.Context;

namespace StateManagement.Persistence.Repositories
{
    public class TaskRepository : GenericRepository<Task>, ITaskRepository
    {
        public TaskRepository(EFDbContext context)
            : base(context)
        {

        }
    }
}
