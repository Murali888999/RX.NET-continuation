using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class ObservableRange
    {
        static void Main(string[] args)
        {
            obsrange();
            Console.ReadKey();
        }
        public static void obsrange()
        {
            var range = Observable.Range(10, 12);
            range.Subscribe(Console.WriteLine);
            Console.WriteLine("done");
        }
    }
}
