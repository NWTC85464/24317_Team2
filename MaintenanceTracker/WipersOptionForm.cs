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
using System.Drawing.Drawing2D;

namespace MaintenanceTracker
{
    public partial class WipersOptionForm : System.Windows.Forms.Form
    {
         WipersOptionsClass wipersOptionsClass = new WipersOptionsClass();
        //Variables.
        public int vehicleNum;          //Holds vehical number.

        //Create paths to hold each vehicle's info - save text files.
        string path1 = @"C:\Users\x12 t2015\source\repos\24317_Team2g1\MaintenanceTracker\Resources\v1Info.txt";
        string path2 = @"C:\Users\x12 t2015\source\repos\24317_Team2g1\MaintenanceTracker\Resources\v2Info.txt";
        string path3 = @"C:\Users\x12 t2015\source\repos\24317_Team2g1\MaintenanceTracker\Resources\v3Info.txt";
        string path4 = @"C:\Users\x12 t2015\source\repos\24317_Team2g1\MaintenanceTracker\Resources\v4Info.txt";


        public WipersOptionForm(int vehicleNum)
        {
            InitializeComponent();

            //Set vehical number and mpg from passed in value.
            this.vehicleNum = vehicleNum;

            //Form background color.
            this.BackColor = System.Drawing.Color.Aqua;
                        
            //this.BackgroundImage = Properties.Resources.wiper;  
           
            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }
      
        private void WipersOptionForm_Load(object sender, EventArgs e)
        {
            tipAndInfoButton.BackColor = System.Drawing.Color.AliceBlue;

            tipAndInfoButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);

            tipAndInfoButton.FlatStyle = FlatStyle.Flat;
            tipAndInfoButton.FlatAppearance.BorderSize = 2;

            // Display wiper info for the selected vehicle
            vehicleNumLabel.Text = "Wiper Info for Vehicle #" + vehicleNum;

            if (wipersOptionsClass.V1Stored == 1 && vehicleNum == 1)
            {
                //Fill form with array values.......
                vehicleNumLabel.Text = "Wiper Info for Vehicle #" + wipersOptionsClass.Vehicle1Values[0];
                //sliderValueLbl.Text = wipersOptionsClass.Vehicle1Values[1];
                //milageTrackBar.Value = Int32.Parse(wiperOptionClass.Vehical1Values[1]);
                installedDateTimePicker.Text = wipersOptionsClass.Vehicle1Values[2];


                //Deactivate the track bar slide
                //milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                //lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                //scrollLock = 1;

                //Call progressBar method.
                progressBar(vehicleNum, wipersOptionsClass.Vehicle1Values[0]);
            }
            else if (wipersOptionsClass.V2Stored == 1 && vehicleNum == 2)
            {
                //Fill form with array values.......
                //sliderValueLbl.Text = wipersOptionsClass.Vehicle2Values[1];
                //milageTrackBar.Value = Int32.Parse(wipersOptionsClass.Vehicle2Values[1]);
                //installDateTextBox.Text = wipersOptionsClass.Vehicle2Values[2];
                vehicleNumLabel.Text = "Wiper Info for Vehicle #" + wipersOptionsClass.Vehicle2Values[0];

                //Deactivate the track bar slide
                //milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                //lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                //scrollLock = 1;

                //Call ProgressBar method.
                progressBar(vehicleNum, wipersOptionsClass.Vehicle2Values[0]);
            }
            else if (wipersOptionsClass.V3Stored == 1 && vehicleNum == 3)
            {
                //Fill form with array values.......
                //sliderValueLbl.Text = wipersOptionsClass.Vehicle3Values[1];
                //milageTrackBar.Value = Int32.Parse(wipersOptionsClass.Vehicle3Values[1]);
                installedDateTimePicker.Text = wipersOptionsClass.Vehicle3Values[2];
                vehicleNumLabel.Text = "Wiper Info for Vehicle #" + wipersOptionsClass.Vehicle3Values[0];

                //Deactivate the track bar slide
                //milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                //lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                //scrollLock = 1;

                //Call progressBar method.
                progressBar(vehicleNum, wipersOptionsClass.Vehicle3Values[1]);
            }
            else if (wipersOptionsClass.V4Stored == 1 && vehicleNum == 4)
            {
                //Fill form with array values.......
                //sliderValueLbl.Text = wipersOptionsClass.Vehicle4Values[1];
                //milageTrackBar.Value = Int32.Parse(wipersOptionsClass.Vehicle4Values[1]);
                installedDateTimePicker.Text = wipersOptionsClass.Vehicle4Values[2];
                vehicleNumLabel.Text = "Wiper Info for Vehicle #" + wipersOptionsClass.Vehicle4Values[0];

                //Deactivate the track bar slide
                //milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                //lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                //scrollLock = 1;

                //Call progressBar method.
                progressBar(vehicleNum, wipersOptionsClass.Vehicle4Values[1]);
            }
            else
            {
                //Set the slider value label inital to 0.
                //sliderValueLbl.Text = "5000";
                vehicleNumLabel.Text = "Wiper Info for Vehicle #" + vehicleNum;

                ////Added for progressbar.
                progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            }

        }

