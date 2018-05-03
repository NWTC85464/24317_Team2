using System;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace MaintenanceTracker
{
    public partial class OilOptionsForm : System.Windows.Forms.Form
    {
        //streamwriter
        private string[] information = new string[5];

        public string path;
        public string storage;
        MainFormClass MainClass = new MainFormClass();

    

        public OilOptionsForm()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.Aqua;

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            Console.WriteLine(MainClass.VehicalNumber);

        }

       
        private void OilTrackerForm(object sender, EventArgs e)
        {
            AmountTotal.ReadOnly = true;

         

            int car = MainClass.VehicalNumber;


            switch (car)
            {
                case 1:
                    path = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\mains\oil\car1.txt";
                    storage = @"C:.\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\back-ups\oil\car1.txt";
                    break;

                case 2:
                    path = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\mains\oil\car2.txt";
                    storage = @"C:.\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\back-ups\oil\car2.txt";
                    break;

                case 3:
                    path = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\mains\oil\car3.txt";
                    storage = @"C:.\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\back-ups\oil\car3.txt";
                    break;

                case 4:
                    path = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\mains\oil\car4.txt";
                    storage = @"C:.\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\back-ups\oil\car4.txt";
                    break;

                default: Console.WriteLine("error404"); break;
            }


            Console.WriteLine("loading....");



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

                ProgressBar();

                info.Close();

                Console.WriteLine("Completed");

                oilBrand.Text = information[0];
                oilUse.Text = information[1];
                AmountTotal.Text = information[2];

                Amount.Enabled = false;
                oilBrand.ReadOnly = true;
                oilUse.ReadOnly = true;
                Lock.Text = "Unlock";

            }
            else
            {
                Console.WriteLine("No data retrived");
            }

        }


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
                oilBrand.ReadOnly = true;
                oilUse.ReadOnly = true;

                Lock.Text = "Unlock";
            }
            else
            {
                Amount.Enabled = true;
                oilBrand.ReadOnly = false;
                oilUse.ReadOnly = false;

                Lock.Text = "Lock";
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

        private Boolean Clicked =true;

        private void options(object sender, EventArgs e)
        {
            if (Clicked)
            {
                
            }




        }

        private void exit(object sender, EventArgs e)
        {

            if (StartDate == compare && ChangeDate == compare)
            {
                Console.WriteLine("Saving Dates");

                StartDate = DateTime.Today;

                ChangeDate = StartDate.AddMonths(3);

                information[3] = StartDate.ToString();
                information[4] = ChangeDate.ToString();

            }

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
                        Save();
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
                CheckIFHaveFiles();

            }
        }

        //----------------------------------------------------------
        //----------------------------------------------------------
        //----------------------------------------------------------

        private void CheckIFHaveFiles()
        {
            if (!File.Exists(storage) && !File.Exists(path))
            {
                Console.WriteLine("No Oil Files Created Yet for this Car");
                Console.WriteLine("Now Preparing to create the files");
                //make back-up
                Console.WriteLine("Back-up file created");
                File.Create(storage);

                //make path
                Console.WriteLine("Main file created");
                File.Create(path);

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




        private DateTime Date = DateTime.Today;
        private DateTime StartDate = new DateTime();
        private DateTime ChangeDate = new DateTime();
        private DateTime compare = new DateTime();

        private Timer Progress = new Timer();

     
        private void ProgressBar()
        {
            GYR.Minimum = 0;

            StartDate = DateTime.Parse(information[3]);
            ChangeDate = DateTime.Parse(information[4]);
           

            if (StartDate != compare)
            {


                double Time = (ChangeDate.Date - StartDate.Date).TotalDays;
                GYR.Maximum = (int)Time;
                Console.WriteLine(Time);

                int T = (int)(ChangeDate - Date).TotalDays;

                Console.WriteLine((int) T);

                int TimeLeft = (int) Time - T;

                GYR.Value += (int) Time - TimeLeft;

            }

            if (GYR.Value >= 80)
            {    
                GYR.ForeColor = System.Drawing.Color.Green;
            }
            else if (GYR.Value >= 45 && GYR.Value <= 79)
            {
               
                GYR.ForeColor = System.Drawing.Color.Yellow;
            }
            else
            {
                
                GYR.ForeColor = System.Drawing.Color.Red;
            }

        }


        }
    }

    

