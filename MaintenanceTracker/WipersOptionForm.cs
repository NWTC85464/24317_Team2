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
        public int vehicleNum;          //Holds Vehicle number.
        string nextInstallDateParse;
        string installedDateParse;
        double driver;
        double passager;
        double rear;
        string brand;

        
        public WipersOptionForm()
        {
            InitializeComponent();

            //Set Vehicle number and mpg from passed in value.
            //this.vehicleNum = vehicleNum;

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
               
                //installedDateTimePicker.Text = wipersOptionsClass.Vehicle1Values[2];
                
                //Call progressBar method.
                //progressBar(vehicleNum, wipersOptionsClass.Vehicle1Values[0]);
            }
            else if (wipersOptionsClass.V2Stored == 1 && vehicleNum == 2)
            {
                
                vehicleNumLabel.Text = "Wiper Info for Vehicle #" + wipersOptionsClass.Vehicle2Values[0];
                //installDateTextBox.Text = wipersOptionsClass.Vehicle2Values[2];

                //Call ProgressBar method.
                //progressBar(vehicleNum, wipersOptionsClass.Vehicle2Values[0]);
            }
            else if (wipersOptionsClass.V3Stored == 1 && vehicleNum == 3)
            {
                //Fill form with array values.......
                
                //installedDateTimePicker.Text = wipersOptionsClass.Vehicle3Values[2];
                vehicleNumLabel.Text = "Wiper Info for Vehicle #" + wipersOptionsClass.Vehicle3Values[0];
                                
                //Call progressBar method.
                //progressBar(vehicleNum, wipersOptionsClass.Vehicle3Values[1]);
            }
            else if (wipersOptionsClass.V4Stored == 1 && vehicleNum == 4)
            {
                
                installedDateTimePicker.Text = wipersOptionsClass.Vehicle4Values[2];
                vehicleNumLabel.Text = "Wiper Info for Vehicle #" + wipersOptionsClass.Vehicle4Values[0];
                  
                //Call progressBar method.
                //progressBar(vehicleNum, wipersOptionsClass.Vehicle4Values[1]);
            }
            else
            {
                
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

            // Enable the fields to be edited
            installedDateTimePicker.Enabled = true;
            nextReplaceDateDisplayLabel.Enabled = true;
            driverSideTextBox.Enabled = true;
            passagerSideTextBox.Enabled = true;
            rearTextBox.Enabled = true;
            brandTextBox.Enabled = true;
            notesTextBox.Enabled = true;
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

                DateTime nextInstallDate = thisDay.AddDays(180);

                nextInstallDateParse = nextInstallDate.ToString("D");

                installedDateParse = thisDay.ToString("D");   // To be passed to be stored

                // Display the next replacement date.
                nextReplaceDateDisplayLabel.Text = nextInstallDateParse.ToString();
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
                //double driver;
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
                //double passager;
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
                //double rear;
                if (!double.TryParse(rearTextBox.Text, out rear))
                {
                    MessageBox.Show("This is a number only field");
                    rearTextBox.Focus();
                    return;
                }

            }

            //Brand name
            if (string.IsNullOrWhiteSpace(brandTextBox.Text))
            {
                MessageBox.Show("Please enter brand name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                brandTextBox.Focus();
                //notes = notesTextBox.Text;
            }
            else
            {

                // Pass info to be stored
                //storeWipersInfo(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brand, notesTextBox.Text);

                // Lock everything
                installedDateTimePicker.Enabled = false;
                nextReplaceDateDisplayLabel.Enabled = false;
                driverSideTextBox.Enabled = false;
                passagerSideTextBox.Enabled = false;
                rearTextBox.Enabled = false;
                brandTextBox.Enabled = false;
                notesTextBox.Enabled = false;
            }
        }
       
    }


}

