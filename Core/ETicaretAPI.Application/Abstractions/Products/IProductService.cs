using ETicaretAPI.Domain.Entities.Products;

namespace ETicaretAPI.Application.Abstractions.Products
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
