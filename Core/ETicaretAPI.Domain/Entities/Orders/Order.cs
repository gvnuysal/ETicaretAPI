﻿using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Domain.Entities.Customers;
using ETicaretAPI.Domain.Entities.Products;

namespace ETicaretAPI.Domain.Entities.Orders
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}
