using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class PoisonPotion : Item
    {
        public PoisonPotion(int weight)
            : base(weight=5)
        {
        }

        public override void AffectCharacter(Character character)
        {

            base.AffectCharacter(character);
            character.Health = Math.Max(0, character.Health - 20);
            if (character.Health == 0)
            {
                character.IsAlive = false;
            }
        }

    }
}
