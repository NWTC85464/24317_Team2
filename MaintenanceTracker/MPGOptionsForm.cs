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

                       
                        /*foreach (var row in usedFile.Split('\n'))
                        {
                            j = 0;
                            foreach (var col in row.Trim().Split(' '))
                            {
                                dblArray[x, j] = col.Trim();
                                j++;
                            }
                            holdDbl = dblArray;
                            dgTrack.Rows.Add(dblArray[x, 0], dblArray[x, 1], dblArray[x, 2], dblArray[x, 3]);
                            x++;
                        }*/
                    }
                    else
                    {
                        using (StreamWriter sw = File.CreateText(@"mpg/mpg1.txt"))
                        {
                            //use blank data when updating mpg first time. 
                            sw.WriteLine("0/00/0000 00 0000 00");
                            sw.Close();
                            usedFile = File.ReadAllText(@"mpg/mpg1.txt");
                            setup(usedFile);

                            //int[,] result = new int[10, 10];
                            /*foreach (var row in usedFile.Split('\n'))
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
                            }*/
                            
                        }
                    }
                    break;

                case 2:
                    if (File.Exists(@"mpg/mpg2.txt"))
                    {
                        usedFile = File.ReadAllText(@"mpg/mpg2.txt");
                        
                        ArrayString(usedFile);
                    }
                    else
                    {
                        using (StreamWriter sw = File.CreateText(@"mpg/mpg2.txt"))
                        {
                            sw.WriteLine("0/00/0000 00 0000 00");
                            sw.Close();
                            usedFile = File.ReadAllText(@"mpg/mpg2.txt");
                            setup(usedFile);
                        }
                    }
                    break;

                case 3:
                    if (File.Exists(@"mpg/mpg3.txt"))
                    {
                        
                        usedFile = File.ReadAllText(@"mpg/mpg3.txt");

                        ArrayString(usedFile);
                    }
                    else
                    {
                        using (StreamWriter sw = File.CreateText(@"mpg/mpg3.txt"))
                        {
                            //write blank line of data to use when mpg is updated
                            sw.WriteLine("0/00/0000 00 0000 00");
                            sw.Close();
                            usedFile = File.ReadAllText(@"mpg/mpg3.txt");
                            setup(usedFile);  
                        }
                    }
                    
                    break;
                case 4:
                    if (File.Exists(@"mpg/mpg4.txt"))
                    {
                       
                        usedFile = File.ReadAllText(@"mpg/mpg4.txt");

                        ArrayString(usedFile);
                    }
                    else
                    {
                        using (StreamWriter sw = File.CreateText(@"mpg/mpg4.txt"))
                        {
                            sw.WriteLine("0/00/0000 00 0000 00");
                            sw.Close();
                            usedFile = File.ReadAllText(@"mpg/mpg4.txt");
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
                    
                    
                    var lastLine = File.ReadLines(fln).Last();

                    int j = 0;
                    foreach (var col in lastLine.Trim().Split(' '))
                    {
                        holdOdo[j] = col.Trim();
                        j++;
                    }
                    double oldOdo = double.Parse(holdOdo[2]);
                    //double oldOdo =

                    if (odoCur <= oldOdo)
                    {
                        MessageBox.Show("Please enter a Odometer reading greater than " + oldOdo);
                        return;
                    }

                    double mileDiff = odoCur - oldOdo;

                    //mainFrm.milesDriven = mileDiff;

                    main.MilesDriven = mileDiff;

                    curMpg = (mileDiff) / galCur;

                    //lblAlert.Text = "Current MPG is: " + curMpg;

                    //Enter math code here!
                    dgTrack.Rows.Add(today1.ToString("d"), Math.Round(curMpg, 2), Math.Round(odoCur, 2), Math.Round(galCur, 2));
                    string createTxt = "\n" + today1.ToString("d") + " " + Math.Round(curMpg, 2) + " " + Math.Round(odoCur, 2) + " " + Math.Round(galCur, 2);
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
            //System.IO.StreamWriter objWrt;
            this.Close();
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


        public void ArrayString(string fileName)
        {

            foreach (var row in fileName.Split('\r'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    dblArray[x, j] = col.Trim();
                    j++;
                }

                dgTrack.Rows.Add(dblArray[x, 0], dblArray[x, 1], dblArray[x, 2], dblArray[x, 3]);
                x++;

            }
            holdDbl = dblArray;
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
    }
}
