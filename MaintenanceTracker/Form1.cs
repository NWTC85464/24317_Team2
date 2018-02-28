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
    public partial class Form1 : Form
    {
        public Form1()
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
            //Hide the exit button.
            exitButton.Visible = false;

            //Set color of buttons.
            tiresButton.BackColor = System.Drawing.Color.AliceBlue;
            airFilterButton.BackColor = System.Drawing.Color.AliceBlue;
            wipersButton.BackColor = System.Drawing.Color.AliceBlue;
            mpgButton.BackColor = System.Drawing.Color.AliceBlue;
            oilButton.BackColor = System.Drawing.Color.AliceBlue;
            exitButton.BackColor = System.Drawing.Color.AliceBlue;
            settingsButton.BackColor = System.Drawing.Color.AliceBlue;

            //Set font of buttons.
            tiresButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            airFilterButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            wipersButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            mpgButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            oilButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            exitButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            settingsButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);

            //Set border of buttons.
            tiresButton.FlatStyle = FlatStyle.Flat;
            tiresButton.FlatAppearance.BorderSize = 2;            
        }

        private void tiresButton_Click(object sender, EventArgs e)
        {
            //Call tires option form.
            TireOptionsForm tireOptionsForm = new TireOptionsForm();
            tireOptionsForm.ShowDialog();
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
        private void exitButton_Click(object sender, EventArgs e)
        {
            /*
            tiresButton.Visible = true;
            airFilterButton.Visible = true;
            oilButton.Visible = true;
            wipersButton.Visible = true;
            mpgButton.Visible = true;
            exitButton.Visible = true;
            settingsButton.Visible = true;
            */
        }

    }
}
