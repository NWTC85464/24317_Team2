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
    /// <summary>
    /// TODO: 
    /// 
    /// Add ability to name vehical and select vehical?
    /// 
    /// Create vehical objects that use vehical index value?
    /// 
    /// ***Add progress bars (use set "tire rotation value - subtract MPG-miles value" and set 
    ///     progress bar value. Set max value to tire rotation value and min value to 0.***
    ///     
    /// Add a way to create vehical on main form and save to object?
    /// 
    /// How do we run in background to maintaine progress?
    /// 
    /// Ability to adjust rotate milage after running for awhile?
    /// </summary>




    public partial class TireOptionsForm : System.Windows.Forms.Form
    {
        TireOptionsClass tireOptionsClass = new TireOptionsClass();
        MainFormClass mainFormClass = new MainFormClass();
        MainTracker mainTracker = new MainTracker();
        
        //Variables.
        public int vehicalNum;          //Holds vehical number.
        private int scrollLock = 0;     //Store value to lock track bar. 
        public int milage;              //Store MPG mileage from MPG form.

        public TireOptionsForm(int vehicalNum /*,int MPG*/)
        {
            //Set vehical number and mpg from passed in value.
            this.vehicalNum = vehicalNum;
            //this.milage = MPG;

            InitializeComponent();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;     
        }

        private void TireOptionsForm_Load(object sender, EventArgs e)
        {
            infoLbl.Text = "Vehical" + tireOptionsClass.Vehical1Values[0];

            if (tireOptionsClass.V1Stored == 1 && vehicalNum == 1)
            {

                    //Fill form with array values.......
                    sliderValueLbl.Text = tireOptionsClass.Vehical1Values[1];
                    milageTrackBar.Value = Int32.Parse(tireOptionsClass.Vehical1Values[1]); 
                    installDateTextBox.Text = tireOptionsClass.Vehical1Values[2];
                    infoLbl.Text = "Vehical" + tireOptionsClass.Vehical1Values[0];

                    //Deactivate the track bar slide
                    milageTrackBar.Enabled = false;

                    //Set the lock button back color.                
                    lockTrackBarButton.Image = new Bitmap("lock.png");

                    //Set scrollLock value to 1.
                    scrollLock = 1;                       
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
                lockTrackBarButton.Image = new Bitmap("lock.png");

                //Set scrollLock value to 1.
                scrollLock = 1;
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
                lockTrackBarButton.Image = new Bitmap("lock.png");

                //Set scrollLock value to 1.
                scrollLock = 1;
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
                lockTrackBarButton.Image = new Bitmap("lock.png");

                //Set scrollLock value to 1.
                scrollLock = 1;
            }
            else
            {
                //Set the slider value label inital to 0.
                sliderValueLbl.Text = "5000";
                infoLbl.Text = "Vehical" + vehicalNum;

                ////Added for progressbar.
                progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                rotateMilagelbl.Text = "0";
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
            lockTrackBarButton.Image = new Bitmap("lock.png");

            //Set scrollLock value to 1.
            scrollLock = 1;
        }

        private void storeArrays(int vehicalNum, string installDateTextBox, int milageTrackBar)
        {
            //Local variables.
            int vn = vehicalNum;
            int mtB = milageTrackBar;
            string iDTB = installDateTextBox;

            if (vehicalNum == 1)
            {               
                //Add tire values to array.
                tireOptionsClass.Vehical1Values[0] = vn.ToString();                                                                                              
                tireOptionsClass.Vehical1Values[1] = mtB.ToString();
                tireOptionsClass.Vehical1Values[2] = iDTB;

                //Int to state values added to restore form on return.
               // tireOptionsClass.TStored = 1;
                tireOptionsClass.V1Stored = 1;
            }
            else if (vehicalNum == 2)
            {               
                //Add tire values to array.
                tireOptionsClass.Vehical2Values[0] = vn.ToString(); 
                tireOptionsClass.Vehical2Values[1] = mtB.ToString();
                tireOptionsClass.Vehical2Values[2] = iDTB;

                //Int to state values added to restore form on return.
                //tireOptionsClass.TStored = 1;
                tireOptionsClass.V2Stored = 1;
            }
            else if (vehicalNum == 3)
            {
                //Add tire values to array.
                tireOptionsClass.Vehical3Values[0] = vn.ToString();
                tireOptionsClass.Vehical3Values[1] = mtB.ToString();
                tireOptionsClass.Vehical3Values[2] = iDTB;

                //Int to state values added to restore form on return.
                //tireOptionsClass.TStored = 1;
                tireOptionsClass.V3Stored = 1;
            }
            else if (vehicalNum == 4)
            {
                //Add tire values to array.
                tireOptionsClass.Vehical4Values[0] = vn.ToString();
                tireOptionsClass.Vehical4Values[1] = mtB.ToString();
                tireOptionsClass.Vehical4Values[2] = iDTB;

                //Int to state values added to restore form on return.
                //tireOptionsClass.TStored = 1;
                tireOptionsClass.V4Stored = 1;
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
                lockTrackBarButton.Image = new Bitmap("lock.png");

                //Set scrollLock value to 1.
                scrollLock = 1;
            }
            else if (scrollLock == 1)
            {
                //Reactivate the track bar slide
                milageTrackBar.Enabled = true;

                //Set the lock button back color.
                lockTrackBarButton.Image = new Bitmap("unlock.png");

                //Set the scrollLock value to 0.
                scrollLock = 0;
            }
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
                lockTrackBarButton.Image = new Bitmap("unlock.png");

                //Set the scrollLock value to 0.
                scrollLock = 0;

                //Set stored to false.
               // tireOptionsClass.TStored = 0;

                //Set track bar value and lbl to "0".
                milageTrackBar.Value = 5000;
                sliderValueLbl.Text = milageTrackBar.Value.ToString();

                //Clear text boxes.
                installDateTextBox.Text = "";

                if (vNum == 1)
                {
                    //Reset tire values array.          
                    for (int index = 0; index < tireOptionsClass.Vehical1Values.Length; index++)
                    {
                        tireOptionsClass.Vehical1Values[index] = "";
                    }

                    tireOptionsClass.V1Stored = 0;
                } 
                else if (vNum == 2)
                {
                    //Reset tire values array.          
                    for (int index = 0; index < tireOptionsClass.Vehical2Values.Length; index++)
                    {
                        tireOptionsClass.Vehical2Values[index] = "";
                    }
                    tireOptionsClass.V2Stored = 0;
                }
                else if (vNum == 3)
                {
                    //Reset tire values array.          
                    for (int index = 0; index < tireOptionsClass.Vehical3Values.Length; index++)
                    {
                        tireOptionsClass.Vehical3Values[index] = "";
                    }
                    tireOptionsClass.V3Stored = 0;
                }
                else if (vNum == 4)
                {
                    //Reset tire values array.          
                    for (int index = 0; index < tireOptionsClass.Vehical4Values.Length; index++)
                    {
                        tireOptionsClass.Vehical4Values[index] = "";
                    }
                    tireOptionsClass.V4Stored = 0;
                }

                //Display message everything was reset.
                MessageBox.Show("All values have been Reset!", "Success");
                
            }
            if (res == DialogResult.Cancel)
            {
                MessageBox.Show("You have clicked Cancel Button");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        /// <summary>
        /// This button click section is for progress bar which increases with click, to be changed by
        ///     adding milage as variable and subtracting it from rotate milage to increase progress bar.
        ///     
        /// Added variable pvalue and button1_Click for progress bar. Will be removed.
        /// </summary>
        int pvalue;

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Only set for vehical 1.
            progressBar1.Maximum = Int32.Parse(tireOptionsClass.Vehical1Values[1]);
            pvalue += 100;  //value to be from MPG miles
            progressBar1.Value = pvalue;
            if (progressBar1.Value < (Int32.Parse(tireOptionsClass.Vehical1Values[1]) / 2))
            {
                progressBar1.ForeColor = Color.Green;
            }
            if ((progressBar1.Value >= (Int32.Parse(tireOptionsClass.Vehical1Values[1]) / 2)) && progressBar1.Value < Int32.Parse(tireOptionsClass.Vehical1Values[1]) - (Int32.Parse(tireOptionsClass.Vehical1Values[1]) / 4))
            {
                progressBar1.ForeColor = Color.Yellow;
            }
            if (progressBar1.Value >= Int32.Parse(tireOptionsClass.Vehical1Values[1]) - (Int32.Parse(tireOptionsClass.Vehical1Values[1]) / 4))
            {
                progressBar1.ForeColor = Color.Red;
            }
            //label2.Text = pvalue.ToString();
            
        }
    }
}
