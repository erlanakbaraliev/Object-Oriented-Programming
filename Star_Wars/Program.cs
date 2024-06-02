using Microsoft.Reporting.Map.WebForms.BingMaps;
using Star_Wars;
using System.Numerics;
using TextFile;

namespace Star_Wars
{
    public class WrongShipTypeException: Exception;
    internal class Program
    {
        
        static void Main(string[] args)
        {   
            SolarSystem solarSystem = new SolarSystem();

            solarSystem.MaxPowerShip();
            solarSystem.Unprotected();

            Console.WriteLine("Total shields guarding " + solarSystem.planets[0].GetName() + ": " + solarSystem.planets[0].TotalShield());
        }
    }
}