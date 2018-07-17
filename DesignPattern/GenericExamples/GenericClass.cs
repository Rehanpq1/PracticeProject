using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExamples
{
    public class GenericClass<T>
    {
        public readonly List<T> list = new List<T>();
        public const int i = 10;

        public List<T> AddItem(T item)
        {
            list.Add(item);
            return list;
        }

        public List<T> DeleteIteme(T item)
        {
            list.Remove(item);
            return list;
        }
    }
}
