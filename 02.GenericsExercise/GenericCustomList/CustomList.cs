using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericCustomList
{
    public class CustomList<T> : ICustomList<T>
        where T : IComparable<T>
    {
        private readonly IList<T> data;

        public CustomList(IEnumerable<T> data)
        {
            this.data = new List<T>(data);
        }

        public CustomList(): this(Enumerable.Empty<T>())
        {
            
        }

        public IList<T> Data
        {
            get { return this.data; }
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove(int index)
        {
            var rem = this.data[index];
            this.data.RemoveAt(index);
            return rem;
        }

        public bool Contains(T element)
        {
            return this.data.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            var temp = this.data[index1];
            this.data[index1] = this.data[index2];
            this.data[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            return this.data.Count(e => e.CompareTo(element) > 0);
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public void Print()
        {
            foreach (var element in this.data)
            {
                Console.WriteLine(element);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
