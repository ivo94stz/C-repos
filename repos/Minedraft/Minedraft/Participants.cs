using System;
using System.Collections.Generic;
using System.Text;

public abstract class Participant
{
    public string Id { get; set; }

    protected Participant(string id)
    {
        this.Id = id;
    }


}
