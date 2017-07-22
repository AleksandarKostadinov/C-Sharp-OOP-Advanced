using System.IO.IsolatedStorage;
using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string name, int workHours)
        {
            this.Name = name;
            this.WorkHours = workHours;
        }
        public string Name { get; }
        public int WorkHours { get; }

        public override string ToString()
        {
            return $"  Part Name: {this.Name} Hours Worked: {this.WorkHours}";
        }
    }
}
