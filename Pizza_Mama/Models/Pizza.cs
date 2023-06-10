using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizza_Mama.Models
{
    public class Pizza
    {
        [JsonIgnore]
        public int PizzaID { get; set; }
        [Display(Name = "Nom")]
        public string nom {  get; set; }
        [Display(Name = "Prix ($)")]
        public float prix { get; set; }
        [Display(Name = "Végétarienne")]
        public bool vegetarienne { get; set; }
        [Display(Name = "Ingrédients")]
        [JsonIgnore]
        public string ingredients { get; set; }
        [NotMapped]
        [JsonPropertyName("ingredients")]
        public string[] listeIngredients { 
            get
            {
                if ((ingredients == null) || (ingredients.Length == 0)) { return null; }
                return ingredients.Split(", ");
            }
                
        }
    }
}
