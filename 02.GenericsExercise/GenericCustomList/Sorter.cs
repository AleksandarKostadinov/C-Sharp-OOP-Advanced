using System;
using System.Linq;

namespace GenericCustomList
{
    public class Sorter
    {
        public static ICustomList<T> Sort<T>(ICustomList<T> custList)
            where T: IComparable<T>
        {
            return new CustomList<T>(custList.Data.OrderBy(x => x));
        }
    }
}
