using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace Final.Pages_Habitats
{
    public class DetailsModel : PageModel
    {
        private readonly Final.Models.AppDbContext _context;

        public DetailsModel(Final.Models.AppDbContext context)
        {
            _context = context;
        }

        public Habitat Habitat { get; set; } = default!;
        public List<Monster> Monsters { get; set; } = new List<Monster>();
        

        [BindProperty(SupportsGet = true)]
        public string CurrentSort { get; set; } = string.Empty;

        public int TotalPages { get; set; }
        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; } = 1;
        public int PageSize { get; set; } = 4; 



        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var habitat = await _context.Habitats!
                .Include(h => h.MonsterHabitats!)
                .ThenInclude(mh => mh.Monster)
                .ThenInclude(m => m.Weakness)
                .Include(h => h.MonsterHabitats!)
                .ThenInclude(mh => mh.Monster)
                .ThenInclude(m => m.Countermeasures)
                .FirstOrDefaultAsync(m => m.HabitatID == id);

            if (habitat == null)
            {
                return NotFound();
            }

            Habitat = habitat;

            ////
            ///
            
            var query = habitat.MonsterHabitats!
                .Select(mh => mh.Monster)
                .AsQueryable();

            switch (CurrentSort)
            {
                case "name_asc":
                    query = query.OrderBy(m => m.MonsterName);
                    break;
                case "name_desc":
                    query = query.OrderByDescending(m => m.MonsterName);
                    break;
                default:
                    break;
            }

            TotalPages = (int)Math.Ceiling(query.Count() / (double)PageSize);

            Monsters = query
                .Skip((PageNum - 1) * PageSize)
                .Take(PageSize)
                .ToList();



            return Page();
        }
    }
}
