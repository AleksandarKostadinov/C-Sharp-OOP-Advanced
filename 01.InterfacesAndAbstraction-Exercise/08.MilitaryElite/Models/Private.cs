using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastname, double salary) : base(id, firstName, lastname)
        {
            this.Salary = salary;
        }

        public double Salary { get; }

        public override string ToString()
        {
            return base.ToString() + $"Salary: {this.Salary:f2}";
        }
    }
}
