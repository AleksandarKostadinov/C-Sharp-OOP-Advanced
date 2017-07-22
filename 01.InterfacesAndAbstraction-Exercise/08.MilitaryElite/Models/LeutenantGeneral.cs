using System.Collections.Generic;
using System.Text;
using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class LeutenantGeneral : Private , ILeutenantGeneral
    {
        public LeutenantGeneral(string id, string firstName, string lastname, double salary, IList<ISoldier> soldiers) 
            : base(id, firstName, lastname, salary)
        {
            this.Soldiers = soldiers;
        }

        public IList<ISoldier> Soldiers { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var soldier in Soldiers)
            {
                sb.Append("  ");
                sb.AppendLine(soldier.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
