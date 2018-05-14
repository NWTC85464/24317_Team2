using System;

using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Linq;

namespace MaintenanceTracker
{
    public partial class OilOptionsForm : System.Windows.Forms.Form
    {
        //streamwriter
        private string[] information = new string[6];

        private string path;
        private string storage;
        private string notePath;
        private string mpgFile;
        private string ODreading ;
        MainFormClass MainClass = new MainFormClass();

        private DateTime Date = DateTime.Today;
        private DateTime StartDate = new DateTime();
        private DateTime ChangeDate = new DateTime();
        private DateTime compare = DateTime.Today;

        private Timer Progress = new Timer();

        private int total = 0;
        private int ODS = 0;
        private int ODR = 0;

        string[] section;

        public OilOptionsForm()
        {
            InitializeComponent();
            Start.Visible = true;
            //this.BackColor = System.Drawing.Color.Orange;

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            Console.WriteLine(MainClass.VehicalNumber);

        }

       
        private void OilTrackerForm(object sender, EventArgs e)
        {
            AmountTotal.ReadOnly = true;

           // information[5] = "Notes";

            int car = MainClass.VehicalNumber;


            switch (car)
            {
                case 1:
                    path = @"..\..\Resources\oil\car1a.txt";
                    notePath = @"..\..\Resources\oil\carNotes1a.txt";
                    storage = @"..\..\Resources\oil\car1aBACKUP.txt";
                    mpgFile = @"mpg/mpg1.txt";
                    break;

                case 2:
                    path = @"..\..\Resources\oil\car2a.txt";
                    notePath = @"..\..\Resources\oil\carNotes2a.txt";
                    storage = @"..\..\Resources\oil\car2aBACKUP.txt";
                    mpgFile = @"mpg/mpg2.txt";
                    break;

                case 3:
                    path = @"..\..\Resources\oil\car3a.txt";
                    notePath = @"..\..\Resources\oil\carNotes3a.txt";
                    storage = @"..\..\Resources\oil\car3aBACKUP.txt";
                    mpgFile = @"mpg/mpg3.txt";
                    break;

                case 4:
                    path = @"..\..\Resources\oil\car4a.txt";
                    notePath = @"..\..\Resources\oil\carNotes4a.txt";
                    storage = @"..\..\Resources\oil\car4aBACKUP.txt";
                    mpgFile = @"mpg/mpg4.txt";
                    break;

                default: Console.WriteLine("error404"); break;
            }


            Console.WriteLine("loading....");



            if (File.Exists(notePath))
            {
                StreamReader info = File.OpenText(notePath);

                while (!info.EndOfStream)
                {
                    Information.Text = info.ReadToEnd();
                }
                info.Close();
            }

            if (File.Exists(path))
            {

                int index = 0;

                StreamReader info = File.OpenText(path);

                while (!info.EndOfStream && index < information.Length)
                {
                    information[index] = info.ReadLine();

                    Console.WriteLine(information[index]);

                    index++;
                }

                info.Close();

                Console.WriteLine("Getting last OD reading");

               // StreamReader mpg = File.OpenText(mpgFile);

                if (File.Exists(mpgFile))
                {
                    string mpgData = File.ReadLines(mpgFile).Last();

                    section = mpgData.Split(' ');
                    foreach (string x in section)
                    {
                        Console.WriteLine(x);
                    }

                    ODreading = section[2];
                   
                }
                else
                {
                    MessageBox.Show("!You have not entered anything in the MPG for this car!");
                    Console.WriteLine("There was no OD reading");
                    //ODreading = information[5];
                }
                
                var date = information[3];
               
                // 

                //  mpg.Close();


                Console.WriteLine("Completed");

                oilBrand.Text = information[0];
                oilUse.Text = information[1];
                AmountTotal.Text = information[2];
                //Amount.Value = int.Parse(information[2]);
                Start.Value = DateTime.Parse(information[3]);

                ODStart.Text = information[5];
               // int ODST = int.Parse(information[5]);

               /////////////////// Amount.Enabled = false;
                oilBrand.ReadOnly = true;
                oilUse.ReadOnly = true;
                ODStart.ReadOnly = true;
                Start.Enabled = false;

                Lock.Text = "Unlock";
                ProgressBar();
            }
            else
            {
                Console.WriteLine("No data retrived");
            }

        }

