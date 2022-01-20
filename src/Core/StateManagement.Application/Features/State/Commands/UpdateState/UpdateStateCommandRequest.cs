using MediatR;
using System;

namespace StateManagement.Application.Features.State.Commands.UpdateState
{
    public class UpdateStateCommandRequest : IRequest<UpdateStateCommandResponse>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
