using System;
using System.ComponentModel.DataAnnotations;


namespace GymSharp_Bercea_Anelise_Proiect.Models.GymViewModels
{
    public class WorkoutGroup
    {
        [DataType(DataType.Date)]
        public DateTime? WorkoutDate { get; set; }
        public int ExerciseCount { get; set; }
    }
}
