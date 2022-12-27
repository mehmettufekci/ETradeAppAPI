using ETradeAPI.Application.Repositories;
using ETradeAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETradeAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() {Id = Guid.NewGuid(), Name="Product 1", Price = 100, CreatedDate = DateTime.UtcNow, Stock = 10 },
            //    new() {Id = Guid.NewGuid(), Name="Product 2", Price = 200, CreatedDate = DateTime.UtcNow, Stock = 20 },
            //    new() {Id = Guid.NewGuid(), Name="Product 3", Price = 300, CreatedDate = DateTime.UtcNow, Stock = 130 },
            //});
            //await _productWriteRepository.SaveAsync();

            Product p = await _productReadRepository.GetByIdAsync("9fcaff01-0b61-4a5c-80f3-d882054ec159", false);
            p.Name = "Mehmet";
            await _productWriteRepository.SaveAsync();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
