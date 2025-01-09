using System;
using System.Net.Http.Headers;
using oopConceptsHugo;
public class Controler
{
    public static void Main()
    {
        SmartHouse myHause = new SmartHouse("Av. Street Avenue 347", 3, 9.638);
        myHause.Clean();
        Console.WriteLine(myHause.EnergyConsumption);
        myHause.LaundryTime();
    }
}