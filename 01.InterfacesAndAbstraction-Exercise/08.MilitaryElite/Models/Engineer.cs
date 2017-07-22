using System.Collections.Generic;
using System.Text;
using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastname, 
            double salary, string corps, IList<IRepair> repairs) 
                : base(id, firstName, lastname, salary, corps)
        {
            this.Repairs = repairs;
        }

        public IList<IRepair> Repairs { get; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");
            foreach (var repair in Repairs)
            {
                sb.AppendLine(repair.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
