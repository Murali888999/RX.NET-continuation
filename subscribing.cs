using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class subscribing
    {
        static void Main(string[] args)
        {
            subscribing1();
            Console.ReadKey();
        }
        public static void subscribing1()
        { 
            var values = new Subject<int>();
            values.Subscribe(
            value => Console.WriteLine("1st subscription received {0}", value),
            ex => Console.WriteLine("Caught an exception : {0}", ex));
            values.OnNext(1);
            values.OnError(new Exception("Dummy exception"));
            values.OnCompleted();
            values.OnNext(2);
            values.OnNext(3);
        }      
    }
}