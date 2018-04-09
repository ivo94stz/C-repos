using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private decimal money;
    private List<Product> bagOfProducts;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.bagOfProducts = new List<Product>();
    }

    public string Name
    {
        get { return this.name; }
        private set {
            if(value==null||value==""||value==" ")
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value; }
    }

    public decimal Money
    {
        get { return this.money; }
        private set {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value; }
    }

    public string TryBuyProduct(Product product)
    {
        if (this.money < product.cost)
        {
            return $"{this.Name} cannot afford {product.Name}";
        }
        else
        {
            this.Money -= product.Cost;
            this.bagOfProducts.Add(product);

            return "{this.Name} bought {product.Name}";
        }
    }
    public override string ToString()
    {
        string products = this.bagOfProducts.Count > 0 ? string.Join(", ", this.bagOfProducts) : "Nothing bought";
        string result = $"{this.Name} - {products}";
        return result;
    }

}
    

