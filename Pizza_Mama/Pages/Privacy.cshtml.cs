using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Pizza_Mama.Data;
using Pizza_Mama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Pizza_Mama.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        DataContext dataContext;

        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext dataContext)
        {
            _logger = logger;
            this.dataContext = dataContext;
        }

        public void OnGet()
        {
            /*var pizza = new Pizza() { nom = "Pizza test", prix = 5 };
            dataContext.Pizzas.Add(pizza);
            dataContext.SaveChanges();*/
        }
    }
}
