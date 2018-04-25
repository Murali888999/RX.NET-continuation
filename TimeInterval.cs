using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Rx.Net
{
    class TimeInterval
    {
        static void Main(string[] args)
        {
            power();
            Console.ReadKey();
        }
        public static void power()
        {
            Observable.Interval(TimeSpan.FromSeconds(1)).Take(4)
                .Timestamp().Dump("TimeStamp");
        }
    }
}