using System;
using System.Linq;

namespace _04.Telephony
{
    public class Smartphone : IBrowsable, ICallable
    {
        public string Visit(string url)
        {
            if (url.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {url}!";
        }

        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(c => char.IsDigit(c)))
            {
                throw new ArgumentException("Invalid number!");
            }

            return $"Calling... {phoneNumber}";
        }
    }
}
