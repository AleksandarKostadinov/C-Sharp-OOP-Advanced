using System;

namespace GenericTuples
{
    public class StartUp
    {
        public static void Main()
        {
            var inputTokens = Console.ReadLine().Split();
            var name = $"{inputTokens[0]} {inputTokens[1]}";
            var nameAdress = new Tuple<string, string>(name, inputTokens[2]);
            Console.WriteLine(nameAdress);
            
            inputTokens = Console.ReadLine().Split();
            var personBeer = new Tuple<string, int>(inputTokens[0], int.Parse(inputTokens[1]));
            Console.WriteLine(personBeer);

            inputTokens = Console.ReadLine().Split();
            Console.WriteLine(new Tuple<int,double>(int.Parse(inputTokens[0]), double.Parse(inputTokens[1])));
        }
    }
}
