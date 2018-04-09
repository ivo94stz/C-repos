using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class Cleric :Character, IHealable
    {
        public Cleric(string name, Faction faction)
            :base(name, health: 50, armor:25,abilityPoints:40,bag: new Backpack(100),faction: faction)
        {
            
        }

        protected override double RestHealMultiplier => 0.5;




        public void Heal(Character character)
        {
            if (this.IsAlive == true && character.IsAlive == true)
            {
                if (this.Faction != character.Faction) throw new InvalidOperationException("Cannot heal enemy character!");
                else
                {
                    character.Health += this.AbilityPoints;
                    if (character.Health > character.BaseHealth) character.Health = character.BaseHealth;
                }
            }
            else throw new InvalidOperationException("Must be alive to perform this action!");
        }
    }
}
