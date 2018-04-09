using System;
using System.Collections.Generic;
using System.Text;


public class HarversterFactory
{
    public Harvester GetHarvester(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double oreOutput = double.Parse(arguments[2]);
        double energyRequirement = double.Parse(arguments[3]);

        if (type == "Hammer")
        {
            return new HammerHarvester(id, oreOutput, energyRequirement);
        }
        else if (type == "Sonic")
        {
            int sonicFactor = int.Parse(arguments[4]);
            return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
        }
        else throw new ArgumentException("Harvester creation error.");

    }
}
