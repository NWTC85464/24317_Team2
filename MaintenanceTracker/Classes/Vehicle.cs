namespace MaintenanceTracker.Classes
{
    class Vehicle
    {
        private int _id;
        private string _carMake;
        private string _carModel;
        private int _odo;

        public Vehicle(int id, string make, string model, int odo)
        {
            this._id = id;
            this._carMake = make;
            this._carModel = model;
            this._odo = odo;
        }

        public int Id { get { return _id; } }
        public string Make { get { return _carMake; } }
        public string Model { get { return _carModel; } }
        public int ODO { get { return _odo; } }
    }
}
