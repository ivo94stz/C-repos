using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class HealthPotion : Item
    {
        public HealthPotion(int weight)
            : base(weight=5)
        {
            
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Health += 20;
        }

    }
}
