using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace Rx.Net
{
    class ObservableTimer
    {
        static void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }
        public static void test()
        { 
            var timer = Observable.Timer(TimeSpan.FromSeconds(3));
            timer.Subscribe(Console.WriteLine,() => Console.WriteLine("Completed"));           
        }
    }
}
