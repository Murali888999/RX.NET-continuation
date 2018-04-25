using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;
using System.Reactive.Linq;
using Rx.Net;

namespace Rx.Net
{
    public static class dumpclass
    {
        public static void Dump<T>(this IObservable<T> source, string name)
        {
            source.Subscribe(
            i => Console.WriteLine("{0}-->{1}", name, i),
            ex => Console.WriteLine("{0} failed-->{1}", name, ex.Message),
            () => Console.WriteLine("{0} completed", name));
        }
    }
    class AggregateFunctions
    {
        static void Main(string[] args)
        {
            power();
            Console.ReadKey();
        }

        public static void power()
        {
            var numbers = new Subject<int>();
            numbers.Dump("numbers");
            numbers.Min().Dump("Min");
            numbers.Average().Dump("Average");
            numbers.OnNext(1);
            numbers.OnNext(2);
            numbers.OnNext(3);
            numbers.OnCompleted();
        }
    }
}