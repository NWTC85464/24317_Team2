using MaintenanceTracker.Classes;
using MaintenanceTracker.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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
            _Path = Path.Combine(Directory.GetCurrentDirectory(), "AirFilterData.txt");

        public AirFilterOptionsForm()
        {
            InitializeComponent();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            //Instantiate the vehicle object
            Vehicle[] _Vehicle = new Vehicle[5];
            _Vehicle[0] = new Vehicle(0, "", "", 0);
            _Vehicle[1] = new Vehicle(1, "", "", 1);
            _Vehicle[2] = new Vehicle(2, "", "", 2);
            _Vehicle[3] = new Vehicle(3, "", "", 3);
            _Vehicle[4] = new Vehicle(4, "", "", 4);

            //Define the Vehicle Number
            _VehicleNumber = mFormClass.VehicalNumber;
            
            //Switch between the selected vehicle
            switch (mFormClass.VehicalNumber)
            {
                case 1:
                    _VehicleMake = "Ford";
                    _VehicleModel = "Mustange";
                    _Vehicle[_VehicleNumber] = new Vehicle(_VehicleNumber, _VehicleMake, _VehicleModel, 1);
                    break;
                case 2:
                    _VehicleMake = "Ford";
                    _VehicleModel = "Fiesta";
                    _Vehicle[_VehicleNumber] = new Vehicle(_VehicleNumber, _VehicleMake, _VehicleModel, 2);
                    break;
                case 3:
                    _VehicleMake = "Subaru ";
                    _VehicleModel = "Outback";
                    _Vehicle[_VehicleNumber] = new Vehicle(_VehicleNumber, _VehicleMake, _VehicleModel, 3);
                    break;
                case 4:
                    _VehicleMake = "Dodge";
                    _VehicleModel = "Challenger";
                    _VehicleNumber = mFormClass.VehicalNumber;
                    _Vehicle[_VehicleNumber] = new Vehicle(_VehicleNumber, _VehicleMake, _VehicleModel, 4);
                    break;
                default:
                    _VehicleMake = "Ford";
                    _VehicleModel = "Da-Pinto";
                    _Vehicle[_VehicleNumber] = new Vehicle(_VehicleNumber, _VehicleMake, _VehicleModel, 0);
                    break;
            }

            //Create XML
            CreateXMLFile(_Vehicle);

            //Assign the colors
            _PrimaryColor = cThemes.PrimaryColor;
            _SecondaryColor = cThemes.SecondaryColor;
            
            //OnLoad Display
            this.BackColor = _PrimaryColor;

            //OnLoad Methods
            EngFilterStatusCondition(_CurrentODOReading);
            CabFilterStatusCondition(_CurrentODOReading);

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
            XDocument _AirFilterData = XDocument.Load("AirFilterData.xml");
            var _ODOReading = _AirFilterData.Root.Elements("Vehicle").Elements("Vehicle_Info").Elements("Eng_Air_Filter").Elements("Max_Eng_ODO").Single();
            _ODOReading.Value = _CurrentODOReading.ToString();
            _AirFilterData.Save("AirFilterData.xml");
            //Update Base Date
            //Update Base ODO
        }

        private void CabFilterChangedBTTN_Click(object sender, EventArgs e)
        {
            //Update Base Date
            //Update Base ODO
        }

        //Engine's Filter Condition
        private void EngFilterStatusCondition(int M)
        {
            //Calculations
            _OneFourth = _EngineMAX/ 4;
            _OneHalf = _EngineMAX / 2;
            _ThreeFourth = _OneFourth + _OneHalf;

            //Define the Engine Air Filter Background color
            //depending on the MPG or amount of months it
            //has been used.
            if (M <= _OneFourth)
            {
                engAirFilter.BackColor = Color.Green;
            }
            else if (M > _OneFourth && M <= _OneHalf)
            {
                engAirFilter.BackColor = Color.GreenYellow;
            }
            else if (M > _OneHalf && M <= _ThreeFourth)
            {
                engAirFilter.BackColor = Color.Yellow;
            }
            else
            {
                engAirFilter.BackColor = Color.Red;
            }
        }
        
        //Engine's Filter Condition
        private void CabFilterStatusCondition(int M)
        {
            //Calculations
            _OneFourth = _CabinMAX / 4;
            _OneHalf = _CabinMAX / 2;
            _ThreeFourth = _OneFourth + _OneHalf;

            //Define the Cabin Air Filter Background color
            //depending on the MPG or amount of months it
            //has been used.
            if (M <= _OneFourth)
            {
                cabAirFilter.BackColor = Color.Green;
            }
            else if (M > _OneFourth && M <= _OneHalf)
            {
                cabAirFilter.BackColor = Color.GreenYellow;
            }
            else if (M > _OneHalf && M <= _ThreeFourth)
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

        private void EngAirFilterSB_Scroll(object sender, System.EventArgs e)
        {
            //Display the trackbar value in the text box.
            engAirFilterTBarLabel.Text = "" + engAirFilterTB.Value;
            _EngineMAX = engAirFilterTB.Value;
        }

        private void CabAirFilterSB_Scroll(object sender, System.EventArgs e)
        {
            //Display the trackbar value in the text box.
            cabAirFilterTBarLabel.Text = "" + cabAirFilterTB.Value;
            _CabinMAX = cabAirFilterTB.Value;
        }

        private void ExitBTTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBTTN_Click(object sender, EventArgs e)
        {
            
        }

        //Create XML
        private static void CreateXMLFile(Vehicle[] vehicle)
        {
            string filePath = "AirFilterData";
            string extensionType = ".XML";

            if (!File.Exists(filePath + extensionType))
            {
                using (XmlTextWriter write = new XmlTextWriter(filePath + extensionType, Encoding.UTF8))
                {
                    //Start of the Main Fields
                    write.WriteStartElement("Vehicle");

                    foreach (Vehicle v in vehicle)
                    {
                        //Sub Vehicle Fields
                        write.WriteStartElement("Vehicle_Info");
                            write.WriteElementString("Vehicle_Number", v.Id.ToString());
                            write.WriteElementString("Make", v.Make);
                            write.WriteElementString("Model", v.Model);
                            write.WriteElementString("Current_ODO", v.ODO.ToString());

                            //Sub Filter Fields
                            write.WriteStartElement("Eng_Air_Filter");
                                write.WriteElementString("Max_Eng_ODO", "MaxODO");
                                write.WriteElementString("Eng_DateFilterChangedLast", "DateFilterChangedLast");
                            write.WriteEndElement();

                            //Sub Filter Fields
                            write.WriteStartElement("Cabin_Air_Filter");
                                write.WriteElementString("Max_Cab_ODO", "MaxODO");
                                write.WriteElementString("Cab_DateFilterChangedLast", "DateFilterChangedLast");
                            write.WriteEndElement();

                        //End of the Vehicle Fields
                        write.WriteEndElement();
                    }

                    //End of the Main Fields
                    write.WriteEndElement();
                    write.Close();
                }
            }
        }
    }
}
