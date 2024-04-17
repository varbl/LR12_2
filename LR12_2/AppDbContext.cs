using LR12_2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LR12_2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }
    }
}
