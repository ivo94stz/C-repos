using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class Warrior:Character,IAttackable
    {
        public Warrior(string name,Faction faction)
            :base(name, health:100, armor:50,abilityPoints:40,bag: new Satchel(20), faction:faction)
        {
        }

        


        public void Attack(Character character)
        {
            if (this.IsAlive == true && character.IsAlive == true)
            {
                if (character.Name == this.Name) throw new InvalidOperationException("Cannot attack self!");
                else if (character.Faction == this.Faction) throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
                else
                {
                    character.TakeDemage(this.AbilityPoints);
                }
                
            }
            else throw new InvalidOperationException("Must be alive to perform this action!");

        }
    }
}
