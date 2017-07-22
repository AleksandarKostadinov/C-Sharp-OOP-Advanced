using System.Collections.Generic;

namespace _08.MilitaryElite.Interfaces
{
    public interface ICommando : ISpecialisetSoldier
    {
        IList<IMission> Missions { get; }
    }
}
