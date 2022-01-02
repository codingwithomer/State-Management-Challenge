using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StateManagement.Domain.Entities;

namespace StateManagement.Persistence.Mappings
{
    public class FlowStateMap : IEntityTypeConfiguration<FlowState>
    {
        public void Configure(EntityTypeBuilder<FlowState> builder)
        {
            builder.HasKey(flowState => flowState.Id);
            builder.Property(flowState => flowState.Sequence).IsRequired();
            builder.HasOne(flowState => flowState.State);
            builder.HasOne(flowState => flowState.Flow);
        }
    }
}
