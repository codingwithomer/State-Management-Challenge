using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StateManagement.Domain.Entities;

namespace StateManagement.Persistence.Mappings
{
    public class FlowMap : IEntityTypeConfiguration<Flow>
    {
        public void Configure(EntityTypeBuilder<Flow> builder)
        {
            builder.HasKey(flow => flow.Id);
            builder.Property(flow => flow.Name).IsRequired();
        }
    }
}
