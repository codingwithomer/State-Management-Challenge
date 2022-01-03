using AutoMapper;
using MediatR;
using StateManagement.Application.Interfaces.UoW;
using System.Threading;
using System.Threading.Tasks;

namespace StateManagement.Application.Features.Flow.Queries.GetFlow
{
    public class GetFlowQueryRequestHandler : IRequestHandler<GetFlowQueryRequest, GetFlowQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetFlowQueryRequestHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GetFlowQueryResponse> Handle(GetFlowQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.FlowRepository.GetAsync(request.Id);

            return _mapper.Map<GetFlowQueryResponse>(result);
        }
    }
}
