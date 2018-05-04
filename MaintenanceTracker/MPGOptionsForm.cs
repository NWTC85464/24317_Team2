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


        MpgSetupForm setupFrm = new MpgSetupForm();
        //Path to miles driven files.
        string path1a = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\v1Miles.txt";
        string path2a = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\v2Miles.txt";
        string path3a = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\v3Miles.txt";
        string path4a = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\v4Miles.txt";

        //Temp variable.
        //string tempMilesDriven;
        double tMD;


        //array for odometer readings
        string[] odoRay = new string[10];
        //incrementer for stream writer
        int i = 0;
        //To hold stream reader
        string usedFile;
        //to hold file name for stream writer
        string fln;
        //current odometer reading(input by user)
        double odoCur;
        //current gallons used (input by user)
        double galCur;
        //holds current MPG after user input
        double curMpg;

        public static Boolean cancStart = false;
        public static double startOdo;
        //gets current date
        DateTime today1 = DateTime.Today;
        //object of new form to use switch statement
        MainFormClass main = new MainFormClass();

        MainTracker mainFrm = new MainTracker();
        //StreamReader fsMain;
        
        //doulbe array holding current file.  will be overwritten when new switch created.
        string[,] dblArray = new string[10, 4];
        public string[,] holdDbl;
        //increment double array. 
        int x = 0, j = 0;
        private void MPGOptionsForm_Load(object sender, EventArgs e)
        {
            //scroll data grid to bottom?
            //dgTrack.FirstDisplayedScrollingRowIndex = dgTrack.RowCount - 1;

            //create folder path
            if (Directory.Exists(@"mpg"))
            {
                Console.WriteLine("That path exists already.");
                //return;
            }
            else
            {
                //checking that folder path was created
                DirectoryInfo mpg = Directory.CreateDirectory(@"mpg");
                //states when path was created for new folder
                Console.WriteLine("The directory was created successfully at {0}.",
                Directory.GetCreationTime(@"mpg"));
            }

            ////Test Files based on car selected
            switch (main.VehicalNumber)
            {
                    case 1:
                    if (File.Exists(@"mpg/mpg1.txt"))
                    {
                        fln = @"mpg/mpg1.txt";
                        usedFile = File.ReadAllText(@"mpg/mpg1.txt");

                        ArrayString(usedFile);

                    }
                    else
                    {
                        startFile();
                        if (cancStart == true)
                        {
                            cancStart = false;
                            this.btnExitMpg.PerformClick();
                            return;
                        }
                        else
                        {
                            //do nothing
                        }
                        using (StreamWriter sw = File.CreateText(@"mpg/mpg1.txt"))
                        {
                            //startFile();
                            //use blank data when updating mpg first time. 
                            sw.WriteLine(today1.ToString("d")+" 00 " +startOdo+" 00");
                            sw.Close();
                            usedFile = File.ReadAllText(@"mpg/mpg1.txt");
                            fln = @"mpg/mpg1.txt";
                            setup(usedFile);
  
                        }
                    }
                    break;

                case 2:
                    if (File.Exists(@"mpg/mpg2.txt"))
                    {
                        fln = @"mpg/mpg2.txt";
                        usedFile = File.ReadAllText(@"mpg/mpg2.txt");
                        
                        ArrayString(usedFile);
                        dgTrack.FirstDisplayedScrollingRowIndex = dgTrack.RowCount - 1;
                    }
                    else
                    {
                        startFile();
                        if (cancStart == true)
                        {
                            cancStart = false;
                            this.btnExitMpg.PerformClick();
                            return;
                        }
                        else
                        {
                            //do nothing
                        }
                        using (StreamWriter sw = File.CreateText(@"mpg/mpg2.txt"))
                        {
                            sw.WriteLine(today1.ToString("d") + " 00 " + startOdo + " 00");
                            sw.Close();
                            usedFile = File.ReadAllText(@"mpg/mpg2.txt");
                            fln = @"mpg/mpg2.txt";
                            setup(usedFile);
                        }
                    }
                    break;

                case 3:
                    if (File.Exists(@"mpg/mpg3.txt"))
                    {
                        fln = @"mpg/mpg3.txt";
                        usedFile = File.ReadAllText(@"mpg/mpg3.txt");

                        ArrayString(usedFile);
                    }
                    else
                    {
                        startFile();
                        if (cancStart == true)
                        {
                            cancStart = false;
                            this.btnExitMpg.PerformClick();
                            return;
                        }
                        else
                        {
                            //do nothing
                        }
                        using (StreamWriter sw = File.CreateText(@"mpg/mpg3.txt"))
                        {
                            //write blank line of data to use when mpg is updated
                            sw.WriteLine(today1.ToString("d") + " 00 " + startOdo + " 00");
                            sw.Close();
                            usedFile = File.ReadAllText(@"mpg/mpg3.txt");
                            fln = @"mpg/mpg3.txt";
                            setup(usedFile);  
                        }
                    }
                    
                    break;
                case 4:
                    if (File.Exists(@"mpg/mpg4.txt"))
                    {
                        fln = @"mpg/mpg4.txt";
                        usedFile = File.ReadAllText(@"mpg/mpg4.txt");

                        ArrayString(usedFile);
                    }
                    else
                    {
                        startFile();
                        if (cancStart == true)
                        {
                            cancStart = false;
                            this.btnExitMpg.PerformClick();
                            return;
                        }
                        else
                        {
                            //do nothing
                        }
                        using (StreamWriter sw = File.CreateText(@"mpg/mpg4.txt"))
                        {
                            sw.WriteLine(today1.ToString("d") + " 00 " + startOdo + " 00");
                            sw.Close();
                            usedFile = File.ReadAllText(@"mpg/mpg4.txt");
                            fln = @"mpg/mpg4.txt";
                            setup(usedFile); 
                        }
                    }
                    
                    break;
                default:
                    //FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
                    MessageBox.Show("you broke something!");
                    break;
            }

        }

        private void btnEnterMpg_Click(object sender, EventArgs e)
        {
            //array to hold last odo input.
            string[] holdOdo = new string[4];
             
            //parser user input to double.
            if(double.TryParse(txtbxOdoRead.Text, out odoCur))
            {
                //lblAlert.Text = "odoCur is: " + odoCur;
                if (double.TryParse(txtbxGallonsRead.Text, out galCur))
                {
                    
                    //read last line from current file to get odometer reading
                    var lastLine = File.ReadLines(fln).Last();
                    //incrementer for array
                    int j = 0;
                    //splitting up the string based on " "<--spaces it finds
                    foreach (var col in lastLine.Trim().Split(' '))
                    {
                        //storing split up string into an array
                        holdOdo[j] = col.Trim();
                        j++; //increment array
                    }
                    //parse string to doulbe for MPG math
                    double oldOdo = double.Parse(holdOdo[2]);
                    //check to make sure new odometer reading is greater than last reading.
                    if (odoCur <= oldOdo)
                    {
                        MessageBox.Show("Please enter a Odometer reading greater than " + oldOdo);
                        return;
                    }
                    //finding the difference of miles driven since last mpg entered
                    double mileDiff = odoCur - oldOdo;
                    //15000 is based on the average driver and how far they go in a year (13474 miles per year)
                    //gives some flexibility incase driver forgets to add mpg for a long time, or travels a lot)
                    if (mileDiff > 15000)
                    {

                        double limit=oldOdo + 15000;
                        MessageBox.Show("Please enter a odometer reading less than " + limit);
                        return;
                    }
                    //raised gallons number for Semi-truck drivers to use.
                    //negative gallons???
                    if (galCur > 400 || galCur<0)
                    {
                        MessageBox.Show("Please enter gallons less than 400 and greater than 0");
                        return;
                    }
                    //mainFrm.milesDriven = mileDiff;

                    //count how many lines are in a file
                    var lineCount = File.ReadLines(fln).Count();

                    //if file line count is at 10, then shave off top line and append new line to bottom. 
                    //rewrites file to get rid of first line. 
                    if (lineCount == 9)
                    {
                        var lines = File.ReadAllLines(fln);
                        File.WriteAllLines(fln, lines.Skip(1).ToArray());
                    }

                        main.MilesDriven = mileDiff;

                    curMpg = (mileDiff) / galCur;

                    //lblAlert.Text = "Current MPG is: " + curMpg;

                    //Enter math code here!
                    dgTrack.Rows.Add(today1.ToString("d"), Math.Round(curMpg, 2), Math.Round(odoCur, 2), Math.Round(galCur, 2));
                    string createTxt =  today1.ToString("d") + " " + Math.Round(curMpg, 2) + " " + Math.Round(odoCur, 2) + " " + Math.Round(galCur, 2);
                    System.IO.StreamWriter objWrt;
                    switch (main.VehicalNumber)
                    {
                        case 1:
                            objWrt = new System.IO.StreamWriter(@"mpg/mpg1.txt", true);
                            objWrt.WriteLine(createTxt);
                            objWrt.Close();
                            break;
                        case 2:
                            objWrt = new System.IO.StreamWriter(@"mpg/mpg2.txt", true);
                            objWrt.WriteLine(createTxt);
                            objWrt.Close();
                            break;
                        case 3:
                            objWrt = new System.IO.StreamWriter(@"mpg/mpg3.txt", true);
                            objWrt.WriteLine(createTxt);
                            objWrt.Close();
                            break;
                        case 4:
                            objWrt = new System.IO.StreamWriter(@"mpg/mpg4.txt", true);
                            objWrt.WriteLine(createTxt);
                            objWrt.Close();
                            break;
                        default:
                            MessageBox.Show("did not work");
                            break;

                    }

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
            
            //save vehicle values to file
            saveMilesDriven(main.MilesDriven); 

            //Close the form.
            this.Close();

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

        private void saveMilesDriven(double milesDriven)
        {
            //Read exsisting files and add new miles driven to file.
            switch (main.VehicalNumber)
            {                
                case 1:
                    if (File.Exists(path1a))
                    {
                        //Read the file and save to tmd.
                        usedFile = File.ReadAllText(path1a);
                        tMD = Convert.ToDouble(usedFile);
                    }
                    else if (!File.Exists(path1a))
                    {
                        //Set tmd to 0.
                        tMD = 0;
                    }
                    break;
                case 2:
                    if (File.Exists(path2a))
                    {
                        //Read the file and save to tmd.
                        usedFile = File.ReadAllText(path2a);
                        tMD = Convert.ToDouble(usedFile);
                    }
                    else if (!File.Exists(path2a))
                    {
                        //Set tmd to 0.
                        tMD = 0;
                    }
                    break;
                case 3:
                    if (File.Exists(path3a))
                    {
                        //Read the file and save to tmd.
                        usedFile = File.ReadAllText(path3a);
                        tMD = Convert.ToDouble(usedFile);
                    }
                    else if (!File.Exists(path3a))
                    {
                        //Set tmd to 0.
                        tMD = 0;
                    }
                    break;
                case 4:
                    if (File.Exists(path4a))
                    { 
                        //Read the file and save to tmd.
                        usedFile = File.ReadAllText(path4a);
                        tMD = Convert.ToDouble(usedFile);
                    }
                    else if (!File.Exists(path4a))
                    {
                        //Set tmd to 0.
                        tMD = 0;
                    }
                    break;
                default:
                    //Do nothing.......
                    break;
            }

            //Add new value to file value.
            main.MilesDriven += tMD;

            //Write the file for vehicle mpg.
            System.IO.StreamWriter objWrt;

            switch (main.VehicalNumber)
            {
                case 1:

                    //Write the file for v1 with new values.
                    objWrt = new System.IO.StreamWriter(path1a, true);
                    objWrt.WriteLine(main.MilesDriven);
                    objWrt.Close();
                    break;
                case 2:
                    //Write the file for v2with new values.
                    objWrt = new System.IO.StreamWriter(path2a, true);
                    objWrt.WriteLine(main.MilesDriven);
                    objWrt.Close();
                    break;
                case 3:
                    //Write the file for v3 with new values.
                    objWrt = new System.IO.StreamWriter(path3a, true);
                    objWrt.WriteLine(main.MilesDriven);
                    objWrt.Close();
                    break;
                case 4:
                    //Write the file for v4 with new values.
                    objWrt = new System.IO.StreamWriter(path4a, true);
                    objWrt.WriteLine(main.MilesDriven);
                    objWrt.Close();
                    break;
                default:
                    break;
            }
        }

        public void ArrayString(string fileContent)
        {
            //count how many lines are in a file
            var lineCount = File.ReadLines(fln).Count();

            //if (lineCount==17)
            foreach (var row in fileContent.Split('\n')) //works with \r in split
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    dblArray[x, j] = col.Trim();
                    Console.WriteLine(dblArray.Length + " legnth");
                    j++;
                }

                dgTrack.Rows.Add(dblArray[x, 0], dblArray[x, 1], dblArray[x, 2], dblArray[x, 3]);
                x++;

            }
            holdDbl = dblArray;


            Array.Clear(dblArray, 0, dblArray.Length);
            x = 0;
            j = 0;
            Console.WriteLine(dblArray.Length+ " new legnth");
            //return;
        }

        public void setup(string newFile)
        {
            //usedFile = File.ReadAllText(@"mpg/mpg1.txt");

            //int[,] result = new int[10, 10];
            foreach (var row in newFile.Split('\r'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    dblArray[x, j] = col.Trim();
                    j++;
                }
                holdDbl = dblArray;
                dgTrack.Rows.Add(dblArray[x, 0], dblArray[x, 1], dblArray[x, 2], dblArray[x, 3]);
                //x++;
                break;
            }

        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you REALLY sure you want to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //MessageBox.Show("Things being deleted as we speak!");

                //var lines = System.IO.File.ReadAllLines(fln);
               // System.IO.File.WriteAllLines("...", lines.Take(lines.Length - 1).ToArray());

                ///////////////////////////////////////////////////////////////////////////////
                var lineCount = File.ReadLines(fln).Count();

                //if file line count is greater than 1, then shave off bottom line and append new line to bottom. 
                //rewrites file to get rid of first line. 
                if (lineCount > 1)
                {
                    var lines = File.ReadAllLines(fln);
                    File.WriteAllLines(fln, lines.Take(lines.Length-1).ToArray());
                    usedFile = File.ReadAllText(fln);
                    dgTrack.Rows.Clear();
                    dgTrack.Refresh();
                    ArrayString(usedFile);
                }
                else
                {
                    var lastResult = MessageBox.Show("Deleting this line will DELETE YOUR FILE, are you sure you wish to continue?",
                                     "Delete File?!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        File.Delete(fln);
                        MessageBox.Show("You will need to re-enter start odometer. Exiting now!");
                        this.Close();

                    }
                    else {

                        MessageBox.Show("Last line NOT deleted");

                    }
                        
                }
            }
            else
            {
                return;
            }
        }

        public void startFile()
        {
            setupFrm.ShowDialog();
            /* if (cancStart == true)
             {
                 this.btnExitMpg.PerformClick();
             }
             else
             {
                 //do nothing
             }*/
            Console.WriteLine(cancStart + " boolean");

        }


    }
}
