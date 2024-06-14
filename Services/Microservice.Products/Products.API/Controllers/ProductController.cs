using MassTransit;
using MassTransit.Contract.ViewModels.Product;
using MassTransit.Contract.ViewModels.Product.Request;
using Microsoft.AspNetCore.Mvc;

namespace Products.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
    
        private readonly IPublishEndpoint publishEndpoint;

        public ProductController(  IPublishEndpoint publishEndpoint)
        {

            this.publishEndpoint = publishEndpoint;
        }

        [Route("Create")]
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductViewModel productVM)
        {
            await publishEndpoint.Publish<CreateProductRequest>(new 
            { 
                productVM
            });

       

            return Ok();
        }
    }
}
