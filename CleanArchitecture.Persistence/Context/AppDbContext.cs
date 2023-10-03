using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        #region Ctor
        public AppDbContext(DbContextOptions<AppDbContext> options) :
           base(options)
        {

        }
        #endregion
    }
}