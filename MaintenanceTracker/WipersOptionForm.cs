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
using System.Drawing.Drawing2D;
using System.Xml;
using System.Xml.Linq;

namespace MaintenanceTracker
{
    public partial class WipersOptionForm : System.Windows.Forms.Form
    {
        Wiper[] wiper = new Wiper[1];
        MainFormClass mainFormClass = new MainFormClass();
        MainTracker mainTracker = new MainTracker();
        

        //Variables.
        int vehicleNum;                 // Holds Vehicle number.
        string nextInstallDateParse;    // Next wiper installation date
        string installedDateParse;      // Wiper installed date
        double driver;                  // Wiper size - driver
        double passager;                // Wiper size - passager
        double rear;                    // Wiper size - rear

        public object HttpContext { get; private set; }

        public WipersOptionForm(int vNum)
        {
            InitializeComponent();

            //Set Vehicle number from passed in value.
            this.vehicleNum = vNum;

            //Form background color.
            this.BackColor = System.Drawing.Color.Aqua;

            //this.BackgroundImage = Properties.Resources.wiper;  

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            // Display wiper info for the selected vehicle
            vehicleNumLabel.Text = "Wiper Info for Vehicle #" + vehicleNum;

            // VEHICLE #1
            if (vehicleNum == 1)    // If vehicle number 1 is selected
            {
                // Variable to hold file
                string wiperDataFile = @"C:\Users\x12 t2015\source\repos\24317_Team2\MaintenanceTracker\bin\Debug\WiperData1.xml";

                // If file exists or not
                MessageBox.Show(File.Exists(wiperDataFile) ? "File exists." : "File does not exist.");

                //wiperProgressBar.Visible = true;    // Show progress bar
                //installedDateTimePicker.Enabled = false;

                if (File.Exists(wiperDataFile))
                {
                    // ***************NEED FOR KEEP OR DELETE FILE**************
                    //***IF KEEP, THEN DISPLAY DATA FOR THE VEHICLE
                    //***IF DELETE, DISPLAY FORM TO CREATE NEW DATA
                      
                   
                    
                    // Call and pass the xml file to be displayed
                    displayWiperData(wiperDataFile);

                    //*****display on new form
                    //if click RESET, file will be delete and back to fill form for the vehicle
                    //if click OK, back to the main form to select a different vehicle

                }

            }

            // VEHICLE #2
            if (vehicleNum == 2)    // If vehicle number 2 is selected
            {
                // Variable to hold file
                string wiperDataFile = @"C:\Users\x12 t2015\source\repos\24317_Team2\MaintenanceTracker\bin\Debug\WiperData2.xml";

                // If file exists or not
                MessageBox.Show(File.Exists(wiperDataFile) ? "File exists." : "File does not exist.");

                //wiperProgressBar.Visible = true;    // Show progress bar
                //installedDateTimePicker.Enabled = false;
                if (File.Exists(wiperDataFile))
                {
                    // Call and pass the xml file to be displayed
                    displayWiperData(wiperDataFile);

                }

            }

            // VEHICLE #3
            if (vehicleNum == 3)    // If vehicle number 3 is selected
            {
                // Variable to hold file
                string wiperDataFile = @"C:\Users\x12 t2015\source\repos\24317_Team2\MaintenanceTracker\bin\Debug\WiperData3.xml";

                // If file exists or not
                MessageBox.Show(File.Exists(wiperDataFile) ? "File exists." : "File does not exist.");

                //wiperProgressBar.Visible = true;    // Show progress bar
                //installedDateTimePicker.Enabled = false;
                if (File.Exists(wiperDataFile))
                {
                    displayWiperData(wiperDataFile);
                }

            }

            // VEHICLE #4
            if (vehicleNum == 4)    // If vehicle number 4 is selected
            {
                // Variable to hold file
                string wiperDataFile = @"C:\Users\x12 t2015\source\repos\24317_Team2\MaintenanceTracker\bin\Debug\WiperData4.xml";

                // If file exists or not
                MessageBox.Show(File.Exists(wiperDataFile) ? "File exists." : "File does not exist.");

                //wiperProgressBar.Visible = true;    // Show progress bar
                //installedDateTimePicker.Enabled = false;
                if (File.Exists(wiperDataFile))
                {
                    displayWiperData(wiperDataFile);
                }

            }
        }

