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
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IOrderRepository _orderRepository;
        public ProductService(IMapper mapper, IUnitOfWork unitOfWork, IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        //public async Task<IActionResult> GetAll()
        //{
        //    return Ok(await _productRepository.GetAll());
        //}

        //public async Task<IActionResult> Get(int? productId)
        //{
        //    if (productId==null || productId==0)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage="Invalid Id",
        //            StatusCode=StatusCodes.Status400BadRequest
        //        });
        //    }

        //    var product = await _productRepository.Get(productId.Value);
        //    if (product==null)
        //    {
        //        return BadRequest(new ErrorModelDTO()
        //        {
        //            ErrorMessage="Invalid Id",
        //            StatusCode=StatusCodes.Status404NotFound
        //        });
        //    }

        //    return Ok(product);
        //}
    }
}
