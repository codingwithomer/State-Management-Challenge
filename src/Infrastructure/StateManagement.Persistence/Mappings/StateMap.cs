using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StateManagement.Domain.Entities;

namespace StateManagement.Persistence.Mappings
{
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
                builder.HasKey(state => state.Id);
                builder.Property(state => state.Name).IsRequired();
        }
    }
}
