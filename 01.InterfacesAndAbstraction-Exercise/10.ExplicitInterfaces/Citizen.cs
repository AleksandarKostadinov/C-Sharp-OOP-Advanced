
namespace _10.ExplicitInterfaces
{
    class Citizen : IPerson , IResident
    {
        private string name;

        public Citizen(string name ,string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set { this.name = value; }
        }

        public string Country { get; }

        public int Age { get; }

        string IPerson.Name
        {
            get {return  this.Name; }
        }

        string IResident.Name
        {
            get { return this.Name; }
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
        
        string IPerson.GetName()
        {
            return $"{this.Name}";
        }
    }
}
