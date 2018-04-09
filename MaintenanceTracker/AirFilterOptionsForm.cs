using MaintenanceTracker.Classes;
using MaintenanceTracker.Properties;
using System;
using System.Drawing;
using System.IO;
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
        private string txt, 
            vehicle,
            path = Path.Combine(Directory.GetCurrentDirectory(), "AirFilterData.txt");


        public AirFilterOptionsForm()
        {
            InitializeComponent();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

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

            //Track bars
            engAirFilterTB.Visible = false;
            cabAirFilterTB.Visible = false;

            //Track labels
            engAirFilterTbLb.Visible = false;
            cabAirFilterTbLb.Visible = false;
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
                engAirFilter.BackColor = Color.White;
                engAirFilter.Image = Resources.X120;
                engAirFilterTB.Visible = true;
                engAirFilterTbLb.Visible = true;
                engAirFilterTB.Scroll += new System.EventHandler(EngAirFilterSB_Scroll);
                engAirFilterTB.Minimum = 0;
                engAirFilterTB.Maximum = mx;
                engAirFilterTB.TickFrequency = 5000;
                engAirFilterTB.LargeChange = 10000;
                engAirFilterTB.SmallChange = 5000;
                engAirFilterTB.Value = eMX;
                engAirFilterTbLb.Text = eMX.ToString();
                eCount++;
            }
            else if (eCount == 1)
            {
                engAirFilter.Text = "Engine Air Filter";
                EngFilterStatusColor(mls);
                engAirFilter.Image = null;

                engAirFilterLB.Text = "Current Engine Air Filter: \n" +
                    "" + string.Format("{0:n0}", mls) + "/" + string.Format("{0:n0}", eMX) + " miles.";

                //Hide the track bar and label
                engAirFilterTB.Visible = false;
                engAirFilterTbLb.Visible = false;
                eCount--;
            }
        }

        private void CabAirFilter_Click(object sender, EventArgs e)
        {
            if (cCount == 0)
            {
                cabAirFilter.Text = "";
                cabAirFilter.BackColor = Color.White;
                cabAirFilter.Image = Resources.X120;
                cabAirFilterTB.Visible = true;
                cabAirFilterTbLb.Visible = true;
                cabAirFilterTB.Scroll += new System.EventHandler(CabAirFilterSB_Scroll);
                cabAirFilterTB.Minimum = 0;
                cabAirFilterTB.Maximum = mx;
                cabAirFilterTB.TickFrequency = 5000;
                cabAirFilterTB.LargeChange = 10000;
                cabAirFilterTB.SmallChange = 5000;
                cabAirFilterTB.Value = cMX;
                cabAirFilterTbLb.Text = cMX.ToString();
                cCount++;
            }
            else if (cCount == 1)
            {
                cabAirFilter.Text = "Cabin Air Filter";
                CabFilterStatusColor(mls);
                cabAirFilter.Image = null;

                cabAirFilterLB.Text = "Current Cabin Air Filter: \n" +
                    "" + string.Format("{0:n0}", mls) + "/" + string.Format("{0:n0}", cMX) + " miles.";

                //Hide the track bar and label
                cabAirFilterTB.Visible = false;
                cabAirFilterTbLb.Visible = false;
                cCount--;
            }
        }

        private void EngAirFilterSB_Scroll(object sender, System.EventArgs e)
        {
            //Display the trackbar value in the text box.
            engAirFilterTbLb.Text = "" + engAirFilterTB.Value;
            eMX = engAirFilterTB.Value;
        }

        private void CabAirFilterSB_Scroll(object sender, System.EventArgs e)
        {
            //Display the trackbar value in the text box.
            cabAirFilterTbLb.Text = "" + cabAirFilterTB.Value;
            cMX = cabAirFilterTB.Value;
        }

        private void ExitBTTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBTTN_Click(object sender, EventArgs e)
        {
            //Switch between the selected vehicle
            switch (mFormClass.VehicalNumber)
            {
                case 1:
                    this.vehicle = "Hennessey Venom F5";
                    vNumber = 1;
                    break;
                case 2:
                    this.vehicle = "Koenigsegg Agera RS";
                    vNumber = 2;
                    break;
                case 3:
                    this.vehicle = "Hennessey Venom GT ";
                    vNumber = 3;
                    break;
                case 4:
                    this.vehicle = "Bugatti Chiron";
                    vNumber = 4;
                    break;
                default:
                    this.vehicle = "Da-Pinto";
                    break;
            }

            ////Write to the file
            //File.WriteAllText(path, vehicle);

            ////Read the file
            //txt = File.ReadAllText(path);

            //Display the result
            generalMessageLB.Text = this.vehicle + " " + vNumber.ToString();
            
            Vehicle[] vehicle = new Vehicle[4];
            vehicle[0] = new Vehicle(vNumber, "Ford", "Mustange", mx);
            vehicle[1] = new Vehicle(2, "Ford", "Fiesta", 30000);
            vehicle[2] = new Vehicle(3, "Subaru", "Outback", 20000);
            vehicle[3] = new Vehicle(4, "Dodge", "Challenger", 120000);

            using (XmlWriter writer = XmlWriter.Create("AirFilterData.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Vehicle");

                foreach (Vehicle v in vehicle)
                {
                    writer.WriteStartElement("Vehicle");

                    writer.WriteElementString("ID", v.Id.ToString());   // <-- These are new
                    writer.WriteElementString("Make", v.FirstName);
                    writer.WriteElementString("Model", v.LastName);
                    writer.WriteElementString("ODO", v.Salary.ToString());
                    writer.WriteElementString("Filters", "Filter Type");


                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
