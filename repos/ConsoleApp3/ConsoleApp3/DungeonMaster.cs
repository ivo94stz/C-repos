using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DungeonsAndCodeWizards
{
    public class DungeonMaster
    {
        List<Item> itemPool = new List<Item>();
        List<Character> characters = new List<Character>();

        public string JoinParty(string[] args)
        {
            Faction faction = new Faction(args[0]);
            string factions = faction.ToString();
            string characterType = args[1];
            string name = args[2];

            

            if (factions != "CSharp" && factions != "Java") throw new ArgumentException($"Invalid faction {faction}");
            
            
            if (characterType == "Warrior")
            {
                Warrior warrior = new Warrior(name, faction);
                characters.Add(warrior);
            }
            else if (characterType == "Cleric")
            {
                Cleric cleric = new Cleric(name, faction);
                characters.Add(cleric);
            }
            else throw new ArgumentException($"Invalid character type {characterType}");

            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string itemName = args[0];
            
            if(itemName=="HealthPotion")
            {
                HealthPotion healthPotion = new HealthPotion(5);
                itemPool.Add(healthPotion);
            }
            else if(itemName == "PoisonPotion")
            {
                PoisonPotion poisonPotion = new PoisonPotion(5);
                itemPool.Add(poisonPotion);
            }
            else if(itemName == "ArmorRepairKit")
            {
                ArmorRepairKit armorRepairKit = new ArmorRepairKit(10);
                itemPool.Add(armorRepairKit);
            }
            else throw new ArgumentException($"Invalid item {itemName}");

            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string characterName = args[0];
            ArgumentException error = new ArgumentException($"Character {characterName} not found!");
            bool isCharThere = false;
            string itemName="";

            if (itemPool.Count == 0) throw new InvalidOperationException("No items left in pool!");
            
            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].Name == characterName)
                {
                    isCharThere = true;
                    characters[i].Bag.AddItem(itemPool.Last());
                    itemName = characters[i].Bag.Items.Last().GetType().Name.ToString();
                    break;
                }
            }
            if (isCharThere == false) throw new ArgumentException($"Character {characterName} not found!");


            return $"{characterName} picked up {itemName}!";

        }

        public string UseItem(string[] args)
        {
            throw new NotImplementedException();
        }

        public string UseItemOn(string[] args)
        {
            string giverName = args[0];
            string receiverName = args[1];
            string itemName = args[2];

            Character giver = characters.First(c => c.Name == giverName);
            Character reciever = characters.First(c => c.Name == receiverName);
            Item usingItem = giver.Bag.Items.First(i => i.GetType().Name == itemName);

            giver.UseItemOn(usingItem, reciever);


            return $"{giverName} used {itemName} on {receiverName}.";
        }

        public string GiveCharacterItem(string[] args)
        {
            throw new NotImplementedException();
        }

        public string GetStats()
        {
            throw new NotImplementedException();
        }

        public string Attack(string[] args)
        {
            throw new NotImplementedException();
        }

        public string Heal(string[] args)
        {
            throw new NotImplementedException();
        }

        public string EndTurn(string[] args)
        {
            throw new NotImplementedException();
        }

        public bool IsGameOver()
        {
            throw new NotImplementedException();
        }

        private Character FindCharacter(string name)
        {
            var character = this.characters.FirstOrDefault(e => e.Name == name);

            if (character == null)
            {
                throw new ArgumentException($"Character {name} not found!");
            }

            return character;
        }

    }
}
