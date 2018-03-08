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
        private static string tireSize = "";        //Store size value.
        private static string tireBrand = "";       //Store brand value.
        private static string installDate = "";     //Store install date value.
        private static string prevRotate = "";      //Store previous rotate date value.
        private static string rotateMessage = "Michelin Recomends: During rotation, each tire and wheel is removed from your " +
            "vehicle and moved to a different position to ensure that all tires wear evenly and last longer. " +
            "Tires should be rotated every six months or 6,000 to 8,000 miles.";

        //Array list to hold the tire values. 
        private static string[] tireValues = new string[6];

        //Move array and tire options varibables here.
        private static int rotateMilage;    //Hold set rotation value.
        private static int tStored;

        //Gets and sets.
        public int RotateMilage { get => rotateMilage; set => rotateMilage = value; }
        public string[] TireValues { get => tireValues; set => tireValues = value; }
        public string TireSize { get => tireSize; set => tireSize = value; }
        public string TireBrand { get => tireBrand; set => tireBrand = value; }
        public string InstallDate { get => installDate; set => installDate = value; }
        public string PrevRotate { get => prevRotate; set => prevRotate = value; }
        public string RotateMessage { get => rotateMessage; set => rotateMessage = value; }
        public int TStored { get => tStored; set => tStored = value; }
    }
}
