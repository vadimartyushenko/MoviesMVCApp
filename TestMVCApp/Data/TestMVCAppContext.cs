using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestMVCApp.Models;

namespace TestMVCApp.Data
{
    public class TestMVCAppContext : DbContext
    {
        public TestMVCAppContext (DbContextOptions<TestMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<TestMVCApp.Models.Movie> Movie { get; set; } = default!;
    }
}
