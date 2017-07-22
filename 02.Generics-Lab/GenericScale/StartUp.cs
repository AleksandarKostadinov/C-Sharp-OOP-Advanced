using System;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main()
        {
            var scale = new Scale<int>(10 , 10);

            Console.WriteLine(scale.GetHavier());
        }
    }
}
