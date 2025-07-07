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
    public class IndexModel : PageModel
    {
        private readonly CrudCsharp.Data.ApplicationDbContext _context;

        public IndexModel(CrudCsharp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Premium> Premium { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Premium = await _context.Premiuns
                .Include(p => p.Student).ToListAsync();
        }
    }
}
