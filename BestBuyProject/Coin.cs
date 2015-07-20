using System;
using System.Collections.Generic;

public class Coin
{
    public int Value { get; private set; }

    public float Volume { get; private set; }

    public Coin(int value, float volume)
    {
        this.Value = value;
        this.Volume = volume;
    }
}
