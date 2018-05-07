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

namespace MaintenanceTracker
{
    public partial class TireCommentForm : Form
    {
        //Variable.
        public int vehNum;  //Holds vehical number passed in.
        public TireCommentForm(int vehicalNum)
        {
            //Set vehicalNumber to vehNum.
            this.vehNum = vehicalNum; 

            InitializeComponent();
            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

        }
       
        //Path to miles driven files.
        string path1b = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\Veh1Com.txt";
        string path2b = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\Veh2Com.txt";
        string path3b = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\Veh3Com.txt";
        string path4b = @".\..\..\..\..\..\..\Source\Repos\24317_Team2\MaintenanceTracker\Resources\TiresInfo\Veh4Com.txt";

        private void TireCommentForm_Load(object sender, EventArgs e)
        {
          

            createFile(vehNum, path1b, path2b, path3b, path4b);
            //Read vehicals text file and load into text area.
            commentsLoaded(vehNum);        
        }
        private void commentsLoaded(int vehNum)
        {
            try
            {
                string textIn = "";
                //Create a stream reader input file.
                StreamReader inputFile;

                if (vehNum == 1)
                {
                    //Open vehical's text file.
                    inputFile = File.OpenText(path1b);

                    while (!inputFile.EndOfStream)
                    {
                        //Read vehical's text file into inputFile.
                        textIn = inputFile.ReadLine();

                        //Check for empty lines.
                        if (!string.IsNullOrEmpty(textIn))
                        {
                            //Display text in text area on form.
                            richTextBox1.Text = textIn;
                        }

                    }
                    inputFile.Close();
                }
                else if (vehNum == 2)
                {
                    //Open vehical's text file.
                    inputFile = File.OpenText(path2b);
                    while (!inputFile.EndOfStream)
                    {
                        //Read vehical's text file into inputFile.
                        textIn = inputFile.ReadLine();

                        //Check for empty lines.
                        if (!string.IsNullOrEmpty(textIn))
                        {
                            //Display text in text area on form.
                            richTextBox1.Text = textIn;
                        }
                    }
                    inputFile.Close();
                }
                else if (vehNum == 3)
                {
                    //Open vehical's text file.
                    inputFile = File.OpenText(path3b);
                    while (!inputFile.EndOfStream)
                    {
                        //Read vehical's text file into inputFile.
                        textIn = inputFile.ReadLine();

                        //Check for empty lines.
                        if (!string.IsNullOrEmpty(textIn))
                        {
                            //Display text in text area on form.
                            //
                            richTextBox1.Text = textIn;
                        }
                    }
                    inputFile.Close();
                }
                else if (vehNum == 4)
                {
                    //Open vehical's text file.
                    inputFile = File.OpenText(path4b);
                    while (!inputFile.EndOfStream)
                    {
                        //Read vehical's text file into inputFile.
                        textIn = inputFile.ReadLine();

                        //Check for empty lines.
                        if (!string.IsNullOrEmpty(textIn))
                        {
                            //Display text in text area on form.
                            richTextBox1.Text = textIn;
                        }
                    }
                    inputFile.Close();
                }
            }
            catch
            {
                //Do nothing.....
                Console.Write("Error");
            }
        }
        private void clearComments(int vehNum)
        {
            richTextBox1.Text = "";

            //Create a streamWriter outputFile.
            StreamWriter outputFile;

            if (vehNum == 1)
            {
                //Clear vehicalNumber's text file and close the file.
                outputFile = File.CreateText(path1b);
                outputFile.WriteLine("");
                outputFile.Close();
            }
            else if (vehNum == 2)
            {
                //Clear vehicalNumber's text file and close the file.
                outputFile = File.CreateText(path2b);
                outputFile.WriteLine("");
                outputFile.Close();
            }
            else if (vehNum == 3)
            {
                //Clear vehicalNumber's text file and close the file.
                outputFile = File.CreateText(path3b);
                outputFile.WriteLine("");
                outputFile.Close();
            }
            else if (vehNum == 4)
            {
                //Clear vehicalNumber's text file and close the file.
                outputFile = File.CreateText(path4b);
                outputFile.WriteLine("");
                outputFile.Close();
            }
        }
        private void createFile(int vn, string path1b, string path2b, string path3b, string path4b)
        {
            StreamWriter sw;
            switch (vn)
            {
                case 1:
                    if (!File.Exists(path1b))
                    {
                        using (sw = File.CreateText(path1b))
                        {
                            sw.WriteLine("");
                        }
                    }
                    break;
                case 2:
                    if (!File.Exists(path2b))
                    {
                        using (sw = File.CreateText(path2b))
                        {
                            sw.WriteLine("");
                        }
                    }
                    break;
                case 3:
                    if (!File.Exists(path3b))
                    {
                        using (sw = File.CreateText(path3b))
                        {
                            sw.WriteLine("");
                        }
                    }
                    break;
                case 4:
                    if (!File.Exists(path4b))
                    {
                        using (sw = File.CreateText(path4b))
                        {
                            sw.WriteLine("");
                        }
                    }
                    break;
                default:
                    break;

            }
        }
        private void saveCommentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Create streamWriter variable and write text to a file for each vehical.  
                StreamWriter outputFile;

                if (vehNum == 1)
                {

                    //Read comments text area and write to text file then close outputFile.            
                    outputFile = File.CreateText(path1b);
                    outputFile.WriteLine(richTextBox1.Text);
                    outputFile.Close();
                }
                else if (vehNum == 2)
                {
                    //Read comments text area and write to text file then close outputFile.     
                    outputFile = File.CreateText(path2b);
                    outputFile.WriteLine(richTextBox1.Text);
                    outputFile.Close();
                }

                else if (vehNum == 3)
                {
                    //Read comments text area and write to text file then close outputFile.     
                    outputFile = File.CreateText(path3b);
                    outputFile.WriteLine(richTextBox1.Text);
                    outputFile.Close();
                }
                else if (vehNum == 4)
                {
                    //Read comments text area and write to text file then close outputFile.     
                    outputFile = File.CreateText(path4b);
                    outputFile.WriteLine(richTextBox1.Text);
                    outputFile.Close();
                }
            }
            catch
            {
                //Do nothing......
            }

            //Display a message saying the file saved.
            MessageBox.Show("Saved to file");

            //Close the form.
            //this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void commentFormClearButton_Click(object sender, EventArgs e)
        {
            //Call method to clear text area and vehicalNumber text file.
            clearComments(vehNum);
        }
    }    
}
