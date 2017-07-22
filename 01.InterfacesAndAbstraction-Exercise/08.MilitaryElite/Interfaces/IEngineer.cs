using System.Collections.Generic;

namespace _08.MilitaryElite.Interfaces
{
    public interface IEngineer : ISpecialisetSoldier
    {
        IList<IRepair> Repairs { get; }
    }
}
