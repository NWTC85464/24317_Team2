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

                    //lblAlert.Text = "Current MPG is: " + curMpg;

                    //Enter math code here!
                    dgTrack.Rows.Add(today1.ToString("d"), Math.Round(curMpg, 2), Math.Round(odoCur, 2), Math.Round(galCur, 2));
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

        private void btnExitMpg_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter objWrt;
            objWrt = new System.IO.StreamWriter(@".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\odo.txt", true);
            string createText = odoCur + "\n";
            objWrt.WriteLine(createText);
            objWrt.Close();
            //File.WriteAllText(@"C:\Users\Andrew\Source\Repos\24317_Team2\MaintenanceTracker\Resources\odo.txt", createText);

            // Open the file to read from.
            //string readText = File.ReadAllText(@"C:\Users\Andrew\Source\Repos\24317_Team2\MaintenanceTracker\Resources\odo.txt");
        }
    }
}
