using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class ObservableReturn
    {
        static void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }
        public static void test()
        { 
           // var singleValue = Observable.Return<string>("Murali");
            var subject = new ReplaySubject<string>();
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("Mohan");
            subject.OnCompleted();
        }
    }
}
