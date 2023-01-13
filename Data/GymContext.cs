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
        public DbSet<Food> Foods { get; set; }
        public DbSet<Measurement> Measurements { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Workout>().ToTable("Workouts");
            modelBuilder.Entity<Exercise>().ToTable("Exercises");
            modelBuilder.Entity<Food>().ToTable("Foods");
            modelBuilder.Entity<Measurement>().ToTable("Measurements");

        }


        public DbSet<GymSharp_Bercea_Anelise_Proiect.Models.Food> Food { get; set; }
    }
}
