using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pusok_Alex_Lab2.Data;
using Pusok_Alex_Lab2.Models;

namespace Pusok_Alex_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Pusok_Alex_Lab2.Data.Pusok_Alex_Lab2Context _context;

        public IndexModel(Pusok_Alex_Lab2.Data.Pusok_Alex_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
