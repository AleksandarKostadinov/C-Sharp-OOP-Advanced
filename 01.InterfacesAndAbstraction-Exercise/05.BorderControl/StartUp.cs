using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BorderControl
{
    public class StartUp
    {
        public static void Main()
        {
            
            var buyers = new List<IBuyer>();

            var numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                var input = Console.ReadLine();
                var tokens = input.Split();

                if (tokens.Length == 4)
                {
                    buyers.Add(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }
                else if (tokens.Length == 3)
                {
                    buyers.Add(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }
            var peopleBuyingInput = Console.ReadLine();

            while (peopleBuyingInput != "End")
            {
                var currentBuyer = buyers.FirstOrDefault(b => b.Name == peopleBuyingInput.Trim());

                if (currentBuyer != null)
                {
                    currentBuyer.BuyFood();
                }

                peopleBuyingInput = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b => b.Food));
        }
    }
}
