using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    class Order
    {
        public string OrderId { get; set; }
        public string Customer { get; set; }
        public double TotalAmount { get; set; }
        public List<OrderDetail> Details { get; set; }

        public Order(string orderId, string customer, double totalAmount)
        {
            this.OrderId = orderId;
            this.Customer = customer;
            this.TotalAmount = totalAmount;
            this.Details = new List<OrderDetail>();
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            if (this.Details.Contains(orderDetail))
            {
                throw new ApplicationException($"OrderDetail-{orderDetail} is already existed!");
            }
            Details.Add(orderDetail);
        }

        public void RemoveOrderDetail(OrderDetail orderDetail)
        {
            Details.Remove(orderDetail);
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            return -1937169414 + EqualityComparer<string>.Default.GetHashCode(OrderId);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"OrderId:{OrderId}, customer:{Customer}, total amount:{TotalAmount}\n");
            foreach (OrderDetail orderDetail in Details)
            {
                stringBuilder.Append("\t" + orderDetail + "\n");
            }
            return stringBuilder.ToString();
        }
    }
}
