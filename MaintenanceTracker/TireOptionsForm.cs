using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaintenanceTracker.Properties;

namespace MaintenanceTracker
{
    //TODO:   
    //
    //Change how file gets writen on exit form so it wont error if someone doesnt save a file and closes.
    //
    //install date day month year validation?
    //
    //change reset message boxes
    //
    //change tip message box
    //
   
    //
    //Remove scroll lock
    //
    //Add progress bar 2 for tire change feed back?

    public partial class TireOptionsForm : System.Windows.Forms.Form
    {
        //Create instances.
        TireOptionsClass tireOptionsClass = new TireOptionsClass();
        MainFormClass mainFormClass = new MainFormClass();
        MainTracker mainTracker = new MainTracker();

        //Create new controls.
        public Button setBtn1 = new Button();   //Set values button.
        Label tiLB = new Label();               //Tire info label.
        Label ttLB = new Label();               //Tire tips label.
        PictureBox pB = new PictureBox();       //Tire tips rotation picture.
        FlowLayoutPanel flowPanel = new FlowLayoutPanel();
       

        //Variables.
        public int vehicalNum;          //Holds vehical number.
        private int scrollLock = 0;     //Store value to lock track bar. 
        public int milesDriven;              //Store MPG mileage from MPG form.  
        //public int prevOdometer;
        public int odometer;
        //public int storedOdometer;
        bool allDataEntered = false;
        bool filesCreated = false;       //bool state if a file exsits.
        bool fileDataExsits = false;

        //Create path to save text files.
        string path1 = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\v1Info.txt";
        string path2 = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\v2Info.txt";
        string path3 = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\v3Info.txt";
        string path4 = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\v4Info.txt";
        
        public TireOptionsForm(int vehicalNum, int MilesDriven, int odometerReading)
        {
            InitializeComponent();

            //Create files if not existing.
            filesCreated = createTextFiles(vehicalNum, path1, path2, path3, path4, filesCreated);

            //Check files for data.
            fileDataExsits = checkFileData(vehicalNum, path1, path2, path3, path4, fileDataExsits);

            //Set vehical number and mpg from passed in value.
            this.vehicalNum = vehicalNum;
            this.milesDriven = MilesDriven;
            this.odometer = odometerReading;
            

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            //Add vehical number to tire options form lbl
            tireOptionsFormLBL.Text = "Vehicle " + vehicalNum + " Tire Options";

            //Add items to combobox.
            this.comboBox1.Items.Add("30,000");
            this.comboBox1.Items.Add("40,000");
            this.comboBox1.Items.Add("50,000");
            this.comboBox1.Items.Add("60,000");
            this.comboBox1.Items.Add("70,000");
            this.comboBox1.Items.Add("80,000");
            this.comboBox1.Items.Add("90,000");
            this.comboBox1.Items.Add("100,000");

            //Add tire info label controls to form.            
            tiLB.AutoSize = true;
            tiLB.Margin = new Padding(40, 30, 40, 10);
            tiLB.Visible = false;

            //Add tire tips label and controls to form.
            ttLB.Height = 100;
            ttLB.Width = 250;
            ttLB.Padding = new Padding(10, 10, 10, 10);
            ttLB.Visible = false;

////////////////////////////////////////////////////////////////////////////////////////////
            //Add a click feature to expand the image "zoom"
            //remove buttons and make area bigger less cluttered.
            //Add tire tips picture box and controls to form.            
            pB.Height = 85;
            pB.Width = 225;
            pB.BackgroundImage = new Bitmap(Resources.rotatePatern);
            pB.BackgroundImageLayout = ImageLayout.Stretch;                        
            pB.Margin = new Padding(10, 0, 10, 10);
            pB.Visible = false;

            //Add tire tips label and picture box to pannel.            
            flowPanel.Height = 200;
            flowPanel.Width = 250;
            flowPanel.Location = new Point(this.ClientSize.Width / 2 - flowPanel.Size.Width / 2, 30);
            flowPanel.Controls.Add(tiLB);
            flowPanel.Controls.Add(ttLB);
            flowPanel.Controls.Add(pB);
            
            flowPanel.FlowDirection = FlowDirection.TopDown;
            Controls.Add(flowPanel);
            flowPanel.BackColor = Color.LightGray;
            flowPanel.Visible = false;
            
            setTireValuesgroupBox.Visible = false;
        }
       
