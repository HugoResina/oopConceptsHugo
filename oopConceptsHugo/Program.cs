using System;
using System.Net.Http.Headers;
using oopConceptsHugo;
public class Controler
{
    public static void Main()
    {
        SmartHouse myHause = new SmartHouse("sdd", 4, 4.4);
        myHause.Clean();
        Console.WriteLine(myHause.EnergyConsumption);

    }
}