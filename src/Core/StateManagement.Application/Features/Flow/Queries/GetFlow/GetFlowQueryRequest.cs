using MediatR;
using System;

namespace StateManagement.Application.Features.Flow.Queries.GetFlow
{
    public class GetFlowQueryRequest : IRequest<GetFlowQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
