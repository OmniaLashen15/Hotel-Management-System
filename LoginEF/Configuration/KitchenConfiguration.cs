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
    public class KitchenConfiguration: IEntityTypeConfiguration<Kitchen>
    {

      


        public void Configure(EntityTypeBuilder<Kitchen> builder)
        {
            builder.HasKey(F => F.UserName);
            builder.Property(F => F.UserName).
                IsRequired().HasMaxLength(50);
            builder.Property(F => F.Password)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
