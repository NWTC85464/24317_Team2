using MaintenanceTracker.Classes;
using MaintenanceTracker.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private int _CurrentODOReading = 0,
            _EngStoredODO = 0,
            _EngODODiff = 0,
            _EngineMAX = 30000,
            _EgnineCount = 0,
            _CabStoredODO = 0,
            _CabODODiff = 0,
            _CabinMAX = 30000,
            _CabinCount = 0,
            _MAX = 30000,
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
            _FileExtensionType = ".XML",
            _EngStoredDate = null,
            _CabStoredDate = null;

        //Main
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

            //Pull the current ODO value
            ODOReadings(_VehicleNumber, out _CurrentODOReading);

            //If the directory doesn't exist, create it.
            if (!Directory.Exists(_FilePath))
            {
                Directory.CreateDirectory(_FilePath);
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
                        if (_SubNode.Name == "Cab_DateFilterChangedLast") { _CabStoredDate = _SubNode.InnerText; }
                        if (_SubNode.Name == "Eng_Stored_ODO" && _SubNode.InnerText != "") { _EngStoredODO = Int32.Parse(_SubNode.InnerText); }
                        if (_SubNode.Name == "Max_Eng_ODO" && _SubNode.InnerText != "") { _EngineMAX = Int32.Parse(_SubNode.InnerText); }
                        if (_SubNode.Name == "Eng_DateFilterChangedLast") { _EngStoredDate = _SubNode.InnerText; }
                    }
                }
            }
            
            //OnLoad Display
            this.BackColor = _PrimaryColor;
            generalMessagePanel.BackColor = _SecondaryColor;
            engAirFilterPanel.BackColor = _SecondaryColor;
            cabAirFilterPanel.BackColor = _SecondaryColor;
            
            //ODO Diff
            _EngODODiff = _CurrentODOReading - _EngStoredODO;
            _CabODODiff = _CurrentODOReading - _CabStoredODO;

            //Date
            _EngStoredDate = engDateTimePicker.Value.ToShortDateString();
            _CabStoredDate = cabDateTimePicker.Value.ToShortDateString();

            //OnLoad Methods
            EngFilterStatusCondition(_EngODODiff);
            CabFilterStatusCondition(_CabODODiff);

            //Save the changes
            _AirFilterData.Save(_FilePath + _FileName + _FileExtensionType);

            //General Message Label
            generalMessageLB.Font = new Font(generalMessageLB.Font.FontFamily, 9);
            generalMessageLB.Text = "The engine and cabin air filters in a veicle \n" +
                "are recommended to be replaced between \n" +
                "15,000 to 30,000 miles or once a year.";

            //Engine & Cabin Air Filter Text
            engAirFilterLB.Font = new Font(engAirFilterLB.Font.FontFamily, 9);
            engAirFilterLB.Text = "Miles Driven: " + "\n" +
                        string.Format("{0:n0}", _EngODODiff) + "\n" +
                    "Remaining Miles: " + "\n" +
                        string.Format("{0:n0}", (_EngineMAX - _EngODODiff)) + "\n" +
                    "Last Replacement:\n" +
                        _EngStoredDate;

            cabAirFilterLB.Font = new Font(cabAirFilterLB.Font.FontFamily, 9);
            cabAirFilterLB.Text = "Miles Driven: " + "\n" +
                        string.Format("{0:n0}", _CabODODiff) + "\n" +
                    "Remaining Miles: " + "\n" +
                        string.Format("{0:n0}", (_CabinMAX - _CabODODiff)) + "\n" +
                    "Last Replacement:\n" +
                        _CabStoredDate;

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

            //TextBox Visibility
            engTextBox.Visible = false;
            cabTextBox.Visible = false;

            //DateTimePicker Visibility
            engDateTimePicker.Visible = false;
            cabDateTimePicker.Visible = false;

            //TextBox Values
            engTextBox.Text = _EngStoredODO.ToString();
            cabTextBox.Text = _CabStoredODO.ToString();

            //Exit Buttons
            exitBTTN.BackColor = _SecondaryColor;
        }

        //Engine reset value button
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
                        if (_SubNode.Name == "Eng_Stored_ODO") { _SubNode.InnerText = _CurrentODOReading.ToString(); }
                        if (_SubNode.Name == "Eng_DateFilterChangedLast") { _EngStoredDate = _SubNode.InnerText; }
                    }
                }
            }

            //Save the changes
            _AirFilterData.Save(_FilePath + _FileName + _FileExtensionType);

            //Update Base ODO
            engTextBox.Text = _CurrentODOReading.ToString();

            //Update Base Date
            engDateTimePicker.Value = DateTime.Today;
        }

        //Cabine reset value button
        private void CabFilterChangedBTTN_Click(object sender, EventArgs e)
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
                        if (_SubNode.Name == "Cab_Stored_ODO") { _SubNode.InnerText = _CurrentODOReading.ToString(); }
                        if (_SubNode.Name == "Cab_DateFilterChangedLast") { _CabStoredDate = _SubNode.InnerText; }
                    }
                }
            }

            //Save the changes
            _AirFilterData.Save(_FilePath + _FileName + _FileExtensionType);
            
            //Update Base ODO
            cabTextBox.Text = _CurrentODOReading.ToString();

            //Update Base Date
            cabDateTimePicker.Value = DateTime.Today;
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

        //Engine's Open, Close, for the settings
        private void EngAirFilter_Click(object sender, EventArgs e)
        {
            if (_EgnineCount == 0)
            {
                engAirFilterLB.Text = "ODO @ Rep: \n\n\n" + 
                    "Date Stored:";
                engTextBox.Visible = true;
                engTextBox.Text = _EngStoredODO.ToString();
                engDateTimePicker.Visible = true;
                engDateTimePicker.Value.ToShortDateString();

                engAirFilter.Text = "";
                engAirFilter.BackColor = _SecondaryColor;
                engAirFilter.Image = Resources.X120;
                engFilterChangedBTTN.BackColor = _SecondaryColor;
                engAirFilterTB.Visible = true;
                engAirFilterTBarLabel.Visible = true;
                engMaxMilesLabel.Visible = true;
                engFilterChangedBTTN.Visible = true;
                engAirFilterTB.Scroll += new EventHandler(EngAirFilterSB_Scroll);
                engAirFilterTB.Minimum = _EngODODiff;
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
                //Validate if the inpute value in the text field is correct.
                if (engTextBox.Text != _EngStoredODO.ToString())
                {
                    DialogResult dialogResult = MessageBox.Show("Are you wanting to change your historical ODO value?", "Are you sure?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes && int.TryParse(engTextBox.Text, out int intCheck))
                    {
                        if (int.Parse(engTextBox.Text) < 0)
                        {
                            MessageBox.Show("Your value cannot be a negative value.");
                        }
                        else
                        {
                            if ((_CurrentODOReading - int.Parse(engTextBox.Text)) < 0)
                            {
                                MessageBox.Show("Your ODO is currently at: " + _CurrentODOReading + "\n" + 
                                    "Your value must be less than or equal to your current ODO.");
                            }
                            else
                            {
                                _EngStoredODO = int.Parse(engTextBox.Text);
                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        engTextBox.Text = _EngStoredODO.ToString();
                    }
                    else
                    {
                        if (int.TryParse(engTextBox.Text, out int intC))
                        {
                            engTextBox.Text = _EngStoredODO.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Value must be an integer values, 0-9. You inserted: " + engTextBox.Text);
                        }
                    }
                }

                //Date
                _EngStoredDate = engDateTimePicker.Value.ToShortDateString();

                //Engine ODO Diff
                _EngODODiff = _CurrentODOReading - _EngStoredODO;

                //Display Comments
                engAirFilter.Text = "Engine Air Filter Settings";
                EngFilterStatusCondition(_EngODODiff);

                engAirFilterLB.Text = "Miles Driven: " + "\n" + 
                        string.Format("{0:n0}", _EngODODiff) + "\n" +
                    "Remaining Miles: " + "\n" + 
                        string.Format("{0:n0}", (_EngineMAX - _EngODODiff)) + "\n" +
                    "Last Replacement:\n" +
                        _EngStoredDate;

                engTextBox.Visible = false;
                engDateTimePicker.Visible = false;
                engAirFilter.Image = null;

                //Hide the track bar and label
                engAirFilterTB.Visible = false;
                engAirFilterTBarLabel.Visible = false;
                engMaxMilesLabel.Visible = false;
                engFilterChangedBTTN.Visible = false;

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
                            if (_SubNode.Name == "Eng_Stored_ODO") { _SubNode.InnerText = _EngStoredODO.ToString(); }
                        }
                    }
                }

                //Save the changes
                _AirFilterData.Save(_FilePath + _FileName + _FileExtensionType);

                _EgnineCount--;
            }
        }

        //Cabin's Open, Close, for the settings
        private void CabAirFilter_Click(object sender, EventArgs e)
        {
            if (_CabinCount == 0)
            {
                cabAirFilterLB.Text = "ODO @ Rep: \n\n\n" +
                    "Date Stored:";
                cabTextBox.Visible = true;
                cabTextBox.Text = _CabStoredODO.ToString();
                cabDateTimePicker.Visible = true;
                cabDateTimePicker.Value.ToShortDateString();

                cabAirFilter.Text = "";
                cabAirFilter.BackColor = _SecondaryColor;
                cabAirFilter.Image = Resources.X120;
                cabFilterChangedBTTN.BackColor = _SecondaryColor;
                cabAirFilterTB.Visible = true;
                cabAirFilterTBarLabel.Visible = true;
                cabMaxMilesLabel.Visible = true;
                cabFilterChangedBTTN.Visible = true;
                cabAirFilterTB.Scroll += new EventHandler(CabAirFilterSB_Scroll);
                cabAirFilterTB.Minimum = _CabODODiff;
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
                //Validate if the inpute value in the text field is correct.
                if (cabTextBox.Text != _CabStoredODO.ToString())
                {
                    DialogResult dialogResult = MessageBox.Show("Are you wanting to change your historical ODO value?", "Are you sure?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes && int.TryParse(cabTextBox.Text, out int intCheck))
                    {
                        if (int.Parse(cabTextBox.Text) < 0)
                        {
                            MessageBox.Show("The ODO value cannot be a negative value.");
                        }
                        else
                        {
                            if ((_CurrentODOReading - int.Parse(cabTextBox.Text)) < 0)
                            {
                                MessageBox.Show("Your ODO is currently at: " + _CurrentODOReading + "\n" +
                                    "Your value must be less than or equal to your current ODO.");
                            }
                            else
                            {
                                _CabStoredODO = int.Parse(cabTextBox.Text);
                            }
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        cabTextBox.Text = _CabStoredODO.ToString();
                    }
                    else
                    {
                        if (int.TryParse(cabTextBox.Text, out int intC))
                        {
                            cabTextBox.Text = _CabStoredODO.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Value must be an integer values, 0-9. You inserted: " + cabTextBox.Text);
                        }
                    }
                }

                //Date
                _CabStoredDate = cabDateTimePicker.Value.ToShortDateString();

                //Engine ODO Diff
                _CabODODiff = _CurrentODOReading - _CabStoredODO;
                
                //Display Comments
                cabAirFilter.Text = "Cabin Air Filter Settings";
                CabFilterStatusCondition(_CabODODiff);

                cabAirFilterLB.Text = "Miles Driven:" + "\n" +
                        string.Format("{0:n0}", _CabODODiff) + "\n" +
                    "Remaining Miles:" + "\n" +
                        string.Format("{0:n0}", (_CabinMAX - _CabODODiff)) + "\n" +
                    "Last Replacement:\n" +
                        _CabStoredDate;

                cabTextBox.Visible = false;
                cabDateTimePicker.Visible = false;
                cabAirFilter.Image = null;

                //Hide the track bar and label
                cabAirFilterTB.Visible = false;
                cabAirFilterTBarLabel.Visible = false;
                cabMaxMilesLabel.Visible = false;
                cabFilterChangedBTTN.Visible = false;

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
                            if (_SubNode.Name == "Cab_Stored_ODO") { _SubNode.InnerText = _CabStoredODO.ToString(); }
                        }
                    }
                }

                //Save the changes
                _AirFilterData.Save(_FilePath + _FileName + _FileExtensionType);

                _CabinCount--;
            }
        }

        //The egnine's Track Bar
        private void EngAirFilterSB_Scroll(object sender, System.EventArgs e)
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
                        if (_SubNode.Name == "Max_Eng_ODO") { _SubNode.InnerText = _EngineMAX.ToString(); }
                    }
                }
            }

            //Save the changes
            _AirFilterData.Save(_FilePath + _FileName + _FileExtensionType);

            //Display the trackbar value in the text box.
            engAirFilterTBarLabel.Text = "" + engAirFilterTB.Value;
            _EngineMAX = engAirFilterTB.Value;
        }

        //The cabin's Track Bar
        private void CabAirFilterSB_Scroll(object sender, System.EventArgs e)
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
                        if (_SubNode.Name == "Max_Cab_ODO") { _SubNode.InnerText = _CabinMAX.ToString(); }
                    }
                }
            }

            //Save the changes
            _AirFilterData.Save(_FilePath + _FileName + _FileExtensionType);

            //Display the trackbar value in the text box.
            cabAirFilterTBarLabel.Text = "" + cabAirFilterTB.Value;
            _CabinMAX = cabAirFilterTB.Value;
        }

        //Exit Button
        private void ExitBTTN_Click(object sender, EventArgs e)
        {
            this.Close();
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

        //Reading the MPG files for the ODO miles
        private static void ODOReadings(int vehicleNumber, out int odoReadings)
        {
            string fln = @"mpg/mpg"+ vehicleNumber + ".txt";

            //array to hold last odo input.
            string[] holdOdo = new string[4];
            if (File.Exists(fln))
            {
                //read last line from current file to get odometer reading
                var lastLine = File.ReadLines(fln).Last();
                //incrementer for array
                int j = 0;
                //splitting up the string based on " "<--spaces it finds
                foreach (var col in lastLine.Trim().Split(' '))
                {
                    //storing split up string into an array
                    holdOdo[j] = col.Trim();
                    j++; //increment array
                }
                odoReadings = int.Parse(holdOdo[2]);
            }
            else
            {
                odoReadings = 0;
            }
        }
    }
}
