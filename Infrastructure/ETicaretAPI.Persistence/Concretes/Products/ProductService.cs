using ETicaretAPI.Application.Abstractions.Products;
using ETicaretAPI.Domain.Entities.Products;

namespace ETicaretAPI.Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() => new()
        {
            new()
            {
                CreatedDate = DateTime.Now,
                Id = Guid.NewGuid(),
                Name = "Laptop",
                Price=4522,
                Stock=11
            }, new()
            {
                CreatedDate = DateTime.Now,
                Id = Guid.NewGuid(),
                Name = "Laptop 2",
                Price=4545,
                Stock=11
            }, new()
            {
                CreatedDate = DateTime.Now,
                Id = Guid.NewGuid(),
                Name = "Laptop 3",
                Price=7484,
                Stock=11
            }, new()
            {
                CreatedDate = DateTime.Now,
                Id = Guid.NewGuid(),
                Name = "Laptop 4",
                Price=4125485,
                Stock=11
            },
        };
    }
}
