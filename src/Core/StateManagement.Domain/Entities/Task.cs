using StateManagement.Domain.Common;

namespace StateManagement.Domain.Entities
{
    public class Task : BaseEntity
    {
        public string Name { get;  set; }

        public int FlowId { get; set; }

        public int StateId { get; set; }

        public virtual State State { get; set; }

        public virtual Flow Flow { get; set; }

        public void UpdateTask(string name)
        {
            Name = name;

            Update();
        }
    }
}
