using System.Collections.Generic;
using _09.CollectionHierarchy.Interfaces;

namespace _09.CollectionHierarchy.Entities
{
    public class AddCollection : IAddCollection
    {
        public IList<string> data { get; }

        public AddCollection()
        {
            this.data = new List<string>();
        }
        public byte Add(string item)
        {
            this.data.Add(item);
            return (byte)(this.data.Count - 1);
        }
    }
}
