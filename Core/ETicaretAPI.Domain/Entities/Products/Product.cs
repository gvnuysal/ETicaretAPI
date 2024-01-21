using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Domain.Entities.Orders;

namespace ETicaretAPI.Domain.Entities.Products
{
    public class Product:BaseEntity
    {
        /// <summary>
        /// Name of product
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Unit of product
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// Price of product
        /// </summary>
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
