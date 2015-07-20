using System;
using System.Collections.Generic;

public class CoinJar
{
    private List<Coin> Coins { get; set; }

    public float TotalVolume { get; private set; }

    public float UsedVolume { get; private set; }

    public float TotalValue { get; private set; }

    public CoinJar()
    {
        this.Coins = new List<Coin>();
        this.TotalValue = 0;
        this.TotalVolume = 32f;
        this.UsedVolume = 0f;
    }

    public Coin DetectValidCoin(int value)
    {
        switch(value)
        {
            case 1:
                return new Coin(value, 0.0122f);
            case 5:
                return new Coin(value, 0.0243f);
            case 10:
                return new Coin(value, 0.0115f);
            case 25:
                return new Coin(value, 0.027f);
            default:
                break;
        }
        return null;
    }

    public bool AddCoin(Coin coin)
    {
        if (coin == null)
        {
            return false;
        }

        if (coin.Volume + this.UsedVolume > this.TotalVolume)
        {
            Console.WriteLine("Coin jar is full!");
            return false;
        }

        this.Coins.Add(coin);
        this.TotalValue += coin.Value;
        this.UsedVolume += coin.Volume;

        return true;
    }

    public void ResetJar()
    {
        this.Coins = new List<Coin>();
        this.TotalValue = 0;
        this.UsedVolume = 0f;
    }

    public void PrintJarDetail()
    {
        if (this.Coins.Count != 0)
        {
            foreach (Coin coin in this.Coins)
            {
                Console.WriteLine("Coin No." + this.Coins.IndexOf(coin) + ":\t" + coin.Value);
            }
        }
        else
            Console.WriteLine("Coin Jar is empty!");
    }
}
