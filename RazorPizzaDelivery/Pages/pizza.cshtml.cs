using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaDelivery.Models;

namespace RazorPizzaDelivery.Pages
{
    public class pizzaModel : PageModel
    {

        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){Imagetitle="Margerita",PizzaName="Margerita",basePrice=2,TomatoSauce=true, Cheese=true, FinalPrice=4},
            new PizzasModel(){Imagetitle="Hawaiian",PizzaName="Hawaiian",basePrice=2,TomatoSauce=true, Cheese=true, Pinaple=true, Bacon = true, FinalPrice=6},
            new PizzasModel(){Imagetitle="MeatFeast",PizzaName="MeatFeast",basePrice=2,TomatoSauce=true, Cheese=true, Chicken=true, Bacon = true,Peperoni=true,Corn=true, FinalPrice=8},
            new PizzasModel(){Imagetitle="Pepperoni",PizzaName="Pepperoni",basePrice=2,TomatoSauce=true, Cheese=true, Peperoni=true, Jalapeno=true, FinalPrice=6 },
            new PizzasModel(){Imagetitle="Vegetarian",PizzaName="Vegetarian",basePrice=2,TomatoSauce=true, Cheese=true, Mushroom=true, Corn=true, FinalPrice=6 },
            new PizzasModel(){Imagetitle="Vegetarian",PizzaName="ExtraVegetarian",basePrice=2,TomatoSauce=true, Cheese=true, Mushroom=true, Jalapeno=true, Corn=true, Onion=true, FinalPrice=8 }

        };
        public void OnGet()
        {
        }
    }
}
