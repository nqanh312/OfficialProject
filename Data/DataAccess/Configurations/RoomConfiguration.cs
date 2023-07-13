using Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.DataAccess.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");

            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);

            builder.HasOne(x => x.Admin)
                .WithMany(x => x.Rooms)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
