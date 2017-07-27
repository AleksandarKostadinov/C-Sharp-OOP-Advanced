using System;
using System.Collections.Generic;

namespace GenericCustomList
{
    public interface ICustomList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        IList<T> Data { get; }

        void Add(T element);

        T Remove(int index);

        bool Contains(T element);

        void Swap(int index1, int index2);

        int CountGreaterThan(T element);

        T Max();

        T Min();

        void Print();
    }
}
