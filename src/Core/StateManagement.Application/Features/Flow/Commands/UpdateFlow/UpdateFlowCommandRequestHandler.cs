using AutoMapper;
using MediatR;
using StateManagement.Application.Interfaces.UoW;
using System.Threading;
using System.Threading.Tasks;

namespace StateManagement.Application.Features.Flow.Commands.UpdateFlow
{
    public class UpdateFlowCommandRequestHandler : IRequestHandler<UpdateFlowCommandRequest, UpdateFlowCommandResponse>
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

        public async Task<UpdateFlowCommandResponse> Handle(UpdateFlowCommandRequest request, CancellationToken cancellationToken)
        {
            var flow = _mapper.Map<Domain.Entities.Flow>(request);

            await _unitOfWork.FlowRepository.UpdateAsync(flow);
            await _unitOfWork.CommitAsync();

            var result = _mapper.Map<UpdateFlowCommandResponse>(flow);

            return await Task.FromResult(result);
        }
    }
}
