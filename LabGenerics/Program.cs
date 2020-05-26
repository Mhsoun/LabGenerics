using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine($"count value :{box.Count}, Elements in the box :");
            box.Element.ForEach(el => Console.WriteLine(el));
            Console.WriteLine($"this Item is removed : {box.Remove()}");

            box.Add(4);
            box.Add(5);
            Console.WriteLine($"count value :{box.Count}, Elements in the box :");
            box.Element.ForEach(el => Console.WriteLine(el));
            Console.WriteLine($"this Item is removed : {box.Remove()}");

            Console.ReadLine();
        }
    }
}
