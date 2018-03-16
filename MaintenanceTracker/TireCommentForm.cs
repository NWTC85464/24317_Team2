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
        public int vehNum;
        public TireCommentForm(int vehicalNumber)
        {
            this.vehNum = vehicalNumber;
            InitializeComponent();
            //Read vehicals text file
            commentsLoaded(vehNum);
        }

        private void saveCommentButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Write comments to vehicals text file
                if (vehNum == 1)
                {
                    //Create streamWriter and write text to a file for each vehical.
                    StreamWriter outputFile;
                    outputFile = File.CreateText("Vehical 1 Comments.txt");
                    outputFile.WriteLine(richTextBox1.Text);
                    outputFile.Close();
                }
                else if(vehNum == 2)
                {

                }
                else if (vehNum == 3)
                {

                }
                else if (vehNum == 4)
                {

                }
                
            }
            catch
            {
                //Do nothing......
            }
        }

        private void commentFormClearButton_Click(object sender, EventArgs e)
        {
            clearComments(vehNum);
        }

        private void clearComments(int vehNum)
        {
            richTextBox1.Text = "";
            //Add clear vehicals text file also.
        }
        private void commentsLoaded(int vehNum)
        {
            try
            {
                string textIn;
                //Create a stream reader and read a text file for each vehical.
                if (vehNum == 1)
                {
                    StreamReader inputFile;
                    inputFile = File.OpenText("Vehical 1 Comments.txt");
                    while (!inputFile.EndOfStream)
                    {
                        textIn = inputFile.ReadLine();
                        richTextBox1.Text = textIn;
                    }
                    inputFile.Close();
                }
                else if (vehNum == 2)
                {

                }
                else if (vehNum == 3)
                {

                }
                else if (vehNum == 4)
                {

                }
                else
                {
                    richTextBox1.Text = "Sorry no comments Loaded";
                }
            }
            catch
            {
                //Do nothing.....
            }
        }

        private void commentFormReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
