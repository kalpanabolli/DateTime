using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime matchDate = new DateTime(day: 13, month: 07, year: 2023);
            //DateTime currentDate =DateTime.Now;
            //TimeSpan ts = matchDate.Subtract(currentDate);
            // Console.WriteLine("Days Remain " + ts.Days);
            //  Console.WriteLine("Days Remain " +ts.Hours);
            // Console.WriteLine(ts.ToString());
            // Console.ReadKey();
            TimeSpan duration = new TimeSpan(2, 15, 45);
            Console.WriteLine($"Total Duration Hours: {duration.Hours} Minutes : {duration.Minutes} Seconds : {duration.Seconds}");
            TimeSpan t2 = new TimeSpan(4, 30, 30);
            duration.Add(t2);
            Console.WriteLine($"Total Duration Hours : {t2.Hours} Minutes:{t2.Minutes} Seconds :{t2.Seconds}");
            Console.WriteLine("Duration after Adding 4:15:30");
            Console.WriteLine($"Total Duration Hours: {duration.Hours} Minutes : {duration.Minutes} Seconds : {duration.Seconds}");
            Console.ReadKey();
        }
    }
}