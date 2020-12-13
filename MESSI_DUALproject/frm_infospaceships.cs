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

namespace App
{
    public partial class frm_infoSpaceShips : Form
    {
        string filePath = "C:\\Users\\saman\\Documents\\GitHub\\MESSI_DUAL\\images\\Info.xml";

        public frm_infoSpaceShips()
        {
            InitializeComponent();
        }

        private void frm_infoSpaceShips_Load(object sender, EventArgs e)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            XmlReader reader = XmlReader.Create(filePath, settings);
            lstNodes.Items.Clear();

            if (reader.ReadToFollowing("TechnicalInfo"))
            {
                while (reader.Read())
                {
                    if (reader.ReadToFollowing("textOption"))
                    {
                        lstNodes.Items.Add(reader.ReadElementContentAsString());
                    }
                }
            }
 
        }

        private void lstNodes_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_spaceshipname.Text = this.lstNodes.SelectedItem.ToString();
        }
    }
}
