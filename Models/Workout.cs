using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace GymSharp_Bercea_Anelise_Proiect.Models
{
    public class Workout
    {
        public int ID { get; set; }
        public int User_id { get; set; }
        public int ExerciseId { get; set; }
        public DateTime? Date { get; set; }
        public string? Exercise_name { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int Weight { get; set; }
        public string Level { get; set; }
       

        public User? User { get; set; }
        public Exercise? Exercise { get; set; }
    }

}
