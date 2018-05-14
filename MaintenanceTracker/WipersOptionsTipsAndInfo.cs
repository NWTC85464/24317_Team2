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
    public partial class WipersOptionsTipsAndInfo : Form
    {
        public WipersOptionsTipsAndInfo()
        {
            InitializeComponent();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void WipersOptionsTipsAndInfo_Load(object sender, EventArgs e)
        {
            //Form background color.
            this.BackColor = System.Drawing.Color.LightSkyBlue;

           
        }

        private void exitTipsInfoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
