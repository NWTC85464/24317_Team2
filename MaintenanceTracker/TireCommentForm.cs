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
    public partial class TireCommentForm : Form
    {
        //Variable.
        public int vehNum;  //Holds vehical number passed in.

        public TireCommentForm(int vehicalNumber)
        {
            //Center form on the screen.
            this.StartPosition = FormStartPosition.CenterScreen;

            //Set vehicalNumber to vehNum.
            this.vehNum = vehicalNumber;

            InitializeComponent();

            //Read vehicals text file and load into text area.
            commentsLoaded(vehNum);
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
                    outputFile = File.CreateText("Vehical 1 Comments.txt");
                    outputFile.WriteLine(richTextBox1.Text);
                    outputFile.Close();
                }
                else if(vehNum == 2)
                {
                    //Read comments text area and write to text file then close outputFile.     
                    outputFile = File.CreateText("Vehical 2 Comments.txt");
                    outputFile.WriteLine(richTextBox1.Text);
                    outputFile.Close();
                }
                else if (vehNum == 3)
                {
                    //Read comments text area and write to text file then close outputFile.     
                    outputFile = File.CreateText("Vehical 3 Comments.txt");
                    outputFile.WriteLine(richTextBox1.Text);
                    outputFile.Close();
                }
                else if (vehNum == 4)
                {
                    //Read comments text area and write to text file then close outputFile.     
                    outputFile = File.CreateText("Vehical 4 Comments.txt");
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

        private void commentFormClearButton_Click(object sender, EventArgs e)
        {
            //Call method to clear text area and vehicalNumber text file.
            clearComments(vehNum);            
        }

        private void clearComments(int vehNum)
        {
            richTextBox1.Text = "";

            //Create a streamWriter outputFile.
            StreamWriter outputFile;

            if (vehNum == 1)
            {
                //Clear vehicalNumber's text file and close the file.
                outputFile = File.CreateText("Vehical 1 Comments.txt");
                outputFile.WriteLine("");
                outputFile.Close();
            }
            else if (vehNum == 2)
            {
                //Clear vehicalNumber's text file and close the file.
                outputFile = File.CreateText("Vehical 2 Comments.txt");
                outputFile.WriteLine("");
                outputFile.Close();
            }
            else if (vehNum == 3)
            {
                //Clear vehicalNumber's text file and close the file.
                outputFile = File.CreateText("Vehical 3 Comments.txt");
                outputFile.WriteLine("");
                outputFile.Close();
            }
            else if (vehNum == 4)
            {
                //Clear vehicalNumber's text file and close the file.
                outputFile = File.CreateText("Vehical 4 Comments.txt");
                outputFile.WriteLine("");
                outputFile.Close();
            }
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
                    inputFile = File.OpenText("Vehical 1 Comments.txt");
                   
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
                    inputFile = File.OpenText("Vehical 2 Comments.txt");
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
                    inputFile = File.OpenText("Vehical 3 Comments.txt");
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
                else if (vehNum == 4)
                {
                    //Open vehical's text file.
                    inputFile = File.OpenText("Vehical 4 Comments.txt");
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
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