        private void TireOptionsForm_Load(object sender, EventArgs e)
        {
            //If to check if file exsits, if it does call loadVehicalSavedValues method to load values from file.
            if (fileDataExsits == true)
            {
                //Load values form saved text file.
                loadVehicalSavedValues(vehicalNum);
            }

            //Set trackbar tick marks.
            milageTrackBar.TickStyle = TickStyle.BottomRight;
            milageTrackBar.TickFrequency = 1000;
           
            //Load form with values from arrays.
            if (tireOptionsClass.V1Stored == 1 && vehicalNum == 1)
            {
                //Fill form with array values.......
                tireOptionsFormLBL.Text = "Vehicle " + tireOptionsClass.Vehical1Values[0] + " Tire Options";
                sliderValueLbl.Text = tireOptionsClass.Vehical1Values[1];
                milageTrackBar.Value = Int32.Parse(tireOptionsClass.Vehical1Values[1]); 
                installDateTextBox.Text = tireOptionsClass.Vehical1Values[2];
                comboBox1.SelectedIndex = Convert.ToInt32(tireOptionsClass.Vehical1Values[3]);
                

                //Deactivate the track bar slide
                milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                scrollLock = 1;

                //Call progressBar method.
                pBar1Set(vehicalNum, milesDriven, tireOptionsClass.Vehical1Values[1]);
                //pBar2Set(odometer, milesDriven, storedOdometer);
            }
            else if (tireOptionsClass.V2Stored == 1 && vehicalNum == 2)
            {
                //Fill form with array values.......
                sliderValueLbl.Text = tireOptionsClass.Vehical2Values[1];
                milageTrackBar.Value = Int32.Parse(tireOptionsClass.Vehical2Values[1]);
                installDateTextBox.Text = tireOptionsClass.Vehical2Values[2];
                comboBox1.SelectedIndex = Convert.ToInt32(tireOptionsClass.Vehical2Values[3]);
                tireOptionsFormLBL.Text = "Vehicle " + tireOptionsClass.Vehical2Values[0] + " Tire Options";

                //Deactivate the track bar slide
                milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                scrollLock = 1;

                //Call progressBar method.
                pBar1Set(vehicalNum, milesDriven, tireOptionsClass.Vehical2Values[1]);
            }
            else if (tireOptionsClass.V3Stored == 1 && vehicalNum == 3)
            {
                //Fill form with array values.......
                sliderValueLbl.Text = tireOptionsClass.Vehical3Values[1];
                milageTrackBar.Value = Int32.Parse(tireOptionsClass.Vehical3Values[1]);
                installDateTextBox.Text = tireOptionsClass.Vehical3Values[2];
                comboBox1.SelectedIndex = Convert.ToInt32(tireOptionsClass.Vehical3Values[3]);
                tireOptionsFormLBL.Text = "Vehical " + tireOptionsClass.Vehical3Values[0] + " Tire Options";

                //Deactivate the track bar slide
                milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                scrollLock = 1;

                //Call progressBar method.
                pBar1Set(vehicalNum, milesDriven, tireOptionsClass.Vehical3Values[1]);
            }
            else if (tireOptionsClass.V4Stored == 1 && vehicalNum == 4)
            {
                //Fill form with array values.......
                sliderValueLbl.Text = tireOptionsClass.Vehical4Values[1];
                milageTrackBar.Value = Int32.Parse(tireOptionsClass.Vehical4Values[1]);
                installDateTextBox.Text = tireOptionsClass.Vehical4Values[2];
                comboBox1.SelectedIndex = Convert.ToInt32(tireOptionsClass.Vehical4Values[3]);
                tireOptionsFormLBL.Text = "Vehical " + tireOptionsClass.Vehical4Values[0] + " Tire Options";

                //Deactivate the track bar slide
                milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                scrollLock = 1;

                //Call progressBar method.
                pBar1Set(vehicalNum, milesDriven, tireOptionsClass.Vehical4Values[1]);
            }
            else
            {
                //Set the slider value label inital to 0.
                sliderValueLbl.Text = "5000";
                tireOptionsFormLBL.Text = "Vehicle " + vehicalNum + " Tire Options";

                ////Added for progressbar.
                progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

                //Hide progress bar and percent lbl if no file exsits on load.
                progressBar1.Visible = false;
                progressBar2.Visible = false;
                percentLbl.Visible = false;
                percentLbl2.Visible = false;
            }
        }

