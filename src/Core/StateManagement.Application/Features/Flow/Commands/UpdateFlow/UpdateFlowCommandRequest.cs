using MediatR;
using System;

namespace StateManagement.Application.Features.Flow.Commands.UpdateFlow
{
    public class UpdateFlowCommandRequest : IRequest<UpdateFlowCommandResponse>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
