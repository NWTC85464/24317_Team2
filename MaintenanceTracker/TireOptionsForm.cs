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
using MaintenanceTracker.Properties;

namespace MaintenanceTracker
{
    //TODO:
    //
    //Add install date format validation.
    //
    //change reset message boxes
    //
    //change tip message box
    //
    //change tire value message box
    //
    //Add tire milage start text?
    //
    //Add progress bar 2 for tire change feed back?

    public partial class TireOptionsForm : System.Windows.Forms.Form
    {
        //Create instances.
        TireOptionsClass tireOptionsClass = new TireOptionsClass();
        MainFormClass mainFormClass = new MainFormClass();
        MainTracker mainTracker = new MainTracker();

        //Create new controls.
        public Button setBtn1 = new Button();

        //Variables.
        public int vehicalNum;          //Holds vehical number.
        private int scrollLock = 0;     //Store value to lock track bar. 
        public int milage;              //Store MPG mileage from MPG form.   
        bool fileExsists = false;       //bool state if a file exsits.

        //Create path to save text files.
        string path1 = @"C:\Users\jk\source\repos\24317_Team2\MaintenanceTracker\Resources\v1Info.txt";
        string path2 = @"C:\Users\jk\source\repos\24317_Team2\MaintenanceTracker\Resources\v2Info.txt";
        string path3 = @"C:\Users\jk\source\repos\24317_Team2\MaintenanceTracker\Resources\v3Info.txt";
        string path4 = @"C:\Users\jk\source\repos\24317_Team2\MaintenanceTracker\Resources\v4Info.txt";
        
        public TireOptionsForm(int vehicalNum, int MPG)
        {
            InitializeComponent();

            //Create files if not existing.
            fileExsists = createTextFiles(vehicalNum, path1, path2, path3, path4, fileExsists);
           
            //Set vehical number and mpg from passed in value.
            this.vehicalNum = vehicalNum;
            this.milage = MPG;

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
           
            //Create progress bar2.

            //Add items to combobox.
            this.comboBox1.Items.Add("30,000");
            this.comboBox1.Items.Add("40,000");
            this.comboBox1.Items.Add("50,000");
            this.comboBox1.Items.Add("60,000");
            this.comboBox1.Items.Add("70,000");
            this.comboBox1.Items.Add("80,000");
            this.comboBox1.Items.Add("90,000");
            this.comboBox1.Items.Add("100,000");

            //Hide track bar, installDate textbox, and associated labels.
            sliderValueLbl.Visible = false;
            milesLbl.Visible = false;
            sldLbl.Visible = false;
            milageTrackBar.Visible = false;
            lockTrackBarButton.Visible = false;
            installLbl.Visible = false;
            installDateTextBox.Visible = false;
            saveValuesButton.Visible = false;
            tireMilLbl.Visible = false;
            comboBox1.Visible = false;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }        

