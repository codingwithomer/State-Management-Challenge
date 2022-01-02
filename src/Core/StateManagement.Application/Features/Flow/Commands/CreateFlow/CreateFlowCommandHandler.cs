using AutoMapper;
using MediatR;
using StateManagement.Application.Interfaces.UoW;
using System.Threading;
using System.Threading.Tasks;

namespace StateManagement.Application.Features.Flow.Commands.CreateFlow
{
    public class CreateFlowCommandHandler : IRequestHandler<CreateFlowCommandRequest, CreateFlowCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateFlowCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateFlowCommandResponse> Handle(CreateFlowCommandRequest request, CancellationToken cancellationToken)
        {
            var flow = _mapper.Map<Domain.Entities.Flow>(request);

            await _unitOfWork.FlowRepository.AddAsync(flow);
            await _unitOfWork.CommitAsync();

            var result = _mapper.Map<CreateFlowCommandResponse>(flow);

            return await Task.FromResult(result);
        }
    }
}
