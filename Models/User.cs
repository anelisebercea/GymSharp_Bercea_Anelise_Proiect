using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymSharp_Bercea_Anelise_Proiect.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Account_type { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Height { get; set; }

        public ICollection<Workout>? Workouts { get; set; }
    }
}
