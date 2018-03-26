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
    public partial class MPGOptionsForm : System.Windows.Forms.Form
    {
        public MPGOptionsForm()
        {
            InitializeComponent();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MPGOptionsForm_Load(object sender, EventArgs e)
        {
            

        }

        double odoCur;
        double galCur;
        double curMpg;
        DateTime today1 = DateTime.Today;
        
        //ListBox lstb

        private void btnEnterMpg_Click(object sender, EventArgs e)
        {
            
            if(double.TryParse(txtbxOdoRead.Text, out odoCur))
            {
                //lblAlert.Text = "odoCur is: " + odoCur;
                if (double.TryParse(txtbxGallonsRead.Text, out galCur))
                {
                    curMpg = odoCur / galCur;

                    lblAlert.Text = "Current MPG is: " + curMpg;

                    //Enter math code here!
                    lstbxMpgHistory.Items.Add("Todays date: " + today1.ToString("d"));
                    lstbxMpgHistory.Items.Add( "current MPG: " + Math.Round(curMpg, 2));
                    lstbxMpgHistory.Items.Add("Odometer: " + Math.Round(odoCur, 2));
                    lstbxMpgHistory.Items.Add("Gallons used: " + Math.Round(galCur, 2));
                    dgTrack.Rows.Add(today1.ToString("d"), Math.Round(curMpg, 2), Math.Round(odoCur, 2), Math.Round(galCur, 2));
                    //dgTrack.Rows.Insert(0, new double[] { today1.ToString("d"), Math.Round(curMpg, 2), Math.Round(odoCur, 2), Math.Round(galCur, 2) });

                }
                else
                {
                    lblAlert.Text = "Please enter numbers in Current Gallons";
                    txtbxGallonsRead.Text = "";
                    txtbxGallonsRead.Focus();
                }
            }
            else
            {
                lblAlert.Text = "Please enter numbers in odometer";
                txtbxOdoRead.Text = "";
                txtbxOdoRead.Focus();
                
            }

            

        }
    }
}
