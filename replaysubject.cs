using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class replaysubject
    {
        static void Main(string[] args)
        {
            subscribe1();
            Console.ReadKey();
        }
        public static void subscribe1()
        {
            //var bufferSize = 2;
            var subject = new Subject<string>();
            subject.OnNext("a");
            subject.OnNext("b");
            subject.OnNext("c");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("d");
            
        }
    }
}