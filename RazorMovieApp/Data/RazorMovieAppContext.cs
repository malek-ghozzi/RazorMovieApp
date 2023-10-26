using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorMovieApp.Models;

namespace RazorMovieApp.Data
{
    public class RazorMovieAppContext : DbContext
    {
        public RazorMovieAppContext (DbContextOptions<RazorMovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorMovieApp.Models.Movie> Movie { get; set; } = default!;
    }
}
