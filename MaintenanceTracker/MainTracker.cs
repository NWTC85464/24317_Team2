using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MaintenanceTracker
{
    public partial class MainTracker : System.Windows.Forms.Form
    {
        TireOptionsClass tireOptionsClass = new TireOptionsClass();
        MainFormClass mainFormClass = new MainFormClass();
   
        //public int milesDriven = 0;
       // public int odometerReading = 0;

        public double odo;

        //private double milesDriven=0;

        //public double MilesDriven { get => milesDriven; set => milesDriven = value; }

        public MainTracker()
        {
            InitializeComponent();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            //Set font of buttons.
            tiresButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            airFilterButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            wipersButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            mpgButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            oilButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            settingsButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
        }

        private void TiresButton_Click(object sender, EventArgs e)
        {
            double md = mainFormClass.MilesDriven;
            int mmdd = Convert.ToInt32(md);
            //Variable.
            int vn; //To hold vehical number.

            //Set vn to vehicalSelectList number and add 1.
            vn = vehicalSelectList.SelectedIndex + 1;

            //Create new instance of tireOptionsForm and pass vn and MPG.
            TireOptionsForm tireOptionsForm = new TireOptionsForm(vn, mmdd);//, odometerReading);            
            
             if (vehicalSelectList.SelectedItem == null)
             {
                 //Display message saying select vehical.              
                 MessageBox.Show("Please Select a vehical first!");
             }
             else
             {
                 //Show the form.              
                 tireOptionsForm.ShowDialog();
             }
            
            /*
            //Test code only.........
            int vn;
            vn = 1;
            TireOptionsForm tireOptionsForm = new TireOptionsForm(vn, milesDriven, odometerReading);
            tireOptionsForm.ShowDialog();
           */ 
        }

        private void wipersButton_Click(object sender, EventArgs e)
        {
            int vn; // Vehicle number

            vn = vehicalSelectList.SelectedIndex + 1;

            //Call wipers options form.
            WipersOptionForm wipersOptionForm = new WipersOptionForm(vn);

            if (vehicalSelectList.SelectedItem == null)
            {
                //Display message saying select vehical.              
                MessageBox.Show("Please Select a vehical first!");
            }
            else
            {
                //Show the form.             
                wipersOptionForm.ShowDialog();
            }
        }


        private void airFilterButton_Click(object sender, EventArgs e)
        {
            //Call air filter option form.
            AirFilterOptionsForm airFilterOptionsForm = new AirFilterOptionsForm();


            if (vehicalSelectList.SelectedItem == null)
            {
                //Display message saying select vehical.              
                MessageBox.Show("Please Select a vehical first!");
            }
            else
            {
                //Show the form.             
                airFilterOptionsForm.ShowDialog();
            }
        }

        private void MpgButton_Click(object sender, EventArgs e)
        {
            //Call mpg options form.
            MPGOptionsForm mPGOptionsForm = new MPGOptionsForm();
             //mPGOptionsForm.ShowDialog();
            //mpg += 500;
            if (vehicalSelectList.SelectedItem == null)
            {
                //Display message saying select vehical.              
                MessageBox.Show("Please Select a vehical first!");
            }
            else
            {
                //Show the form.              
                mPGOptionsForm.ShowDialog();
            }
            
        }

        private void OilButton_Click(object sender, EventArgs e)
        {
            //Call oil options form.
            OilOptionsForm oilOptionsForm = new OilOptionsForm();
            oilOptionsForm.ShowDialog();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            //Call settings option form.
            SettingsOptionForm settingsOptionForm = new SettingsOptionForm();
            settingsOptionForm.ShowDialog();
        }

        private void VehicalSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Variable.
            int vn; //To hold vehical number.

            //Set vn to vehicalSelectList number and add 1.
            vn = vehicalSelectList.SelectedIndex + 1;

            //Set the Vehical Number
            mainFormClass.VehicalNumber = vn;

            string checkFile = "";
            string[] holdOdo= new string[4];

            switch (vn)
            {
                case 1:
                    checkFile = @"mpg/mpg1.txt";

                    if (File.Exists(checkFile))
                    {
                        var lastLine = File.ReadLines(@"mpg/mpg1.txt").Last();
                        //MessageBox.Show(lastLine);


                        int j = 0;
                        foreach (var col in lastLine.Trim().Split(' '))
                        {
                            holdOdo[j] = col.Trim();
                            j++;
                        }


                        odo = double.Parse(holdOdo[2]);
                        //MessageBox.Show("this is parsed: " + odo);

                    }
                    else
                    {
                        //do nothing
                    }

                    break;
                case 2:
                    checkFile = @"mpg/mpg2.txt";

                    if (File.Exists(checkFile))
                    {
                        var lastLine = File.ReadLines(@"mpg/mpg2.txt").Last();
                        //MessageBox.Show(lastLine);


                        int j = 0;
                        foreach (var col in lastLine.Trim().Split(' '))
                        {
                            holdOdo[j] = col.Trim();
                            j++;
                        }


                        odo = double.Parse(holdOdo[2]);
                        //MessageBox.Show("this is parsed: " + odo);

                    }
                    else
                    {
                        //do nothing
                    }
                    break;
                case 3:
                    checkFile = @"mpg/mpg3.txt";

                    if (File.Exists(checkFile))
                    {
                        var lastLine = File.ReadLines(@"mpg/mpg3.txt").Last();
                        //MessageBox.Show(lastLine);


                        int j = 0;
                        foreach (var col in lastLine.Trim().Split(' '))
                        {
                            holdOdo[j] = col.Trim();
                            j++;
                        }


                        odo = double.Parse(holdOdo[2]);
                        //MessageBox.Show("this is parsed: " + odo);

                    }
                    else
                    {
                        //do nothing
                    }
                    break;
                case 4:
                     checkFile = @"mpg/mpg4.txt";
                
                    if (File.Exists(checkFile))
                    {
                        var lastLine = File.ReadLines(@"mpg/mpg4.txt").Last();
                        //MessageBox.Show(lastLine);

                       
                            int j = 0;
                            foreach (var col in lastLine.Trim().Split(' '))
                            {
                                holdOdo[j] = col.Trim();
                                j++;
                            }
                        

                        odo = double.Parse(holdOdo[2]);
                        //MessageBox.Show("this is parsed: "+ odo);
                            
                    }
                    else
                    {
                        //do nothing
                    }

                    break;
                default:
                    MessageBox.Show("did not work");
                    break;

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //milesDriven += 100;
            //odometerReading += 50000;
        }
    }
}
