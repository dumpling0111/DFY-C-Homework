using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagementSystem
{
    class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
            {
                throw new Exception("Order already exists!");
            }

            orders.Add(order);
        }

        public void RemoveOrder(string orderId)
        {
            Order order = orders.SingleOrDefault(o => o.OrderId == orderId);

            if (order is null)
            {
                throw new Exception("Order not found!");
            }

            orders.Remove(order);
        }

        public void ModifyOrder(Order newOrder)
        {
            Order oldOrder = orders.SingleOrDefault(o => o.OrderId == newOrder.OrderId);

            if (oldOrder is null)
            {
                throw new Exception("Order not found!");
            }

            orders.Remove(oldOrder);
            orders.Add(newOrder);
        }

        public Order GetOrder(string orderId)
        {
            return orders.SingleOrDefault(o => o.OrderId == orderId);
        }

        public List<Order> QueryOrders(Func<Order, bool> predicate)
        {
            return orders.Where(predicate).ToList();
        }

        public void SortOrders()
        {
            orders.Sort();
        }

        public void SortOrders(Comparison<Order> comparison)
        {
            orders.Sort(comparison);
        }

        public override string ToString()
        {
            return string.Join("\n", orders);
        }
    }
}
