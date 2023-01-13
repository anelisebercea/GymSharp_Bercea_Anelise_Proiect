using GymSharp_Bercea_Anelise_Proiect.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using GymSharp_Bercea_Anelise_Proiect.Data;
using GymSharp_Bercea_Anelise_Proiect.Models.GymViewModels;

namespace GymSharp_Bercea_Anelise_Proiect.Controllers
{
    public class HomeController : Controller
    {

        private readonly GymContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(GymContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task<ActionResult> Statistics()
        {
            IQueryable<WorkoutGroup> data =
            from workout in _context.Workouts
            group workout by workout.Date into dateGroup
            select new WorkoutGroup()
            {
                WorkoutDate = dateGroup.Key,
                ExerciseCount = dateGroup.Count()
            };
            return View(await data.AsNoTracking().ToListAsync());
        }

    }
}