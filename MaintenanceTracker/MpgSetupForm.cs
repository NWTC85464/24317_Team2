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
    public partial class MpgSetupForm : Form
    {
        public MpgSetupForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        //MPGOptionsForm Optionform = new MPGOptionsForm();
        double startOdo;

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtbxStartOdo.Text, out startOdo))
            {
                if (startOdo < 1000000)
                {
                    MPGOptionsForm.startOdo = this.startOdo;
                    this.Close();
                }
                else
                {
                    introLbl1.Text = "";
                    introLbl2.Text = "Odometer must be below 1 million";
                    txtbxStartOdo.Focus();
                    return;
                }
            }
            else
            {
                introLbl1.Text = "";
                introLbl2.Text = "Please enter a number";
                txtbxStartOdo.Focus();
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MPGOptionsForm.cancStart = true;
            this.Close();
            
        }
    }
}
