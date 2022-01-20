using MediatR;
using System;

namespace StateManagement.Application.Features.State.Queries.GetState
{
    public class GetStateQueryRequest : IRequest<GetStateQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
