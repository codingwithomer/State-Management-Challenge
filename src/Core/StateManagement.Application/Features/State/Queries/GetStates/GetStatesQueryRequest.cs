using MediatR;
using System.Collections.Generic;

namespace StateManagement.Application.Features.State.Queries.GetStates
{
    public class GetStatesQueryRequest : IRequest<IList<GetStatesQueryResponse>>
    {
        
    }
}
