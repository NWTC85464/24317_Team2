using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceTracker
{
    public partial class SettingsOptionForm : System.Windows.Forms.Form
    {
        public SettingsOptionForm()
        {
            InitializeComponent();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Create path to save vehicle data to text files.
        string path1 = @"..\..\Resources\TiresInfo\v1Info.txt";
        string path2 = @"..\..\Resources\TiresInfo\v2Info.txt";
        string path3 = @"..\..\Resources\TiresInfo\v3Info.txt";
        string path4 = @"..\..\Resources\TiresInfo\v4Info.txt";

        //Paths to miles driven saved from MPG form.
        string path1a = @"..\..\Resources\TiresInfo\v1Miles.txt";
        string path2a = @"..\..\Resources\TiresInfo\v2Miles.txt";
        string path3a = @"..\..\Resources\TiresInfo\v3Miles.txt";
        string path4a = @"..\..\Resources\TiresInfo\v4Miles.txt";

        //Path to miles driven files.
        string path1b = @"..\..\Resources\TiresInfo\Veh1Com.txt";
        string path2b = @"..\..\Resources\TiresInfo\Veh2Com.txt";
        string path3b = @"..\..\Resources\TiresInfo\Veh3Com.txt";
        string path4b = @"..\..\Resources\TiresInfo\Veh4Com.txt";

        //Mpg file path
        string mpg1 = @"mpg/mpg1.txt";
        string mpg2 = @"mpg/mpg2.txt";
        string mpg3 = @"mpg/mpg3.txt";
        string mpg4 = @"mpg/mpg4.txt";


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            switch (carNum.SelectedIndex+1)
            {                
                case 1:
                    dialogResult = MessageBox.Show("Sure you want to delete?", "Delete saved files", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Tire 1 text file.
                        File.Delete(path1);
                        File.Delete(path1a);
                        File.Delete(path1b);

                        //Mpg 1 text file.
                        File.Delete(mpg1);

                        //Display message all files have been deleted.
                        MessageBox.Show("All files have been destroyed!!\n" +
                            "Have a nice day :)");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing.
                    }          
                    break;
                case 2:
                    dialogResult = MessageBox.Show("Sure you want to delete?", "Delete saved files", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Tire 1 text file.
                        File.Delete(path2);
                        File.Delete(path2a);
                        File.Delete(path2b);

                        //Mpg 1 text file.
                        File.Delete(mpg2);

                        //Display message all files have been deleted.
                        MessageBox.Show("All files have been destroyed!!\n" +
                            "Have a nice day :)");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing.
                    }
                    break;
                case 3:
                    dialogResult = MessageBox.Show("Sure you want to delete?", "Delete saved files", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Tire 1 text file.
                        File.Delete(path3);
                        File.Delete(path3a);
                        File.Delete(path3b);

                        //Mpg 1 text file.
                        File.Delete(mpg3);

                        //Display message all files have been deleted.
                        MessageBox.Show("All files have been destroyed!!\n" +
                            "Have a nice day :)");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing.
                    }
                    break;
                case 4:
                    dialogResult = MessageBox.Show("Sure you want to delete?", "Delete saved files", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Tire 1 text file.
                        File.Delete(path4);
                        File.Delete(path4a);
                        File.Delete(path4b);

                        //Mpg 1 text file.
                        File.Delete(mpg4);

                        //Display message all files have been deleted.
                        MessageBox.Show("All files have been destroyed!!\n" +
                            "Have a nice day :)");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing.
                    }
                    break;
                default:
                    MessageBox.Show("Select a vehicle first");
                    break;
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
