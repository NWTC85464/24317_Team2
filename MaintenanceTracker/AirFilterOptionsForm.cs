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
        private int mls = 15000,
            mx = 30000,
            eMX = 25000,
            cMX = 30000,
            eCount = 0,
            cCount = 0,
            oneFourth = 0,
            oneHalf = 0,
            threeFourth = 0,
            vNumber = 0;

        //Colors
        private Color primaryColor = Color.FromArgb(255, 255, 255),
            secondaryColor = Color.FromArgb(255, 255, 255);

        //Strings
        private string vMake,
            vModel,
            path = Path.Combine(Directory.GetCurrentDirectory(), "AirFilterData.txt");

        public AirFilterOptionsForm()
        {
            InitializeComponent();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            //Instantiate the vehicle object
            Vehicle[] vehicle = new Vehicle[5];

            //Switch between the selected vehicle
            switch (mFormClass.VehicalNumber)
            {
                case 1:
                    vMake = "Ford";
                    vModel = "Mustange";
                    vNumber = 1;
                    break;
                case 2:
                    vMake = "Ford";
                    vModel = "Fiesta";
                    vNumber = 2;
                    break;
                case 3:
                    vMake = "Subaru ";
                    vModel = "Outback";
                    vNumber = 3;
                    break;
                case 4:
                    vMake = "Dodge";
                    vModel = "Challenger";
                    vNumber = 4;
                    break;
                default:
                    vMake = "Ford";
                    vModel = "Da-Pinto";
                    vNumber = 0;
                    break;
            }

            //test

            //end test

            vehicle[0] = new Vehicle(1, vMake, vModel, 1);
            vehicle[1] = new Vehicle(2, vMake, vModel, 2);
            vehicle[2] = new Vehicle(3, vMake, vModel, 3);
            vehicle[3] = new Vehicle(4, vMake, vModel, 4);
            vehicle[4] = new Vehicle(5, vMake, vModel, 5);

            //Create XML, or alter XML
            CreateXMLFile(vehicle);

            //Assign the colors
            primaryColor = cThemes.PrimaryColor;
            secondaryColor = cThemes.SecondaryColor;
            
            //OnLoad Display
            this.BackColor = primaryColor;

            //OnLoad Methods
            EngFilterStatusColor(mls);
            CabFilterStatusColor(mls);

            //General Message Label
            generalMessageLB.Font = new Font(generalMessageLB.Font.FontFamily, 9);
            generalMessageLB.Text = "The engine and cabin air filters in your car are \n" +
                "recommended to be replaced between 15,000 \n" +
                "to 30,000 miles or once a year.";

            //Engine & Cabin Air Filter Text
            engAirFilterLB.Font = new Font(engAirFilterLB.Font.FontFamily, 9);
            engAirFilterLB.Text = "Current Engine Air Filter: \n" +
                "" + string.Format("{0:n0}", mls) + "/" + string.Format("{0:n0}", eMX) + " miles.";

            cabAirFilterLB.Font = new Font(cabAirFilterLB.Font.FontFamily, 9);
            cabAirFilterLB.Text = "Current Cabin Air Filter: \n" +
                "" + string.Format("{0:n0}", mls) + "/" + string.Format("{0:n0}", cMX) + " miles.";

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
        }

        private void EngFilterChangedBTTN_Click(object sender, EventArgs e)
        {
            //Update Base Date
            //Update Base ODO
        }

        private void CabFilterChangedBTTN_Click(object sender, EventArgs e)
        {
            //Update Base Date
            //Update Base ODO
        }

        //Engine's Filter Condition
        private void EngFilterStatusColor(int M)
        {
            //Calculations
            oneFourth = eMX/ 4;
            oneHalf = eMX / 2;
            threeFourth = oneFourth + oneHalf;

            //Define the Engine Air Filter Background color
            //depending on the MPG or amount of months it
            //has been used.
            if (M <= oneFourth)
            {
                engAirFilter.BackColor = Color.Green;
            }
            else if (M > oneFourth && M <= oneHalf)
            {
                engAirFilter.BackColor = Color.GreenYellow;
            }
            else if (M > oneHalf && M <= threeFourth)
            {
                engAirFilter.BackColor = Color.Yellow;
            }
            else
            {
                engAirFilter.BackColor = Color.Red;
            }
        }
        
        //Engine's Filter Condition
        private void CabFilterStatusColor(int M)
        {
            //Calculations
            oneFourth = cMX / 4;
            oneHalf = cMX / 2;
            threeFourth = oneFourth + oneHalf;

            //Define the Cabin Air Filter Background color
            //depending on the MPG or amount of months it
            //has been used.
            if (M <= oneFourth)
            {
                cabAirFilter.BackColor = Color.Green;
            }
            else if (M > oneFourth && M <= oneHalf)
            {
                cabAirFilter.BackColor = Color.GreenYellow;
            }
            else if (M > oneHalf && M <= threeFourth)
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
            if (eCount == 0)
            {
                engAirFilter.Text = "";
                engAirFilter.BackColor = secondaryColor;
                engAirFilter.Image = Resources.X120;
                engFilterChangedBTTN.BackColor = secondaryColor;
                engAirFilterTB.Visible = true;
                engAirFilterTBarLabel.Visible = true;
                engMaxMilesLabel.Visible = true;
                engFilterChangedBTTN.Visible = true;
                engAirFilterTB.Scroll += new System.EventHandler(EngAirFilterSB_Scroll);
                engAirFilterTB.Minimum = 0;
                engAirFilterTB.Maximum = mx;
                engAirFilterTB.TickFrequency = 5000;
                engAirFilterTB.LargeChange = 10000;
                engAirFilterTB.SmallChange = 5000;
                engAirFilterTB.Value = eMX;
                engAirFilterTBarLabel.Text = eMX.ToString();
                eCount++;
            }
            else if (eCount == 1)
            {
                engAirFilter.Text = "Engine Air Filter Settings";
                EngFilterStatusColor(mls);
                engAirFilter.Image = null;

                engAirFilterLB.Text = "Current Engine Air Filter: \n" +
                    "" + string.Format("{0:n0}", mls) + "/" + string.Format("{0:n0}", eMX) + " miles.";

                //Hide the track bar and label
                engAirFilterTB.Visible = false;
                engAirFilterTBarLabel.Visible = false;
                engMaxMilesLabel.Visible = false;
                engFilterChangedBTTN.Visible = false;
                eCount--;
            }
        }

        private void CabAirFilter_Click(object sender, EventArgs e)
        {
            if (cCount == 0)
            {
                cabAirFilter.Text = "";
                cabAirFilter.BackColor = secondaryColor;
                cabAirFilter.Image = Resources.X120;
                cabFilterChangedBTTN.BackColor = secondaryColor;
                cabAirFilterTB.Visible = true;
                cabAirFilterTBarLabel.Visible = true;
                cabMaxMilesLabel.Visible = true;
                cabFilterChangedBTTN.Visible = true;
                cabAirFilterTB.Scroll += new System.EventHandler(CabAirFilterSB_Scroll);
                cabAirFilterTB.Minimum = 0;
                cabAirFilterTB.Maximum = mx;
                cabAirFilterTB.TickFrequency = 5000;
                cabAirFilterTB.LargeChange = 10000;
                cabAirFilterTB.SmallChange = 5000;
                cabAirFilterTB.Value = cMX;
                cabAirFilterTBarLabel.Text = cMX.ToString();
                cCount++;
            }
            else if (cCount == 1)
            {
                cabAirFilter.Text = "Cabin Air Filter Settings";
                CabFilterStatusColor(mls);
                cabAirFilter.Image = null;

                cabAirFilterLB.Text = "Current Cabin Air Filter: \n" +
                    "" + string.Format("{0:n0}", mls) + "/" + string.Format("{0:n0}", cMX) + " miles.";

                //Hide the track bar and label
                cabAirFilterTB.Visible = false;
                cabAirFilterTBarLabel.Visible = false;
                cabMaxMilesLabel.Visible = false;
                cabFilterChangedBTTN.Visible = false;
                cCount--;
            }
        }

        private void EngAirFilterSB_Scroll(object sender, System.EventArgs e)
        {
            //Display the trackbar value in the text box.
            engAirFilterTBarLabel.Text = "" + engAirFilterTB.Value;
            eMX = engAirFilterTB.Value;
        }

        private void CabAirFilterSB_Scroll(object sender, System.EventArgs e)
        {
            //Display the trackbar value in the text box.
            cabAirFilterTBarLabel.Text = "" + cabAirFilterTB.Value;
            cMX = cabAirFilterTB.Value;
        }

        private void ExitBTTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBTTN_Click(object sender, EventArgs e)
        {
            
        }

        //Create XML, or alter XML
        private static void CreateXMLFile(Vehicle[] vehicle)
        {
            string filePath = "AirFilterData";
            string extensionType = ".XML";

            if (!File.Exists(filePath + extensionType))
            {
                using (XmlTextWriter writer = new XmlTextWriter(filePath + extensionType, Encoding.UTF8))
                {
                    writer.WriteStartElement("Vehicle");
                    writer.WriteEndElement();
                    writer.Close();
                }

                Console.WriteLine("File didn't exists and was creates successfully");
            }

            // Xml exists now
            // Adding a child to the xml
            using (XmlTextReader read = new XmlTextReader(filePath + extensionType))
            {
                using (XmlTextWriter write = new XmlTextWriter(filePath + "TEMP.XML", Encoding.UTF8))
                {
                    //Start of the Main Fields
                    write.WriteStartElement("Vehicle");
                    foreach (Vehicle v in vehicle)
                    {
                        //Sub Vehicle Fields
                        write.WriteStartElement("Vehicle");
                        write.WriteAttributeString("Number", v.Id.ToString());
                        write.WriteElementString("Make", v.Make);
                        write.WriteElementString("Model", v.Model);
                        write.WriteElementString("Current_ODO", v.ODO.ToString());

                            //Sub Filter Fields
                            write.WriteStartElement("Air_Filter");
                            write.WriteElementString("Max_ODO", "MaxODO");
                            write.WriteElementString("DateFilterChangedLast", "DateFilterChangedLast");
                            write.WriteEndElement();
                            
                            //Sub Filter Fields
                            write.WriteStartElement("Cabin_Filter");
                            write.WriteElementString("Max_ODO", "MaxODO");
                            write.WriteElementString("DateFilterChangedLast", "DateFilterChangedLast");
                            write.WriteEndElement();

                        //End of the Vehicle Fields
                        write.WriteEndElement();

                    }
                    //End of the Main Fields
                    write.WriteEndElement();
                }
            }

            File.Delete(filePath + extensionType);
            File.Move(filePath + "TEMP.XML", filePath + extensionType);
        }
    }
}
