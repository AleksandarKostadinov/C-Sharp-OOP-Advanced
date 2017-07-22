using _08.MilitaryElite.Interfaces;

namespace _08.MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public string CodeName { get; }
        public string State { get; }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