        private void TireOptionsForm_Load(object sender, EventArgs e)
        {
            //If to check if file exsits, if it does call loadVehicalSavedValues method to load values from file.
            if (fileExsists == true)
            {
                //Load values form saved text file.
                loadVehicalSavedValues(vehicalNum);
            }

            //Set trackbar tick marks.
            milageTrackBar.TickStyle = TickStyle.BottomRight;
            milageTrackBar.TickFrequency = 1000;
           
            //Set label to vehical number.
            infoLbl.Text = "Vehical" + vehicalNum;

            //Load form with values from arrays.
            if (tireOptionsClass.V1Stored == 1 && vehicalNum == 1)
            {               
                //Fill form with array values.......
                infoLbl.Text = "Vehical" + tireOptionsClass.Vehical1Values[0];
                sliderValueLbl.Text = tireOptionsClass.Vehical1Values[1];
                milageTrackBar.Value = Int32.Parse(tireOptionsClass.Vehical1Values[1]); 
                installDateTextBox.Text = tireOptionsClass.Vehical1Values[2];
               
                //Deactivate the track bar slide
                milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                scrollLock = 1;

                //Call progressBar method.
                pBarSet(vehicalNum, milage, tireOptionsClass.Vehical1Values[1]);
            }
            else if (tireOptionsClass.V2Stored == 1 && vehicalNum == 2)
            {
                //Fill form with array values.......
                sliderValueLbl.Text = tireOptionsClass.Vehical2Values[1];
                milageTrackBar.Value = Int32.Parse(tireOptionsClass.Vehical2Values[1]);
                installDateTextBox.Text = tireOptionsClass.Vehical2Values[2];
                infoLbl.Text = "Vehical" + tireOptionsClass.Vehical2Values[0];

                //Deactivate the track bar slide
                milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                scrollLock = 1;

                //Call progressBar method.
                pBarSet(vehicalNum, milage, tireOptionsClass.Vehical2Values[1]);
            }
            else if (tireOptionsClass.V3Stored == 1 && vehicalNum == 3)
            {
                //Fill form with array values.......
                sliderValueLbl.Text = tireOptionsClass.Vehical3Values[1];
                milageTrackBar.Value = Int32.Parse(tireOptionsClass.Vehical3Values[1]);
                installDateTextBox.Text = tireOptionsClass.Vehical3Values[2];
                infoLbl.Text = "Vehical" + tireOptionsClass.Vehical3Values[0];

                //Deactivate the track bar slide
                milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                scrollLock = 1;

                //Call progressBar method.
                pBarSet(vehicalNum, milage, tireOptionsClass.Vehical3Values[1]);
            }
            else if (tireOptionsClass.V4Stored == 1 && vehicalNum == 4)
            {
                //Fill form with array values.......
                sliderValueLbl.Text = tireOptionsClass.Vehical4Values[1];
                milageTrackBar.Value = Int32.Parse(tireOptionsClass.Vehical4Values[1]);
                installDateTextBox.Text = tireOptionsClass.Vehical4Values[2];
                infoLbl.Text = "Vehical" + tireOptionsClass.Vehical4Values[0];

                //Deactivate the track bar slide
                milageTrackBar.Enabled = false;

                //Set the lock button back color.                
                lockTrackBarButton.Image = Resources._lock;

                //Set scrollLock value to 1.
                scrollLock = 1;

                //Call progressBar method.
                pBarSet(vehicalNum, milage, tireOptionsClass.Vehical4Values[1]);
            }
            else
            {
                //Set the slider value label inital to 0.
                sliderValueLbl.Text = "5000";
                infoLbl.Text = "Vehical" + vehicalNum;

                ////Added for progressbar.
                progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            }
        }       

        //Button to store the values enter in the text boxes into a list.
        private void saveValuesButton_Click(object sender, EventArgs e)
        {           
            //Pass values to storeArray method.
            storeArrays(vehicalNum, installDateTextBox.Text, milageTrackBar.Value);

            //Deactivate the track bar slide
            milageTrackBar.Enabled = false;

            //Set the lock button back color.                
            lockTrackBarButton.Image = Resources._lock;

            //Set scrollLock value to 1.
            scrollLock = 1;

            //Set to visible.
            //setMilageLbl.Visible = false;
            sliderValueLbl.Visible = false;
            milesLbl.Visible = false;
            sldLbl.Visible = false;
            milageTrackBar.Visible = false;
            lockTrackBarButton.Visible = false;
            installLbl.Visible = false;
            installDateTextBox.Visible = false;
            saveValuesButton.Visible = false;
            comboBox1.Visible = false;
            tireMilLbl.Visible = false;
            setBtn.Visible = true;
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
            //Set to visible.
            //setMilageLbl.Visible = true;
            sliderValueLbl.Visible = true;
            milesLbl.Visible = true;
            sldLbl.Visible = true;
            milageTrackBar.Visible = true;
            lockTrackBarButton.Visible = true;
            installLbl.Visible = true;
            installDateTextBox.Visible = true;
            saveValuesButton.Visible = true;
            setBtn.Visible = false;
            comboBox1.Visible = true;
            tireMilLbl.Visible = true;
        }
        
