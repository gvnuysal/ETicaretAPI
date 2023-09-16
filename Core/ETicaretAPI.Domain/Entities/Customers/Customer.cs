using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Domain.Entities.Orders;

namespace ETicaretAPI.Domain.Entities.Customers
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
