using StateManagement.Application.Interfaces.Repositories;
using StateManagement.Domain.Entities;
using StateManagement.Persistence.Context;

namespace StateManagement.Persistence.Repositories
{
    public class FlowStateRepository : GenericRepository<FlowState> , IFlowStateRepository
    {
        public FlowStateRepository(EFDbContext context) 
            : base(context)
        {

        }
    }
}
