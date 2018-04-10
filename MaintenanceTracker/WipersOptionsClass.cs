using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceTracker
{
    class WipersOptionsClass
    {
        //Array list to hold the tire values. 
        private static string[] vehicle1Values = new string[3];
        private static string[] vehicle2Values = new string[3];
        private static string[] vehicle3Values = new string[3];
        private static string[] vehicle4Values = new string[3];

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
        //public string RotateMessage { get => rotateMessage; set => rotateMessage = value; }
        public string[] Vehicle1Values { get => vehicle1Values; set => vehicle1Values = value; }
        public string[] Vehicle2Values { get => vehicle2Values; set => vehicle2Values = value; }
        public string[] Vehicle3Values { get => vehicle3Values; set => vehicle3Values = value; }
        public string[] Vehicle4Values { get => vehicle4Values; set => vehicle4Values = value; }
    }
}
