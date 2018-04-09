using System;
using System.Text;

public abstract class Provider : Participant
{
    private double energyOutput;

    public Provider(string id, double energyOutput) 
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return energyOutput; }
        protected set {
            if (value <= 0 || value > 9999) throw new ArgumentException($"Provider is not registered, because of it's EnergyOutput");
            energyOutput = value; }
    }


}