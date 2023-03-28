using System;

namespace OrderManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();

            Order order1 = new Order("20220328001", "Alice", 1000.0);
            OrderDetail orderDetail1 = new OrderDetail("iPhone", 1, 1000.0);
            order1.AddOrderDetail(orderDetail1);

            Order order2 = new Order("20220328002", "Bob", 2000.0);
            OrderDetail orderDetail2 = new OrderDetail("iPad", 2, 500.0);
            order2.AddOrderDetail(orderDetail2);

            orderService.AddOrder(order1);
            orderService.AddOrder(order2);

            Console.WriteLine(orderService);

            Order order3 = new Order("20220328001", "Chris", 3000.0);
            OrderDetail orderDetail3 = new OrderDetail("MacBook", 1, 3000.0);
            order3.AddOrderDetail(orderDetail3);

            orderService.ModifyOrder(order3);

            Console.WriteLine(orderService);

            orderService.RemoveOrder("20220328002");

            Console.WriteLine(orderService);

            Console.WriteLine(orderService.GetOrder("20220328001"));

            Console.WriteLine(orderService.QueryOrders(o => o.TotalAmount > 2000.0));

            orderService.SortOrders();

            Console.WriteLine(orderService);

            orderService.SortOrders((o1, o2) => o2.TotalAmount.CompareTo(o1.TotalAmount));

            Console.WriteLine(orderService);
        }
    }
}
