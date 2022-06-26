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
using System.Xml.Linq;

namespace DatReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string addFile = "";
        string toFile = ""; 

        private void addButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith("dat") == true | openFileDialog.FileName.EndsWith("txt") == true)
                {
                    addPathLabel.Text = openFileDialog.FileName.ToString();
                    addFile = openFileDialog.FileName;
                } else
                {
                    MessageBox.Show("Please select a valid dat or txt file");
                }
            }
        }

        private void toButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith("dat") == true | openFileDialog.FileName.EndsWith("txt") == true)
                {
                    toPathLabel.Text = openFileDialog.FileName.ToString();
                    toFile = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("Please select a valid dat or txt file");
                }
            }
        }

        private void combineButton_Click(object sender, EventArgs e)
        {
            if (addFile == "" | toFile == "")
            {
                MessageBox.Show("Please select both dump and origin files");
            } else
            {
                AllMethods.XMLAnalyzer(addFile, toFile);
                //TIME TO MERGE!

                //Requirements:
                //Check for any duplicate names being added first
                //1. Add new <game> to <datafile> (alphabetical?)
                //2. Add all <rom> to new <game>
                //3. Collect date and modify <header><description>
                //4. Present user with save file dialog for end file
            }
        }

        class AllMethods
        {
            public static void XMLAnalyzer (string addFile, string toFile)
            {
                //Expect BOTH to be xml at first
                try
                {
                    StreamReader addReader = new StreamReader(addFile);
                    StreamReader toReader = new StreamReader(toFile);
                    //XElement.Parse(addReader);
                    //XElement.Parse(toReader);
                    var addXML = XDocument.Load(addReader);
                    var toXML = XDocument.Load(toReader);
                    toXML.Descendants("game").LastOrDefault().AddAfterSelf(addXML.Descendants("game"));
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
                    {
                        toXML.Save(saveFileDialog1.FileName);
                    }
                } catch
                {
                   MessageBox.Show("XML file not readable!");
                }
            }
        }
    }
}
