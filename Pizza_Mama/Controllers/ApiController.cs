using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pizza_Mama.Data;
using Pizza_Mama.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pizza_Mama.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        // GET: api/<ApiController>
        DataContext dataContext;
        public ApiController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {

            var pizza = dataContext.Pizzas.ToList();
            return Json(pizza);
        }
    }
}
