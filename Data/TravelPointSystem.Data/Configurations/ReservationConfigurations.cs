namespace TravelPointSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TravelPointSystem.Data.Models;

    internal class ReservationConfigurations : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder
                .HasOne<ApplicationUser>(r => r.Creator)
                .WithMany(au => au.Reservations)
                .HasForeignKey(r => r.CreatorId);
        }
    }
}
