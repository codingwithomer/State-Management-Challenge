using System;

namespace StateManagement.Domain.Common
{
    public class BaseEntity
    {

        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool IsActive { get; set; } = true;

        public BaseEntity()
        {
            CreatedDate = DateTime.UtcNow;
        }

        public void Update()
        {
            ModifiedDate = DateTime.UtcNow;
        }

        public void Delete()
        {
            ModifiedDate = DateTime.UtcNow;
            IsActive = false;
        }
    }
}