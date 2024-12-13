using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;

namespace Final.Pages_Habitats
{
    public class IndexModel : PageModel
    {
        private readonly Final.Models.AppDbContext _context;

        public IndexModel(Final.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Habitat> Habitats { get; set; } = default!;
        public IList<Monster> Monsters { get; set; } = new List<Monster>();
        public int? SelectedHabitatId { get; set; }

        public async Task OnGetAsync(int? habitatId)
        {
            Habitats = await _context.Habitats!.ToListAsync();

            ///// info loading for the carosel
            Monsters = await _context.Monsters!.Include(m => m.Weakness).ToListAsync();

            if (habitatId.HasValue)
            {
                SelectedHabitatId = habitatId;
                Monsters = await _context.MonsterHabitats!
                    .Where(mh => mh.HabitatID == habitatId.Value)
                    .Include(mh => mh.Monster)
                        .ThenInclude(m => m.Weakness)
                    .Include(mh => mh.Monster)
                        .ThenInclude(m => m.Countermeasures)
                    .Select(mh => mh.Monster)
                    .ToListAsync();
            }
        }

    }
}
