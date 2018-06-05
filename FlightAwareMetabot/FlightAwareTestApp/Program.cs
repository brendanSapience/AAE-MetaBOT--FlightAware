using System;
using FlightAwareLib;

namespace FlightAwareTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UsefulMethods methods = new UsefulMethods();

            String JSONResp = methods.GetFlightInfo("DL430", "brendansapience", "somestuff", false);
            Console.WriteLine("Debug:" + JSONResp);
            Console.ReadKey();
        }
    }
}
