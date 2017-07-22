namespace _05.BorderControl
{
    public class Pet : ICreature 
    {
        public Pet(string name, string birthDay)
        {
            this.Name = name;
            this.BirthDay = birthDay;
        }
        public string Name { get; }
        public string BirthDay { get; }
    }
}
