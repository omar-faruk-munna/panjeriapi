using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using panjeriapi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace panjeriapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _product;

        public ProductController(IProductRepository product)
        {
            this._product = product;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var result = await _product.GetAllProduct();

            return Ok(result);
        }



    }
}
