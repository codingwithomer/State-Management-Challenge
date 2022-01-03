using AutoMapper;
using MediatR;
using StateManagement.Application.Interfaces.UoW;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StateManagement.Application.Features.Flow.Queries.GetFlows
{
    public class GetFlowsQueryRequestHandler : IRequestHandler<GetFlowsQueryRequest, IList<GetFlowsQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetFlowsQueryRequestHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IList<GetFlowsQueryResponse>> Handle(GetFlowsQueryRequest request, CancellationToken cancellationToken)
        {
            var result = request.Id.HasValue ? await _unitOfWork.FlowRepository.GetAsync(x => x.Id == request.Id.Value) :
                                               await _unitOfWork.FlowRepository.GetAsync();

            return _mapper.Map<IList<GetFlowsQueryResponse>>(result);
        }
    }
}
