using StateManagement.Application.Interfaces.Repositories;
using StateManagement.Application.Interfaces.UoW;
using StateManagement.Persistence.Context;
using StateManagement.Persistence.Repositories;
using System.Threading.Tasks;

namespace StateManagement.Persistence.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public IStateRepository StateRepository { get; }
        public ITaskRepository TaskRepository { get; }
        public IFlowRepository FlowRepository { get; }
        public IFlowStateRepository FlowStateRepository { get; }

        private readonly EFDbContext _context;

        public UnitOfWork(EFDbContext context)
        {
            _context = context;

            StateRepository = new StateRepository(_context);
            FlowRepository = new FlowRepository(_context);
            TaskRepository = new TaskRepository(_context);
            FlowStateRepository = new FlowStateRepository(_context);
        }


        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
