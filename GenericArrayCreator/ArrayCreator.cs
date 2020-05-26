using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    public class ArrayCreator<T>
    {
        public static T[] Create(int length, T item)
        {
            T[] newArray = new T[length];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = item;
            }
            return newArray;
        }
    }
}
