using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(g => g.Size)
                .IsRequired();
            builder.Property(g => g.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(g => g.Name)
                .IsUnique();

            builder.Property(g => g.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.HasOne(g => g.Category).WithMany(c => c.Games);
            builder.HasOne(g => g.Company).WithMany(c => c.Games);
        }
    }
}