        // Exit the app
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Select data wipers are installed
        private void installedDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            // Get the current date.
            DateTime thisDay = installedDateTimePicker.Value.Date;

            DateTime answer = thisDay.AddDays(180);

            string day = answer.ToString("D");
            // Display the next replacement date.
            nextReplaceDateDisplayLabel.Text = day.ToString();
        }

        // View tips and more info
        private void tipAndInfoButton_Click_1(object sender, EventArgs e)
        {
            //Call Tips and Info form.
            WipersOptionsTipsAndInfo wipersTipsAndInfo = new WipersOptionsTipsAndInfo();
            wipersTipsAndInfo.ShowDialog();
        }

        // Reset the form
        private void resetButton_Click_1(object sender, EventArgs e)
        {
            installedDateTimePicker.ResetText();
            nextReplaceDateDisplayLabel.Text = "";
            driverSideTextBox.Clear();
            passagerSideTextBox.Clear();
            rearTextBox.Clear();
            brandTextBox.Clear();
            notesTextBox.Clear();
        }

        // Save the info entered
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            //***** NEED DATA STORAGE **************

            
            // Check to see if next replacement date is filled
            if (String.IsNullOrEmpty(nextReplaceDateDisplayLabel.Text))
            {
                MessageBox.Show("Please select date wiper was installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                installedDateTimePicker.Focus();
            }
            else if (!String.IsNullOrEmpty(nextReplaceDateDisplayLabel.Text))
            {
                // Get the current date.
                DateTime thisDay = installedDateTimePicker.Value.Date;

                DateTime answer = thisDay.AddDays(180);

                string day = answer.ToString("D");
                // Display the next replacement date.
                nextReplaceDateDisplayLabel.Text = day.ToString();
            }
            
            // Customer can leave wiper size textboxes blank
            // If textboxes are filled, check to see if they are in correct format
            // Driver side
            if (String.IsNullOrEmpty(driverSideTextBox.Text))
            {
                MessageBox.Show("Please enter driver side wiper size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else
            {
                double driver;
                    if (!double.TryParse(driverSideTextBox.Text, out driver))
                    {
                        MessageBox.Show("This is a number only field");
                        driverSideTextBox.Focus();
                        return;
                    }

                }

            //Passage side
            if (String.IsNullOrEmpty(passagerSideTextBox.Text))
            {
                MessageBox.Show("Please enter passager side wiper size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dataGridView1.Rows.Clear();
            }
            else
            {
                double passager;
                if (!double.TryParse(passagerSideTextBox.Text, out passager))
                {
                    MessageBox.Show("This is a number only field");
                    passagerSideTextBox.Focus();
                    return;
                }

            }

            //Rear
            if (String.IsNullOrEmpty(rearTextBox.Text))
            {
                MessageBox.Show("Please enter rear wiper size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dataGridView1.Rows.Clear();
            }
            else
            {
                double rear;
                if (!double.TryParse(rearTextBox.Text, out rear))
                {
                    MessageBox.Show("This is a number only field");
                    rearTextBox.Focus();
                    return;
                }

            }
            
            //Brand name
            if (string.IsNullOrWhiteSpace(notesTextBox.Text))
            {
                MessageBox.Show("Please enter brand name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                notesTextBox.Focus();              
                
            }
            

        }

        // Progress Bar
        private void progressBar(int vehicalNum, string rotateValue)
        {
            int vehNum = vehicalNum;
            //int miles = milage;
            //int rotate = Int32.Parse(rotateValue);
            //double mil = System.Convert.ToDouble(milage);
            //double rot = double.Parse(rotateValue);

            //Display the percentage remaining and round.            
            double percentLeft = Math.Round((100 - (100 * (mil / rot))), 2);
            percentLbl.Text = percentLeft.ToString() + "%";

            try
            {
                //progressBar1.Maximum = rotate;
                progressBar1.Value = progressBar1.Maximum - miles;

                if (progressBar1.Value > (rotate / 2))
                {
                    progressBar1.ForeColor = Color.Green;
                }
                else if ((progressBar1.Value <= (rotate / 2)) && progressBar1.Value > rotate / 4)
                {
                    progressBar1.ForeColor = Color.Yellow;
                }
                else if (progressBar1.Value <= rotate / 4 && progressBar1.Value > 0)
                {
                    progressBar1.ForeColor = Color.Red;
                }
                else if (progressBar1.Value <= 0)
                {
                    MessageBox.Show("Tire need to be rotated");
                }
            }
            catch
            {
                MessageBox.Show("Tire need to be rotated");
                //Do nothing.....
            }
        }
    }
}

