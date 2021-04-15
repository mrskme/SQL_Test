using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Test
{
    public class Order
    {
        public int Id;
        public int CustomerId;
        public List<Product> Products;
        public DateTime DateOrdered;

        public Order(int id, int customerId, List<Product> products, DateTime dateOrdered)
        {
            Id = id;
            CustomerId = customerId;
            Products = products;
            DateOrdered = dateOrdered;
        }
    }
}
