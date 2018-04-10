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
    public partial class OilOptionsForm : System.Windows.Forms.Form
    {
        public OilOptionsForm()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.Aqua;

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void OilTrackerForm(object sender, EventArgs e)
        {




        }

        private void exit(object sender, EventArgs e)
        {
            //close window
            this.Close();
        }

        private void FindNumber(object sender, EventArgs e)
        {
            double a = Amount.Value;

            double av = a * 0.1;

            // show oil amount in car
            AmountTotal.Text = av.ToString() + " quarts";

        }

        private void LockScoll(object sender, EventArgs e)
        {
            //lock or unlock slider
            if (Amount.Enabled == true)
            {
                Amount.Enabled = false;
            }
            else
            {
                Amount.Enabled = true;
            }

            // lock or unlock textbox
            if (Answer1.ReadOnly == false && Answer2.ReadOnly == false)
            {
                Answer1.ReadOnly = true;
                Answer2.ReadOnly = true;
            }
            else 
            {
                Answer1.ReadOnly = false;
                Answer2.ReadOnly = false;
                
            }

        }





    }
}
