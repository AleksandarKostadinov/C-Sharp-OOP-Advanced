using System;

namespace _04.Telephony
{
    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split();

            var URLs = Console.ReadLine()
                .Split();

            var smartPhone = new Smartphone();

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    Console.WriteLine(smartPhone.Call(numbers[i]));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            for (int i = 0; i < URLs.Length; i++)
            {
                try
                {
                    Console.WriteLine(smartPhone.Visit(URLs[i]));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
