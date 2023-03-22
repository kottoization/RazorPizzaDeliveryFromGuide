using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzaDelivery.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {

        private string pizzaName;
        private float pizzaPrice;
        private string imageTitle;

        public string PizzaName { get => pizzaName; set => pizzaName = value; }
        public float PizzaPrice { get => pizzaPrice; set => pizzaPrice = value; }
        public string ImageTitle { get => imageTitle; set => imageTitle = value; }

        public void OnGet()
        {
        }
    }
}
