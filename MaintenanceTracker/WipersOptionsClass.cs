using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceTracker
{
    class Wiper
    {
        int vehicleN;
        string installedDate;
        string nextInstallationDate;
        double dSize;
        double pSize;
        double rSize;
        string bName;
        string n;

        
        public Wiper(int vN, string iDate, string nextDate, double driverSize, double passagerSize, double rearSize, string brandName, string notes)
        {
            this.vehicleN = vN;
            this.installedDate = iDate;
            this.nextInstallationDate = nextDate;
            this.dSize = driverSize;
            this.pSize = passagerSize;
            this.rSize = rearSize;
            this.bName = brandName;
            this.n = notes;
        }

        public int vNumber { get { return vehicleN; } }
        public string Install { get { return installedDate; } }
        public string Next { get { return nextInstallationDate; } }
        public double Driver { get { return dSize; } }
        public double Passager { get { return pSize; } }
        public double Rear { get { return rSize; } }
        public string Brand { get { return bName; } }
        public string Notes { get { return n; } }

      
    }
}
