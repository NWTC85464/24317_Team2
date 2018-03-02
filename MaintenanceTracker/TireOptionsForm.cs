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
    public partial class TireOptionsForm : Form
    {
        public TireOptionsForm()
        {
            InitializeComponent();
          
            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Variable to store value to lock track bar.
        public int scrollLock = 0;

        private void TireOptionsForm_Load(object sender, EventArgs e)
        {
            //Set the slider value label inital to 0.
            sliderLbl.Text = "0";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Display the sliders current value in label.
            sliderLbl.Text = trackBar1.Value.ToString();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            //If else statment to lock the track bar from being adjusted.
            if(scrollLock == 0)
            {
                trackBar1.Enabled = false;

                //Locks the track bar.
               // trackBar1.SmallChange = 0;
               // trackBar1.LargeChange = 0;

                //Set the lock button back color.
                button3.BackColor = System.Drawing.Color.Orange;

                //Set scrollLock value to 1.
                scrollLock = 1;
            }
            else if (scrollLock == 1)
            {
                trackBar1.Enabled = true;

                //Set track Bar values back.
                //trackBar1.SmallChange = 1;
                //trackBar1.LargeChange = 5;

                //Set the lock button back color.
                button3.BackColor = System.Drawing.Color.LightGray;

                //Set the scrollLock value to 0.
                scrollLock = 0;
            }


    

        }
    }
}