        // ------------------------------------------------
        //
        //                      Values
        //
        // ------------------------------------------------

        private void FindNumber(object sender, EventArgs e)
        {
            double a = Amount.Value;

            double av = a * 0.1;

            // show oil amount in car
            AmountTotal.Text = av.ToString() + " quarts";

        }




        private void LockScoll(object sender, EventArgs e)
        {
            //lock or unlock slider
            // lock or unlock textbox
            if (oilBrand.ReadOnly == false && oilUse.ReadOnly == false && Amount.Enabled == true)
            {
                Amount.Enabled = false;
                Start.Enabled = false;
                oilBrand.ReadOnly = true;
                oilUse.ReadOnly = true;
                ODStart.ReadOnly = true;
                ODStart.ReadOnly = true;

                Lock.Text = "Unlock";
            }
            else
            {
                Amount.Enabled = true;
                Start.Enabled = true;
                oilBrand.ReadOnly = false;
                oilUse.ReadOnly = false;
                ODStart.ReadOnly = true;
                ODStart.ReadOnly = false;

                Lock.Text = "Lock";
            }

        }


        private void ODFirstReading(object sender, EventArgs e)
        {

            if (int.TryParse(ODStart.Text, out int num) == true)
            {
                information[5] = ODStart.Text;
                Console.WriteLine(information[5]);
            }
            else
            {
                MessageBox.Show("this is not a number");
                information[5] = null;
            }

        }



        private void oilBrandChange(object sender, EventArgs e)
        {
            if (int.TryParse(oilBrand.Text, out int num) == false)
            {
                information[0] = oilBrand.Text;
                Console.WriteLine(information[0]);
            }
            else
            {
                MessageBox.Show("this is not a word");
                information[0] = null;
            }

        }


        private void oilUseChange(object sender, EventArgs e)
        {
            if (int.TryParse(oilUse.Text, out int num) == false)
            {
                information[1] = oilUse.Text;
                Console.WriteLine(information[1]);
            }
            else
            {
                MessageBox.Show("this is not a number");
                information[1] = null;
            }
        }

        private void TotalChange(object sender, EventArgs e)
        {
            information[2] = AmountTotal.Text;

            //Console.WriteLine(information[2]);

        }


        private void StartingDatePicker(object sender, EventArgs e)
        {
            Start.Format = DateTimePickerFormat.Custom;
            Start.CustomFormat = "MM-dd-yyyy hh:mm:ss";
            //  StartDate = Start.Value;

            information[3] = Start.Value.ToString();
            Console.WriteLine(information[3]);
        }


        // ------------------------------------------------
        //
        //                      NOTES
        //
        // ------------------------------------------------

