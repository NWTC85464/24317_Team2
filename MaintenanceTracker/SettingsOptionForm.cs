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
        TireOptionsClass toc = new TireOptionsClass();
        //TireInfo text files paths.
        string path1 = @"..\..\Resources\TiresInfo\v1Info.txt";
        string path2 = @"..\..\Resources\TiresInfo\v2Info.txt";
        string path3 = @"..\..\Resources\TiresInfo\v3Info.txt";
        string path4 = @"..\..\Resources\TiresInfo\v4Info.txt";
        string path1a = @"..\..\Resources\TiresInfo\v1Miles.txt";
        string path2a = @"..\..\Resources\TiresInfo\v2Miles.txt";
        string path3a = @"..\..\Resources\TiresInfo\v3Miles.txt";
        string path4a = @"..\..\Resources\TiresInfo\v4Miles.txt";
        string path1b = @"..\..\Resources\TiresInfo\Veh1Com.txt";
        string path2b = @"..\..\Resources\TiresInfo\Veh2Com.txt";
        string path3b = @"..\..\Resources\TiresInfo\Veh3Com.txt";
        string path4b = @"..\..\Resources\TiresInfo\Veh4Com.txt";

        //Mpg text file paths.
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
                        if (Directory.Exists(@"..\..\Resources\TiresInfo"))
                        {
                            //Tire 1 text file.
                            File.Delete(path1);
                            File.Delete(path1a);
                            File.Delete(path1b);
                            toc.V1Stored = 0;
                        }
                        if (Directory.Exists(@"mpg"))
                        {
                            //Mpg 1 text file.
                            File.Delete(mpg1);
                        }
                        if (Directory.Exists(@"..\..\Resources\AirFilterData"))
                        {
                            //Delete airfilter files.
                            //File.Delete(@"..\..\Resources\AirFilterData\AirFilterData1.xml");
                        }
                        if (Directory.Exists(@"..\..\Resources\oil"))
                        {
                            //Delete oil text files.
                            File.Delete(@"..\..\Resources\oil\car1a.txt");
                            File.Delete(@"..\..\Resources\oil\carNotes1a.txt");
                            File.Delete(@"..\..\Resources\oil\car1aBACKUP.txt");                           
                        }
                        if (Directory.Exists(@"..\..\Resources\WiperInfo"))
                        {
                            //Delete wipers files.
                            //File.Delete(@"..\..\Resources\WiperInfo\WiperData1.xml");
                        }                       

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
                        if (Directory.Exists(@"..\..\Resources\TiresInfo"))
                        {
                            //Tire 1 text file.
                            File.Delete(path2);
                            File.Delete(path2a);
                            File.Delete(path2b);
                            toc.V2Stored = 0;
                        }
                        if (Directory.Exists(@"mpg"))
                        {
                            //Mpg 1 text file.
                            File.Delete(mpg2);
                        }
                        if (Directory.Exists(@"..\..\Resources\AirFilterData"))
                        {
                            //Delete airfilter files.
                            //File.Delete(@"..\..\Resources\AirFilterData\AirFilterData2.xml");
                        }
                        if (Directory.Exists(@"..\..\Resources\oil"))
                        {
                            //Delete oil text files.
                            File.Delete(@"..\..\Resources\oil\car2a.txt");
                            File.Delete(@"..\..\Resources\oil\carNotes2a.txt");
                            File.Delete(@"..\..\Resources\oil\car2aBACKUP.txt");
                        }
                        if (Directory.Exists(@"..\..\Resources\WiperInfo"))
                        {
                            //Delete wipers files.
                            //File.Delete(@"..\..\Resources\WiperInfo\WiperData2.xml");
                        }

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
                        if (Directory.Exists(@"..\..\Resources\TiresInfo"))
                        {
                            //Tire 1 text file.
                            File.Delete(path3);
                            File.Delete(path3a);
                            File.Delete(path3b);
                            toc.V3Stored = 0;
                        }
                        if (Directory.Exists(@"mpg"))
                        {
                            //Mpg 1 text file.
                            File.Delete(mpg3);
                        }
                        if (Directory.Exists(@"..\..\Resources\AirFilterData"))
                        {
                            //Delete airfilter files.
                            //File.Delete(@"..\..\Resources\AirFilterData\AirFilterData3.xml");
                        }
                        if (Directory.Exists(@"..\..\Resources\oil"))
                        {
                            //Delete oil text files.
                            File.Delete(@"..\..\Resources\oil\car3a.txt");
                            File.Delete(@"..\..\Resources\oil\carNotes3a.txt");
                            File.Delete(@"..\..\Resources\oil\car3aBACKUP.txt");
                        }
                        if (Directory.Exists(@"..\..\Resources\WiperInfo"))
                        {
                            //Delete wipers files.
                            //File.Delete(@"..\..\Resources\WiperInfo\WiperData3.xml");
                        }

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
                        if (Directory.Exists(@"..\..\Resources\TiresInfo"))
                        {
                            //Tire 1 text file.
                            File.Delete(path4);
                            File.Delete(path4a);
                            File.Delete(path4b);
                            toc.V4Stored = 0;
                        }
                        if (Directory.Exists(@"mpg"))
                        {
                            //Mpg 1 text file.
                            File.Delete(mpg4);
                        }
                        if (Directory.Exists(@"..\..\Resources\AirFilterData"))
                        {
                            //Delete airfilter files.
                            //File.Delete(@"..\..\Resources\AirFilterData\AirFilterData4.xml");
                        }
                        if (Directory.Exists(@"..\..\Resources\oil"))
                        {
                            //Delete oil text files.
                            File.Delete(@"..\..\Resources\oil\car4a.txt");
                            File.Delete(@"..\..\Resources\oil\carNotes4a.txt");
                            File.Delete(@"..\..\Resources\oil\car4aBACKUP.txt");
                        }
                        if (Directory.Exists(@"..\..\Resources\WiperInfo"))
                        {
                            //Delete wipers files.
                            //File.Delete(@"..\..\Resources\WiperInfo\WiperData4.xml");
                        }

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
