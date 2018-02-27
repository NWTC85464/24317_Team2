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
            this.BackColor = System.Drawing.Color.Aqua;
            BackgroundImage = new Bitmap("tire.jpeg");
            
           // form.StartPosition = FormStartPosition.CenterScreen; form1.ShowDialog();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            exitButton.Visible = false;
            tiresButton.BackColor = System.Drawing.Color.AliceBlue;
            airFilterButton.BackColor = System.Drawing.Color.AliceBlue;
            wipersButton.BackColor = System.Drawing.Color.AliceBlue;
            mpgButton.BackColor = System.Drawing.Color.AliceBlue;
            oilButton.BackColor = System.Drawing.Color.AliceBlue;
            exitButton.BackColor = System.Drawing.Color.AliceBlue;
            settingsButton.BackColor = System.Drawing.Color.AliceBlue;

            tiresButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            airFilterButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            wipersButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            mpgButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            oilButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            exitButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);
            settingsButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);

            tiresButton.FlatStyle = FlatStyle.Flat;
            tiresButton.FlatAppearance.BorderSize = 2;
            
        }

        private void tiresButton_Click(object sender, EventArgs e)
        {
            //airFilterButton.Visible = false;
           // oilButton.Visible = false;
           // wipersButton.Visible = false;
           // mpgButton.Visible = false;
           // exitButton.Visible = true;
           // settingsButton.Visible = false;

            //Call tires option form.
            TireOptionsForm tireOptionsForm = new TireOptionsForm();
            tireOptionsForm.ShowDialog();

        }

        private void wipersButton_Click(object sender, EventArgs e)
        {
            tiresButton.Visible = false;
            airFilterButton.Visible = false;
            oilButton.Visible = false;
            mpgButton.Visible = false;
            exitButton.Visible = true;
            settingsButton.Visible = false;

            //Call wipers options form.
            WipersOptionForm wipersOptionForm = new WipersOptionForm();
            wipersOptionForm.ShowDialog();
        }

        private void airFilterButton_Click(object sender, EventArgs e)
        {
            tiresButton.Visible = false;
            oilButton.Visible = false;
            wipersButton.Visible = false;
            mpgButton.Visible = false;
            exitButton.Visible = true;
            settingsButton.Visible = false;
        }

        private void mpgButton_Click(object sender, EventArgs e)
        {
            tiresButton.Visible = false;
            airFilterButton.Visible = false;
            oilButton.Visible = false;
            wipersButton.Visible = false;
            exitButton.Visible = true;
            settingsButton.Visible = false;
        }

        private void oilButton_Click(object sender, EventArgs e)
        {
            tiresButton.Visible = false;
            airFilterButton.Visible = false;
            wipersButton.Visible = false;
            mpgButton.Visible = false;
            exitButton.Visible = true;
            settingsButton.Visible = false;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            tiresButton.Visible = false;
            airFilterButton.Visible = false;
            wipersButton.Visible = false;
            mpgButton.Visible = false;
            oilButton.Visible = false;
            exitButton.Visible = true;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            tiresButton.Visible = true;
            airFilterButton.Visible = true;
            oilButton.Visible = true;
            wipersButton.Visible = true;
            mpgButton.Visible = true;
            exitButton.Visible = true;
            settingsButton.Visible = true;

        }

    }
}
