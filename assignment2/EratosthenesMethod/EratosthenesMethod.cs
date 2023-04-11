using System;

public class EratosthenesMethod {
    public static void Main(string[] args)
    {
        Console.WriteLine("使用埃式筛法，输出2—100之间的素数：");
        int[] num = new int[101];
        eMethod(ref num);
        for(int i=2;i<101;i++ )
        {
            if (num[i] == 0)
                Console.Write(i + " ");
        }
    }

    public static void eMethod(ref int []num)
    {
        //num[i]=1时表示i不为素数
        //i=2;i*i<primes.length
        //j=i*i;j<primes.length;j+=i
        for(int i = 0; i<=100; i++)
        {
            if (i == 0 || i == 1) num[i] = 1;
            for (int j = 2; j<i; j++)
            {
                if (i != j && i % j == 0) num[i] = 1;
            }
        }
    }
}