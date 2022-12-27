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

        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;

        private readonly ICustomerWriteRepository _customerWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
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

            // Add scoped olduğu için aynı instance içinde tracking ile veriyi read ve write kullanabiliyor
            //Product p = await _productReadRepository.GetByIdAsync("9fcaff01-0b61-4a5c-80f3-d882054ec159");
            //p.Name = "Product 1";
            //await _productWriteRepository.SaveAsync();

            //await _productWriteRepository.AddAsync(new() { Name = "C Product", Price = 1.500F, Stock = 10, CreatedDate = DateTime.UtcNow });
            //await _productWriteRepository.SaveAsync();

            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id = customerId, Name = "Muhittin" });

            //await _orderWriteRepository.AddAsync(new() { Description = "Aciklama", Address = "Ankara, Çankaya", CustomerId = customerId });
            //await _orderWriteRepository.AddAsync(new() { Description = "Aciklama 2", Address = "Ankara, Pursaklar", CustomerId = customerId });
            //await _orderWriteRepository.SaveAsync();

            Order order = await _orderReadRepository.GetByIdAsync("6a8b09bd-28c8-47b0-9864-d3ca1625986a");
            order.Address = "Istanbul";
            await _orderWriteRepository.SaveAsync();

        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(string id)
        //{
        //    Product product = await _productReadRepository.GetByIdAsync(id);
        //    return Ok(product);
        //}
    }
}
