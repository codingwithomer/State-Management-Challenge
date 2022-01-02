using StateManagement.Domain.Common;

namespace StateManagement.Domain.Entities
{
    public class FlowState : BaseEntity
    {
        public int Sequence { get; set; }

        public int FlowId { get; set; }

        public int StateId { get; set; }

        public virtual Flow Flow { get; set; }

        public virtual State State { get; set; }
    }
}
