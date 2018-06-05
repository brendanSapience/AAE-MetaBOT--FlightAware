using System;
using FlightAwareLib;

namespace FlightAwareTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UsefulMethods methods = new UsefulMethods();

            String JSONResp = methods.GetFlightInfo("DL430", "brendansapience", "21fec579110cd763138e9e797c43c1a23db27ecd", false);
            //String JSONResp = VisibleMethods.GetAirportDelays("YUL", "brendansapience", "21fec579110cd763138e9e797c43c1a23db27ecd");
            Console.WriteLine("Debug:" + JSONResp);
            Console.ReadKey();
        }
    }
}
