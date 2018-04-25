using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class Subject
    {
        static void Main(string[] args)
        {
            subscribe();
            Console.ReadKey();
        }
       public static void subscribe()
        {
            var subject = new Subject<string>();            
            subject.OnNext("a");
            subject.Subscribe(Console.WriteLine);
            subject.OnNext("b");            
            subject.OnNext("c");
            
        }            
     }        
}