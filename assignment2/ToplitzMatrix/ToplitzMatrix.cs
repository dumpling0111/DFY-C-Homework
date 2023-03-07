using System;

public class ToplitzMatrix {
    public static void Main(string[] args)
    {
        Console.Write("请矩阵的行数：");
        int m = int.Parse(Console.ReadLine());
        Console.Write("请矩阵的列数：");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("请输入矩阵(无需输入‘|’，数字之间用空格隔开):");
        double[,] input = matrixInput(m,n);
        bool res = isToplitz(input, m, n);
        Console.Write("判断是否为托普利茨矩阵：");
        Console.WriteLine(res);
    }

    public static double[,] matrixInput(int m, int n)
    {
        try
        {
            double[,]input = new double[m,n];
            string[] str = new string[m];
            for (int i = 0; i < m; i++)
            {
                str[i]= Console.ReadLine();
            }
            char s = ' ';
            string[][] strArray = new string[m][];
            for (int i=0;i< m; i++)
            {
                strArray[i]=str[i].Split(s);
            }
            int length = strArray[0].Length;
            for(int i=0;i< m; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    double num = Convert.ToDouble(strArray[i][j]);
                    input[i,j] = num;                   
                }
            }
            return input;            
        }
        catch (IOException e)
        {
            Console.WriteLine("输入错误！原因为：" + e.Message);
            return null;
        }
        
    }

    public static bool isToplitz(double[,] input,int m, int n)
    {
        int min = m > n ? n : m;

        for(int i=0; i < m; i++)
        {
            int j = 0;
            double value = input[i,j];
            while (i+1<m && j+1<m)
            {
                i++;
                j++;
                if (input[i,j] != value) { return  false; }
            }
        }

        for (int j = 1; j < n; j++)
        {
            int i = 0;
            double value = input[i, j];
            while (i + 1 < m && j + 1 < m)
            {
                i++;
                j++;
                if (input[i, j] != value) { return false; }
            }
        }
        return true;
    }
} 