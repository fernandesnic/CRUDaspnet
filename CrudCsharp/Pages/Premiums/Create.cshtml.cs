using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CrudCsharp.Data;
using CrudCsharp.Models;

namespace CrudCsharp.Pages_Premiums
{
    public class CreateModel : PageModel
    {
        private readonly CrudCsharp.Data.ApplicationDbContext _context;

        public CreateModel(CrudCsharp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Email");
            return Page();
        }

        [BindProperty]
        public Premium Premium { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Premiuns.Add(Premium);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