        //Button to store the values enter in the text boxes into a list.
        private void saveValuesButton_Click(object sender, EventArgs e)
        {
            //Method to check if user entered set their prefrences
            allDataEntered = checkDataEntered(allDataEntered, installDateTextBox.Text, milageTrackBar.Value, comboBox1.SelectedIndex);

            if (allDataEntered == true)
            { 
                //Pass values to storeArray method.
                storeArrays(vehicalNum, installDateTextBox.Text, milageTrackBar.Value, comboBox1.SelectedIndex, odometer, milesDriven);

                //Deactivate the track bar slide
                milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                scrollLock = 1;

                //Set backcolors back to default.
                milageTrackBar.BackColor = default(Color);
                installDateTextBox.BackColor = default(Color);
                comboBox1.BackColor = default(Color);
                saveValuesButton.Focus();

                //Set to visiblability.                
                progressBar1.Visible = true;
                progressBar2.Visible = true;
                percentLbl.Visible = true;
                percentLbl2.Visible = true;
                setTireValuesgroupBox.Visible = false;
                setBtn.Visible = true;
                tireInfoButton.Enabled = true;
                notepad.Enabled = true;
                tireTipsButton.Enabled = true;
            }
        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //Display the sliders current value in label.
            sliderValueLbl.Text = milageTrackBar.Value.ToString();
        }

        private void lockTrackBarButton_Click_1(object sender, EventArgs e)
        {
            //If else statment to lock the track bar from being adjusted.
            if (scrollLock == 0)
            {
                //Deactivate the track bar slide
                milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                scrollLock = 1;
            }
            else if (scrollLock == 1)
            {
                //Reactivate the track bar slide
                milageTrackBar.Enabled = true;

                //Set the lock button back color.
                lockTrackBarButton.Image = Resources.unlock;

                //Set the scrollLock value to 0.
                scrollLock = 0;
            }
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            //Set to visiblability.
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            percentLbl.Visible = false;
            percentLbl2.Visible = false;
            setTireValuesgroupBox.Visible = true;
            setBtn.Visible = false;
            tiLB.Visible = false;
            flowPanel.Visible = false;
            tireInfoButton.Enabled = false;
            notepad.Enabled = false;
            tireTipsButton.Enabled = false;
        }
        
        private void resetButton_Click(object sender, EventArgs e)
        {
            //Hide tire info label.
            tiLB.Visible = false;

            //Pass vehicalNum to method.
            resetValues(vehicalNum);           
        }

