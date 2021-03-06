﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreMvcMovie.Models
{
    public class CoreMvcMovieContext : DbContext
    {
        public CoreMvcMovieContext (DbContextOptions<CoreMvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<CoreMvcMovie.Models.Movie> Movie { get; set; }
    }
}
