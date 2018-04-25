using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class AsynSubject
    {
        static void Main(string[] args)
        {
            async();
            Console.ReadKey();
        }
        public static void async()
        {
            var subject = new AsyncSubject<string>();
            subject.OnNext("a");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("b");
            subject.OnNext("c");
            subject.OnCompleted();
        }
    }
}