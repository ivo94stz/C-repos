﻿using System;
using System.Text;

public abstract class Harvester : Participant
{
    private double oreOutput;
    private double energyRequirement;

    public Harvester(string id,double oreOutput,double energyRequirement) 
        : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double OreOutput
    {
        get { return oreOutput; }
        protected set {
            if (value < 0) throw new ArgumentException($"Harvester is not registered, because of it's OreOutput");
            oreOutput = value; }
    }
    

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        protected set {
            if (value < 0 || value > 20000) throw new ArgumentException($"Harvester is not registered, because of it's EnergyRequirement");
            energyRequirement = value; }
    }





}