        private void resetButton_Click(object sender, EventArgs e)
        {
            //Pass vehicalNum to method.
            resetValues(vehicalNum);           
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
                        for (int index = 0; index < tireOptionsClass.Vehical1Values.Length; index++)
                        {
                            tireOptionsClass.Vehical1Values[index] = "";
                        }

                        tireOptionsClass.V1Stored = 0;
                        progressBar1.Value = 0;
                        break;
                    case 2:
                        //Reset tire values array.          
                        for (int index = 0; index < tireOptionsClass.Vehical2Values.Length; index++)
                        {
                            tireOptionsClass.Vehical2Values[index] = "";
                        }
                        tireOptionsClass.V2Stored = 0;
                        progressBar1.Value = 0;
                        break;
                    case 3:
                        //Reset tire values array.          
                        for (int index = 0; index < tireOptionsClass.Vehical3Values.Length; index++)
                        {
                            tireOptionsClass.Vehical3Values[index] = "";
                        }
                        tireOptionsClass.V3Stored = 0;
                        progressBar1.Value = 0;
                        break;
                    case 4:
                        //Reset tire values array.          
                        for (int index = 0; index < tireOptionsClass.Vehical4Values.Length; index++)
                        {
                            tireOptionsClass.Vehical4Values[index] = "";
                        }
                        tireOptionsClass.V4Stored = 0;
                        progressBar1.Value = 0;
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
                MessageBox.Show("You have clicked Cancel Button");
            }
        }
      
        //Button click will print array index values to dialogbox.
        private void tireInfoButton_Click(object sender, EventArgs e)
        {           
            if(vehicalNum == 1 && tireOptionsClass.V1Stored == 1)
            {
                //Concatnat output string.
                string Output = "Vehical #" + vehicalNum + "\n" + "Tires Installed On " + tireOptionsClass.Vehical1Values[2].ToString()
                    + "\n" + "Set Rotation Milage " + tireOptionsClass.Vehical1Values[1];

                //Display Output in messeage box.
                MessageBox.Show(Output);
            }
            else if (vehicalNum == 2 && tireOptionsClass.V2Stored == 1)
            {
                //Concatnat output string.
                string Output = "Vehical #" + vehicalNum + "\n" + "Tires Installed On " + tireOptionsClass.Vehical2Values[2].ToString()
                    + "\n" + "Set Rotation Milage " + tireOptionsClass.Vehical2Values[1];

                //Display Output in messeage box.
                MessageBox.Show(Output);
            }
            else if (vehicalNum == 3 && tireOptionsClass.V3Stored == 1)
            {
                //Concatnat output string.
                string Output = "Vehical #" + vehicalNum + "\n" + "Tires Installed On " + tireOptionsClass.Vehical3Values[2].ToString()
                    + "\n" + "Set Rotation Milage " + tireOptionsClass.Vehical3Values[1];

                //Display Output in messeage box.
                MessageBox.Show(Output);
            }
            else if (vehicalNum == 4 && tireOptionsClass.V4Stored == 1)
            {
                //Concatnat output string.
                string Output = "Vehical #" + vehicalNum + "\n" + "Tires Installed On " + tireOptionsClass.Vehical4Values[2].ToString()
                    + "\n" + "Set Rotation Milage " + tireOptionsClass.Vehical4Values[1];

                //Display Output in messeage box.
                MessageBox.Show(Output);
            }
            else
            {
                //Display if no values.
                MessageBox.Show("No Vaues Stored");
            }            
        }

        private void otherInfoButton_Click(object sender, EventArgs e)
        {
            //Display other info in messege box.
            MessageBox.Show(tireOptionsClass.RotateMessage, "Information");
        }
       