        private void NotesButton(object sender, EventArgs e)
        {
            if (notesButton.Text != "Back")
            {
                this.GYR.Visible = false;
                this.GYRTXT.Visible = false;
                this.brand.Visible = false;
                this.oilBrand.Visible = false;
                this.oilUse.Visible = false;
                this.type.Visible = false;
                this.Amount.Visible = false;
                this.AmountTotal.Visible = false;
                this.TotalTxT.Visible = false;
                this.Lock.Visible = false;
                this.Exit.Visible = false;
                this.Information.Visible = false;
                this.ODStartingTxT.Visible = false;
                this.ODStart.Visible = false;
                this.StartingDateTxT.Visible = false;
                this.Start.Visible = false;

                this.Notes.Visible = true;
                this.SaveNotes.Visible = true;

                notesButton.Text = "Back";


                if (File.Exists(notePath))
                {
                    StreamReader info = File.OpenText(notePath);

                    while (!info.EndOfStream)
                    {
                        Notes.Text = info.ReadToEnd();
                    }
                    info.Close();
                }

               // Notes.Text = information[5];

            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult box;

               
                box = MessageBox.Show("Did you remember to save?", "Saved?", buttons);

                if (box == System.Windows.Forms.DialogResult.Yes)
                {
                    
                    this.GYR.Visible = true;
                    this.GYRTXT.Visible = true;
                    this.brand.Visible = true;
                    this.oilBrand.Visible = true;
                    this.oilUse.Visible = true;
                    this.type.Visible = true;
                    this.Amount.Visible = true;
                    this.AmountTotal.Visible = true;
                    this.TotalTxT.Visible = true;
                    this.Lock.Visible = true;
                    this.Exit.Visible = true;
                    this.Information.Visible = true;
                    this.ODStartingTxT.Visible = true;
                    this.ODStart.Visible = true;
                    this.StartingDateTxT.Visible = true;
                    this.Start.Visible = true;

                    this.Notes.Visible = false;
                    this.SaveNotes.Visible = false;

                    notesButton.Text = "Notes";  


                    if (File.Exists(notePath))
                    {
                        StreamReader info = File.OpenText(notePath);

                        while (!info.EndOfStream)
                        {
                            Information.Text = info.ReadToEnd();
                        }
                        info.Close();
                    }   
                }
            }

        }

        private void SavingNotes(object sender, EventArgs e)
        {

            using (StreamWriter file =
                   new StreamWriter(notePath))

            {

                //go though array and save new data
                for (int i = 0; i < Notes.Text.Length; i++)
                {
                    var line = Notes.Text[i];
                    file.Write(line);

                    Console.Write(line);
                }

                file.Close();

            }
           // information[5] = Notes.Text;
            Console.WriteLine("Saved");
        }


        // ------------------------------------------------
        //
        //                     Exit Window
        //
        // ------------------------------------------------

        private void exit(object sender, EventArgs e)
        {
            // StartDate = DateTime.Today;
            StartDate = Start.Value;

            ChangeDate = StartDate.AddMonths(3);

            information[4] = ChangeDate.ToString();
            information[5] = ODStart.Text;

            //save information if not null
            int pos = Array.IndexOf(information, null);
            if (pos > -1)
            {
                Console.WriteLine("values are not being saved?");

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult box;

                //make sure if want to exit

                box = MessageBox.Show("Are you sure you want to exit?", "all fields where not filled", buttons);

                if (box == System.Windows.Forms.DialogResult.Yes)
                {
                    box = MessageBox.Show("Warring: if click yes, information maybe become lost or wrong in the future.", "incomplete", buttons);

                    if (box == System.Windows.Forms.DialogResult.Yes)
                    {
                        Console.WriteLine("Saving incomplete data");
                        CheckIFHaveFiles();
                        this.Close();
                    }
                    else if (box == System.Windows.Forms.DialogResult.No)
                    {
                        Console.WriteLine("values are not saved");
                        this.Close();
                    }
                }

            }
            else
            {
                Console.WriteLine("Saving Dates");

                

                information[3] = StartDate.ToString();
                information[4] = ChangeDate.ToString();

                CheckIFHaveFiles();

            }
        }

        //----------------------------------------------------------
        //----------------------------------------------------------
        //----------------------------------------------------------

        private void CheckIFHaveFiles()
        {

            if (Directory.Exists(@"..\..\Resources\oil"))
            {
                if (!File.Exists(storage) && !File.Exists(path))
                {
                    Console.WriteLine("No Oil Files Created Yet for this Car");
                    Console.WriteLine("Now Preparing to create the files");
                    //make back-up
                    Console.WriteLine("Back-up file created");
                    var back=File.Create(storage);
                    back.Close();

                    //make path
                    Console.WriteLine("Main file created");
                    var car=File.Create(path);
                    car.Close();

                    Console.WriteLine("Files completed");
                    Console.WriteLine("Back-up Stored at " + storage);
                    Console.WriteLine("Main Stored at " + path);

                    BackUp();
                }
                else
                {
                    BackUp();
                }
            }
            else
            {
                DirectoryInfo folderoil = Directory.CreateDirectory(@"..\..\Resources\oil");
                //states when path was created for new folder
                Console.WriteLine("The directory was created successfully at {0}.",
                Directory.GetCreationTime(@"..\..\Resources\oil"));

                CheckIFHaveFiles();
            }
        }



