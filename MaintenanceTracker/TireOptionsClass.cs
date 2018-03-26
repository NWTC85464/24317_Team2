using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceTracker
{
    class TireOptionsClass
    {
        //Variables.   
        private static string rotateMessage = "Michelin Recomends: During rotation, each tire and wheel is removed from your " +
            "vehicle and moved to a different position to ensure that all tires wear evenly and last longer. " +
            "Tires should be rotated every six months or 6,000 to 8,000 miles.";

        //Array list to hold the tire values. 
        private static string[] vehical1Values = new string[3];
        private static string[] vehical2Values = new string[3];
        private static string[] vehical3Values = new string[3];
        private static string[] vehical4Values = new string[3];

        //Move array and tire options varibables here.
        private static int v1Stored;
        private static int v2Stored;
        private static int v3Stored;
        private static int v4Stored;

        //Gets and sets.
        public int V1Stored { get => v1Stored; set => v1Stored = value; }
        public int V2Stored { get => v2Stored; set => v2Stored = value; }
        public int V3Stored { get => v3Stored; set => v3Stored = value; }
        public int V4Stored { get => v4Stored; set => v4Stored = value; }        
        public string RotateMessage { get => rotateMessage; set => rotateMessage = value; }
        public string[] Vehical1Values { get => vehical1Values; set => vehical1Values = value; }
        public string[] Vehical2Values { get => vehical2Values; set => vehical2Values = value; }
        public string[] Vehical3Values { get => vehical3Values; set => vehical3Values = value; }
        public string[] Vehical4Values { get => vehical4Values; set => vehical4Values = value; }
    }
}
