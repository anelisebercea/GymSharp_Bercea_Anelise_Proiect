using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymSharp_Bercea_Anelise_Proiect.Models
{
    public class Exercise
    {
        public int ID { get; set; }
        public string Exercise_name { get; set; }
        public string Description { get; set; }
        public string Muscle_group { get; set; }
        
        

        public ICollection<Workout>? Workouts { get; set; }
    }

}
