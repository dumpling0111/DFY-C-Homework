using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLink
{
    public class main
    {
        public static void Main(string[] args)
        {
            try
            {
                int sum = 0;
                GenericList<int> genericList = createIntList();
                int max = genericList.Head.Data;
                int min = genericList.Head.Data;

                Console.Write("打印链表元素：");
                genericList.ForEach(x => Console.Write(x + " "));
                Console.WriteLine();

                Console.Write("打印链表最大值：");
                genericList.ForEach(x => { max = max < x ? x : max; });
                Console.WriteLine(max);

                Console.Write("打印链表最小值：");
                genericList.ForEach(x => { min = min < x ? min : x; });
                Console.WriteLine(min);

                Console.Write("打印链表的和：");
                genericList.ForEach(x => sum += x);
                Console.WriteLine(sum);

            }catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            
        }
        //新建一个整型链表
        public static GenericList<int> createIntList()
        {
            
            Random rd = new Random();
            GenericList<int> genericList = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                int k = rd.Next(1, 101);
                genericList.Add(k);
            }
            if (genericList.Head == null)
            {
                throw new ArgumentNullException("链表不能为空！");
            }
            return genericList;
        } 
    }
}
