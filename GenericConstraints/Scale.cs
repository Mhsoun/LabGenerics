using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraints
{
    public class Scale<T> where T : IComparable
    {
        public T Left { get; set; }
        public T Right { get; set; }
        public Scale(T left, T right)
        {
            Left = left;
            Right = right;
        }
        public T GetHeavier()
        {
            int x =Right.CompareTo(Left);

            if (x > 0)
            {
                Console.WriteLine("The right scale is the heaviest");
                return Right;
            }
            else if (x<0)
            {
                Console.WriteLine("The left scale is the heaviest");
                return Left;
            } else
            {
                Console.WriteLine("they are equal");
                return default;
            }
        }

    }
}
