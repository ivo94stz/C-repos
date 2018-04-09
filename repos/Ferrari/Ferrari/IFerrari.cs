using System;
using System.Collections.Generic;
using System.Text;


public interface IFerrari
{
    string Model { get; }

    string Driver { get; }

    string Brakes();

    string Gas();

}
