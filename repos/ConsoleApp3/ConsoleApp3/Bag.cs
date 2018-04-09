using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public abstract class Bag
    {
        protected Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        protected int Capacity { get; }

        private readonly List<Item> items;

        public IReadOnlyCollection<Item> Items
        {
            get { return this.items.AsReadOnly(); }
        }


        private int load;

        public int Load
        {
            get { return load; }
            set {
                value = this.Items.Sum(i => i.Weight);

                load = value; }
        }


        public void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.Capacity) throw new InvalidOperationException("Bag is full!");
            else
            {
                this.items.Add(item);
            }
        }

        public Item  GetItem(string name)
        {
            if (this.Items.Count == 0) Console.WriteLine("Bag is empty!");

            var itemExists = this.Items.Any(i => i.GetType().Name == name);
            if (!itemExists)
            {
                throw new ArgumentException($"No item with name {name} in bag!");
            }

            var item = this.items.First(t => t.GetType().Name == name);
            this.items.Remove(item);
            return item;

        }
    }
}
