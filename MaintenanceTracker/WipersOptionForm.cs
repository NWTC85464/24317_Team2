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

namespace MaintenanceTracker
{
    public partial class WipersOptionForm : System.Windows.Forms.Form
    {
        Wiper[] wiper = new Wiper[1];
        MainFormClass mainFormClass = new MainFormClass();
        MainTracker mainTracker = new MainTracker();

        //Variables.
        int vehicleNum;          // Holds Vehicle number.
        string nextInstallDateParse;    // Next wiper installation date
        string installedDateParse;      // Wiper installed date
        double driver;                  // Wiper size - driver
        double passager;                // Wiper size - passager
        double rear;                    // Wiper size - rear
        //string brand;                   // Wiper brand


        public WipersOptionForm(int vNum)
        {
            InitializeComponent();

            //Set Vehicle number and mpg from passed in value.
            this.vehicleNum = vNum;

            //Form background color.
            this.BackColor = System.Drawing.Color.Aqua;

            //this.BackgroundImage = Properties.Resources.wiper;  

            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            // Display wiper info for the selected vehicle
            vehicleNumLabel.Text = "Wiper Info for Vehicle #" + vehicleNum;
            /*
            XmlTextReader reader = new XmlTextReader("WiperData.xml");

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
            MessageBox.Show(Console.ReadLine());
            */
        }

        private void WipersOptionForm_Load(object sender, EventArgs e)
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
        private void installedDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            // Get the current date.
            DateTime thisDay = installedDateTimePicker.Value.Date;

            installedDateParse = thisDay.ToString("D");   // To be passed to be stored

            DateTime answer = thisDay.AddDays(180); // Add 180 days to the installed date

            nextInstallDateParse = answer.ToString("D");      // Convert for display

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
                        wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brandTextBox.Text, notesTextBox.Text);

                        using (XmlWriter writer = XmlWriter.Create("WiperData1.xml"))
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
                                writer.WriteElementString("Passage_Size", "");
                                writer.WriteElementString("Rear_Size", "");
                                writer.WriteElementString("Brand", "");
                                writer.WriteElementString("Notes", "");

                                writer.WriteEndElement();   // End writing 
                            }

                            writer.WriteEndElement();       // End writing 
                            writer.WriteEndDocument();      // End writing to file
                        }
                        break;

                    case 2:
                        wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brandTextBox.Text, notesTextBox.Text);

                        using (XmlWriter writer = XmlWriter.Create("WiperData2.xml"))
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
                                writer.WriteElementString("Passage_Size", "");
                                writer.WriteElementString("Rear_Size", "");
                                writer.WriteElementString("Brand", "");
                                writer.WriteElementString("Notes", "");

                                writer.WriteEndElement();   // End writing 
                            }

                            writer.WriteEndElement();       // End writing 
                            writer.WriteEndDocument();      // End writing to file
                        }
                        break;

                    case 3:
                        wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brandTextBox.Text, notesTextBox.Text);

                        using (XmlWriter writer = XmlWriter.Create("WiperData3.xml"))
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
                                writer.WriteElementString("Passage_Size", "");
                                writer.WriteElementString("Rear_Size", "");
                                writer.WriteElementString("Brand", "");
                                writer.WriteElementString("Notes", "");

                                writer.WriteEndElement();   // End writing 
                            }

                            writer.WriteEndElement();       // End writing 
                            writer.WriteEndDocument();      // End writing to file
                        }
                        break;

                    case 4:
                        wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brandTextBox.Text, notesTextBox.Text);

                        using (XmlWriter writer = XmlWriter.Create("WiperData4.xml"))
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
                                writer.WriteElementString("Passage_Size", "");
                                writer.WriteElementString("Rear_Size", "");
                                writer.WriteElementString("Brand", "");
                                writer.WriteElementString("Notes", "");

                                writer.WriteEndElement();   // End writing 
                            }

                            writer.WriteEndElement();       // End writing 
                            writer.WriteEndDocument();      // End writing to file
                        }
                        break;

                    default:
                        break;

                        
                }

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
                    wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brand, notes);
                
                    using (XmlWriter writer = XmlWriter.Create("WiperData1.xml"))
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
                            writer.WriteElementString("Passage_Size", w.Passager.ToString());
                            writer.WriteElementString("Rear_Size", w.Rear.ToString());
                            writer.WriteElementString("Brand", w.Brand);
                            writer.WriteElementString("Notes", w.Notes);

                            writer.WriteEndElement();   // End writing 
                        }

                        writer.WriteEndElement();       // End writing 
                        writer.WriteEndDocument();      // End writing to file
                    }
                    break;

                case 2:
                    wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brand, notes);
                
                    using (XmlWriter writer = XmlWriter.Create("WiperData2.xml"))
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
                            writer.WriteElementString("Passage_Size", w.Passager.ToString());
                            writer.WriteElementString("Rear_Size", w.Rear.ToString());
                            writer.WriteElementString("Brand", w.Brand);
                            writer.WriteElementString("Notes", w.Notes);

                            writer.WriteEndElement();   // End writing 
                        }

                        writer.WriteEndElement();       // End writing 
                        writer.WriteEndDocument();      // End writing to file
                    }
                    break;

                case 3:
                    wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brand, notes);
                   
                    using (XmlWriter writer = XmlWriter.Create("WiperData3.xml"))
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
                            writer.WriteElementString("Passage_Size", w.Passager.ToString());
                            writer.WriteElementString("Rear_Size", w.Rear.ToString());
                            writer.WriteElementString("Brand", w.Brand);
                            writer.WriteElementString("Notes", w.Notes);

                            writer.WriteEndElement();   // End writing 
                        }

                        writer.WriteEndElement();       // End writing 
                        writer.WriteEndDocument();      // End writing to file
                    }
                    break;

                case 4:
                    wiper[0] = new Wiper(vehicleNum, installedDateParse, nextInstallDateParse, driver, passager, rear, brand, notes);

                    using (XmlWriter writer = XmlWriter.Create("WiperData4.xml"))
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
                            writer.WriteElementString("Passage_Size", w.Passager.ToString());
                            writer.WriteElementString("Rear_Size", w.Rear.ToString());
                            writer.WriteElementString("Brand", w.Brand);
                            writer.WriteElementString("Notes", w.Notes);

                            writer.WriteEndElement();   // End writing 
                        }

                        writer.WriteEndElement();       // End writing 
                        writer.WriteEndDocument();      // End writing to file
                    }
                    break;

                default:
                    break;

            }
        }
    }
}
        
    

        /*
        private void progressBar(int vehicalNum, string rotateValue)
        {
            int vehNum = vehicalNum;
            //int miles = milage;
            int rotate = Int32.Parse(rotateValue);
            //double mil = System.Convert.ToDouble(milage);
            double rot = double.Parse(rotateValue);

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
        */
        //}
   // }
 
        