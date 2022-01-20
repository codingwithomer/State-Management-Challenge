using AutoMapper;
using MediatR;
using StateManagement.Application.Interfaces.UoW;
using System.Threading;
using System.Threading.Tasks;

namespace StateManagement.Application.Features.State.Commands.UpdateState
{
    public class UpdateFlowCommandRequestHandler : IRequestHandler<UpdateStateCommandRequest, UpdateStateCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateFlowCommandRequestHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UpdateStateCommandResponse> Handle(UpdateStateCommandRequest request, CancellationToken cancellationToken)
        {
            var state = _mapper.Map<Domain.Entities.State>(request);

            await _unitOfWork.StateRepository.UpdateAsync(state);
            await _unitOfWork.CommitAsync();

            var result = _mapper.Map<UpdateStateCommandResponse>(state);

            return await Task.FromResult(result);
        }
    }
}
