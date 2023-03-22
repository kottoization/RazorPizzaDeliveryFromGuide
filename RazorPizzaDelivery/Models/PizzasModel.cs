namespace RazorPizzaDelivery.Models
{
    public class PizzasModel
    {
        private string imagetitle;
        private string pizzaName;        
        private bool tomatoSauce;
        private bool garlicSauce;
        private bool peperoni;
        private bool cheese;
        private bool chicken;
        private bool mushroom;
        private bool jalapeno;
        private bool pinaple;
        private bool corn;
        private bool bacon;
        private bool onion;
        private float finalPrice;

        public float basePrice { get; set; }=2;
        public string Imagetitle { get => imagetitle; set => imagetitle = value; }
        public string PizzaName { get => pizzaName; set => pizzaName = value; }       
        public bool TomatoSauce { get => tomatoSauce; set => tomatoSauce = value; }
        public bool GarlicSauce { get => garlicSauce; set => garlicSauce = value; }
        public bool Peperoni { get => peperoni; set => peperoni = value; }
        public bool Mushroom { get => mushroom; set => mushroom = value; }
        public bool Jalapeno { get => jalapeno; set => jalapeno = value; }
        public bool Corn { get => corn; set => corn = value; }
        public bool Bacon { get => bacon; set => bacon = value; }
        public bool Onion { get => onion; set => onion = value; }
        public bool Chicken { get => chicken; set => chicken = value; }
        public float FinalPrice { get => finalPrice; set => finalPrice = value; }
        public bool Cheese { get => cheese; set => cheese = value; }
        public bool Pinaple { get => pinaple; set => pinaple = value; }
    }
}