        private void displayWiperData(string wFile)
        {
            // Turn off fields that used to enter data
            installedDateTimePicker.Visible = false;
            nextReplaceDateDisplayLabel.Visible = false;
            driverSideTextBox.Visible = false;
            passagerSideTextBox.Visible = false;
            rearTextBox.Visible = false;
            brandTextBox.Visible = false;
            notesTextBox.Visible = false;

            XmlDocument d = new XmlDocument();
            d.Load(wFile);
            XmlElement root = d.DocumentElement;
            vehicleNumLabel.Text = "Wiper Info for Vehicle #" + root.GetElementsByTagName("Vehicle_Number")[0].InnerText;
            displayInstDateLabel.Text = root.GetElementsByTagName("Installed_Date")[0].InnerText;
            displayNextDateLabel.Text = root.GetElementsByTagName("Next_Install_Date")[0].InnerText;
            displayDrSideLabel.Text = root.GetElementsByTagName("Driver_Size")[0].InnerText;
            displayPassSideLabel.Text = root.GetElementsByTagName("Passager_Size")[0].InnerText;
            displayRearLabel.Text = root.GetElementsByTagName("Rear_Size")[0].InnerText;
            displayBrandLabel.Text = root.GetElementsByTagName("Brand")[0].InnerText;
            displayNotesLabel.Text = root.GetElementsByTagName("Notes")[0].InnerText;
           
        }
        private void WipersOptionForm_Load(int vNum)
        {
            tipAndInfoButton.BackColor = System.Drawing.Color.AliceBlue;

            tipAndInfoButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);

            tipAndInfoButton.FlatStyle = FlatStyle.Flat;
            tipAndInfoButton.FlatAppearance.BorderSize = 2;           

        }


        // progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;



        // Exit the app
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Select data wipers are installed
        public void installedDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            // Get the current date.
            DateTime thisDay = installedDateTimePicker.Value.Date;

            installedDateParse = thisDay.ToString("D");     // To be passed to be stored

            DateTime answer = thisDay.AddDays(180);         // Add 180 days to the installed date

            nextInstallDateParse = answer.ToString("D");    // Convert for display

