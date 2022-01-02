using StateManagement.Domain.Common;
using System.Collections.Generic;

namespace StateManagement.Domain.Entities
{
    public class State: BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

        public void UpdateState(string name)
        {
            Name = name;

            Update();
        }
    }
}
