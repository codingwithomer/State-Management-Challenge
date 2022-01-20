using MediatR;

namespace StateManagement.Application.Features.State.Commands.CreateState
{
    public class CreateStateCommandRequest : IRequest<CreateStateCommandResponse>
    {
        public string Name { get; set; }
    }
}
