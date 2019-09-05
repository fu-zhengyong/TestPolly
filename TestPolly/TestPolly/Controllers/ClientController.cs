using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestPolly.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ProductService productService;

        public ClientController(ProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            var product = await productService.GetAllProductsAsync("B");

            return product;
        }
    }
}
