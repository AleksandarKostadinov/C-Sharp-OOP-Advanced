using System.Collections.Generic;
using _09.CollectionHierarchy.Interfaces;

namespace _09.CollectionHierarchy.Entities
{
    public abstract class  MyCollection : AddCollection, IAddRemoveCollection
    {
        public IList<string> data { get; }

        protected MyCollection()
        {
            this.data = new List<string>();
        }
        public byte Add(string item)
        {
            this.data.Insert(0, item);
            return 0;
        }

        public virtual string Remove()
        {
            var result = this.data[this.data.Count - 1];
            this.data.RemoveAt(this.data.Count - 1);
            return result;
        }
    }
}
