using StateManagement.Application.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace StateManagement.Application.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IStateRepository StateRepository { get; }
        ITaskRepository TaskRepository { get; }
        IFlowRepository FlowRepository { get; }
        IFlowStateRepository FlowStateRepository { get; }

        Task CommitAsync();
    }
}
