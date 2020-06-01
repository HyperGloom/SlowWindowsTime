using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strCmdText;
            Console.WriteLine("Set hour");
            int hour = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Set minute");
            int minute = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Set second");
            int second = Int32.Parse(Console.ReadLine());
            Console.WriteLine("how much slow down time?(if you write 2, it will 2 times slower");
            int slowValue = Int32.Parse(Console.ReadLine())*2;
            int Timedelay = 500;

            for (int i = 0; ;i++)
            {
                
                for(int j=0;j<slowValue;j++)
                {
                    Thread.Sleep(Timedelay);
                    strCmdText = "/C time " + hour.ToString() + ":" + minute.ToString() + ":" + second.ToString() + ",0";
                    System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                }
                second++;
                if (second == 60)
                {
                    second = 0;
                    minute++;
                }
                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                }
            }
            
        }
    }
}
