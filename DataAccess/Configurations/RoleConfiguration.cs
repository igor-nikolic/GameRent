using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(r => r.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(10);
            builder.HasIndex(r => r.Name)
                .IsUnique();

        }
    }
}
