using Microsoft.EntityFrameworkCore;
using GymSharp_Bercea_Anelise_Proiect.Models;
using Azure;

namespace GymSharp_Bercea_Anelise_Proiect.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GymContext(serviceProvider.GetRequiredService<DbContextOptions<GymContext>>()))
            {
                if (context.Exercises.Any())
                {
                    return; // BD a fost creata anterior
                }
                context.Exercises.AddRange(
                new Exercise
                {
                    Exercise_name = "Bicep Curl",
                    Description = "Isolation exercise for biceps",
                    Muscle_group = "Arms",
                },
                new Exercise
                {
                    Exercise_name = "Tricep Dips",
                    Description = "Isolation exercise for triceps",
                    Muscle_group = "Arms",
                },
                new Exercise
                {
                    Exercise_name = "Hammer Curl",
                    Description = "Isolation exercise for biceps",
                    Muscle_group = "Arms",
                },
                new Exercise
                {
                    Exercise_name = "Deadlift",
                    Description = "A compound movement that works your lower back, glutes, hamstrings, and core.",
                    Muscle_group = "Back",
                },
                new Exercise
                {
                    Exercise_name = "Bench Press",
                    Description = "A compound movement that works your chest, triceps, and shoulders.",
                    Muscle_group = "Chest",
                },
                new Exercise
                {
                    Exercise_name = "Cable Fly",
                    Description = "Isolation exercise for chest",
                    Muscle_group = "Chest",
                },
                new Exercise
                {
                    Exercise_name = "Incline bench press",
                    Description = "Compound exercise for upper chest",
                    Muscle_group = "Chest",
                },
                new Exercise
                {
                    Exercise_name = "Dumbbell press",
                    Description = "Isolation exercise for chest",
                    Muscle_group = "Chest",
                },
                new Exercise
                {
                    Exercise_name = "Cable Crossover",
                    Description = "Isolation exercise for chest",
                    Muscle_group = "Chest",
                    
                },
                new Exercise
                {
                    Exercise_name = "Push ups",
                    Description = "Bodyweight exercise for chest",
                    Muscle_group = "Chest",
                },
                new Exercise
                {
                    Exercise_name = "Dumbbell Fly",
                    Description = "Isolation exercise for chest",
                    Muscle_group = "Chest",
                },
                new Exercise
                {
                    Exercise_name = "Incline Dumbbell Fly",
                    Description = "Isolation exercise for upper chest",
                    Muscle_group = "Chest",
                    
                },
                new Exercise
                {
                    Exercise_name = "Barbell press",
                    Description = "Compound exercise for chest",
                    Muscle_group = "Chest",
                    
                },
                new Exercise
                {
                    Exercise_name = "Lunges",
                    Description = "Compound exercise for legs and glutes",
                    Muscle_group = "Legs",
                    
                },
                new Exercise
                {
                    Exercise_name = "Squat",
                    Description = "Compound exercise for legs",
                    Muscle_group = "Legs",
                    
                },
                new Exercise
                {
                    Exercise_name = "Leg press",
                    Description = "Compound exercise for legs and glutes",
                    Muscle_group = "Legs",
                    
                },
                new Exercise
                {
                    Exercise_name = "Calf Raise",
                    Description = "Isolation exercise for calves",
                    Muscle_group = "Legs"
                    
                },
                new Exercise
                {
                    Exercise_name = "Step-up",
                    Description = "Compound exercise for legs and glutes",
                    Muscle_group = "Legs",
                },
                new Exercise
                {
                    Exercise_name = "Leg Extension",
                    Description = "Isolation exercise for quadriceps",
                    Muscle_group = "Legs",
                },
                new Exercise
                {
                    Exercise_name = "Leg Curl",
                    Description = "Isolation exercise for hamstrings",
                    Muscle_group = "Legs",
                },
                new Exercise
                {
                     Exercise_name = "Box Jump",
                     Description = "Compound exercise for legs and core",
                     Muscle_group = "Legs",
                },
                new Exercise
                {
                    Exercise_name = "Reverse lunge",
                    Description = "Compound exercise for legs and glutes",
                    Muscle_group = "Legs",
                },
                new Exercise
                {
                    Exercise_name = "Pull-ups",
                    Description = "Compound exercise for back and biceps",
                    Muscle_group = "Back",
                },
                new Exercise
                {
                    Exercise_name = "Shoulder Press",
                    Description = "Compound exercise for shoulders and triceps",
                    Muscle_group = "Shoulders",
                },
                new Exercise
                {
                    Exercise_name = "Barbell Row",
                    Description = "Compound exercise for back and biceps",
                    Muscle_group = "Back",
                },
                
                new Exercise
                {
                    Exercise_name = "Lat Pulldown",
                    Description = "Compound exercise for back and biceps",
                    Muscle_group = "Back",
                },
                new Exercise
                {
                    Exercise_name = "Dumbbell Row",
                    Description = "Compound exercise for back and biceps",
                    Muscle_group = "Back",
                },
                new Exercise
                {
                    Exercise_name = "Seated Cable Row",
                    Description = "Compound exercise for back and biceps",
                    Muscle_group = "Back",
                },
                new Exercise
                {
                    Exercise_name = "Lateral Raise",
                    Description = "Isolation exercise for shoulders",
                    Muscle_group = "Shoulders",
                },
                new Exercise
                {
                    Exercise_name = "Upright Row",
                    Description = "Compound exercise for shoulders and traps",
                    Muscle_group = "Shoulders",
                },
                
                new Exercise
                {
                    Exercise_name = "Planks",
                    Description = "Isolation exercise for core",
                    Muscle_group = "Core",
                },
                new Exercise
                {
                    Exercise_name = "Sit-ups",
                    Description = "Core exercise for the rectus abdominis",
                    Muscle_group = "Core",
                },
                new Exercise
                {
                    Exercise_name = "Russian Twist",
                    Description = "Core exercise for the obliques",
                    Muscle_group = "Core",
                },
                new Exercise
                {
                    Exercise_name = "Dead bug",
                    Description = "Core exercise for the rectus abdominis,  internal and external obliques",
                    Muscle_group = "Core",
                },
                new Exercise
                {
                    Exercise_name = "Side plank",
                    Description = "Core exercise for the rectus abdominis and obliques",
                    Muscle_group = "Core",
                },
                new Exercise
                {
                    Exercise_name = "Mountain climbers",
                    Description = "Compound exercise for the core and legs",
                    Muscle_group = "Core",
                },
                new Exercise
                {
                    Exercise_name = "Bicycle crunch",
                    Description = "Core exercise for the rectus abdominis and obliques",
                    Muscle_group = "Core",
                },
                new Exercise
                {
                    Exercise_name = "Reverse crunch",
                    Description = "Core exercise for the rectus abdominis",
                    Muscle_group = "Core",
                },
                new Exercise
                {
                    Exercise_name = "Hanging leg raise",
                    Description = "Core exercise for the rectus abdominis,  internal and external obliques",
                    Muscle_group = "Core",
                },
                new Exercise
                {
                    Exercise_name = "Hip thrust",
                    Description = "Core exercise for the rectus abdominis,  glutes and hamstrings",
                    Muscle_group = "Core",
                },
                new Exercise
                {
                    Exercise_name = "Reverse Fly",
                    Description = "Isolation exercise for shoulders",
                    Muscle_group = "Shoulders",
                },
                new Exercise
                {
                    Exercise_name = "Tricep Pushdowns",
                    Description = "Isolation exercise for triceps",
                    Muscle_group = "Arms",
                },
                new Exercise
                {
                    Exercise_name = "Diamond Push ups",
                    Description = "Isolation exercise for triceps",
                    Muscle_group = "Arms",
                },
                new Exercise
                {
                    Exercise_name = "Close-Grip Bench Press",
                    Description = "Compound exercise for triceps",
                    Muscle_group = "Arms",
                },
                new Exercise
                {
                    Exercise_name = "Tricep Pushdowns",
                    Description = "Isolation exercise for triceps",
                    Muscle_group = "Arms",
                },
                new Exercise
                {
                    Exercise_name = "Tricep Extension",
                    Description = "Isolation exercise for triceps",
                    Muscle_group = "Arms",
                },
                new Exercise
                {
                    Exercise_name = "Tricep Kickbacks",
                    Description = "Isolation exercise for triceps",
                    Muscle_group = "Arms",
                },
                new Exercise
                {
                    Exercise_name = "Barbell Close Grip Bench Press",
                    Description = "Compound exercise for triceps",
                    Muscle_group = "Arms",
                }
                );


                context.SaveChanges();
            }
        }
    }
}
