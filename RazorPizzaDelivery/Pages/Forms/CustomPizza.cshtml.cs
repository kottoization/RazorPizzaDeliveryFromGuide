using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaDelivery.Models;

namespace RazorPizzaDelivery.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.basePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.GarlicSauce) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Jalapeno) PizzaPrice += 1;
            if (Pizza.Corn) PizzaPrice += 1;
            if (Pizza.Bacon) PizzaPrice += 1;
            if (Pizza.Onion) PizzaPrice += 1;
            if (Pizza.Chicken) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }

    }
}
