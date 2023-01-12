using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymSharp_Bercea_Anelise_Proiect.Models
{
    public class Food
    {
        public int ID { get; set; }
        public int User_id { get; set; }
        public DateTime Date { get; set; }
        public string? Food_name { get; set; }
        public float Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fats { get; set; }
    }

}
