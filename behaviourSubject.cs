using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class behaviourSubject
    {
        static void Main(string[] args)
        {
            BehaviorSubject();
            Console.ReadKey();
        }
        public static void BehaviorSubject()
        {
            var subject = new BehaviorSubject<string>("a");
            subject.OnNext("Murali");
            subject.OnNext("b");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("c");
            subject.OnNext("d");          
        }
    }
}
