using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Models
{
    public class MisicianDbContext : DbContext
    {
        public DbSet<MusicLabel> MusicLabels { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Musician_Track> Musitian_Tracks { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public MisicianDbContext()
        {
            
        }

        public MisicianDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
