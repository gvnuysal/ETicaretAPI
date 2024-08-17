using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.ViewModels.Products
{
    public class VM_Create_Product
    {
        /// <summary>
        /// Stock Name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Stock quantity in warehouse
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// stock price
        /// </summary>
        public long Price { get; set; }
    }
}