        //Button click will print array index values to dialogbox.
        private void tireInfoButton_Click(object sender, EventArgs e)
        {
            //Hide progress bar.
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            percentLbl.Visible = false;
            percentLbl2.Visible = false;

            //Make panel visable.
            flowPanel.Visible = true;
            tiLB.Visible = true;
            ttLB.Visible = false;
            pB.Visible = false;

            if (vehicalNum == 1 && tireOptionsClass.V1Stored == 1)
            {
                //Get the tire mileage rating from combobox.
                string tMr = getTireMileageRating();

                //Concatnat output string.
                string Output = "Vehicle #" + vehicalNum + "\n" + "Tires Installed On " + tireOptionsClass.Vehical1Values[2].ToString()
                    + "\n" + "Set Rotation Mileage " + tireOptionsClass.Vehical1Values[1]
                    + "\nTire Mileage Rating: " + tMr;
                    //+ "\nCurrent Odometer: " + tireOptionsClass.Vehical1Values[5];               
                
                //Add String output to tire info listbox.
                foreach (string line in Output.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                {
                    tiLB.Text = Output;
                }
            }
            else if (vehicalNum == 2 && tireOptionsClass.V2Stored == 1)
            {
                //Get the tire mileage rating from combobox.
                string tMr = getTireMileageRating();

                //Concatnat output string.
                string Output = "Vehicle #" + vehicalNum + "\n" + "Tires Installed On " + tireOptionsClass.Vehical2Values[2].ToString()
                    + "\n" + "Set Rotation Mileage " + tireOptionsClass.Vehical2Values[1]
                    + "\nTire Mileage Rating: " + tMr;
                     //+ "\nCurrent Odometer: " + tireOptionsClass.Vehical2Values[5];
                //Add String output to tire info listbox.
                foreach (string line in Output.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                {
                    tiLB.Text = Output;
                }
            }
            else if (vehicalNum == 3 && tireOptionsClass.V3Stored == 1)
            {
                //Get the tire mileage rating from combobox.
                string tMr = getTireMileageRating();

                //Concatnat output string.
                string Output = "Vehicle #" + vehicalNum + "\n" + "Tires Installed On " + tireOptionsClass.Vehical3Values[2].ToString()
                    + "\n" + "Set Rotation Mileage " + tireOptionsClass.Vehical3Values[1]
                    + "\nTire Mileage Rating: " + tMr;
                     //+ "\nCurrent Odometer: " + tireOptionsClass.Vehical3Values[5];

                //Add String output to tire info listbox.
                foreach (string line in Output.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                {
                    tiLB.Text = Output;
                }
            }
            else if (vehicalNum == 4 && tireOptionsClass.V4Stored == 1)
            {
                //Get the tire mileage rating from combobox.
                string tMr = getTireMileageRating();

                //Concatnat output string.
                string Output = "Vehicle #" + vehicalNum + "\n" + "Tires Installed On " + tireOptionsClass.Vehical4Values[2].ToString()
                    + "\n" + "Set Rotation Mileage " + tireOptionsClass.Vehical4Values[1]
                    + "\nTire Mileage Rating: " + tMr;
                    // + "\nCurrent Odometer: " + tireOptionsClass.Vehical4Values[5];

                //Add String output to tire info listbox.
                foreach (string line in Output.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                {
                    tiLB.Text = Output;
                }
            }
            else
            {
                //Display if no values.
                MessageBox.Show("No Vaues are Stored");
            }            
        }
                
        private void tireTipsButton_Click(object sender, EventArgs e)
        {
            //Hide tire info label.
            tiLB.Visible = false;
            progressBar1.Visible = false;
            progressBar2.Visible = false;
            percentLbl.Visible = false;
            percentLbl2.Visible = false;

            //Display other info in messege box.
            //MessageBox.Show(tireOptionsClass.RotateMessage, "Information");
            pB.Visible = true;
            ttLB.Visible = true;
            ttLB.Text = tireOptionsClass.RotateMessage;
            flowPanel.Visible = true;            
        }       

        private void installDateTextBox_Click(object sender, EventArgs e)
        {
            //Empty text box when clicked.
            installDateTextBox.Text = string.Empty;
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            //Hide tire info label.
            tiLB.Visible = false;

            //Load comments form.
            TireCommentForm tireCommentForm = new TireCommentForm(vehicalNum);
            tireCommentForm.Show();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Hide tire info label.
            tiLB.Visible = false;

            //Save values to textfiles.
            switch (vehicalNum)
            {
                case 1:
                        if ((!File.Exists("v1Info.txt"))) //Checking if v1Info.txt exists or not
                        {
                            FileStream fs = File.Create("v1Info.txt"); //Creates v1Info.txt
                            fs.Close(); //Closes file stream
                        }

                        //Write each line of tireOptionsClass.Vehical1Values array to text file.               
                        foreach (string line in tireOptionsClass.Vehical1Values)
                        {
                            //Write tireOptionsClass.Vehical1Values array values to file upon form exit.
                            File.WriteAllLines(path1, tireOptionsClass.Vehical1Values);
                            // MessageBox.Show(line);
                        }                                        
                    break;
                case 2:
                    if ((!File.Exists("v2Info.txt"))) //Checking if v2Info.txt exists or not
                    {
                        FileStream fs = File.Create("v2Info.txt"); //Creates v2Info.txt
                        fs.Close(); //Closes file stream
                    }
                    
                    //Write each line of tireOptionsClass.Vehical2Values array to text file.               
                    foreach (string line in tireOptionsClass.Vehical2Values)
                    {
                        //Write tireOptionsClass.Vehical2Values array values to file upon form exit.
                        File.WriteAllLines(path2, tireOptionsClass.Vehical2Values);
                        // MessageBox.Show(line);
                    }
                    break;
                case 3:
                    if ((!File.Exists("v3Info.txt"))) //Checking if v3Info.txt exists or not
                    {
                        FileStream fs = File.Create("v3Info.txt"); //Creates v3Info.txt
                        fs.Close(); //Closes file stream
                    }

                    //Write each line of tireOptionsClass.Vehical3Values array to text file.               
                    foreach (string line in tireOptionsClass.Vehical3Values)
                    {
                        //Write tireOptionsClass.Vehical2Values array values to file upon form exit.
                        File.WriteAllLines(path3, tireOptionsClass.Vehical3Values);
                        // MessageBox.Show(line);
                    }
                    break;
                case 4:
                    if ((!File.Exists("v4Info.txt"))) //Checking if v4Info.txt exists or not
                    {
                        FileStream fs = File.Create("v4Info.txt"); //Creates v4Info.txt
                        fs.Close(); //Closes file stream
                    }
                    
                    //Write each line of tireOptionsClass.Vehical4Values array to text file.               
                    foreach (string line in tireOptionsClass.Vehical4Values)
                    {
                        //Write tireOptionsClass.Vehical4Values array values to file upon form exit.
                        File.WriteAllLines(path4, tireOptionsClass.Vehical4Values);
                        // MessageBox.Show(line);
                    }
                    break;
                default:
                    //
                    break;
            }
           this.Close();
        }

        //Methods....
        private bool createTextFiles(int vn, string p1, string p2, string p3, string p4, bool cTf)
        {
            switch (vn)
            {
                case 1:
                    //If the files doesn't exsist.
                    if (!File.Exists(p1))
                    {
                        //Create the file.
                        using (File.Create(p1)) ;
                        
                        //Return false.
                        cTf = false;
                    }
                    else
                    {
                        //If the file exsists and the length is == 0 or = 10 file is blank.
                        if ((new FileInfo(p1).Length == 0) || (new FileInfo(p1).Length == 10))
                        {
                            //Return false.
                            cTf = false;
                        }
                        else
                        {
                            //If file exsists return true.
                            cTf = true;
                        }                       
                    }
                    break;
                case 2:
                    //If the files doesn't exsist.
                    if (!File.Exists(p2))
                    {
                        //Create the file.
                        using (File.Create(p2)) ;

                        //Return false.
                        cTf = false;
                    }
                    else
                    {
                        //If the file exsists and the length is == 0 or = 10 file is blank.
                        if ((new FileInfo(p2).Length == 0) || (new FileInfo(p2).Length == 10))
                        {
                            //Return false.
                            cTf = false;
                        }
                        else
                        {
                            //If file exsists return true.
                            cTf = true;
                        }
                    }
                    break;
                case 3:
                    //If the files doesn't exsist.
                    if (!File.Exists(p3))
                    {
                        //Create the file.
                        using (File.Create(p3)) ;

                        //Return false.
                        cTf = false;
                    }
                    else
                    {
                        //If the file exsists and the length is == 0 or = 10 file is blank.
                        if ((new FileInfo(p3).Length == 0) || (new FileInfo(p3).Length == 10))
                        {
                            //Return false.
                            cTf = false;
                        }
                        else
                        {
                            //If file exsists return true.
                            cTf = true;
                        }
                    }
                    break;
                case 4:
                    //If the files doesn't exsist.
                    if (!File.Exists(p4))
                    {
                        //Create the file.
                        using (File.Create(p4)) ;

                        //Return false.
                        cTf = false;
                    }
                    else
                    {
                        //If the file exsists and the length is == 0 or = 10 file is blank.
                        if ((new FileInfo(p4).Length == 0) || (new FileInfo(p4).Length == 10))
                        {
                            //Return false.
                            cTf = false;
                        }
                        else
                        {
                            //If file exsists return true.
                            cTf = true;
                        }
                    }
                    break;
                default:
                    //Do nothing.
                    break;
            }
            return cTf;
        }
        
        private bool checkFileData(int vehicalNum, string path1, string path2, string path3, string path4, bool fileDataExsits)
        {
            bool fde = fileDataExsits;
            switch (vehicalNum)
            {
                case 1:
                    if ((new FileInfo(path1).Length == 0) || (new FileInfo(path1).Length == 10))
                    {
                        fde = false;
                    }
                    else
                    {
                        fde = true;
                    }
                    break;
                case 2:
                    if ((new FileInfo(path2).Length == 0) || (new FileInfo(path2).Length == 10))
                    {
                        fde = false;
                    }
                    else
                    {
                        fde = true;
                    }
                    break;
                case 3:
                    if ((new FileInfo(path3).Length == 0) || (new FileInfo(path3).Length == 10))
                    {
                        fde = false;
                    }
                    else
                    {
                        fde = true;
                    }
                    break;
                case 4:
                    if ((new FileInfo(path4).Length == 0) || (new FileInfo(path4).Length == 10))
                    {
                        fde = false;
                    }
                    else
                    {
                        fde = true;
                    }
                    break;

                default:
                    //
                    break;
            }
            return fde;
        }

        private string getTireMileageRating()
        {

            //Store selected item in object.
            Object selectedItem = comboBox1.SelectedItem;

            //Return object index items text.
            return selectedItem.ToString();
        }

        //Method to check if user has enterd data when pressing the save button.
        public bool checkDataEntered(bool allDataEntered, string installDate, int milageBarValue, int maxTireMilage)
        {
            //Variables
            bool aDE = allDataEntered;  //Passed in bool all data enterd.
            bool checkedValues = false; //Local variable for while loop.

            //While loop to check if all user preferences are enterd.
            while (checkedValues != true)
            {
                //Check install date format.
                bool dateGood = validateDate(installDate);
                if (dateGood == false)
                {
                    aDE = false;
                    break;
                }

                //Check if mileage bar has value set.
                if (milageBarValue == 0)
                {
                    //Display message box to set rotation if item is not selected.
                    MessageBox.Show("Please set Rotation Mileage Preference");

                    //Set the focus to combobox.
                    milageTrackBar.Focus();

                    //Set back color to yellow.
                    milageTrackBar.BackColor = Color.Yellow;
                    break;
                }

                //Check if combobox item is selected.
                else if (comboBox1.SelectedItem == null)
                {
                    //Display messeage to select tire mileage.
                    MessageBox.Show("Please select tire mileage");

                    //Set focus to combobox.
                    comboBox1.Focus();

                    //Set combobox back color to yellow.
                    comboBox1.BackColor = Color.Yellow;
                    break;
                }
                else
                {
                    //Continue
                    checkedValues = true;
                }
                aDE = true;
            }
            return aDE;
        }

        private void loadVehicalSavedValues(int vehicalNum)
        {
            //Switch to read saved text file values and load into arrays. Switches with vehical number.
            switch (vehicalNum)
            {
                case 1:
                    //Load vehical1 text values into array.
                    var v1 = File.ReadAllLines(path1);
                    tireOptionsClass.Vehical1Values = File.ReadLines(path1).ToArray();
                    tireOptionsClass.V1Stored = 1;
                    break;
                case 2:
                    //Load vehical2 text values into array.
                    var v2 = File.ReadAllLines(path2);
                    tireOptionsClass.Vehical2Values = File.ReadLines(path2).ToArray();
                    tireOptionsClass.V2Stored = 1;
                    break;
                case 3:
                    //Load vehical3 text values into array.
                    var v3 = File.ReadAllLines(path3);
                    tireOptionsClass.Vehical3Values = File.ReadLines(path3).ToArray();
                    tireOptionsClass.V3Stored = 1;
                    break;
                case 4:
                    //Load vehical4 text values into array.
                    var v4 = File.ReadAllLines(path4);
                    tireOptionsClass.Vehical4Values = File.ReadLines(path4).ToArray();
                    tireOptionsClass.V4Stored = 1;
                    break;
                default:
                    //Nothing to load.
                    break;
            }
        }

        private void pBar1Set(int vehicalNum, int milage, string rotateValue)
        {
            int vehNum = vehicalNum;
            int miles = milage;
            int rotate = Int32.Parse(rotateValue);
            double mil = System.Convert.ToDouble(milage);
            double rot = double.Parse(rotateValue);

            //Display the percentage remaining and round.            
            double percentLeft = Math.Round((100 - (100 * (mil / rot))), 2);
            
            //Set percent label to not show below 0%.
            if(percentLeft > 0)
            {
                percentLbl.Text = percentLeft.ToString() + "%";
            }
            else
            {
                percentLbl.Text = "0%";
            }

            try
            {
                progressBar1.Maximum = rotate;
                progressBar1.Value = progressBar1.Maximum - miles;

                if (progressBar1.Value > (rotate / 2))
                {
                    progressBar1.ForeColor = Color.Green;
                }
                else if ((progressBar1.Value <= (rotate / 2)) && progressBar1.Value > rotate / 4)
                {
                    progressBar1.ForeColor = Color.Yellow;
                }
                else if (progressBar1.Value <= rotate / 4 && progressBar1.Value > 0)
                {
                    progressBar1.ForeColor = Color.Red;
                }
                else if (progressBar1.Value <= 0)
                {
                    MessageBox.Show("Tire need to be rotated");
                }
            }
            catch
            {
                MessageBox.Show("Tire need to be rotated");
                //Do nothing.....
            }
        }

        //Check method to validate the install date text box.
        private bool validateDate(string installDate)
        {
            //Variables.
            bool dg;
            DateTime Test;

            //Check if install text box is empty string or empty mask.
            if ((String.IsNullOrEmpty(installDate) || installDateTextBox.Text == "  /  /"))
            {
                //Display messeage to re-enter date.
                MessageBox.Show("Please re-enter Install Date");

                //Set the focus to install text box.
                installDateTextBox.Focus();

                //Set the back color to yellow.
                installDateTextBox.BackColor = Color.Yellow;

                dg = false;
            }
            //Check the format of the date entered.
            else if (DateTime.TryParseExact(installDateTextBox.Text, "MM/dd/yyyy", null, DateTimeStyles.None, out Test) == true)
            {
                //Add checker for months, day, yr maybe?
                dg = true;
            }
            else
            {
                //Display messeage to re-enter date.
                MessageBox.Show("Please re-enter Install Date");

                //Set the focus to install text box.
                installDateTextBox.Focus();

                //Set the back color to yellow.
                installDateTextBox.BackColor = Color.Yellow;

                dg = false;
            }

            //Return true if date is good or false if date is bad.
            return dg;
        }

        private void storeArrays(int vehicalNum, string installDateTextBox, int milageTrackBar, 
                                int tireTreadMilage, int odometer, int milesDriven)
        {
            //Local variables.
            int vn = vehicalNum;
            int mtB = milageTrackBar;
            string iDTB = installDateTextBox;
            int tTM = tireTreadMilage;
            int md = milesDriven;
            int odom = odometer;
            //int pOdo = preOdometer;
            //int newOdb=0; 

            switch (vehicalNum)
            {
                case 1:
                    //Add tire values to array.
                    tireOptionsClass.Vehical1Values[0] = vn.ToString();
                    tireOptionsClass.Vehical1Values[1] = mtB.ToString();
                    tireOptionsClass.Vehical1Values[2] = iDTB;
                    tireOptionsClass.Vehical1Values[3] = tTM.ToString();
                    tireOptionsClass.Vehical1Values[4] = md.ToString();
                    //tireOptionsClass.Vehical1Values[5] = odom.ToString();
                    
                    pBar1Set(vehicalNum, md, tireOptionsClass.Vehical1Values[1]);
                    //pBar2Set(odom, md, storedOdometer);

                    //Int to state values added to restore form on return.
                    tireOptionsClass.V1Stored = 1;
                    break;
                case 2:
                    //Add tire values to array.
                    tireOptionsClass.Vehical2Values[0] = vn.ToString();
                    tireOptionsClass.Vehical2Values[1] = mtB.ToString();
                    tireOptionsClass.Vehical2Values[2] = iDTB;
                    tireOptionsClass.Vehical2Values[3] = tTM.ToString();
                    tireOptionsClass.Vehical2Values[4] = md.ToString();
                    //tireOptionsClass.Vehical2Values[5] = odom.ToString();

                    pBar1Set(vehicalNum, md, tireOptionsClass.Vehical2Values[1]);
                    //pBar2Set(odom, md, storedOdometer);

                    //Int to state values added to restore form on return.
                    tireOptionsClass.V2Stored = 1;
                    break;
                case 3:
                    //Add tire values to array.
                    tireOptionsClass.Vehical3Values[0] = vn.ToString();
                    tireOptionsClass.Vehical3Values[1] = mtB.ToString();
                    tireOptionsClass.Vehical3Values[2] = iDTB;
                    tireOptionsClass.Vehical3Values[3] = tTM.ToString();
                    tireOptionsClass.Vehical3Values[4] = md.ToString();
                    //tireOptionsClass.Vehical3Values[5] = odom.ToString();

                    pBar1Set(vehicalNum, md, tireOptionsClass.Vehical3Values[1]);
                   // pBar2Set(odom, md, storedOdometer);

                    //Int to state values added to restore form on return.
                    tireOptionsClass.V3Stored = 1;
                    break;
                case 4:
                    //Add tire values to array.
                    tireOptionsClass.Vehical4Values[0] = vn.ToString();
                    tireOptionsClass.Vehical4Values[1] = mtB.ToString();
                    tireOptionsClass.Vehical4Values[2] = iDTB;
                    tireOptionsClass.Vehical4Values[3] = tTM.ToString();
                    tireOptionsClass.Vehical4Values[4] = md.ToString();
                    //tireOptionsClass.Vehical4Values[5] = odom.ToString();

                    pBar1Set(vehicalNum, md, tireOptionsClass.Vehical4Values[1]);
                    //pBar2Set(odom, md, storedOdometer);

                    //Int to state values added to restore form on return.
                    tireOptionsClass.V4Stored = 1;
                    break;
                default:
                    //
                    break;
            }
        }

        private void pBar2Set(int Odometer, int MilesDriven, int StoredOdometer)
        {
            int odometer = Odometer;
            int milesDriven = MilesDriven;
            int storedOdometer = StoredOdometer;            
        }

        private void resetValues(int vehicalNum)
        {
            int vNum = vehicalNum;

            //Prompt user if they want to reset values.
            DialogResult res = MessageBox.Show("Are you sure you want to Reset Values?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                //Reset milage value and unlock track bar.
                //
                //Reactivate the track bar slide
                milageTrackBar.Enabled = true;

                //Set the lock button back to unlock.
                lockTrackBarButton.Image = Resources.unlock;

                //Set the scrollLock value to 0.
                scrollLock = 0;

                //Set track bar value and lbl to "0".
                milageTrackBar.Value = 5000;
                sliderValueLbl.Text = milageTrackBar.Value.ToString();

                //Clear text boxes.
                installDateTextBox.Text = "";

                switch (vNum)
                {
                    case 1:
                        //Reset tire values array.  
                        Array.Clear(tireOptionsClass.Vehical1Values, 0, tireOptionsClass.Vehical1Values.Length);
                        tireOptionsClass.V1Stored = 0;
                        progressBar1.Value = 0;
                        progressBar2.Value = 0;
                        percentLbl.Text = "";
                        percentLbl2.Text = "";
                        progressBar1.Visible = false;
                        progressBar2.Visible = false;
                        break;
                    case 2:
                        //Reset tire values array. 
                        Array.Clear(tireOptionsClass.Vehical2Values, 0, tireOptionsClass.Vehical2Values.Length);
                        tireOptionsClass.V2Stored = 0;
                        progressBar1.Value = 0;
                        progressBar2.Value = 0;
                        percentLbl.Text = "";
                        percentLbl2.Text = "";
                        progressBar1.Visible = false;
                        progressBar2.Visible = false;
                        break;
                    case 3:
                        //Reset tire values array. 
                        Array.Clear(tireOptionsClass.Vehical3Values, 0, tireOptionsClass.Vehical3Values.Length);
                        tireOptionsClass.V3Stored = 0;
                        progressBar1.Value = 0;
                        progressBar2.Value = 0;
                        percentLbl.Text = "";
                        percentLbl2.Text = "";
                        progressBar1.Visible = false;
                        progressBar2.Visible = false;
                        break;
                    case 4:
                        //Reset tire values array.    
                        Array.Clear(tireOptionsClass.Vehical4Values, 0, tireOptionsClass.Vehical4Values.Length);
                        tireOptionsClass.V4Stored = 0;
                        progressBar1.Value = 0;
                        progressBar2.Value = 0;
                        percentLbl.Text = "";
                        percentLbl2.Text = "";
                        progressBar1.Visible = false;
                        progressBar2.Visible = false;
                        break;
                    default:
                        //
                        break;
                }

                //Display message everything was reset.
                MessageBox.Show("All values have been Reset!", "Success");
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked the Cancel Button");
            }
        }

    }
}
