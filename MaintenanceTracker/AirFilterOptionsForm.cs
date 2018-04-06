using MaintenanceTracker.Classes;
using MaintenanceTracker.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MaintenanceTracker
{

    public partial class AirFilterOptionsForm : System.Windows.Forms.Form
    {
        MainFormClass mFormClass = new MainFormClass();
        colorThemes cThemes = new colorThemes();
                
        //Read Text
        private string path = Path.Combine(Directory.GetCurrentDirectory(), "AirFilterData.txt");

        //Variables
        private int mls = 15000;
        private int mx = 30000;
        private int eMX = 25000;
        private int cMX = 30000;
        private int eCount = 0;
        private int cCount = 0;
        private int oneFourth = 0;
        private int oneHalf = 0;
        private int threeFourth = 0;
        private Color primaryColor = Color.FromArgb(255, 255, 255);
        private Color secondaryColor = Color.FromArgb(255, 255, 255);

        private string txt, vehicle;


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
                    vehicle = "Hennessey Venom F5";
                    break;
                case 2:
                    vehicle = "Koenigsegg Agera RS";
                    break;
                case 3:
                    vehicle = "Hennessey Venom GT ";
                    break;
                case 4:
                    vehicle = "Bugatti Chiron";
                    break;
                default:
                    vehicle = "Da-Pinto";
                    break;
            }

            //Write to the file
            File.WriteAllText(path, vehicle);

            //Read the file
            txt = File.ReadAllText(path);

            //Display the result
            generalMessageLB.Text = txt;
        }
    }
}
