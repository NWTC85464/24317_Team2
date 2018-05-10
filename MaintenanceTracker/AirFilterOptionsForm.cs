using MaintenanceTracker.Classes;
using MaintenanceTracker.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MaintenanceTracker
{

    public partial class AirFilterOptionsForm : System.Windows.Forms.Form
    {
        //Classes
        MainFormClass mFormClass = new MainFormClass();
        colorThemes cThemes = new colorThemes();

        //Variables
        //Int
        private int _CurrentODOReading = 10000,
            _EngStoredODO = 0, 
            _CabStoredODO = 0,
            _MAX = 30000,
            _EngineMAX = 30000,
            _CabinMAX = 30000,
            _EgnineCount = 0,
            _CabinCount = 0,
            _OneFourth = 0,
            _OneHalf = 0,
            _ThreeFourth = 0,
            _VehicleNumber = 0;

        //Colors
        private Color _PrimaryColor = Color.FromArgb(255, 255, 255),
            _SecondaryColor = Color.FromArgb(255, 255, 255);

        //Strings
        private string _VehicleMake = null,
            _VehicleModel = null,
            _FilePath = @"..\..\Resources\AirFilterData\",
            _FileName = "AirFilterData",
            _FileExtensionType = ".XML";

        public AirFilterOptionsForm()
        {
            InitializeComponent();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            //Instantiate the vehicle object
            Vehicle[] _Vehicle = new Vehicle[5];
            _Vehicle[0] = new Vehicle(0, "", "", 0);
            _Vehicle[1] = new Vehicle(1, "", "", 0);
            _Vehicle[2] = new Vehicle(2, "", "", 0);
            _Vehicle[3] = new Vehicle(3, "", "", 0);
            _Vehicle[4] = new Vehicle(4, "", "", 0);

            //Define the Vehicle Number
            _VehicleNumber = mFormClass.VehicalNumber;
            
            //Switch between the selected vehicle
            switch (mFormClass.VehicalNumber)
            {
                case 1:
                    _VehicleMake = "Ford";
                    _VehicleModel = "Mustange";
                    _Vehicle[_VehicleNumber] = new Vehicle(_VehicleNumber, _VehicleMake, _VehicleModel, _CurrentODOReading);
                    break;
                case 2:
                    _VehicleMake = "Ford";
                    _VehicleModel = "Fiesta";
                    _Vehicle[_VehicleNumber] = new Vehicle(_VehicleNumber, _VehicleMake, _VehicleModel, _CurrentODOReading);
                    break;
                case 3:
                    _VehicleMake = "Subaru ";
                    _VehicleModel = "Outback";
                    _Vehicle[_VehicleNumber] = new Vehicle(_VehicleNumber, _VehicleMake, _VehicleModel, _CurrentODOReading);
                    break;
                case 4:
                    _VehicleMake = "Dodge";
                    _VehicleModel = "Challenger";
                    _VehicleNumber = mFormClass.VehicalNumber;
                    _Vehicle[_VehicleNumber] = new Vehicle(_VehicleNumber, _VehicleMake, _VehicleModel, _CurrentODOReading);
                    break;
                default:
                    _VehicleMake = "Ford";
                    _VehicleModel = "Da-Pinto";
                    _Vehicle[_VehicleNumber] = new Vehicle(_VehicleNumber, _VehicleMake, _VehicleModel, _CurrentODOReading);
                    break;
            }

            //Create XML
            CreateXMLFile(_Vehicle, _FilePath, _FileName, _FileExtensionType, 
                _VehicleNumber, _VehicleMake, _VehicleModel, _CurrentODOReading,
                _EngineMAX, 0, _CabinMAX, 0, _EngStoredODO, _CabStoredODO);

            //Assign the colors
            _PrimaryColor = cThemes.PrimaryColor;
            _SecondaryColor = cThemes.SecondaryColor;

            //Assign Vehicle Values
            //Load the XML file
            XmlDocument _AirFilterData = new XmlDocument();
            _AirFilterData.Load(_FilePath + _FileName + _FileExtensionType);

            XmlElement root = _AirFilterData.DocumentElement;
            XmlNodeList _Nodes = root.SelectNodes("Vehicle_Details");

            foreach (XmlNode _Node in _Nodes)
            {
                if (_Node.Attributes["Vehicle_Number"].Value == _VehicleNumber.ToString())
                {
                    foreach (XmlNode _SubNode in _Node)
                    {
                        //Update the field values
                        if (_SubNode.Name == "Current_ODO") { _CurrentODOReading = Int32.Parse(_SubNode.InnerText); }
                        if (_SubNode.Name == "Cab_Stored_ODO" && _SubNode.InnerText != "") { _CabStoredODO = Int32.Parse(_SubNode.InnerText); }
                        if (_SubNode.Name == "Max_Cab_ODO" && _SubNode.InnerText != "") { _CabinMAX  = Int32.Parse(_SubNode.InnerText); }
                        //if (_SubNode.Name == "Cab_DateFilterChangedLast") { _EngineMAX = Int32.Parse(_SubNode.InnerText); }
                        if (_SubNode.Name == "Eng_Stored_ODO" && _SubNode.InnerText != "") { _EngStoredODO = Int32.Parse(_SubNode.InnerText); }
                        if (_SubNode.Name == "Max_Eng_ODO" && _SubNode.InnerText != "") { _EngineMAX = Int32.Parse(_SubNode.InnerText); }
                        //if (_SubNode.Name == "Eng_DateFilterChangedLast") { _EngineMAX = Int32.Parse(_SubNode.InnerText); }
                    }
                }
            }
            
            //OnLoad Display
            this.BackColor = _PrimaryColor;

            //OnLoad Methods
            EngFilterStatusCondition(_CurrentODOReading);
            CabFilterStatusCondition(_CurrentODOReading);

            //Save the changes
            _AirFilterData.Save(_FilePath + _FileName + _FileExtensionType);

            //General Message Label
            generalMessageLB.Font = new Font(generalMessageLB.Font.FontFamily, 9);
            generalMessageLB.Text = "The engine and cabin air filters in your car are \n" +
                "recommended to be replaced between 15,000 \n" +
                "to 30,000 miles or once a year.";

            //Engine & Cabin Air Filter Text
            engAirFilterLB.Font = new Font(engAirFilterLB.Font.FontFamily, 9);
            engAirFilterLB.Text = "Miles Driven: " + "\n" +
                        string.Format("{0:n0}", _CurrentODOReading) + "\n" +
                    "Remaining Miles: " + "\n" +
                        string.Format("{0:n0}", (_EngineMAX - _CurrentODOReading));

            cabAirFilterLB.Font = new Font(cabAirFilterLB.Font.FontFamily, 9);
            cabAirFilterLB.Text = "Miles Driven: " + "\n" +
                        string.Format("{0:n0}", _CurrentODOReading) + "\n" +
                    "Remaining Miles: " + "\n" +
                        string.Format("{0:n0}", (_CabinMAX - _CurrentODOReading));

            //Track Bars Visibility
            engAirFilterTB.Visible = false;
            cabAirFilterTB.Visible = false;

            //Labels Visibility
            engAirFilterTBarLabel.Visible = false;
            cabAirFilterTBarLabel.Visible = false;
            engMaxMilesLabel.Visible = false;
            cabMaxMilesLabel.Visible = false;

            //Buttons Visibility
            engFilterChangedBTTN.Visible = false;
            cabFilterChangedBTTN.Visible = false;

            //Reset & Exit Buttons
            resetBTTN.BackColor = _SecondaryColor;
            exitBTTN.BackColor = _SecondaryColor;
        }

        private void EngFilterChangedBTTN_Click(object sender, EventArgs e)
        {
            //Load the XML file
            XmlDocument _AirFilterData = new XmlDocument();
            _AirFilterData.Load(_FilePath + _FileName + _FileExtensionType);

            XmlElement root = _AirFilterData.DocumentElement;
            XmlNodeList _Nodes = root.SelectNodes("Vehicle_Details");

            foreach (XmlNode _Node in _Nodes)
            {
                if (_Node.Attributes["Vehicle_Number"].Value == _VehicleNumber.ToString())
                {
                   foreach (XmlNode _SubNode in _Node)
                    {
                        //Update the field values
                        if (_SubNode.Name == "Make") { _SubNode.InnerText = _VehicleMake; }
                        if (_SubNode.Name == "Model") { _SubNode.InnerText = _VehicleMake; }
                    }
                }
            }

            //Save the changes
            _AirFilterData.Save(_FilePath + _FileName + _FileExtensionType);

            //Update Base Date
            //Update Base ODO
        }

        private void CabFilterChangedBTTN_Click(object sender, EventArgs e)
        {
            //Update Base Date
            //Update Base ODO
        }

        //Engine's Filter Condition
        private void EngFilterStatusCondition(int _Engines_Stored_Miles)
        {
            //Calculations
            _OneFourth = _EngineMAX/ 4;
            _OneHalf = _EngineMAX / 2;
            _ThreeFourth = _OneFourth + _OneHalf;

            //Define the Engine Air Filter Background color
            //depending on the MPG or amount of months it
            //has been used.
            if (_Engines_Stored_Miles <= _OneFourth)
            {
                engAirFilter.BackColor = Color.Green;
            }
            else if (_Engines_Stored_Miles > _OneFourth && _Engines_Stored_Miles <= _OneHalf)
            {
                engAirFilter.BackColor = Color.GreenYellow;
            }
            else if (_Engines_Stored_Miles > _OneHalf && _Engines_Stored_Miles <= _ThreeFourth)
            {
                engAirFilter.BackColor = Color.Yellow;
            }
            else
            {
                engAirFilter.BackColor = Color.Red;
            }
        }
        
        //Engine's Filter Condition
        private void CabFilterStatusCondition(int _Cabins_Stored_Miles)
        {
            //Calculations
            _OneFourth = _CabinMAX / 4;
            _OneHalf = _CabinMAX / 2;
            _ThreeFourth = _OneFourth + _OneHalf;

            //Define the Cabin Air Filter Background color
            //depending on the MPG or amount of months it
            //has been used.
            if (_Cabins_Stored_Miles <= _OneFourth)
            {
                cabAirFilter.BackColor = Color.Green;
            }
            else if (_Cabins_Stored_Miles > _OneFourth && _Cabins_Stored_Miles <= _OneHalf)
            {
                cabAirFilter.BackColor = Color.GreenYellow;
            }
            else if (_Cabins_Stored_Miles > _OneHalf && _Cabins_Stored_Miles <= _ThreeFourth)
            {
                cabAirFilter.BackColor = Color.Yellow;
            }
            else
            {
                cabAirFilter.BackColor = Color.Red;
            }
        }

        private void EngAirFilter_Click(object sender, EventArgs e)
        {
            if (_EgnineCount == 0)
            {
                engAirFilterGroupBox.Visible = false;

                engAirFilter.Text = "";
                engAirFilter.BackColor = _SecondaryColor;
                engAirFilter.Image = Resources.X120;
                engFilterChangedBTTN.BackColor = _SecondaryColor;
                engAirFilterTB.Visible = true;
                engAirFilterTBarLabel.Visible = true;
                engMaxMilesLabel.Visible = true;
                engFilterChangedBTTN.Visible = true;
                engAirFilterTB.Scroll += new EventHandler(EngAirFilterSB_Scroll);
                engAirFilterTB.Minimum = _CurrentODOReading;
                engAirFilterTB.Maximum = _MAX;
                engAirFilterTB.TickFrequency = 5000;
                engAirFilterTB.LargeChange = 10000;
                engAirFilterTB.SmallChange = 5000;
                engAirFilterTB.Value = _EngineMAX;
                engAirFilterTBarLabel.Text = _EngineMAX.ToString();
                _EgnineCount++;
            }
            else if (_EgnineCount == 1)
            {
                engAirFilterGroupBox.Visible = true;

                engAirFilter.Text = "Engine Air Filter Settings";
                EngFilterStatusCondition(_CurrentODOReading);
                engAirFilter.Image = null;

                engAirFilterLB.Text = "Miles Driven: " + "\n" + 
                        string.Format("{0:n0}", _CurrentODOReading) + "\n" +
                    "Remaining Miles: " + "\n" + 
                        string.Format("{0:n0}", (_EngineMAX- _CurrentODOReading));
                    //string.Format("{0:n0}", mls) + "/" + string.Format("{0:n0}", eMX);

                //Hide the track bar and label
                engAirFilterTB.Visible = false;
                engAirFilterTBarLabel.Visible = false;
                engMaxMilesLabel.Visible = false;
                engFilterChangedBTTN.Visible = false;
                _EgnineCount--;
            }
        }

        private void CabAirFilter_Click(object sender, EventArgs e)
        {
            if (_CabinCount == 0)
            {
                cabAirFilterGroupBox.Visible = false;

                cabAirFilter.Text = "";
                cabAirFilter.BackColor = _SecondaryColor;
                cabAirFilter.Image = Resources.X120;
                cabFilterChangedBTTN.BackColor = _SecondaryColor;
                cabAirFilterTB.Visible = true;
                cabAirFilterTBarLabel.Visible = true;
                cabMaxMilesLabel.Visible = true;
                cabFilterChangedBTTN.Visible = true;
                cabAirFilterTB.Scroll += new EventHandler(CabAirFilterSB_Scroll);
                cabAirFilterTB.Minimum = _CurrentODOReading;
                cabAirFilterTB.Maximum = _MAX;
                cabAirFilterTB.TickFrequency = 5000;
                cabAirFilterTB.LargeChange = 10000;
                cabAirFilterTB.SmallChange = 5000;
                cabAirFilterTB.Value = _CabinMAX;
                cabAirFilterTBarLabel.Text = _CabinMAX.ToString();
                _CabinCount++;
            }
            else if (_CabinCount == 1)
            {
                cabAirFilterGroupBox.Visible = true;

                cabAirFilter.Text = "Cabin Air Filter Settings";
                CabFilterStatusCondition(_CurrentODOReading);
                cabAirFilter.Image = null;

                cabAirFilterLB.Text = "Miles Driven: " + "\n" +
                        string.Format("{0:n0}", _CurrentODOReading) + "\n" +
                    "Remaining Miles: " + "\n" +
                        string.Format("{0:n0}", (_CabinMAX - _CurrentODOReading));

                //Hide the track bar and label
                cabAirFilterTB.Visible = false;
                cabAirFilterTBarLabel.Visible = false;
                cabMaxMilesLabel.Visible = false;
                cabFilterChangedBTTN.Visible = false;
                _CabinCount--;
            }
        }

        //The egnine's Track Bar
        private void EngAirFilterSB_Scroll(object sender, System.EventArgs e)
        {
            //Display the trackbar value in the text box.
            engAirFilterTBarLabel.Text = "" + engAirFilterTB.Value;
            _EngineMAX = engAirFilterTB.Value;

            //Load the XML file
            XmlDocument _AirFilterData = new XmlDocument();
            _AirFilterData.Load(_FilePath + _FileName + _FileExtensionType);

            XmlElement root = _AirFilterData.DocumentElement;
            XmlNodeList _Nodes = root.SelectNodes("Vehicle_Details");

            foreach (XmlNode _Node in _Nodes)
            {
                if (_Node.Attributes["Vehicle_Number"].Value == _VehicleNumber.ToString())
                {
                    foreach (XmlNode _SubNode in _Node)
                    {
                        //Update the field values
                        if (_SubNode.Name == "Max_Eng_ODO") { _SubNode.InnerText = _EngineMAX.ToString(); }
                    }
                }
            }

            //Save the changes
            _AirFilterData.Save(_FilePath + _FileName + _FileExtensionType);
        }

        //The cabin's Track Bar
        private void CabAirFilterSB_Scroll(object sender, System.EventArgs e)
        {
            //Display the trackbar value in the text box.
            cabAirFilterTBarLabel.Text = "" + cabAirFilterTB.Value;
            _CabinMAX = cabAirFilterTB.Value;

            //Load the XML file
            XmlDocument _AirFilterData = new XmlDocument();
            _AirFilterData.Load(_FilePath + _FileName + _FileExtensionType);

            XmlElement root = _AirFilterData.DocumentElement;
            XmlNodeList _Nodes = root.SelectNodes("Vehicle_Details");

            foreach (XmlNode _Node in _Nodes)
            {
                if (_Node.Attributes["Vehicle_Number"].Value == _VehicleNumber.ToString())
                {
                    foreach (XmlNode _SubNode in _Node)
                    {
                        //Update the field values
                        if (_SubNode.Name == "Max_Cab_ODO") { _SubNode.InnerText = _CabinMAX.ToString(); }
                    }
                }
            }

            //Save the changes
            _AirFilterData.Save(_FilePath + _FileName + _FileExtensionType);
        }

        private void ExitBTTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBTTN_Click(object sender, EventArgs e)
        {
            
        }

        //Create XML
        private static void CreateXMLFile(Vehicle[] vehicle, 
            string filePath, string fileName, string fileExtensionType, 
            int vehicleNumber, string vehicleMake, string vehicleModel, int currentODO,
            int engMAXODO, int eng_DateFilterChangedLast, int cabMAXODO, int cab_DateFilterChangedLast,
            int engStoredODO, int cabStoredODO)
        {          
            if (!File.Exists(filePath + fileName + fileExtensionType))
            {
                using (XmlTextWriter write = new XmlTextWriter(filePath + fileName + fileExtensionType, Encoding.UTF8))
                {
                    //Start of the Main Fields
                    write.WriteStartElement("Vehicle");

                    foreach (Vehicle v in vehicle)
                    {
                        //Start vehicle details (S - 1)
                        write.WriteStartElement("Vehicle_Details");
                        write.WriteAttributeString("Vehicle_Number", v.Id.ToString());

                        //Vehicle details rows
                        //write.WriteElementString("Vehicle_Number", v.Id.ToString());
                        write.WriteElementString("Make", v.Make);
                        write.WriteElementString("Model", v.Model);
                        write.WriteElementString("Current_ODO", v.ODO.ToString());
                        write.WriteElementString("Eng_Stored_ODO", engStoredODO.ToString());
                        write.WriteElementString("Max_Eng_ODO", engMAXODO.ToString());
                        write.WriteElementString("Eng_DateFilterChangedLast", "");
                        write.WriteElementString("Cab_Stored_ODO", cabStoredODO.ToString());
                        write.WriteElementString("Max_Cab_ODO", cabMAXODO.ToString());
                        write.WriteElementString("Cab_DateFilterChangedLast", "");

                        //End vehcile info (S - 1)
                        write.WriteEndElement();
                    }

                    //End of the Main Fields
                    write.WriteEndElement();
                    write.Close();
                }
            }
            else
            {
                //Load the XML file
                XmlDocument _AirFilterData = new XmlDocument();
                _AirFilterData.Load(filePath + fileName + fileExtensionType);

                XmlElement root = _AirFilterData.DocumentElement;
                XmlNodeList _Nodes = root.SelectNodes("Vehicle_Details");

                foreach (XmlNode _Node in _Nodes)
                {
                    if (_Node.Attributes["Vehicle_Number"].Value == vehicleNumber.ToString())
                    {
                        foreach (XmlNode _SubNode in _Node)
                        {   
                            //Update the field values
                            if (_SubNode.Name == "Make") { _SubNode.InnerText = vehicleMake; }
                            if (_SubNode.Name == "Model") { _SubNode.InnerText = vehicleModel; }
                            if (_SubNode.Name == "Current_ODO") { _SubNode.InnerText = currentODO.ToString(); }
                            if (_SubNode.Name == "Eng_Stored_ODO" && _SubNode.InnerText == "") { _SubNode.InnerText = engStoredODO.ToString(); }
                            if (_SubNode.Name == "Max_Eng_ODO" && _SubNode.InnerText == "") { _SubNode.InnerText = engMAXODO.ToString(); }
                            if (_SubNode.Name == "Eng_DateFilterChangedLast" && _SubNode.InnerText == "") { _SubNode.InnerText = eng_DateFilterChangedLast.ToString(); }
                            if (_SubNode.Name == "Cab_Stored_ODO" && _SubNode.InnerText == "") { _SubNode.InnerText = cabStoredODO.ToString(); }
                            if (_SubNode.Name == "Max_Cab_ODO" && _SubNode.InnerText == "") { _SubNode.InnerText = cabMAXODO.ToString(); }
                            if (_SubNode.Name == "Cab_DateFilterChangedLast" && _SubNode.InnerText == "") { _SubNode.InnerText = cab_DateFilterChangedLast.ToString(); }
                        }
                    }
                }

                //Save the changes
                _AirFilterData.Save(filePath + fileName + fileExtensionType);
            }
        }
    }
}
