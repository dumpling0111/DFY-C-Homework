using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceWinForm
{
    public class Goods
    {

        public int Id { get; set; }

        public string Name { get; set; }

        private float price;

        public float Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("the price must >= 0!");
                price = value;
            }
        }

        public Goods() { }

        public Goods(int id, string name, float price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            var goods = obj as Goods;
            return goods != null &&
                   Id == goods.Id &&
                   Name == goods.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Value:{Price}";
        }

    }
}
