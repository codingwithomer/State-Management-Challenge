using MediatR;
using StateManagement.Application.Interfaces.UoW;
using System.Threading;
using System.Threading.Tasks;

namespace StateManagement.Application.Features.Flow.Commands.DeleteFlow
{
    public class DeleteFlowCommanHandler : IRequestHandler<DeleteFlowCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteFlowCommanHandler(
            IUnitOfWork unitOfWork
        )
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteFlowCommandRequest request, CancellationToken cancellationToken)
        {
            _unitOfWork.FlowRepository.Remove(request.Id);

            return await Task.FromResult(Unit.Value);
        }
    }
}
