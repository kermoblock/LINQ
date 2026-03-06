using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class OrderList
    {
        public static readonly List<Order> Orders = new List<Order>()
        {
            new Order()
            {
                Id = 1,
                ClientId = 3,
                ProductId = 2,
                Amount = 1,
            },

            new Order()
            {
                Id = 2,
                ClientId = 1,
                ProductId = 5,
                Amount = 2,
            },

            new Order()
            {
                Id = 3,
                ClientId = 1,
                ProductId = 4,
                Amount = 1,
            },

            new Order()
            {
                Id = 4,
                ClientId = 5,
                ProductId = 10,
                Amount = 4,
            },

            new Order()
            {
                Id = 4,
                ClientId = 4,
                ProductId = 1,
                Amount = 1,
            },

            new Order()
            {
                Id = 5,
                ClientId = 2,
                ProductId = 8,
                Amount = 1,
            },

            new Order()
            {
                Id = 6,
                ClientId = 2,
                ProductId = 7,
                Amount = 5,
            },

            new Order()
            {
                Id = 7,
                ClientId = 2,
                ProductId = 6,
                Amount = 1,
            },

            new Order()
            {
                Id = 8,
                ClientId = 3,
                ProductId = 5,
                Amount = 1,
            },

            new Order()
            {
                Id = 9,
                ClientId = 1,
                ProductId = 7,
                Amount = 3,
            },

            new Order()
            {
                Id = 10,
                ClientId = 1,
                ProductId = 10,
                Amount = 1,
            },
        };
    }
}
