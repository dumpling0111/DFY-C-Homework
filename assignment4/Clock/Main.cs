using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock{
    public class main
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DateTime datetime = new DateTime();
            string clockTime = "";
            Console.WriteLine("请输入闹钟设定的时间！");
            Console.Write("年份为：");
            clockTime += Console.ReadLine()+"/";
            Console.Write("月份为：");
            clockTime += Console.ReadLine() + "/";
            Console.Write("日期为：");
            clockTime += Console.ReadLine() + " ";
            Console.Write("时间为：（e.g.如要设定13点25分50秒则输入13:25:50）");
            clockTime += Console.ReadLine();
            try
            {
                datetime = Convert.ToDateTime(clockTime);
                clock.SetAlarmTime(datetime);
                clock.Start();
            }catch (Exception e)
            {
                Console.WriteLine("没有输入正确的时间！");
                Console.WriteLine(e.ToString());
            }
            
        }
    }
}
