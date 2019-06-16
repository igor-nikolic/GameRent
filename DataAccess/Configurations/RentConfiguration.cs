using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configurations
{
    public class RentConfiguration : IEntityTypeConfiguration<Rent>
    {
        public void Configure(EntityTypeBuilder<Rent> builder)
        {
            builder.Property(r => r.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            //builder.HasOne(r => r.UserId).WithMany(u=>u.Rents);

            //builder.HasOne(r => r.GameId).WithMany(g => g.Rents);

        }
    }
}
