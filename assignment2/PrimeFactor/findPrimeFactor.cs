﻿using System;

public class findPrimeFactor
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入一个整数：");
                string strNumber = Console.ReadLine();
                if(strNumber != null)
                {
                    int num = int.Parse(strNumber);
                    findFactor(num);
                }
                
            }catch (Exception ex)
            {
                Console.WriteLine("输入出错！原因为：" + ex.Message);
            }
            
        }

        public static void findFactor(int n)
        {
            int pfNum = 0;
            Console.Write("质数因子为：");
            for (int i = 2; i <= n/2; i++) {
                if(n % i != 0) {
                continue;}

                bool res = isPrime(i);
                if (res == true) { 
                    Console.Write(i + " "); 
                    pfNum++;
                }
                
            }
            if(pfNum == 0) { 
                Console.WriteLine("无质数因子！"); 
            }
        }
        public static bool isPrime(int n)
        {
            if(n==2) return true;
            for(int i = 2; i <= n / 2; i++)
            {
                if(n % i == 0) {  return false; }
            }
            return true;
            
        }
    }


