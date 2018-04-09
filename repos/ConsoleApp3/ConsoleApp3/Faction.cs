using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class  Faction
    {
        public Faction(string name)
        {
            this.Name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set {if (value != "CSharp" && value != "Java") throw new ArgumentException("Invalid faction!");
                name = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
