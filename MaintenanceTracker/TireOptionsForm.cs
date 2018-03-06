using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceTracker
{
    public partial class TireOptionsForm : System.Windows.Forms.Form
    {
       
        //public static int vns;      //Hold vehical index value from main form.
        TireOptionsClass tireOptionsClass = new TireOptionsClass();
        MainFormClass mainFormClass = new MainFormClass();
        MainTracker mainTracker = new MainTracker();
        int vs;

        public TireOptionsForm(int vId)
        {
            vs = vId;
            InitializeComponent();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;     
        }

        //Variables
        private int scrollLock = 0;          //Store value to lock track bar. 
       


        private void TireOptionsForm_Load(object sender, EventArgs e)
        {
            //Set the slider value label inital to 0.
            sliderValueLbl.Text = "5000";
            infoLbl.Text = tireOptionsClass.RotateMessage;
            
        }
        
        //Button to store the values enter in the text boxes into a list.
        private void storeValuesButton_Click(object sender, EventArgs e)
        {
            //Store track bar value in tireOptionsClass variable for label on main form.  
            tireOptionsClass.RotateMilage = milageTrackBar.Value;

            tireOptionsClass.TireSize = tireSizeTextBox.Text;
            tireOptionsClass.TireBrand = tireBrandTextBox.Text;
            tireOptionsClass.InstallDate = installDateTextBox.Text;
            tireOptionsClass.PrevRotate = prevRotateDateTextBox.Text;

            //Add tire values to array list.

            tireOptionsClass.TireValues[0] = vs.ToString(); //Enter vehical value into array.
            tireOptionsClass.TireValues[1] = tireOptionsClass.TireSize;
            tireOptionsClass.TireValues[2] = tireOptionsClass.TireBrand;
            tireOptionsClass.TireValues[3] = tireOptionsClass.InstallDate;
            tireOptionsClass.TireValues[4] = tireOptionsClass.PrevRotate;
            tireOptionsClass.TireValues[5] = tireOptionsClass.RotateMilage.ToString();

            
        }

        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Display the sliders current value in label.
            sliderValueLbl.Text = milageTrackBar.Value.ToString();

         
            
        }

        private void lockTrackBarButton_Click_1(object sender, EventArgs e)
        {
            //If else statment to lock the track bar from being adjusted.
            if (scrollLock == 0)
            {
                //Deactivate the track bar slide
                milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                lockTrackBarButton.Image = new Bitmap("lock.png");

                //Set scrollLock value to 1.
                scrollLock = 1;
            }
            else if (scrollLock == 1)
            {
                //Reactivate the track bar slide
                milageTrackBar.Enabled = true;

                //Set the lock button back color.
                lockTrackBarButton.Image = new Bitmap("unlock.png");

                //Set the scrollLock value to 0.
                scrollLock = 0;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Prompt user if they want to reset values.
            DialogResult res = MessageBox.Show("Are you sure you want to Reset Values?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                
                //Reset milage value and unlock track bar.
                //
                //Reactivate the track bar slide
                milageTrackBar.Enabled = true;

                //Set the lock button back to unlock.
                lockTrackBarButton.Image = new Bitmap("unlock.png");

                //Set the scrollLock value to 0.
                scrollLock = 0;

                //Set track bar value and lbl to "0".
                milageTrackBar.Value = 5000;
                sliderValueLbl.Text = milageTrackBar.Value.ToString();

                //Reset tire values array.          
                for (int index = 0; index < tireOptionsClass.TireValues.Length; index++)
                {
                    tireOptionsClass.TireValues[index] = "";
                }

                //Clear text boxes.
                tireSizeTextBox.Text = "";
                tireBrandTextBox.Text = "";
                installDateTextBox.Text = "";
                prevRotateDateTextBox.Text = "";

                //Display message everything was reset.
                MessageBox.Show("All values have been Reset!", "Success");
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked Cancel Button");        
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
