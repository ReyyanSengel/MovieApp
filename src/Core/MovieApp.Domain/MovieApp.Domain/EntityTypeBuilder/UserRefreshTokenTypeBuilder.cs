using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieApp.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Domain.EntityTypeBuilder
{
    public class UserRefreshTokenTypeBuilder : IEntityTypeConfiguration<UserRefreshToken>
    {
        public void Configure(EntityTypeBuilder<UserRefreshToken> builder)
        {
            builder.HasKey(x=>x.UserId);
            builder.Property(x=>x.RefreshToken)
                .IsRequired()
                .HasMaxLength(200);
            
                
        }
    }
}
