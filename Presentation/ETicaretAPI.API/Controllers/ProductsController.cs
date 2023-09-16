using ETicaretAPI.Application.Abstractions.Products;
using ETicaretAPI.Application.Repositories.Customers;
using ETicaretAPI.Application.Repositories.Products;
using ETicaretAPI.Domain.Entities.Products;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        private readonly ICustomerReadRepository _customerReadRepository;

        public ProductsController(IProductService productService, IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, ICustomerWriteRepository customerWriteRepository, ICustomerReadRepository customerReadRepository)
        {
            _productService = productService;
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            var customer=await _customerReadRepository.GetSingleAsync(x => x.Id == Guid.Parse("e0208e07-639d-47e7-87c5-73ebb9d5d8a4"));
            customer.Name = "Customer 2";
            _customerWriteRepository.Update(customer);
            await _customerWriteRepository.AddAsync(new()
            {
                Name="Customer 1q"
            });
            await _productWriteRepository.AddRangeAsync(new()
                                                 { new()
                                                 {   
                                                     Name = "Laptop 1",
                                                     Price = 124,
                                                     Stock = 14
                                                 },
                                                 new()
                                                 {  
                                                     Name = "Laptop 2",
                                                     Price = 1245,
                                                     Stock = 1
                                                 }
            });
            var count=await _productWriteRepository.SaveChanges();
        }
        [HttpGet("{id}")]
        public async Task Get(string id)
        {
            var product=await _productReadRepository.GetSingleAsync(x=>x.Id==Guid.Parse(id));
        }

    }
}
