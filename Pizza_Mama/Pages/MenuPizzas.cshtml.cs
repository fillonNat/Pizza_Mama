using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pizza_Mama.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Mama.Pages
{
    public class MenuPizzasModel : PageModel
    {
        private readonly Pizza_Mama.Data.DataContext _context;

        public MenuPizzasModel(Pizza_Mama.Data.DataContext context)
        {
            _context = context;
        }
        public IList<Pizza> Pizza { get; set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
            Pizza = Pizza.OrderBy(p => p.prix).ToList();
        }
    }
}
