using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceWinForm
{
    public class OrderDetail
    {
        public int Id { get; set; } //序号
        public Goods Goods { get; set; }
        public double UnitPrice { get => Goods != null ? this.Goods.Price : 0.0; }
        public int Quantity { get; set; }

        public float TotalPrice
        {
            get => Goods==null?0: Goods.Price * Quantity;
        }

        public OrderDetail() { }

        public OrderDetail(int index, Goods goods, int quantity)
        {
            Id = index;
            Goods = goods;
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null &&
                   EqualityComparer<Goods>.Default.Equals(Goods, detail.Goods);
        }

        public override int GetHashCode()
        {
            return 785010553 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
        }

        public override string ToString()
        {
            return Goods.Name;
        }
    }
}
