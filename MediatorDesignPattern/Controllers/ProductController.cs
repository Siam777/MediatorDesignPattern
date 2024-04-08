using CqrsWithMediatorDesignPattern.Commands;
using CqrsWithMediatorDesignPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CqrsWithMediatorDesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ISender _sender;

        public ProductController(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _sender.Send(new GetProductsQuery());

            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] AddProductCommand command)
        {
            await _sender.Send(command);
            return StatusCode(200);
        }
    }
}
