using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNet_TodoApp.Models;

namespace DotNet_TodoApp.Data
{
    public class DotNet_TodoAppContext : DbContext
    {
        public DotNet_TodoAppContext (DbContextOptions<DotNet_TodoAppContext> options)
            : base(options)
        {
        }

        public DbSet<DotNet_TodoApp.Models.Todo> Todo { get; set; } = default!;
    }
}
