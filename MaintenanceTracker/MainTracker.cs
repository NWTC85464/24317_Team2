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
    public partial class MainTracker : System.Windows.Forms.Form
    {
       

        public MainTracker()
        {
            InitializeComponent();

            //Form background color.
            this.BackColor = System.Drawing.Color.Aqua;

            //Form background image.
            /////
            //BackgroundImage = new Bitmap("tire.jpeg");

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }    
        
        private void Form1_Load(object sender, EventArgs e)
        {                       
            //Set color of buttons.
            tiresButton.BackColor = System.Drawing.Color.AliceBlue;
            airFilterButton.BackColor = System.Drawing.Color.AliceBlue;
            wipersButton.BackColor = System.Drawing.Color.AliceBlue;
            mpgButton.BackColor = System.Drawing.Color.AliceBlue;
            oilButton.BackColor = System.Drawing.Color.AliceBlue;
            settingsButton.BackColor = System.Drawing.Color.AliceBlue;

            //Set font of buttons.
            tiresButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            airFilterButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            wipersButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            mpgButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            oilButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            settingsButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);

            //Set border of buttons.
            tiresButton.FlatStyle = FlatStyle.Flat;
            tiresButton.FlatAppearance.BorderSize = 2;

            
        }

        public static int VehicalNumber;

        private void tiresButton_Click(object sender, EventArgs e)
        {
            //Call tires option form.
            TireOptionsForm tireOptionsForm = new TireOptionsForm(VehicalNumber);
            tireOptionsForm.ShowDialog();

            //Display on main form tire rotation set value.
            rotateMilagelbl.Text = tireOptionsForm.rotateMilage.ToString();
        }

        private void wipersButton_Click(object sender, EventArgs e)
        {
            //Call wipers options form.
            WipersOptionForm wipersOptionForm = new WipersOptionForm();
            wipersOptionForm.ShowDialog();
        }

        private void airFilterButton_Click(object sender, EventArgs e)
        {
            //Call air filter option form.
            AirFilterOptionsForm airFilterOptionsForm = new AirFilterOptionsForm();
            airFilterOptionsForm.ShowDialog();
        }

        private void mpgButton_Click(object sender, EventArgs e)
        {
            //Call mpg options form.
            MPGOptionsForm mPGOptionsForm = new MPGOptionsForm();
            mPGOptionsForm.ShowDialog();
        }

        private void oilButton_Click(object sender, EventArgs e)
        {
            //Call oil options form.
            OilOptionsForm oilOptionsForm = new OilOptionsForm();
            oilOptionsForm.ShowDialog();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            //Call settings option form.
            SettingsOptionForm settingsOptionForm = new SettingsOptionForm();
            settingsOptionForm.ShowDialog();
        }

        private void vehicalSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set vehical number from select list.
            VehicalNumber = vehicalSelectList.SelectedIndex;
        }
    }
}