            // Display the next replacement date.
            nextReplaceDateDisplayLabel.Text = nextInstallDateParse.ToString();
        }

        // View tips and more info
        private void tipAndInfoButton_Click_1(object sender, EventArgs e)
        {
            //Call Tips and Info form.
            WipersOptionsTipsAndInfo wipersTipsAndInfo = new WipersOptionsTipsAndInfo();
            wipersTipsAndInfo.ShowDialog();
        }

        // Reset the form
        private void reset(int vN)
        {
            int v_N = vN;

            //Prompt user if they want to reset values.
            DialogResult res = MessageBox.Show("Are you sure you want to reset the form?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                switch (v_N)
                {
                    case 1:

                        //*********** IF DELETE FILE, NEED CODES TO DELETE FILE AND CLEAR FIELDS *****
                        //****NEED CODES TO CREATE FILE****

                        clearFields(v_N);
                      
                        break;

                    case 2:
                        clearFields(v_N);
                        break;

                    case 3:
                        clearFields(v_N);
                        break;

                    case 4:
                        clearFields(v_N);
                        break;

                    default:
                        break;

                    
                }
               
            }
        }

        
        private void clearFields(int vNum)
        {
            wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brandTextBox.Text, notesTextBox.Text);

            using (XmlWriter writer = XmlWriter.Create("WiperData" + vNum + ".xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Wiper");

                foreach (Wiper w in wiper)
                {
                    writer.WriteStartElement("Wiper");

                    // Empty all elements
                    writer.WriteElementString("Vehicle_Number", "");
                    writer.WriteElementString("Installed_Date", "");
                    writer.WriteElementString("Next_Install_Date", "");
                    writer.WriteElementString("Driver_Size", "");
                    writer.WriteElementString("Passager_Size", "");
                    writer.WriteElementString("Rear_Size", "");
                    writer.WriteElementString("Brand", "");
                    writer.WriteElementString("Notes", "");

                    writer.WriteEndElement();   // End writing 
                }

                writer.WriteEndElement();       // End writing 
                writer.WriteEndDocument();      // End writing to file
            }

           
            // Turn on fields that used to enter data
            installedDateTimePicker.Visible = true;
            nextReplaceDateDisplayLabel.Visible = true;
            driverSideTextBox.Visible = true;
            passagerSideTextBox.Visible = true;
            rearTextBox.Visible = true;
            brandTextBox.Visible = true;
            notesTextBox.Visible = true;
            

            // Turn off display labels
            displayInstDateLabel.Visible = false;
            displayNextDateLabel.Visible = false;
            displayDrSideLabel.Visible = false;
            displayPassSideLabel.Visible = false;
            displayRearLabel.Visible = false;
            displayBrandLabel.Visible = false;
            displayNotesLabel.Visible = false; 


            // Empty fields
            installedDateTimePicker.ResetText();
            nextReplaceDateDisplayLabel.Text = "";
            driverSideTextBox.Clear();
            passagerSideTextBox.Clear();
            rearTextBox.Clear();
            brandTextBox.Clear();
            notesTextBox.Clear();

            // Enable the fields to be edited
            installedDateTimePicker.Enabled = true;
            nextReplaceDateDisplayLabel.Enabled = true;
            driverSideTextBox.Enabled = true;
            passagerSideTextBox.Enabled = true;
            rearTextBox.Enabled = true;
            brandTextBox.Enabled = true;
            notesTextBox.Enabled = true;
        }
        
        private void writeToXML(int v)
        {
            string wi = @"C:\Users\x12 t2015\source\repos\24317_Team2\MaintenanceTracker\bin\Debug\WiperData" + v + ".xml";

            wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brandTextBox.Text, notesTextBox.Text);

            if (File.Exists(wi))
            {
                //****if file already exists, just add the values to the xml file
                //***if file not exist, create file and add values
                //***create method to add file and method to create file and add values
            }
            using (XmlWriter writer = XmlWriter.Create("WiperData" + v + ".xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Wiper");

                foreach (Wiper w in wiper)
                {
                    writer.WriteStartElement("Wiper");

                    writer.WriteElementString("Vehicle_Number", w.vNumber.ToString());
                    writer.WriteElementString("Installed_Date", w.Install);
                    writer.WriteElementString("Next_Install_Date", w.Next);
                    writer.WriteElementString("Driver_Size", w.Driver.ToString());
                    writer.WriteElementString("Passager_Size", w.Passager.ToString());
                    writer.WriteElementString("Rear_Size", w.Rear.ToString());
                    writer.WriteElementString("Brand", w.Brand);
                    writer.WriteElementString("Notes", w.Notes);

                    writer.WriteEndElement();   // End writing 
                }

                writer.WriteEndElement();       // End writing 
                writer.WriteEndDocument();      // End writing to file
            }
        }


        // Save the info entered
        private void saveButton_Click_1(object sender, EventArgs e)
        {
            //***** NEED DATA STORAGE **************
            if (String.IsNullOrEmpty(nextReplaceDateDisplayLabel.Text))
            {
                MessageBox.Show("Please select date wiper was installed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                installedDateTimePicker.Focus();
            }
            else if (String.IsNullOrEmpty(driverSideTextBox.Text))
            {
                MessageBox.Show("Please enter driver side wiper size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                driverSideTextBox.Focus();
            }
            else if (String.IsNullOrEmpty(passagerSideTextBox.Text))
            {
                MessageBox.Show("Please enter passager side wiper size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passagerSideTextBox.Focus();
            }
            else if (String.IsNullOrEmpty(rearTextBox.Text))
            {
                MessageBox.Show("Please enter rear wiper size. Enter 0 if no rear wiper.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rearTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(brandTextBox.Text))
            {
                MessageBox.Show("Please enter brand name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                brandTextBox.Focus();
                //notes = notesTextBox.Text;
            }
            else if (!double.TryParse(driverSideTextBox.Text, out driver))
            {
                MessageBox.Show("This is a number only field");
                driverSideTextBox.Focus();
                return;
            }
            else if (!double.TryParse(passagerSideTextBox.Text, out passager))
            {
                MessageBox.Show("This is a number only field");
                passagerSideTextBox.Focus();
                return;
            }
            else if (!double.TryParse(rearTextBox.Text, out rear))
            {
                MessageBox.Show("This is a number only field");
                rearTextBox.Focus();
                return;
            }
            //Brand name
            else if (string.IsNullOrWhiteSpace(brandTextBox.Text))
            {
                MessageBox.Show("Please enter brand name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                brandTextBox.Focus();
                //notes = notesTextBox.Text;
            }
            else
            {

                // Pass info to be stored
                storeWiperInfo(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brandTextBox.Text, notesTextBox.Text);

                // Lock all field after validated inputs
                installedDateTimePicker.Enabled = false;
                nextReplaceDateDisplayLabel.Enabled = false;
                driverSideTextBox.Enabled = false;
                passagerSideTextBox.Enabled = false;
                rearTextBox.Enabled = false;
                brandTextBox.Enabled = false;
                notesTextBox.Enabled = false;
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Call reset method and passing vehicle number to it
            reset(vehicleNum);
        }

        // Store wiper's info
        private void storeWiperInfo(int vehicleNum, string installedDateParse, string nextInstallDateParse, double driver, double passager, double rear, string brand, string notes)
        {

            switch (vehicleNum)
            {
                case 1:
                    writeToXML(vehicleNum);                   
                    break;

                case 2:
                    writeToXML(vehicleNum);
                    break;

                case 3:
                    writeToXML(vehicleNum);
                    break;

                case 4:
                    writeToXML(vehicleNum);
                    break;

                default:
                    break;

            }
        }
        
        /*
        private void progressBar(int vehicalNum, string rotateValue)
        {
           
            int vehNum = vehicalNum;
            //int miles = milage;
            //int rotate = Int32.Parse(rotateValue);
            //double mil = System.Convert.ToDouble(milage);
            //double rot = double.Parse(rotateValue);

            //Display the percentage remaining and round.            
            double percentLeft = Math.Round((180 - , 2);
            wiperPercentLabel.Text = percentLeft.ToString() + "%";

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
        }*/
        
        }
   }
 
        