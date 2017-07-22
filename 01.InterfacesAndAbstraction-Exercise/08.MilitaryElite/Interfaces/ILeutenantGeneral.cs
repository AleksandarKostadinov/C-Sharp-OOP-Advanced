using System.Collections.Generic;
namespace _08.MilitaryElite.Interfaces
{
    public interface ILeutenantGeneral : IPrivate
    {
        IList<ISoldier> Soldiers { get; }
    }
}
