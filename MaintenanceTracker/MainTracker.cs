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
        TireOptionsClass tireOptionsClass = new TireOptionsClass();
        MainFormClass mainFormClass = new MainFormClass();

        public int mpg;

        public MainTracker()
        {
            InitializeComponent();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }    
        
        private void Form1_Load(object sender, EventArgs e)
        {            
            //Set font of buttons.
            tiresButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            airFilterButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            wipersButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            mpgButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            oilButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
            settingsButton.Font = new Font("Rockwell", 10f, FontStyle.Bold);
        }
        
       

        private void tiresButton_Click(object sender, EventArgs e)
        {
            //Variable.
            int vn; //To hold vehical number.

            //Set vn to vehicalSelectList number and add 1.
            vn = vehicalSelectList.SelectedIndex + 1;

            //Create new instance of tireOptionsForm and pass vn and MPG.
            TireOptionsForm tireOptionsForm = new TireOptionsForm(vn, mpg);
           
            //Show the form.              
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
            //MPGOptionsForm mPGOptionsForm = new MPGOptionsForm();
            // mPGOptionsForm.ShowDialog();
            mpg += 500;
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
    }
}
