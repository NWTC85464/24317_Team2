using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceTracker.Classes
{
    class Vehicle
    {
        int _id;
        string _carMake;
        string _carModel;
        int _odo;

        public Vehicle(int id, string firstName, string lastName, int salary)
        {
            this._id = id;
            this._carMake = firstName;
            this._carModel = lastName;
            this._odo = salary;
        }

        public int Id { get { return _id; } }
        public string FirstName { get { return _carMake; } }
        public string LastName { get { return _carModel; } }
        public int Salary { get { return _odo; } }
    }
}
