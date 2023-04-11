namespace OrderServiceWinForm
{
    public partial class Form1 : Form
    {
        OrderService orderService = new OrderService();

        //public event Action<FormEdit> ShowEditForm;
        public String Keyword { get; set; }
        public Form1()
        {
            InitializeComponent();
            InitOrders();
            orderBindingSource.DataSource = orderService.GetAllOrders();
            //cbxField.SelectedIndex = 0;
            //txtKeyword.DataBindings.Add("Text", this, "Keyword");
            //ShowEditForm += (f => { });
        }
        private void InitOrders()
        {
            Order order = new Order(1, new Customer(1, "dai"), new List<OrderDetail>());
            order.AddDetails(new OrderDetail(1, new Goods(1, "apple", 100), 10));
            order.AddDetails(new OrderDetail(2, new Goods(2, "banana", 50), 61));
            orderService.AddOrder(order);
            Order order2 = new Order(2, new Customer(2, "fei"), new List<OrderDetail>());
            order2.AddDetails(new OrderDetail(1, new Goods(2, "egg", 200), 10));
            orderService.AddOrder(order2);
            Order order3 = new Order(3, new Customer(3, "yang"), new List<OrderDetail>());
            order3.AddDetails(new OrderDetail(1, new Goods(1, "pear", 666), 20));
            orderService.AddOrder(order3);
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}