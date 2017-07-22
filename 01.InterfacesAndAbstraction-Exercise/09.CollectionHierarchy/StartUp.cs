using System;
using _09.CollectionHierarchy.Entities;

namespace _09.CollectionHierarchy
{
    public class StartUp
    {
        public static void Main()
        {
            var addCollevtion = new AddCollection();
            var addRamoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var addCollAdds = new byte[input.Length];
            var addRemoveCollAdds = new byte[input.Length];
            var myListAdds = new byte[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                addCollAdds[i] = addCollevtion.Add(input[i]);
                addRemoveCollAdds[i] = addRamoveCollection.Add(input[i]);
                myListAdds[i] = myList.Add(input[i]);
            }

            var numberOfRemoves = int.Parse(Console.ReadLine());

            var addRemoveCollRemoves = new string[numberOfRemoves];
            var myListRemoves = new string[numberOfRemoves];

            for (int i = 0; i < numberOfRemoves; i++)
            {
                addRemoveCollRemoves[i] = addRamoveCollection.Remove();
                myListRemoves[i] = myList.Remove();
            }

            Console.WriteLine(string.Join(" ", addCollAdds));
            Console.WriteLine(string.Join(" ", addRemoveCollAdds));
            Console.WriteLine(string.Join(" ", myListAdds));
            Console.WriteLine(string.Join(" ", addRemoveCollRemoves));
            Console.WriteLine(string.Join(" ", myListRemoves));
        }
    }
}
