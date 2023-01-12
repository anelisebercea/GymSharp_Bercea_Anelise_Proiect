using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymSharp_Bercea_Anelise_Proiect.Data;
using GymSharp_Bercea_Anelise_Proiect.Models;
using static System.Reflection.Metadata.BlobBuilder;
using GymSharpBerceaAneliseProiect;

namespace GymSharp_Bercea_Anelise_Proiect.Controllers
{
    public class ExercisesController : Controller
    {
        private readonly GymContext _context;

        public ExercisesController(GymContext context)
        {
            _context = context;
        }

        // GET: Exercises INDEX
        /*
        public async Task<IActionResult> Index()
        {
              return View(await _context.Exercises.ToListAsync());
        }
        */
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            IQueryable<Exercise> exercise = _context.Exercises.AsNoTracking();
            ViewData["CurrentSort"] = sortOrder;
            ViewData["ExerciseNameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "exercise_name_desc" : "exercise_name";
            ViewData["MuscleGroupSortParm"] = sortOrder == "muscle_group" ? "muscle_group_desc" : "muscle_group";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            
            if (!String.IsNullOrEmpty(searchString))
            {
                exercise = exercise.Where(s => s.Muscle_group.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "exercise_name_desc":
                    exercise = exercise.OrderByDescending(x => x.Exercise_name);
                    break;
                case "exercise_name":
                    exercise = exercise.OrderBy(x => x.Exercise_name);
                    break;
                case "muscle_group_desc":
                    exercise = exercise.OrderByDescending(x => x.Muscle_group);
                    break;
                case "muscle_group":
                    exercise = exercise.OrderBy(x => x.Muscle_group);
                    break;
                default:
                    exercise = exercise.OrderBy(x => x.Exercise_name);
                    break;
            }

            int pageSize = 8;
            return View(await PaginatedList<Exercise>.CreateAsync(exercise, pageNumber ?? 1, pageSize));
        }


        // GET: Exercises/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null ) 
            {
                return NotFound();
            }

            var exercise = await _context.Exercises
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (exercise == null)
            {
                return NotFound();
            }

            return View(exercise);
        }

        // GET: Exercises/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Exercises/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Exercise_name,Description,Muscle_group")] Exercise exercise)
        {
            try
            {
                if (ModelState.IsValid)
                {
                     _context.Add(exercise);
                     await _context.SaveChangesAsync();
                     return RedirectToAction(nameof(Index));
                }
            }

            catch (DbUpdateException /* ex*/)
            {

                ModelState.AddModelError("", "Unable to save changes. " + "Try again, and if the problem persists ");
            }


            return View(exercise);
        }

        // GET: Exercises/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Exercises == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises.FindAsync(id);
            if (exercise == null)
            {
                return NotFound();
            }
            return View(exercise);
        }

        // POST: Exercises/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var exerciseToUpdate = await _context.Exercises.FirstOrDefaultAsync(s => s.ID == id);

            if (exerciseToUpdate != null)
            {

                if (await TryUpdateModelAsync<Exercise>(exerciseToUpdate, "", s => s.Exercise_name, s => s.Description, s => s.Muscle_group))

                {
                    try
                    {
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));

                    }
                    catch (DbUpdateException)

                    {
                        ModelState.AddModelError("", "Unable to save changes. " + "Try again, and if the problem persists");
                    }
                }
            }
                return View(exerciseToUpdate);
            }

        // GET: Exercises/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null ) //|| _context.Exercises == null)
            {
                return NotFound();
            }

            var exercise = await _context.Exercises
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);
            if (exercise == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] = "Delete failed. Try again";
            }

            return View(exercise);
        }

        // POST: Exercises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exercise = await _context.Exercises.FindAsync(id);
            if (exercise == null)
            {
                return RedirectToAction(nameof(Index)); // Problem("Entity set 'GymContext.Exercises'  is null.");
            }

            try
            { 
                _context.Exercises.Remove(exercise);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch(DbUpdateException)
            {
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }
            
        }

        private bool ExerciseExists(int id)
        {
          return _context.Exercises.Any(e => e.ID == id);
        }
    }
}
