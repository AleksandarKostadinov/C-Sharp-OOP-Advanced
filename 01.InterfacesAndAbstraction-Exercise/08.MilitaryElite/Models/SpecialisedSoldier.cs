using System;
using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisetSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastname, double salary, string corps) : base(id, firstName, lastname, salary)
        {
            this.Corps = corps;
        }

        public string Corps { get; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {this.Corps}";
        }
    }
}
