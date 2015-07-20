using System;
using System.Collections.Generic;

public class MainProgram
{
    public static void Main()
    {
        CoinJar jar = new CoinJar();
        Coin newCoin = null;

        Console.WriteLine("Coin Jar initialized:");
        jar.PrintJarDetail();
        Console.WriteLine("Total Value: " + jar.TotalValue);
        Console.WriteLine("Used Volume: " + jar.UsedVolume);
        Console.WriteLine();

        Console.WriteLine("Creating valid coin value of 25c");
        newCoin = jar.DetectValidCoin(25);
        Console.WriteLine("Coin create status: " + (newCoin != null));
        Console.WriteLine();

        Console.WriteLine("Creating invalid coin value of 35c");
        newCoin = jar.DetectValidCoin(35);
        Console.WriteLine("Coin create status: " + (newCoin != null));
        Console.WriteLine();

        Console.WriteLine("Adding testing coins:");
        jar.AddCoin(jar.DetectValidCoin(1));
        jar.AddCoin(jar.DetectValidCoin(1));
        jar.AddCoin(jar.DetectValidCoin(5));
        jar.AddCoin(jar.DetectValidCoin(5));
        jar.AddCoin(jar.DetectValidCoin(10));
        jar.AddCoin(jar.DetectValidCoin(10));
        jar.AddCoin(jar.DetectValidCoin(25));
        jar.AddCoin(jar.DetectValidCoin(25));

        jar.PrintJarDetail();
        Console.WriteLine("Total Value: " + jar.TotalValue);
        Console.WriteLine("Used Volume: " + jar.UsedVolume);
        Console.WriteLine();

        Console.WriteLine("Reset Coin Jar:");
        jar.ResetJar();
        jar.PrintJarDetail();
        Console.WriteLine("Total Value: " + jar.TotalValue);
        Console.WriteLine("Used Volume: " + jar.UsedVolume);
        Console.WriteLine();

        Console.WriteLine("Testing Coin Jar overflow!");
        for (int i = 0; i <= jar.TotalVolume / 0.027f; i++)
        {
            jar.AddCoin(jar.DetectValidCoin(25));
        }

        Console.Read();
    }
}