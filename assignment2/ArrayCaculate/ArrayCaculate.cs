using System;

public class ArrayCaculate { 
    public static void Main(string[] args)
    {
        double[] input = inputArray();
        double max, min, aver, total;
        if (input != null)
        {
            max = maxValue(input);
            min = minValue(input);
            total = totalValue(input);
            aver = averValue(input);
            Console.WriteLine("最大值为：" + max);
            Console.WriteLine("最小值为：" + min);
            Console.WriteLine("平均值为：" + aver);
            Console.WriteLine("总和为：" + total);
        }
        
    }
    public static double[] inputArray(){
        try
        {
            Console.WriteLine("请输入一个数组：");
            string str = Console.ReadLine();
            char s = ' ';
            string[] strArray = str.Split(s);
            int length = strArray.Length;
            double[] input = new double[length];
            for (int i = 0; i < length; i++)
            {
                input[i] = double.Parse(strArray[i]);
            }
            return input;
        }catch (IOException e)
        {
            Console.WriteLine("输入错误！原因为：" + e.Message);
            return null;
        }
       
    }

    public static double maxValue(double []input)
    {
        double max = -100000;
        for(int i = 0; i < input.Length; i++)
        {
            if (input[i] > max)max= input[i];
        }
        return max;
    }

    public static double minValue(double[] input)
    {
        double min = 100000;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] < min) min = input[i];
        }
        return min;
    }

    public static double totalValue(double[] input)
    {
        double total = 0;
        for (int i = 0; i < input.Length; i++)
        {
            total += input[i];
        }
        return total;
    }

    public static double averValue(double[] input)
    {
        double total = totalValue(input);
        double aver = total / input.Length;
        return aver;
    }
}