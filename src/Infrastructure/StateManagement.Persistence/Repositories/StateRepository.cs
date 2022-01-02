using StateManagement.Application.Interfaces.Repositories;
using StateManagement.Domain.Entities;
using StateManagement.Persistence.Context;

namespace StateManagement.Persistence.Repositories
{
    public class StateRepository : GenericRepository<State>, IStateRepository
    {
        public StateRepository(EFDbContext context) 
            : base(context)
        {

        }
    }
}
