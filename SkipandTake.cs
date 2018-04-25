using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Rx.Net
{
    class SkipandTake
    {
        static void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }
        public static void test()
        {
            //var obj = Observable.Range(0, 15)
            //.Skip(4)
            //.Take(5)
            //.Subscribe(Console.WriteLine,()=> Console.WriteLine());
            var subject = new Subject<int>();
            subject
            .SkipLast(3)
            .Subscribe(Console.WriteLine, () => Console.WriteLine("Completed"));
            Console.WriteLine("Pushing 1");
            subject.OnNext(1);
            Console.WriteLine("Pushing 2");
            subject.OnNext(2);
            Console.WriteLine("Pushing 3");
            subject.OnNext(3);
            Console.WriteLine("Pushing 4");
            subject.OnNext(4);
            Console.WriteLine("Completing");
            subject.OnCompleted();
        }
    }
}
