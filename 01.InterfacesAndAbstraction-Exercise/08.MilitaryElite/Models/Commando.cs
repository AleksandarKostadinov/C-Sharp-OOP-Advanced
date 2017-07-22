using System.Collections.Generic;
using System.Text;
using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier , ICommando
    {
        public Commando(string id, string firstName, string lastname, double salary, string corps, IList<IMission> missions)
            : base(id, firstName, lastname, salary, corps)
        {
            this.Missions = missions;
        }

        public IList<IMission> Missions { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");
            foreach (var mission in Missions)
            {
                sb.AppendLine(mission.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
