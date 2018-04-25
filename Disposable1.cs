using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class Disposable1
    {
        static void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }
        public static void test()
        {
            var disposable = Disposable.Create(() => Console.WriteLine("Being disposed..."));
            Console.WriteLine("Calling by using dispose method...");
            disposable.Dispose();
            Console.WriteLine("Calling again using dispose method...");
            disposable.Dispose();
        }
    }
}
