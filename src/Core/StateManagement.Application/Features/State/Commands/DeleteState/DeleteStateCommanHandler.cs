using MediatR;
using StateManagement.Application.Interfaces.UoW;
using System.Threading;
using System.Threading.Tasks;

namespace StateManagement.Application.Features.State.Commands.DeleteState
{
    public class DeleteStateCommanHandler : IRequestHandler<DeleteStateCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteStateCommanHandler(
            IUnitOfWork unitOfWork
        )
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteStateCommandRequest request, CancellationToken cancellationToken)
        {
            _unitOfWork.StateRepository.Remove(request.Id);

            return await Task.FromResult(Unit.Value);
        }
    }
}
