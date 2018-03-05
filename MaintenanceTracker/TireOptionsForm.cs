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
        public int rotateMilage;
        public TireOptionsForm()
        {            
            InitializeComponent();
          
            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;     
        }

        //Array list to hold the tire values.  
        string[] tireValues = new string[4];

        //Variables.
        public int scrollLock = 0;          //Store value to lock track bar.  
        public string tireSize = "";        //Store size value.
        public string tireBrand = "";       //Store brand value.
        public string installDate = "";     //Store install date value.
        public string prevRotate = "";      //Store previous rotate date value.
        public string rotateMessage = "Michelin Recomends: During rotation, each tire and wheel is removed from your " +
            "vehicle and moved to a different position to ensure that all tires wear evenly and last longer. " +
            "Tires should be rotated every six months or 6,000 to 8,000 miles.";
        private void TireOptionsForm_Load(object sender, EventArgs e)
        {
            //Set the slider value label inital to 0.
            sliderValueLbl.Text = "5000";
            infoLbl.Text = rotateMessage;
        }

        //Button to store the values enter in the text boxes into a list.
        private void storeValuesButton_Click(object sender, EventArgs e)
        {
            tireSize = tireSizeTextBox.Text;
            tireBrand = tireBrandTextBox.Text;
            installDate = installDateTextBox.Text;
            prevRotate = prevRotateDateTextBox.Text;

            //Add tire values to array list.
            tireValues[0] = tireSize;
            tireValues[1] = tireBrand;
            tireValues[2] = installDate;
            tireValues[3] = prevRotate;           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Display the sliders current value in label.
            sliderValueLbl.Text = milageTrackBar.Value.ToString();

            //Store track bar value for label on main form.
            rotateMilage = milageTrackBar.Value;           
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
            for (int index = 0; index < tireValues.Length; index++)
            {
                tireValues[index] = "";
            }

            //Clear text boxes.
            tireSizeTextBox.Text = "";
            tireBrandTextBox.Text = "";
            installDateTextBox.Text = "";
            prevRotateDateTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }       
    }
}
