using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System;
using System.Timers;


namespace flynoobclienttest
{
    class Program
    {
        public static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.AutoReset = true;
            timer.Interval = 1000;
            timer.Elapsed += new ElapsedEventHandler(Tick);
            timer.Start();
            Console.ReadLine();
        }

        private static void Tick(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("每秒执行一次");
        }
    }
}
