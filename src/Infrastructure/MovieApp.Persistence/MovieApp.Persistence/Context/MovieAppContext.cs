using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieApp.Domain.Entities.Identity;
using MovieApp.Domain.EntityTypeBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Persistence.Context
{
    public class MovieAppContext : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public MovieAppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserRefreshTokenTypeBuilder());
            base.OnModelCreating(builder);
        }
    }
}
