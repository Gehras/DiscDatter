using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DiscDatter
{
    public class CueParser
    {
        public List<string> Parse(string txtFile)
        {
            StreamReader txtReader = new StreamReader(txtFile);
            //define empty line 
            var line = "";
            //define bool for loop
            bool cueFound = false;
            //define list for cue lines
            List<string> cueLines = new List<string>();
            while ((line = txtReader.ReadLine()) != null)
            {
                //Rom line-finding section
                if (cueFound == true)
                {
                        cueLines.Add(line);
                }
                if (line.Contains("Cuesheet:"))
                {
                    cueFound = true; 
                }           
            }
            return cueLines;
        }
    }
}
