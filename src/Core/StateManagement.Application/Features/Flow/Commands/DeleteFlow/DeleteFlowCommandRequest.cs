using MediatR;
using System;

namespace StateManagement.Application.Features.Flow.Commands.DeleteFlow
{
    public class DeleteFlowCommandRequest : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
