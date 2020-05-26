using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strings = ArrayCreator<string>.Create(5, "Peter");
            int[] integers = ArrayCreator<int>.Create(10, 33);

            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
            for (int i = 0; i < integers.Length; i++)
            {
                Console.WriteLine(integers[i]);
            }

            Console.ReadLine();
        }
    }
}
