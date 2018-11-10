using controlepesoapi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controlepesoapi.Database
{
    public class ApiDbContext: DbContext
    {
        // When used with ASP.net core, add these lines to Startup.cs
        //   var connectionString = Configuration.GetConnectionString("BlogContext");
        //   services.AddEntityFrameworkNpgsql().AddDbContext<BlogContext>(options => options.UseNpgsql(connectionString));
        // and add this to appSettings.json
        // "ConnectionStrings": { "BlogContext": "Server=localhost;Database=blog" }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
