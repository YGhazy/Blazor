using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;

namespace Blazor.API.Controllers
{
    [Route("api/[controller]/[action]")]
    public class StripePaymentController : Controller
    {

        private readonly IConfiguration _configuration;

        public StripePaymentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        //[HttpPost]
        //[Authorize]
        //[ActionName("Create")]
        //public async Task<IActionResult> Create([FromBody] StripePaymentDTO paymentDTO)
        //{
   
        //}
    }
}
