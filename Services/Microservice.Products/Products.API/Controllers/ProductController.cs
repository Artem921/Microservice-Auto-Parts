using MassTransit;
using MassTransit.Contract.DTO.Product;
using MassTransit.Contract.DTO.Product.Request;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Abstractions;
using Products.Domain.Entities;

namespace Products.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }


        [Route("Create")]
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            productService.CreateAsync(product);

            return( Ok(product));
        }
           

           
        }
    }
