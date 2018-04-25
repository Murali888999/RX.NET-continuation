using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace Rx.Net
{
    class Where
    {
        static void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }
        public static void test()
        {
            var sub = Observable.Range(0, 20)
            .Where(i => i % 2 == 0)
            .Subscribe(Console.WriteLine, () => Console.WriteLine("done"));
        }
    }
}
