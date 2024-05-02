using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Lectura_XML_d_URL
{
    public partial class Form1 : Form
    {
        String URLString;
        XmlTextReader reader;
        public Form1()
        {
            InitializeComponent();
            URLString = "https://www.w3schools.com/xml/cd_catalog.xml";
            reader = new XmlTextReader(URLString);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: 
                        ListViewItem item = new ListViewItem(reader.Name);

                        if (reader.HasAttributes)
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                item.SubItems.Add(reader.Name + ": " + reader.Value);
                            }

                           
                            reader.MoveToElement();
                        }

                        listViewXMLData.Items.Add(item);
                        break;

                    case XmlNodeType.Text: 
                        listViewXMLData.Items[listViewXMLData.Items.Count - 1].SubItems.Add( ""+ reader.Value);
                        break;

                    case XmlNodeType.EndElement: 
                        break;
                }
            }
        }

        private void listViewXMLData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

