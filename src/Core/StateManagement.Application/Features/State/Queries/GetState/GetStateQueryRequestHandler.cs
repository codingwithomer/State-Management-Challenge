using AutoMapper;
using MediatR;
using StateManagement.Application.Interfaces.UoW;
using System.Threading;
using System.Threading.Tasks;

namespace StateManagement.Application.Features.State.Queries.GetState
{
    public class GetStateQueryRequestHandler : IRequestHandler<GetStateQueryRequest, GetStateQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetStateQueryRequestHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper
        )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GetStateQueryResponse> Handle(GetStateQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.StateRepository.GetAsync(request.Id);

            return _mapper.Map<GetStateQueryResponse>(result);
        }
    }
}
