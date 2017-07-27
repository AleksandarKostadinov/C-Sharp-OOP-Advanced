using System;

namespace GenericCustomList
{
    public class StartUp
    {
        public static void Main()
        {
            ICustomList<string> customList = new CustomList<string>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split();

                switch (tokens[0])
                {
                    case "Add":
                        customList.Add(tokens[1]);
                        break;
                    case"Remove":
                        customList.Remove(int.Parse(tokens[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(customList.Contains(tokens[1]));
                        break;
                    case "Swap":
                        customList.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(customList.CountGreaterThan(tokens[1]));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Print":
                        foreach (var item in customList)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "Sort":
                        customList = Sorter.Sort(customList);
                        break;
                }
            }
        }
    }
}
