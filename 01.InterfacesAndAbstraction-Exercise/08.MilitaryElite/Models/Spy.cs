using System;
using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class Spy : Soldier , ISpy
    {
        public Spy(string id, string firstName, string lastname, int codeNumber) : base(id, firstName, lastname)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Code Number: {this.CodeNumber}";
        }
    }
}
