using System;

namespace StateManagement.Application.Features.State.Commands.CreateState
{
    public class CreateStateCommandResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