        private void BackUp()
        {


            Console.WriteLine("Attempting Back-up");

            Console.WriteLine("Checking Back-up location......");

            if (!File.Exists(storage))
            {
                CheckIFHaveFiles();
            }
            else
            {
                //nothing
                Console.WriteLine("file exist");
                // }

                Console.WriteLine("Backing up........");

                try
                {

                    using (StreamWriter file = new StreamWriter(storage))

                    {
                        //date back up
                        file.WriteLine(DateTime.Today);

                        //go though array and save new data
                        foreach (string line in information)
                        {
                            file.WriteLine(line);
                        }

                        file.Close();

                        Console.WriteLine(File.ReadAllText(storage));
                        Console.WriteLine("Backed up");

                    }
                }

                catch
                {
                    Console.WriteLine("no back-up made");
                    Console.WriteLine("This must be the first save or something went wrong");
                    Console.WriteLine("Now moving to saving");
                    Save();
                }

               Save();

            }
        }


            private void Save()
            {
                Console.WriteLine("Attempting Saving");


                Console.WriteLine("Checking location......");

                Console.WriteLine("file exist");
 
                Console.WriteLine("Saving........");
            try
            {
                using (StreamWriter file =
                       new StreamWriter(path))

                {

                    //go though array and save new data
                    foreach (string line in information)
                    {
                        file.WriteLine(line);
                    }

                   

                    file.Close();


                    //worked
                    Console.WriteLine(File.ReadAllText(path));

                    Console.WriteLine("saved");



                    //close window
                    this.Close();


                }
            }
            catch
            {
                Save();
            }

            }

        // ------------------------------------------------
        //
        //                      ProgressBar
        //
        // ------------------------------------------------


    


        private void ProgressBar()
        {
            GYR.Minimum = 0;


                StartDate = DateTime.Parse(information[3]);
                ChangeDate = DateTime.Parse(information[4]);

            if (ODreading != null)
            {
                ODS = int.Parse(ODStart.Text);
                ODR = int.Parse(ODreading);
                total = int.Parse(ODreading) - int.Parse(ODStart.Text);
            }


            if (StartDate != compare)
            {
                

                double Time = ((ChangeDate.Date - StartDate.Date).TotalDays) + ODR;
                GYR.Maximum = (int)Time + total;
                //Console.WriteLine(Time);

                int T = ((int)(ChangeDate - Date).TotalDays) + total;

                Console.WriteLine((int)T);

                int TimeLeft =  T - (int)Time ;

                GYR.Value = (int)Time + TimeLeft;

            }

                if (GYR.Value >= 80)
                {
                    GYRTXT.Text = "GOOD " + GYR.Value.ToString() + "%";
                    GYR.ForeColor = System.Drawing.Color.Green;
                }
                else if (GYR.Value >= 45 && GYR.Value <= 79)
                {
                    GYRTXT.Text = "Okay " + GYR.Value.ToString() + "%";
                    GYR.ForeColor = System.Drawing.Color.Yellow;
                }
                else
                {
                    GYRTXT.Text = "Time to Change Now " + GYR.Value.ToString() + "%";
                    GYR.ForeColor = System.Drawing.Color.Red;
                }
           
            
        }

        private void Information_TextChanged(object sender, EventArgs e)
        {
        }

        private void SaveNotes_Click(object sender, EventArgs e)
        {

        }

        private void SaveNotes_Click(object sender, EventArgs e)
        {

        }
    }
    }
    }
   
