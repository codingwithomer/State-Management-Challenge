using AutoMapper;
using MediatR;
using StateManagement.Application.Interfaces.UoW;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StateManagement.Application.Features.State.Queries.GetStates
{
    public class GetStatesQueryRequestHandler : IRequestHandler<GetStatesQueryRequest, IList<GetStatesQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetStatesQueryRequestHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IList<GetStatesQueryResponse>> Handle(GetStatesQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.FlowRepository.GetAsync();

            return _mapper.Map<IList<GetStatesQueryResponse>>(result);
        }
    }
}
