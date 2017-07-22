using System.Collections.Generic;
using System.Linq;

public class Box<T>
{
    private IList<T> data;

    public Box()
    {
        this.data = new List<T>();
    }
    public void Add(T element)
    {
        this.data.Add(element);
    }

    public T Remove()
    {
        var topMost = this.data.LastOrDefault();
        this.data.RemoveAt(this.data.Count - 1);
        return topMost;
    }

    public int Count => this.data.Count;
}