        private void pBarSet(int vehicalNum, int milage, string rotateValue)
        {
            int vehNum = vehicalNum;
            int miles = milage;
            int rotate = Int32.Parse(rotateValue);
            double mil= System.Convert.ToDouble(milage);
            double rot= double.Parse(rotateValue);

            //Display the percentage remaining and round.            
            double percentLeft = Math.Round((100 - (100 * (mil / rot))), 2);
            percentLbl.Text = percentLeft.ToString() + "%";

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
                else if(progressBar1.Value <= 0)
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

        private void installDateTextBox_Click(object sender, EventArgs e)
        {
            //Empty text box when clicked.
            installDateTextBox.Text = string.Empty;
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            //Load comments form.
            TireCommentForm tireCommentForm = new TireCommentForm(vehicalNum);
            tireCommentForm.Show();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
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
        private bool createTextFiles(int vn, string p1, string p2, string p3, string p4, bool fE)
        {
            switch (vn)
            {
                case 1:
                    if (!File.Exists(p1))
                    {
                        // Create a file to write to for vehcial 1.
                        using (StreamWriter sw = File.CreateText(p1))
                        {
                            sw.WriteLine(" ");
                            sw.WriteLine(" ");
                            sw.WriteLine(" ");
                            fE = false;
                        }
                    }
                    else
                    {
                        if (new FileInfo(p1).Length == 6)
                        {
                            fE = false;
                        }
                        else
                        {
                            fE = true;
                        }
                       
                    }
                    break;
                case 2:
                    if (!File.Exists(p2))
                    {
                        // Create a file to write to for vehcial 1.
                        using (StreamWriter sw = File.CreateText(p2))
                        {
                            sw.WriteLine(" ");
                            sw.WriteLine(" ");
                            sw.WriteLine(" ");
                            fE = false;
                        }
                    }
                    else
                    {
                        if (new FileInfo(p2).Length == 6)
                        {
                            fE = false;
                        }
                        else
                        {
                            fE = true;
                        }

                    }
                    break;
                case 3:
                    if (!File.Exists(p3))
                    {
                        // Create a file to write to for vehcial 1.
                        using (StreamWriter sw = File.CreateText(p3))
                        {
                            sw.WriteLine(" ");
                            sw.WriteLine(" ");
                            sw.WriteLine(" ");
                            fE = false;
                        }
                    }
                    else
                    {
                        if (new FileInfo(p3).Length == 6)
                        {
                            fE = false;
                        }
                        else
                        {
                            fE = true;
                        }

                    }
                    break;
                case 4:
                    if (!File.Exists(p4))
                    {
                        // Create a file to write to for vehcial 1.
                        using (StreamWriter sw = File.CreateText(p4))
                        {
                            sw.WriteLine(" ");
                            sw.WriteLine(" ");
                            sw.WriteLine(" ");
                            fE = false;
                        }
                    }
                    else
                    {
                        if (new FileInfo(p4).Length == 6)
                        {
                            fE = false;
                        }
                        else
                        {
                            fE = true;
                        }

                    }
                    break;
                default:
                    //
                    break;
            }
            return fE;
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

        private void storeArrays(int vehicalNum, string installDateTextBox, int milageTrackBar)
        {
            //Local variables.
            int vn = vehicalNum;
            int mtB = milageTrackBar;
            string iDTB = installDateTextBox;

            switch (vehicalNum)
            {
                case 1:
                    //Add tire values to array.
                    tireOptionsClass.Vehical1Values[0] = vn.ToString();
                    tireOptionsClass.Vehical1Values[1] = mtB.ToString();
                    tireOptionsClass.Vehical1Values[2] = iDTB;
                    pBarSet(vehicalNum, milage, tireOptionsClass.Vehical1Values[1]);

                    //Int to state values added to restore form on return.
                    tireOptionsClass.V1Stored = 1;
                    break;
                case 2:
                    //Add tire values to array.
                    tireOptionsClass.Vehical2Values[0] = vn.ToString();
                    tireOptionsClass.Vehical2Values[1] = mtB.ToString();
                    tireOptionsClass.Vehical2Values[2] = iDTB;
                    pBarSet(vehicalNum, milage, tireOptionsClass.Vehical2Values[1]);

                    //Int to state values added to restore form on return.
                    tireOptionsClass.V2Stored = 1;
                    break;
                case 3:
                    //Add tire values to array.
                    tireOptionsClass.Vehical3Values[0] = vn.ToString();
                    tireOptionsClass.Vehical3Values[1] = mtB.ToString();
                    tireOptionsClass.Vehical3Values[2] = iDTB;
                    pBarSet(vehicalNum, milage, tireOptionsClass.Vehical3Values[1]);

                    //Int to state values added to restore form on return.
                    tireOptionsClass.V3Stored = 1;
                    break;
                case 4:
                    //Add tire values to array.
                    tireOptionsClass.Vehical4Values[0] = vn.ToString();
                    tireOptionsClass.Vehical4Values[1] = mtB.ToString();
                    tireOptionsClass.Vehical4Values[2] = iDTB;
                    pBarSet(vehicalNum, milage, tireOptionsClass.Vehical4Values[1]);

                    //Int to state values added to restore form on return.
                    tireOptionsClass.V4Stored = 1;
                    break;
                default:
                    //
                    break;
            }
        }
    }
}
