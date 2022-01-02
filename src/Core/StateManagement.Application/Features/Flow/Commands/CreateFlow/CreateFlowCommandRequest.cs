using MediatR;

namespace StateManagement.Application.Features.Flow.Commands.CreateFlow
{
    public class CreateFlowCommandRequest : IRequest<CreateFlowCommandResponse>
    {
        public string Name { get; set; }
    }
}
