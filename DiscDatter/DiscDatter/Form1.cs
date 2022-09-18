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

namespace DiscDatter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string datFile = "";
        string txtFile = "";
        private void submissionButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith("txt") == true)
                {
                    txtPathLabel.Text = openFileDialog.FileName.ToString();
                    txtFile = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Please select a valid txt file");
                }
            }
        }

        private void datButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith("dat") == true)
                {
                    datPathLabel.Text = openFileDialog.FileName.ToString();
                    datFile = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Please select a valid dat file");
                }
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var parsedName = "";
            List<string> romLines = new List<string>();
            StreamReader txtReader = new StreamReader(txtFile);
            StreamReader datReader = new StreamReader(datFile);
            //find line with "rom name" header
            //copy line from header up to cuesheet
            //create new game name using rom name
            //add rom name info to this game name
            bool nameFound = false;
            StreamReader inputfile = File.OpenText(txtFile);
            using (txtReader)
            {
                var line = "";
                while ((line = txtReader.ReadLine()) != null)
                {
                    //Rom line-finding section
                    if (line.Contains("<rom name=\""))
                    {
                        romLines.Add("\t\t" + line);
                    }

                    //Name-finding section
                    if (nameFound == false && line.Contains("<rom name=\""))
                    {
                        nameFound = true;
                        var parseLine = line.Split(new string[] { "<rom name=\"" }, StringSplitOptions.None);
                        if(parseLine.Length >= 2)
                        {
                            var nameToParse = parseLine[1].Split(new string[] { " (Track" }, StringSplitOptions.None);
                            parsedName = nameToParse[0];
                            //debug for NAME
                            //MessageBox.Show(parsedName);
                        }
                    }
                }
                //debug for ROM lines
                //for(int i=0;i<romLines.Count;i++)
                //{
                  //  MessageBox.Show(romLines[i]);
                //}
            }
            //Close readers
            datReader.Close();
            txtReader.Close();
            //insert information into dat
            var datLines = File.ReadAllLines(datFile);
            //Remove last </datafile> line
            File.WriteAllLines(datFile, datLines.Take(datLines.Length - 1).ToArray());
            //Add game name line
            var gameName = "\t<game name=\"" + parsedName + "\">";
            File.AppendAllText(datFile, gameName + Environment.NewLine);
            //Add description line
            var descName = "\t\t<description>" + parsedName + "</description>";
            File.AppendAllText(datFile, descName + Environment.NewLine);
            //Add rom name lines 
            romLines.ForEach(item => File.AppendAllText(datFile, item + Environment.NewLine));
            //Add game terminator
            File.AppendAllText(datFile, "\t</game>" + Environment.NewLine);
            //Add datafile terminator
            File.AppendAllText(datFile, "</datafile>" + Environment.NewLine);
            //Show message saying complete
            MessageBox.Show("File modified!");
        }
    }
}
