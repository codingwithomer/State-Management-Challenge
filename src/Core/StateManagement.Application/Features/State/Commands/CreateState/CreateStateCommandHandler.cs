using AutoMapper;
using MediatR;
using StateManagement.Application.Interfaces.UoW;
using System.Threading;
using System.Threading.Tasks;

namespace StateManagement.Application.Features.State.Commands.CreateState
{
    public class CreateStateCommandHandler : IRequestHandler<CreateStateCommandRequest, CreateStateCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateStateCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateStateCommandResponse> Handle(CreateStateCommandRequest request, CancellationToken cancellationToken)
        {
            var state = _mapper.Map<Domain.Entities.State>(request);

            await _unitOfWork.StateRepository.AddAsync(state);
            await _unitOfWork.CommitAsync();

            var result = _mapper.Map<CreateStateCommandResponse>(state);

            return await Task.FromResult(result);
        }
    }
}
