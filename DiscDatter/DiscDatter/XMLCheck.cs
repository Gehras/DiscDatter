using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Windows.Forms;
using System.Security;

namespace DiscDatter
{
    public class XMLCheck
    {
        public static bool HeaderCheck (string headerName, string xmlPath)
        {
            bool isPresent = false;
            //The logic for parsing the XML and finding whether the header is present here
            string xmlText = SecurityElement.Escape(headerName);
            XmlDocument document = new XmlDocument();
            document.Load(xmlPath);
            //Find game node
            var nodes = document.GetElementsByTagName("game");
            var resultNodes = new List<XmlNode>();
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes != null && node.Attributes["name"] != null && node.Attributes["name"].Value == xmlText)
                    resultNodes.Add(node);
            }
            if (resultNodes.Count > 0)
            {
                isPresent = true;
            } else
            {
                isPresent = false;
            }
            return isPresent;
        }
    }
}
