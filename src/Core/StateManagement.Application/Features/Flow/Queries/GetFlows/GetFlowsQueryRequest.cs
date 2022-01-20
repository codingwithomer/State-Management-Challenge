using MediatR;
using System.Collections.Generic;

namespace StateManagement.Application.Features.Flow.Queries.GetFlows
{
    public class GetFlowsQueryRequest : IRequest<IList<GetFlowsQueryResponse>>
    {

    }
}
