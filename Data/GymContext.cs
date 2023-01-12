using Microsoft.EntityFrameworkCore;
using GymSharp_Bercea_Anelise_Proiect.Models;

namespace GymSharp_Bercea_Anelise_Proiect.Data
{
    public class GymContext:DbContext
    {
        public GymContext(DbContextOptions<GymContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Workout>().ToTable("Workouts");
            modelBuilder.Entity<Exercise>().ToTable("Exercises");

        }
    }
}
