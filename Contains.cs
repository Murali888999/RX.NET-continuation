﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Rx.Net
{
    class Contains
    {
        static void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }
        public static void test()
        {
            var subject = new Subject<int>();
            subject.Subscribe(Console.WriteLine,() => Console.WriteLine("Subject completed"));
            var contains = subject.Contains(2);
            contains.Subscribe(b => Console.WriteLine("Contains the value 2? {0}", b),
            () => Console.WriteLine("contains completed"));
            subject.OnNext(1);
            subject.OnNext(2);
            subject.OnNext(3);
            subject.OnCompleted();
        }
    }
}
