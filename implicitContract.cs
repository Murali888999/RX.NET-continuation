using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class implicitContract
    {
        static void Main(string[] args)
        {
            subjectinvalidUsage();
            Console.ReadKey();
        }
        public static void subjectinvalidUsage()
        {
            var sub = new Subject<string>();
            sub.Subscribe(Console.WriteLine);
            sub.OnNext("Murali");           
            sub.OnNext("Mohan");
            sub.OnCompleted();           
            sub.OnNext("Madhu");
            sub.OnNext("Anil");          
        }
    }
}
