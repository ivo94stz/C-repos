using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public abstract class Character
    {

        protected Character(string name, double health, double armor, double abilityPoints, Bag bag,Faction faction )
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
            this.RestHealMultiplier = 0.2;
        }

        
        private string name;

        public string Name
        {
            get { return name; }
            set {
                if (value == "" || value == " ") throw new ArgumentException("Name cannot be null or whitespace!");
                name = value; }
        }
        public double BaseHealth { get; set; }

        private double health;

        public double Health
        {
            get { return health; }
            set {
                if (value <= 0 && value > this.BaseHealth) throw new ArgumentException("Invalid Health!");
                health = value; }
        }


        public double BaseArmor { get; set; }

        private double armor;

        public double Armor
        {
            get { return armor; }
            set {
                if (value <= 0 && value > this.BaseArmor) throw new ArgumentException("Invalid Armor");
                armor = value; }
        }


        public double AbilityPoints { get; set; }

        public Bag Bag { get; set; }

        public Faction Faction { get; set; }

        public bool IsAlive = true;

        protected virtual double RestHealMultiplier { get; set; }


        public void TakeDemage(double hitPoints)
        {
            if (this.IsAlive == true)
            {
                if (hitPoints <= this.Armor)
                {
                    this.Armor -= hitPoints;
                    
                }
                    
                else
                {
                    this.Armor = 0;
                    hitPoints -= Armor;
                    this.Health -= hitPoints;
                    if (this.Health <= 0) IsAlive = false;
                }
            }
            else
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }
        public void Rest()
        {
            if (IsAlive == true)
            {
                this.Health += this.BaseHealth * this.RestHealMultiplier;
            }
            else throw new InvalidOperationException("Must be alive to perform this action!");
        }

        public void UseItem(Item item)
        {
            if (this.IsAlive == true)
            {
                item.AffectCharacter(this);
            }
            else throw new InvalidOperationException("Must be alive to perform this action!");
        }

        public void UseItemOn(Item item, Character character)
        {
            if (character.IsAlive == true&&this.IsAlive==true)
            {
                item.AffectCharacter(character);
            }
            else throw new InvalidOperationException("Must be alive to perform this action!");
        }

        public void GiveCharacterItem(Item item,Character character)
        {
            if (this.IsAlive == true&&character.IsAlive==true)
            {
                character.RecieveItem(item);
            }
            else throw new InvalidOperationException("Must be alive to perform this action!");
        }

        public void RecieveItem(Item item)
        {
            if (IsAlive == true)
            {
                this.Bag.AddItem(item);
            }
            else throw new InvalidOperationException("Must be alive to perform this action!");
        }

    }
}
