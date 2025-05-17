using GymManagement.Domain.Subscriptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagement.Infrastructure.Common.Persistense;

public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedNever();

        builder.Property("_adminId")
            .HasColumnName("AdminId");

        builder.Property(x => x.Type)
            .HasConversion(
                type => type.Value,
                value => SubscriptionType.FromValue(value)
            );
    }
}