﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class ArmorRepairKit : Item
    {
        public ArmorRepairKit(int weight)
            : base(weight=10)
        {
        }


        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);
            character.Armor = character.BaseArmor;
        }
    }
}
