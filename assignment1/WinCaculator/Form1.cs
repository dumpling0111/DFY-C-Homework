namespace WinCaculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void caculateButton_Click(object sender, EventArgs e)
        {
            double result = 0;
            double number1 = Convert.ToDouble(strNumber1.Text);
            double number2 = Convert.ToDouble(strNumber2.Text);
            switch (comboBox1.Text)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }
            calculateResult.Text = result.ToString();

        }

        private void strNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void strNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}