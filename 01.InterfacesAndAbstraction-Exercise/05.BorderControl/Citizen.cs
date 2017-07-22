using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BorderControl
{
    public class Citizen : IIdentifiable , ICreature, IBuyer
    {
        public Citizen(string name, int age, string id, string birthDay)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDay = birthDay;
            this.Food = 0;
        }
        public  string Name { get;}
        public string BirthDay { get; }
        public int Age { get; }
        public string Id { get; }

        public int Food { get; protected set; }
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
