using System.Collections.Generic;
using _09.CollectionHierarchy.Interfaces;

namespace _09.CollectionHierarchy.Entities
{
    public class MyList : MyCollection, IMyList
    {
        public override string Remove()
        {
            var result = this.data[0];

            this.data.RemoveAt(0);

            return result;
        }

        public int GetCount => this.data.Count;
    }
}
