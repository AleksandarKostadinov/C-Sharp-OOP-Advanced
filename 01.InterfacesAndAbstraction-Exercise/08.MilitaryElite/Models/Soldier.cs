using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public abstract class Soldier : ISoldier
    {
        protected Soldier(string id, string firstName, string lastname)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.Lastname = lastname;
        }

        public string ID { get; }
        public string FirstName { get; }
        public string Lastname { get; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.Lastname} Id: {this.ID} ";
        }
    }
}
