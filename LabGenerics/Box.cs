using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LabGenerics
{
    public class Box<T>
    {
        List<T> element = new List<T>();
        public int Count => element.Count;
        public List<T> Element { get => element; set => element = value; }

        public void Add(T input)
        {
            Element.Add(input);
        }

        public T Remove()
        {
            T elToRemove = Element[Count - 1];
            Element.Remove(elToRemove);
            return elToRemove;
        }

    }
}
