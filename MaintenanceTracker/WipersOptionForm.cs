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
    // for future updates
    // add button to each form for each service to view if all forms were filled, files existed, data are there
    // this way user doesn't have to go in and out to view info/data

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
        string wiperDataFile;

        public object HttpContext { get; private set; }

        public WipersOptionForm(int vNum)
        {
            InitializeComponent();

            //Set Vehicle number from passed in value.
            this.vehicleNum = vNum;
           
            // Progress bar
            wiperProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            // Display wiper info for the selected vehicle
            vehicleNumLabel.Text = "Wiper Info for Vehicle #" + vehicleNum;

            // change reset to new/clear
            // have EDIT when load data to edit 

            //***** disabling progress bar - can't have negative value
            //***** will work on for future update
            wiperProgressBar.Visible = false;    // Show progress bar
            wiperProgressBar.Enabled = false;

            // VEHICLE #1
            if (vehicleNum == 1)    // If vehicle number 1 is selected
            {
                displayWiperData(vehicleNum);
                /*
                // Variable to hold file
                wiperDataFile = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\WiperInfo\WiperData1.xml";

                // If file exists or not
                MessageBox.Show(File.Exists(wiperDataFile) ? "File exists." : "File does not exist.");
                ///
               
               /* if (displayNextDateLabel.Text == "")
               {
                    // If not file, enable the form to be filled
                   newForm(vNum);
                }
                else
                {
                    File.Exists(wiperDataFile);
                    displayWiperData(wiperDataFile);
                }
                */
                /*
                if (File.Exists(wiperDataFile))
                {
                    // ***************NEED FOR KEEP OR DELETE FILE**************
                    //***IF KEEP, THEN DISPLAY DATA FOR THE VEHICLE
                    //***IF DELETE, DISPLAY FORM TO CREATE NEW DATA

                    // Call and pass the xml file to be displayed
                    displayWiperData(wiperDataFile);

                }
                else
                {                    
                    // If not file, enable the form to be filled
                    newForm(vNum);
                }
                */
            }
            
            // VEHICLE #2
            if (vehicleNum == 2)    // If vehicle number 2 is selected
            {
                displayWiperData(vehicleNum);
                
            }

            // VEHICLE #3
            if (vehicleNum == 3)    // If vehicle number 3 is selected
            {
                displayWiperData(vehicleNum);
               
            }

            // VEHICLE #4
            if (vehicleNum == 4)    // If vehicle number 4 is selected
            {
                displayWiperData(vehicleNum);
               
            }
        }

        //Displaying information from the existing file for the selected vehicle
        private void displayWiperData(int v)
        {
            // Variable to hold file
            wiperDataFile = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\WiperInfo\WiperData" + v + ".xml";

            // If file exists or not
            MessageBox.Show(File.Exists(wiperDataFile) ? "There is a file for this vehicle." : "There isn't a file for this vehicle. Please enter new data.");
           
            if (File.Exists(wiperDataFile))
            {
                // ***************NEED FOR KEEP OR DELETE FILE**************
                //***IF KEEP, THEN DISPLAY DATA FOR THE VEHICLE
                //***IF DELETE, DISPLAY FORM TO CREATE NEW DATA

                // Call and pass the xml file to be displayed
                //displayWiperData(wiperDataFile);                

                progressBar(wiperDataFile);                 // Call progress bar method to be displayed
                

                // Turn off fields that used to enter data
                installedDateTimePicker.Visible = false;
                nextReplaceDateDisplayLabel.Visible = false;
                driverSideTextBox.Visible = false;
                passagerSideTextBox.Visible = false;
                rearTextBox.Visible = false;
                brandTextBox.Visible = false;
                notesTextBox.Visible = false;

                XmlDocument d = new XmlDocument();
                d.Load(wiperDataFile);
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
            else
            {
                // If not file, enable the form to be filled
                newForm(v);
            }
            

        }
        private void WipersOptionForm_Load(int vNum)
        {
            tipAndInfoButton.BackColor = System.Drawing.Color.AliceBlue;

            tipAndInfoButton.Font = new Font("Rockwell", 20f, FontStyle.Bold);

            tipAndInfoButton.FlatStyle = FlatStyle.Flat;

            tipAndInfoButton.FlatAppearance.BorderSize = 2;

        }

        // Exit the app
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();

            // *****if form is blank, message to show that it's blank and previous info will be restored
        }

        // Select the date wipers are installed
        public void installedDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            // Get the current date.
            DateTime thisDay = installedDateTimePicker.Value.Date;

            DateTime today = DateTime.Now;

            installedDateParse = thisDay.ToString("D");     // To be passed to be stored

            //***Use 6 days for example
            DateTime answer = thisDay.AddDays(6);         // Add 180 days to the installed date                                                       
            
            if (thisDay > today)
            {
                MessageBox.Show("Please pick today's date or older.");
                
            }   
            /*else if(thisDay < b)
            {
                MessageBox.Show("Please pick a date that is less than 6 days ago");
            }*/
            else
            {
                nextInstallDateParse = answer.ToString("D");    // Convert for display

                // Display the next replacement date.
                nextReplaceDateDisplayLabel.Text = nextInstallDateParse.ToString();
            }
           
        }

        // View tips and more info
        private void tipAndInfoButton_Click_1(object sender, EventArgs e)
        {
            //Call Tips and Info form.
            WipersOptionsTipsAndInfo wipersTipsAndInfo = new WipersOptionsTipsAndInfo();
            wipersTipsAndInfo.ShowDialog();

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Reset/clear the form
        private void clear(int vN)
        {
            int v_N = vN;

            //Prompt user if they want to reset values.
            DialogResult res = MessageBox.Show("Are you sure you want to clear the form?\n" + "Click Cancel to go back.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                switch (v_N)
                {
                    case 1:                        
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

        // Set the form to be filled
        private void newForm(int _vn)
        {
            int v = _vn;

            switch (v)
            {
                case 1:

                    //*********** IF DELETE FILE, NEED CODES TO DELETE FILE AND CLEAR FIELDS *****
                    //****NEED CODES TO CREATE FILE****

                    clearFields(v);
                    break;

                case 2:
                    clearFields(v);
                    break;

                case 3:
                    clearFields(v);
                    break;

                case 4:
                    clearFields(v);
                    break;

                default:
                    break;
            }

        }

        // Clear the form
        private void clearFields(int vNum)
        {
            //***WITHOUT THIS, IT WILL DISPLAY THE DATA FROM PREVIOUSLY SAVED****
            //string wi = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\WiperInfo\WiperData" + vNum + ".xml";
            /*
            wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brandTextBox.Text, notesTextBox.Text);
            //using (XmlWriter writer = XmlWriter.Create("WiperData" + vNum + ".xml"))
            using (XmlWriter writer = XmlWriter.Create(wi))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Wiper");

                foreach (Wiper w in wiper)
                {
                    writer.WriteStartElement("Wiper");

                    // Empty all elements
                    writer.WriteElementString("Vehicle_Number", vNum.ToString());
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
            */
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

        // Write the information to XML file
        private void writeToXML(int v)
        {
           
            string wdf = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\WiperInfo\WiperData" + v + ".xml";

            wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brandTextBox.Text, notesTextBox.Text);

            //if (File.Exists(wi))
            //{
            //****if file already exists, just add the values to the xml file
            //***if file not exist, create file and add values
            //***create method to add file and method to create file and add values

            //}            
            using (XmlWriter writer = XmlWriter.Create(wdf))
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
            else if (driver <= 0 || driver > 40)
            {
                MessageBox.Show("Please enter wiper size between: 0-40");
                driverSideTextBox.Focus();
                return;
            }
            else if (!double.TryParse(passagerSideTextBox.Text, out passager))
            {
                MessageBox.Show("This is a number only field");
                passagerSideTextBox.Focus();
                return;
            }
            else if (passager <= 0 || passager > 40)
            {
                MessageBox.Show("Please enter wiper size between: 0-40");
                passagerSideTextBox.Focus();
                return;
            }
            else if (!double.TryParse(rearTextBox.Text, out rear))
            {
                MessageBox.Show("This is a number only field");
                rearTextBox.Focus();
                return;
            }
            else if (rear <= 0 || rear > 40)
            {
                MessageBox.Show("Please enter wiper size between: 0-40");
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

            // Set the file that just saved

            wiperDataFile = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\WiperInfo\WiperData" + vehicleNum + ".xml";

            progressBar(wiperDataFile); // Passing the saved file to be displayed the number of days left
                                        // before the next installation
           
        }        
        
        private void progressBar(string wFile)
        {
            XmlDocument loadFile = new XmlDocument();
            loadFile.Load(wFile);
            XmlElement root = loadFile.DocumentElement;

            string startDate = root.GetElementsByTagName("Installed_Date")[0].InnerText;    // Get start date from xml file
            string endDate = root.GetElementsByTagName("Next_Install_Date")[0].InnerText;   // Get end date from xml

            DateTime parsedStartDate = DateTime.Parse(startDate);   // Parse into start date
            //Console.WriteLine("Start date:" +parsedStartDate);

            DateTime parsedEndDate = DateTime.Parse(endDate);       // Parse into end date
            //Console.WriteLine("End date:" + parsedEndDate);          
                      
            // Get the current DateTime.
            DateTime now = DateTime.Now;
                    
            // Get the TimeSpan of the difference.
            TimeSpan totalDays = parsedEndDate.Subtract(parsedStartDate);
            //TimeSpan elapsed = now.Subtract(parsedEndDate);
            TimeSpan daysLeft = parsedEndDate.Subtract(now);
            
            // Get number of days ago.
            double tDays = totalDays.TotalDays;
           // double daysToGo = elapsed.TotalDays;
            double daysToGo = daysLeft.TotalDays;
            
            /*
            wiperProgressBar.Minimum = 0;       // Progress bar minimum value

            wiperProgressBar.Maximum = Convert.ToInt32(tDays);     // Progress bar maximum value

            wiperProgressBar.Value = Convert.ToInt32(daysToGo);
            
            daysLeftLabel.Text = daysToGo.ToString("0") +" days left";
            
            if (wiperProgressBar.Value <= wiperProgressBar.Maximum && wiperProgressBar.Value >= 5)
            {
                wiperProgressBar.ForeColor = System.Drawing.Color.Green;
            }
            else if (wiperProgressBar.Value >= 3 && wiperProgressBar.Value <= 4)
            {
                wiperProgressBar.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (wiperProgressBar.Value >= wiperProgressBar.Minimum && wiperProgressBar.Value <= 2)
            {
                wiperProgressBar.ForeColor = System.Drawing.Color.Red;
            }
            else if (wiperProgressBar.Value <= wiperProgressBar.Minimum)
            {
                wiperProgressBar.Value = wiperProgressBar.Maximum;
                wiperProgressBar.ForeColor = System.Drawing.Color.Red;
                daysLeftLabel.Text = "Install new wipers now.";
            }
            else
            {
                MessageBox.Show("Date is out of range.");
            }           

            */

            //************ disable progress bar - can't have min value of less than 0 with date picked
            
            double myNegInt = Math.Abs(daysToGo);   // Convert negative to positive

            daysLeftLabel.Text = myNegInt.ToString("0") + " days left";

            //wiperProgressBar.Value = wiperProgressBar.Maximum;
            if (daysToGo <= tDays && daysToGo >= 5)
            {
                daysLeftLabel.BackColor = System.Drawing.Color.Green;
                //wiperProgressBar.ForeColor = System.Drawing.Color.Green;
            }
            else if (daysToGo >= 3 && daysToGo <= 4)
            {
                daysLeftLabel.BackColor = System.Drawing.Color.Yellow;
                //wiperProgressBar.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (daysToGo >= 0 && daysToGo <= 2)
            {
                daysLeftLabel.BackColor = System.Drawing.Color.Red;
                //wiperProgressBar.ForeColor = System.Drawing.Color.Red;
            }
            else if (daysToGo < 0)
            {
                daysLeftLabel.BackColor = System.Drawing.Color.Red;
                //wiperProgressBar.ForeColor = System.Drawing.Color.Red;
                daysLeftLabel.Text = myNegInt.ToString("0") + " days over due. Install new wipers now!";
                //daysLeftLabel.Text = ;
                
            }            
            else
            {
                MessageBox.Show("Date is out of range."); 
                // *******************show when cleared and saved and color not showing******************
            }
            
        }
        
        private void clearButton_Click_1(object sender, EventArgs e)
        {
            clear(vehicleNum);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            wiperDataFile = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\WiperInfo\WiperData" + vehicleNum + ".xml";

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

            XmlDocument d = new XmlDocument();
            d.Load(wiperDataFile);
            XmlElement root = d.DocumentElement;

            vehicleNumLabel.Text = "Wiper Info for Vehicle #" + root.GetElementsByTagName("Vehicle_Number")[0].InnerText;
            displayInstDateLabel.Text = root.GetElementsByTagName("Installed_Date")[0].InnerText;
            displayNextDateLabel.Text = root.GetElementsByTagName("Next_Install_Date")[0].InnerText;
            driverSideTextBox.Text = root.GetElementsByTagName("Driver_Size")[0].InnerText;
            passagerSideTextBox.Text = root.GetElementsByTagName("Passager_Size")[0].InnerText;
            rearTextBox.Text = root.GetElementsByTagName("Rear_Size")[0].InnerText;
            brandTextBox.Text = root.GetElementsByTagName("Brand")[0].InnerText;
            notesTextBox.Text = root.GetElementsByTagName("Notes")[0].InnerText;

            installedDateTimePicker.Enabled = true;
            nextReplaceDateDisplayLabel.Enabled = true;
            driverSideTextBox.Enabled = true;
            passagerSideTextBox.Enabled = true;
            rearTextBox.Enabled = true;
            brandTextBox.Enabled = true;
            notesTextBox.Enabled = true;
        }

    }
}
 
        