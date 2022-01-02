using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StateManagement.Domain.Entities;

namespace StateManagement.Persistence.Mappings
{
    public class TaskMap : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(task => task.Id);
            builder.Property(task => task.Name).IsRequired();
            builder.HasOne(task => task.State);
            builder.HasOne(task => task.Flow);
        }
    }
}
