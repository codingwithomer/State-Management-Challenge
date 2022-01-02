using StateManagement.Domain.Common;

namespace StateManagement.Domain.Entities
{
    public class Flow : BaseEntity
    {
        public string Name { get; set; }

        public void UpdateFlow(string name)
        {
            Name = name;

            Update();
        }
    }
}
