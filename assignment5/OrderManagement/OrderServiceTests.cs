
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*namespace OrderManagementSystem
{
  public class OrderServiceTests {

    OrderService orderService = new OrderService();

    Goods apple = new Goods(1,"dai", 10.0f);
    Goods egg = new Goods(2, "fei", 1.2f);
    Goods milk = new Goods(3, "yang", 50f);
    Customer customer1 = new Customer(1,"dfy");
    Customer customer2 = new Customer(2, "yfd");

    //初始化
    public void Init() {

      Order order1 = new Order(1, customer1,new DateTime(2023, 3, 21));
      order1.AddDetails(new OrderDetail(apple, 80));
      order1.AddDetails(new OrderDetail(egg, 200));
      order1.AddDetails(new OrderDetail(milk, 10));

      Order order2 = new Order(2, customer2, new DateTime(2023, 3, 22));
      order2.AddDetails(new OrderDetail(egg, 200));
      order2.AddDetails(new OrderDetail(milk, 10));

      Order order3 = new Order(3, customer2, new DateTime(2023, 3, 23));
      order3.AddDetails(new OrderDetail(apple, 80));
      order3.AddDetails(new OrderDetail(milk, 10));

      orderService = new OrderService();
      orderService.AddOrder(order1);
      orderService.AddOrder(order2);
      orderService.AddOrder(order3);
    }
    //添加订单
    public void AddOrderTest() {
      Order order4 = new Order(4,customer2, new DateTime(2023, 3, 21));
      order4.AddDetails(new OrderDetail(milk, 10));
      orderService.AddOrder(order4);
      List<Order> orders = orderService.QueryAll();
      Assert.IsNotNull(orders);
      Assert.AreEqual(4, orders.Count);
      CollectionAssert.Contains(orders, order4);
    }

    public void AddOrderTest2() {
      Order order3 = new Order(3, customer2, new DateTime(2023, 3, 21));
      orderService.AddOrder(order3);
    }
    //删除订单
    public void RemoveOrderTest() {
      orderService.RemoveOrder(3);
      List<Order> orders = orderService.QueryAll();
      Assert.AreEqual(2, orders.Count);
      orderService.RemoveOrder(100);
      Assert.AreEqual(2, orderService.QueryAll().Count);
    }
    //更新订单
    public void UpdateOrderTest() {
      Order order3 = new Order(3, customer1, new DateTime(2021, 3, 21));
      order3.AddDetails(new OrderDetail(milk, 200));
      orderService.Update(order3);

      List<Order> orders = orderService.QueryAll();
      Assert.IsNotNull(orders);
      Assert.AreEqual(3, orders.Count);
      Order o = orderService.GetById(3);
      Assert.AreEqual(customer1, o.Customer);
    }

    //根据id查询
    public void QueryOrderByIdTest() {
      Order order2=orderService.GetById(2);
      Assert.IsNotNull(order2);
      Assert.AreEqual(2, order2.Id);
      Assert.AreEqual(customer2, order2.Customer);
      List<OrderDetail> details = new List<OrderDetail>() 
        { new OrderDetail(egg, 200), new OrderDetail(milk, 10) };
      CollectionAssert.AreEqual(details, order2.Details);

      Order order4 = orderService.GetById(4);
      Assert.IsNull(order4);
    }

    //根据商品名查询
    public void QueryOrdersByGoodsNameTest() {
      Assert.AreEqual(2,orderService.QueryByGoodsName("apple").Count);
      Assert.AreEqual(2,orderService.QueryByGoodsName("egg").Count);
      Assert.AreEqual(3,orderService.QueryByGoodsName("milk").Count);
      Assert.AreEqual(0,orderService.QueryByGoodsName("orange").Count);
    }
    //根据客户名查询
    public void QueryOrdersByCustomerNameTest() {
      Assert.AreEqual(1,orderService.QueryByCustomerName("Customer1").Count);
      Assert.AreEqual(2,orderService.QueryByCustomerName("Customer2").Count);
      Assert.AreEqual(0,orderService.QueryByCustomerName("Customer3").Count);
    }

  }
}*/