using Mapster;
using MapsterMapper;
using MassTransit.Contract.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Abstractions;
using Products.Domain.Entities;

namespace Products.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;
        private readonly IMapper mapper;

        public ProductController(IProductService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddProduct(ProductViewModel productVM)
        {
            var product = productVM.Adapt<Product>();

            await service.CreateAsync(product);

            return Ok(product);
        }
    }
}
