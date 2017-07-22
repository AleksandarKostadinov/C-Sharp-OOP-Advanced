using System.Collections.Generic;

namespace _09.CollectionHierarchy.Interfaces
{
    public interface IAddCollection
    {
         IList<string> data { get; }

        byte Add(string item);
    }
}
