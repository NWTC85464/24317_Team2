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
        //array for odometer readings
        string[] odoRay = new string[10];
        //incrementer for stream writer
        int i = 0;
        //current odometer reading(input by user)
        double odoCur;
        //current gallons used (input by user)
        double galCur;
        //holds current MPG after user input
        double curMpg;
        //gets current date
        DateTime today1 = DateTime.Today;
        private void MPGOptionsForm_Load(object sender, EventArgs e)
        {

            string filePath = @"mpg/odo1.txt";

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    
                    //write each txt item to array
                    odoRay[i]= s;
                    //increment array 
                    i++;
                }
                //reverse array for easier user viewing
                Array.Reverse(odoRay);
                //print array to list box
                for (int i = 0; i < odoRay.Length; i++)
                {
                    mpgList.Items.Add(odoRay[i].ToString());
                }
            }
            //create double array with all info, rather than separate files for all info
            string input = File.ReadAllText(@"mpg/mpg1.txt");
            string[,] dblArray = new string[10,4];
            int x = 0, j = 0;
            //int[,] result = new int[10, 10];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    dblArray[x, j] = col.Trim();
                    j++;
                }
                
                dgTrack.Rows.Add(dblArray[x,0], dblArray[x,1], dblArray[x,2], dblArray[x,3]);
                x++;
            }

        }

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
            //System.IO.StreamWriter objWrt;

           // private string path = Path.Combine(Environment.CurrentDirectory, @"Resources\", "odo.txt");
            //line below works
            //objWrt = new System.IO.StreamWriter(@".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\odo.txt", true);
            //texting this write file path.
            //objWrt = new System.IO.StreamWriter(path, true);
           // string createText = odoCur + "\n";
            //objWrt.WriteLine(createText);
            //objWrt.Close();
            //File.WriteAllText(@"C:\Users\Andrew\Source\Repos\24317_Team2\MaintenanceTracker\Resources\odo.txt", createText);

            // Open the file to read from.
            //string readText = File.ReadAllText(@"C:\Users\Andrew\Source\Repos\24317_Team2\MaintenanceTracker\Resources\odo.txt");
        }
    }
}
