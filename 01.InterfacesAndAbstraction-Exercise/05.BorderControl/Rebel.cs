namespace _05.BorderControl
{
    class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }

        public int Food { get; protected set; }
        public string Name { get; }
        public int Age { get; }
        public string Group { get; }

        public void BuyFood()
        {
            this.Food += 5;
        }

    }
}
