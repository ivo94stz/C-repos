using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class DraftManager
{
    private string cuurentMode;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private HarversterFactory harvesterFactory;
    private ProviderFactory providerFactory;
    private List<Harvester> harvesters;
    private List<Provider> providers;

    public DraftManager()
    {
        this.cuurentMode = "Full";
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.harvesterFactory = new HarversterFactory();
        this.providerFactory = new ProviderFactory();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            harvesters.Add(this.harvesterFactory.GetHarvester(arguments));
        }
        catch (ArgumentException ex)
        {

            return ex.Message;
        }
        return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";

    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            providers.Add(providerFactory.GetProvider(arguments));
        }
        catch (ArgumentException ex)
        {

            return ex.Message;
        }

        return $"Successfully registered {arguments[0]} Provider - {arguments[1]}";
    }
    public string Day()
    {
        double totalEnergyNeeded = 0;
        double summedOreOutput = 0;
        double summedEnergyOutput = this.providers.Sum(p => p.EnergyOutput);
        this.totalStoredEnergy += summedEnergyOutput;

        if (this.cuurentMode == "Full")
        {
            totalEnergyNeeded = this.harvesters.Sum(h => h.EnergyRequirement);
            if (this.totalStoredEnergy >= totalEnergyNeeded)
            {
                summedOreOutput = this.harvesters.Sum(h => h.OreOutput);
                this.totalMinedOre += summedOreOutput;
                this.totalStoredEnergy -= totalEnergyNeeded;
            }
        }
        else if (this.cuurentMode == "Half")
        {
            totalEnergyNeeded = this.harvesters.Sum(h => h.EnergyRequirement);
            if (this.totalStoredEnergy >= totalEnergyNeeded)
            {
                summedOreOutput = this.harvesters.Sum(h => h.OreOutput);
                this.totalMinedOre += summedOreOutput;
                this.totalStoredEnergy -= totalEnergyNeeded;
            }
        }
        else if (this.cuurentMode == "Energy")
        {

        }
        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.")
            .AppendLine($"Energy Provided: {summedEnergyOutput}")
            .AppendLine($"Plumbus Ore Mined: {summedOreOutput}");

        return sb.ToString();



    }
    public string Mode(List<string> arguments)
    {
        string mode = arguments[0];
        this.cuurentMode = mode;
        return $"Successfully changed working mode to {mode} Mode";
    }
    public string Check(List<string> arguments)
    {
        string id = arguments[0];
        if (this.harvesters.Any(h => h.Id == id))
        {
            return this.harvesters.First(h => h.Id == id).ToString();
        }
        if (this.providers.Any(p => p.Id == id))
        {
            return this.providers.First(p => p.Id == id).ToString();
        }
        return $"No element found with id - {id}";

    }
    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"System Shutdown")
            .AppendLine($"Total Energy Stored: {this.totalStoredEnergy}")
            .AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");

        return sb.ToString();
    }



}
