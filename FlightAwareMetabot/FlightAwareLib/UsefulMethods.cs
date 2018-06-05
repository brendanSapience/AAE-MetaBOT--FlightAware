using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightAwareLib
{
    public class UsefulMethods
    {
        static String URLBase = "http://flightxml.flightaware.com/json/FlightXML3/";

        // Exposing methods that will call underlying Rest endpoints
        // Rest mechanisms should be abstracted to another project used across all solutions
        RestUtils rUtils = new RestUtils();
        // // http://flightxml.flightaware.com/json/FlightXML3/FlightInfoStatus?ident=DL3660&include_ex_data=true
        public String GetFlightInfo(String FlightNumber, String Login, String AuthToken, Boolean showExtraInfo)
        {
            String URLExt = "FlightInfoStatus";
            String URLComposite = URLBase + URLExt + "?ident=" + FlightNumber + "&include_ex_data=" + showExtraInfo;

            String Res = rUtils.CallRestGETWithBasicAuth(URLComposite, Login, AuthToken);

            // Returns JSON as String
            return Res;
        }

        public String GetAirportDelays(String AirportCode, String Login, String AuthToken)
        {
            String URLExt = "AirportDelays";
            String URLComposite = URLBase + URLExt + "?airport_code=" + AirportCode;

            String Res = rUtils.CallRestGETWithBasicAuth(URLComposite, Login, AuthToken);

            // Returns JSON as String
            return Res;
        }
    }
}
