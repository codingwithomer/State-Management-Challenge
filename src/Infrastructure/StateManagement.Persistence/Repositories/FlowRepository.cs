using StateManagement.Application.Interfaces.Repositories;
using StateManagement.Domain.Entities;
using StateManagement.Persistence.Context;

namespace StateManagement.Persistence.Repositories
{
    public class FlowRepository : GenericRepository<Flow>, IFlowRepository
    {
        public FlowRepository(EFDbContext context) 
            : base(context)
        {

        }
    }
}
