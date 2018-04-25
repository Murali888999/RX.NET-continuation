using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Rx.Net
{
    class Select
    {
        static void Main(string[] args)
        {
            power();
            Console.ReadKey();
        }
        public static void power()
        {
            //var source = Observable.Range(0, 5);
            //source.Select(i => i + 1).Dump("+3");
            var source = Observable.Range(1, 7);
            source.Select(i => (char)(i + 64)).Dump("char");
        }
    }
}
