using System;

namespace OrderManagementSystem
{
    class OrderDetail : IEquatable<OrderDetail>
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public OrderDetail(string itemName, int quantity, double unitPrice)
        {
            ItemName = itemName;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public bool Equals(OrderDetail other)
        {
            if (other is null)
            {
                return false;
            }

            return ItemName == other.ItemName && Quantity == other.Quantity && UnitPrice == other.UnitPrice;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as OrderDetail);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ItemName, Quantity, UnitPrice);
        }

        public override string ToString()
        {
            return $"ItemName: {ItemName}, Quantity: {Quantity}, UnitPrice: {UnitPrice}";
        }
    }
}
