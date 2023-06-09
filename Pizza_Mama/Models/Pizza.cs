namespace Pizza_Mama.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string nom {  get; set; }
        public float prix { get; set; }
        public bool vegetarienne { get; set; }
        public string ingredients { get; set; }
    }
}
