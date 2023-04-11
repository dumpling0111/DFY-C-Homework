using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceWinForm
{
    public class Order : IComparable<Order>
    {

        private readonly List<OrderDetail> details = new List<OrderDetail>();

        public int Id { get; set; }

        public Customer Customer { get; set; }

        /*public string CustomerName { get => (Customer != null) ? Customer.Name : ""; }*/

        public DateTime CreateTime { get; set; }

        public float TotalPrice
        {
            get => Details.Sum(d => d.TotalPrice);
        }

        public List<OrderDetail> Details
        {
            get { return details; }
        }

        public Order()
        {
            details = new List<OrderDetail>();
            CreateTime = DateTime.Now;
        }
        public Order(int id, Customer customer, List<OrderDetail> orderDetails)
        {
            Id = id;
            Customer = customer;
            CreateTime = DateTime.Now;
            details = (orderDetails == null) ? new List<OrderDetail>() : orderDetails;
        }

        public void AddDetails(OrderDetail orderDetail)
        {
            if (Details.Contains(orderDetail))
            {
                throw new ApplicationException($"The goods ({orderDetail.Goods.Name}) exist in order {Id}");
            }
            Details.Add(orderDetail);
        }
        public void RemoveDetails(OrderDetail orderItem)
        {
            Details.Remove(orderItem);
        }

        public int CompareTo(Order other)
        {
            return (other == null) ? 1 : Id - other.Id;
        }

        public string getCustomerName() {
            return Customer.Name;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && Id == order.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"Id:{Id}, customer:{Customer},orderTime:{CreateTime},totalPrice：{TotalPrice}");
            details.ForEach(od => strBuilder.Append("\n\t" + od));
            return strBuilder.ToString();
        }

    }
}
