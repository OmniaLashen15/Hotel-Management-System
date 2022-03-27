using LoginEF.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginEF
{
    public class FrontConfiguration : IEntityTypeConfiguration<Frontend>
    {

        public void Configure(EntityTypeBuilder<Frontend> builder)
        {
            builder.HasKey(F => F.UserName);
            builder.Property(F=>F.UserName).
                IsRequired().HasMaxLength(50);
            builder.Property(F => F.Password)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
