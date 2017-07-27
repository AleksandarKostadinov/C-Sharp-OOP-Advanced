using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBox
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfStr = int.Parse(Console.ReadLine());

            var boxes = new List<Box<double>>();

            for (int i = 0; i < numberOfStr; i++)
            {
                var box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(box);
            }

            //var indices = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToArray();

            //Swap(boxes, indices[0], indices[1]);

            //foreach (var box in boxes)
            //{
            //    Console.WriteLine(box);
            //}

            var compairer = new Box<double>(double.Parse(Console.ReadLine()));

            int countOfGreater = CountGreater(boxes, compairer);
            Console.WriteLine(countOfGreater);
        }

        private static int CountGreater<T>(IList<T> list, T compairer)
            where T:IComparable<T>
        {
            return list.Count(i => i.CompareTo(compairer) > 0);
        }

        public static void Swap<T>(IList<T> list, int firstIndex, int secondIndex)
        {
            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}
