using MediatR;
using System;

namespace StateManagement.Application.Features.State.Commands.DeleteState
{
    public class DeleteStateCommandRequest : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
