using System;
using System.Collections.Generic;
using System.Text;


public class FoodFactory : Food
{
    
    public FoodFactory(List<string> name)
        : base(name)
    {
       
    }

    public string CalculatePoints(List<string> names)
    {
        int result = 0;
        this.Name = names;
        for (int i = 0; i < this.Name.Count; i++)
        {
            if (this.Name[i] == "cram") result += 2;
            else if (this.Name[i] == "lembas") result += 3;
            else if (this.Name[i] == "apple") result += 1;
            else if (this.Name[i] == "melon") result += 1;
            else if (this.Name[i] == "honeycake") result += 5;
            else if (this.Name[i] == "mushrooms") result -= 10;
            else result -= 1;
        }

        if (result < -5) return ($"{result}" + Environment.NewLine + "Angry");
        else if (result >= -5 && result <= 0) return $"{result}" + Environment.NewLine + "Sad";
        else if (result >= 1 && result <= 15) return $"{result}" + Environment.NewLine + "Happy";
        return $"{result}" + Environment.NewLine + "JavaScript";
        
    }

}

