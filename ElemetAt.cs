using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Rx.Net
{
    class ElemetAt
    {
        static void Main(string[] args)
        {
            power();
            Console.ReadKey();
        }
        public static void power()
        {
            var obj = new Subject<int>();
            obj.Subscribe(Console.WriteLine, () => Console.WriteLine("subject completed"));
            var obj1 = obj.ElementAt(2);
            obj1.Subscribe(b => Console.WriteLine("contains 2?{0}",b), 
               () => Console.WriteLine("elementAt compeletd"));
            obj.OnNext(1);
            obj.OnNext(2);
            obj.OnNext(3);
            obj.OnNext(4);
            obj.OnCompleted();
        }
    }
}
