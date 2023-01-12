using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GymSharp_Bercea_Anelise_Proiect.Models
{
    public class Measurement
    {
        
            public int ID { get; set; }
            public int User_id { get; set; }
            public DateTime Date { get; set; }
            public float Weight { get; set; }
            public float Body_fat_percentage { get; set; }
            public float Chest { get; set; }
            public float Waist { get; set; }
            public float Hips { get; set; }
            
        

    }
}
