using System;

namespace _10.ExplicitInterfaces
{
    public class StartUp
    {
        public static void Main()
        {
            string input;
            
            while ((input = Console.ReadLine()) != "End")
            {
                var toknes = input.Split();

                var citizen = new Citizen(toknes[0], toknes[1], int.Parse(toknes[2]));

                var iPerson = (IPerson) citizen;
                var iResident = (IResident) citizen;

                Console.WriteLine(iPerson.GetName());
                Console.WriteLine(iResident.GetName());
            }
        }
    }
}
