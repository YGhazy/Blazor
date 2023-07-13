using AutoMapper;
using Blazor.Application.Common;
using Blazor.Application.DTOs;
using Blazor.Application.IRepository;
using Blazor.Application.Services.IServices;
using Blazor.Domain.Common;
using Microsoft.AspNetCore.Http;
using Stripe.Checkout;

namespace Blazor.Application.Services
{
    public class StripePaymentService : IStripePaymentService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderRepository _orderRepository;
        public StripePaymentService(IMapper mapper, IUnitOfWork unitOfWork, IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        //public async Task<IActionResult> Create(StripePaymentDTO paymentDTO)
        //{
        //    try
        //    {

        //        var domain = _configuration.GetValue<string>("Tangy_Client_URL");

        //        var options = new SessionCreateOptions
        //        {
        //            SuccessUrl = domain+paymentDTO.SuccessUrl,
        //            CancelUrl = domain+paymentDTO.CancelUrl,
        //            LineItems = new List<SessionLineItemOptions>(),
        //            Mode = "payment",
        //            PaymentMethodTypes = new List<string> { "card" }
        //        };


        //        foreach (var item in paymentDTO.Order.OrderDetails)
        //        {
        //            var sessionLineItem = new SessionLineItemOptions
        //            {
        //                PriceData = new SessionLineItemPriceDataOptions
        //                {
        //                    UnitAmount = (long)(item.Price*100), //20.00 -> 2000
        //                    Currency="usd",
        //                    ProductData= new SessionLineItemPriceDataProductDataOptions
        //                    {
        //                        Name= item.Product.Name
        //                    }
        //                },
        //                Quantity= item.Count
        //            };
        //            options.LineItems.Add(sessionLineItem);
        //        }

        //        var service = new SessionService();
        //        Session session = service.Create(options);
        //        return Ok(new SuccessModelDTO()
        //        {
        //            Data = session.Id+";"+session.PaymentIntentId
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage = ex.Message
        //        });
        //    }
        //}
    }
}
