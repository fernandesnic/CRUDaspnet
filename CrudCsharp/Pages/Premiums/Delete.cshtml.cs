using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudCsharp.Data;
using CrudCsharp.Models;

namespace CrudCsharp.Pages_Premiums
{
    public class DeleteModel : PageModel
    {
        private readonly CrudCsharp.Data.ApplicationDbContext _context;

        public DeleteModel(CrudCsharp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Premium Premium { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premiuns.FirstOrDefaultAsync(m => m.Id == id);

            if (premium is not null)
            {
                Premium = premium;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var premium = await _context.Premiuns.FindAsync(id);
            if (premium != null)
            {
                Premium = premium;
                _context.Premiuns.Remove(Premium);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
