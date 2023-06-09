using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pizza_Mama.Data;
using Pizza_Mama.Models;

namespace Pizza_Mama.Pages.Admin.Pizzas
{
    public class IndexModel : PageModel
    {
        private readonly Pizza_Mama.Data.DataContext _context;

        public IndexModel(Pizza_Mama.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
        }
    }
}
