using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<int> scale = new Scale<int>(10,5);
            var heavier = scale.GetHeavier();
            if (heavier != 0)
            {
                Console.WriteLine($"the heaviest scale value is : {heavier}");
            } else
            {
                Console.WriteLine("they are equal!");
            }

            Console.ReadLine();
        }
    }
}
