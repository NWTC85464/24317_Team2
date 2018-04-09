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
        String[] wipersInfo = new String[7]; //array to store wipers information

        public WipersOptionForm()
        {
            InitializeComponent();
            //today
            //Form background color.
            //this.BackColor = System.Drawing.Color.Aqua;
                        
            this.BackgroundImage = Properties.Resources.wiper;  
           
            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }
      
        private void WipersOptionForm_Load(object sender, EventArgs e)
        {
            tipAndInfoButton.BackColor = System.Drawing.Color.AliceBlue;

            tipAndInfoButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);

            tipAndInfoButton.FlatStyle = FlatStyle.Flat;
            tipAndInfoButton.FlatAppearance.BorderSize = 2;

            /*
             * displaying 
            for(int i = 0, i < 7, i++)
            {
                wipersInfo[0] = installedDateTimePicker.Text
                wipersInfo[1] = nextReplaceDateTextBox.Text;
                wipersInfo[2] = driverSideTextBox.Text;
                wipersInfo[3] = passagerSideTextBox.Text;
                wipersInfo[4] = rearTextBox.Text;
                wipersInfo[5] = brandTextBox.Text;
                wipersInfo[6] = notesTextBox.Text;
            }
            */
        }

      
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void installedDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            // Get the current date.
            DateTime thisDay = installedDateTimePicker.Value.Date;

            DateTime answer = thisDay.AddDays(180);

            string day = answer.ToString("D");
            // Display the next replacement date.
            nextReplaceDateDisplayLabel.Text = day.ToString();
        }

        private void tipAndInfoButton_Click_1(object sender, EventArgs e)
        {
            //Call Tips and Info form.
            WipersOptionsTipsAndInfo wipersTipsAndInfo = new WipersOptionsTipsAndInfo();
            wipersTipsAndInfo.ShowDialog();
        }

        private void resetButton_Click_1(object sender, EventArgs e)
        {
            //reset the form
            installedDateTimePicker.ResetText();
            nextReplaceDateDisplayLabel.Text = "";
            driverSideTextBox.Clear();
            passagerSideTextBox.Clear();
            rearTextBox.Clear();
            brandTextBox.Clear();
            notesTextBox.Clear();
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            //***** NEED DATA STORAGE **************

            
            //Check to see if next replacement date is filled
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
            
            //Customer can leave wiper size textboxes blank
            //If textboxes are filled, check to see if they are in correct format
            //Driver side
            if (String.IsNullOrEmpty(driverSideTextBox.Text))
            {
                MessageBox.Show("Please enter driver side wiper size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //dataGridView1.Rows.Clear();
            }
            else
            {
                double d;
                    if (!double.TryParse(driverSideTextBox.Text, out d))
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
                double d;
                if (!double.TryParse(passagerSideTextBox.Text, out d))
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
                double d;
                if (!double.TryParse(rearTextBox.Text, out d))
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
            else
            {
                /*
                string text = notesTextBox.Text;
                if (String.IsNullOrEmpty(text))
                {
                    // Do something 
                }
                */
            }
            /*
            double driverSideSize = double.Parse(driverSideTextBox.Text);
            double passagerSideSize = double.Parse(passagerSideTextBox.Text);
            double rearSize = double.Parse(rearTextBox.Text);
            String notes = notesTextBox.ToString();
            */
        }
    }
}

