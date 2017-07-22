using System;
using System.Collections.Generic;
using System.Linq;
using _08.MilitaryElite.Interfaces;
using _08.MilitaryElite.Models;

namespace _08.MilitaryElite
{
    public class StartUp
    {
        public static IList<ISoldier> army;
        public static void Main()
        {
            army = new List<ISoldier>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var tokens = input.Split();

                switch (tokens[0])
                {
                    case "Private":
                        army.Add(new Private(tokens[1], tokens[2], tokens[3],double.Parse(tokens[4])));
                        break;
                    case "LeutenantGeneral":
                        var privates = ExtractPrivates(tokens.Skip(5).ToList());
                        army.Add(new LeutenantGeneral(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]), privates));
                        break;
                    case "Engineer":
                        if (tokens[5] != "Airforces" && tokens[5] != "Marines")
                        {
                            input = Console.ReadLine();
                            continue;
                        }

                        var parts = ExtractParts(tokens.Skip(6).ToList());
                        army.Add(new Engineer(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5], parts));
                        break;

                    case "Commando":
                        if (tokens[5] != "Airforces" && tokens[5] != "Marines")
                        {
                            input = Console.ReadLine();
                            continue;
                        }

                        var missions = ExtractMissions(tokens.Skip(6).ToList());
                        army.Add(new Commando(tokens[1], tokens[2], tokens[3], double.Parse(tokens[4]), tokens[5], missions));
                        break;

                    case "Spy":
                        army.Add(new Spy(tokens[1], tokens[2], tokens[3], int.Parse(tokens[4])));
                        break;
                }


                input = Console.ReadLine();
            }

            foreach (var soldier in army)
            {
                Console.WriteLine(soldier.ToString());
            }
        }

        private static IList<IMission> ExtractMissions(IList<string> missionsInfo)
        {
            var result = new List<IMission>();

            for (int i = 0; i < missionsInfo.Count; i += 2)
            {
                if (missionsInfo[i + 1] != "inProgress" && missionsInfo[i + 1] != "Finished")
                {
                    continue;
                }

                result.Add(new Mission(missionsInfo[i], missionsInfo[i + 1]));
            }

            return result;
        }

        private static IList<IRepair> ExtractParts(IList<string> partsInfo)
        {
            var result = new List<IRepair>();

            for (int i = 0; i < partsInfo.Count; i += 2)
            {
                result.Add(new Repair(partsInfo[i], int.Parse(partsInfo[i + 1])));
            }

            return result;
        }


        private static IList<ISoldier> ExtractPrivates(IList<string> privatesIDs)
        {
            var result = new List<ISoldier>();

            for (int i = 0; i < privatesIDs.Count; i++)
            {
                result.Add(army.FirstOrDefault(s => s.ID == privatesIDs[i]));
            }

            return result;
        }
    }
}
