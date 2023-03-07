using System;
namespace Caculator
{
    public class Operation
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入第一个数字:");
                string strNumber1 = Console.ReadLine();
                Console.Write("请输入运算符号(+、-、*、/):");
                string strOperate = Console.ReadLine();
                Console.Write("请输入第二个数字:");
                string strNumber2 = Console.ReadLine();
                double number1 = Convert.ToDouble(strNumber1);
                double number2 = Convert.ToDouble(strNumber2);
                double result = Operation.operate(number1, strOperate, number2);
                string strResult = strNumber1 + strOperate + strNumber2 + " = " + result;
                    Console.WriteLine("结果是：" + strResult);
            }
            catch (Exception e)
            {
                Console.WriteLine("您的输入有误：" + e.Message);
            }
        }
        public static double operate(double number1, string operate, double number2)
        {
            double result = 0;
            switch (operate)
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
            return result;
        }

    }
}




