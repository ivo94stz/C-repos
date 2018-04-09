using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>();
            List<Private> privateSoldiers = new List<Private>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split();
                string id = info[1];
                string firtsName = info[2];
                string lastName = info[3];

                if (info[0] == "Private")
                {
                    double salary = double.Parse(info[4]);

                    Private privates = new Private(id, firtsName, lastName, salary);
                    privateSoldiers.Add(privates);
                    soldiers.Add(privates);
                }
                else if (info[0] == "LeutenantGeneral")
                {
                    double salary = double.Parse(info[4]);
                    List<string> privateIds = new List<string>();

                    privateIds.AddRange(info.Skip(5));
                    
                    LeutenantGeneral leutenant = new LeutenantGeneral(id, firtsName, lastName, salary, privateSoldiers,privateIds);

                    soldiers.Add(leutenant);
                }
                else if (info[0] == "Engineer")
                {
                    double salary = double.Parse(info[4]);
                    string corps = info[5];
                    if (corps != "Airforces" && corps != "Marines") continue;
                    Dictionary<string, int> repairs = new Dictionary<string, int>();
                    List<string> reps = new List<string>();
                    reps.AddRange(info.Skip(6));
                    for (int i = 0; i < reps.Count; i+=2)
                    {
                        string repairPart = reps[i];
                        int repairHours = int.Parse(reps[i + 1]);

                        repairs[repairPart] = repairHours;
                    }
                    Engineer engineer = new Engineer(id, firtsName, lastName, salary,corps, repairs);

                    soldiers.Add(engineer);
                }
                else if (info[0] == "Commando")
                {
                    double salary = double.Parse(info[4]);
                    string corps = info[5];
                    if (corps != "Airforces" && corps != "Marines") continue;

                    Dictionary<string, string> missions = new Dictionary<string, string>();
                    List<string> miss = new List<string>();
                    miss.AddRange(info.Skip(6));
                    for (int i = 0; i < miss.Count; i+=2)
                    {
                        string codeName = miss[i];
                        string state = miss[i + 1];
                        if (state != "inProgress" && state != "Finished") continue;
                        else missions[codeName] = state;
                    }
                    Commando commando = new Commando(id, firtsName, lastName, salary,corps, missions);

                    soldiers.Add(commando);
                }
                else if (info[0] == "Spy")
                {
                    int codeNumber = int.Parse(info[4]);
                    Spy spy = new Spy(id, firtsName, lastName, codeNumber);

                    soldiers.Add(spy);
                }
                
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }

        }
    }
}
