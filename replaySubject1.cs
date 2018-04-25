using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rx.Net
{
    class replaySubject1
    {
        static void Main(string[] args)
        {
            ReplaySubject();
            Console.ReadKey();
        }
        public static void ReplaySubject()
        {
            var window = TimeSpan.FromMilliseconds(100);
            var subject = new ReplaySubject<string>(window);
            subject.OnNext("w");
            Thread.Sleep(TimeSpan.FromMilliseconds(50));
            subject.OnNext("x");
            Thread.Sleep(TimeSpan.FromMilliseconds(100));
            subject.OnNext("y");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("z");       
        }
    }
}
