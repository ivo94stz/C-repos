using System;
using System.Linq;

namespace DungeonsAndCodeWizards
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DungeonMaster dungeonMaster = new DungeonMaster();
            string input;

            while ((input = Console.ReadLine()) != "EndTurn")
            {
                string[] info = input.Split();

                
                if (info[0] == "JoinParty")
                {
                    try
                    {
                        Console.WriteLine(dungeonMaster.JoinParty(info.Skip(1).ToArray()));
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (info[0] == "AddItemToPool")
                {
                    try
                    {
                        Console.WriteLine(dungeonMaster.AddItemToPool(info.Skip(1).ToArray()));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (info[0] == "PickUpItem")
                {
                    try
                    {
                        Console.WriteLine(dungeonMaster.PickUpItem(info.Skip(1).ToArray()));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                
            }

            
        }
    }
}
