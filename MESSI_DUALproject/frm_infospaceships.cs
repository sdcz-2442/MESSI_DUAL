using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace App
{
    public partial class frm_infoSpaceShips : Form
    {
        string xmlPath = "..\\images\\Info.xml";
        Dictionary<String, String> Dict_SpaceShips;

        public frm_infoSpaceShips()
        {
            InitializeComponent();
        }

        private void frm_infoSpaceShips_Load(object sender, EventArgs e)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            XmlReader reader = XmlReader.Create(xmlPath, settings);
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

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            XmlReader reader = XmlReader.Create(xmlPath, settings);
            Dict_SpaceShips = new Dictionary<string, string>();
            string spaceShipKey = "";
            string spaceShipValue = "";

            if (reader.ReadToFollowing("TechnicalInfo"))
            {
                while (reader.Read())
                {
                    if (reader.ReadToFollowing("idOption"))
                    {
                        spaceShipValue = reader.ReadElementContentAsString();
                        reader.Read();
                        spaceShipKey = reader.ReadContentAsString();
                        Dict_SpaceShips.Add(spaceShipKey, spaceShipValue);
                    }

                }
            }
            spaceShipKey = this.lstNodes.SelectedItem.ToString();

            spaceShipValue = Dict_SpaceShips[spaceShipKey];

            reader.Close();

            var xmlStr = File.ReadAllText(xmlPath);
            var str = XElement.Parse(xmlStr);
            var result = str.Element("TechnicalInfo").Elements("InfoDetails").Elements("InfoDetail").
                            Where(x => x.Element("idInfoDetail").Value.Equals(spaceShipValue)).ToList();


            pbx_blueprint.Image = Image.FromFile("..\\images\\"+ spaceShipKey+"\\"+result.Elements("Blueprint").FirstOrDefault().Value.ToString());
            rtbx_description.Text = result.Elements("textInfoDetail").FirstOrDefault().Value.ToString();
            var datos = result.Elements("Data").Elements().ToList();

            lst_data.Items.Clear();
            lst_values.Items.Clear();
            foreach (XElement dato in datos){
                lst_data.Items.Add(dato.Name.ToString());
                lst_values.Items.Add(dato.Value.ToString());
            }

            pbx_frontview.Image = Image.FromFile("..\\images\\" + spaceShipKey + "\\" + result.Elements("FrontView").FirstOrDefault().Value.ToString());
            pbx_sideview.Image = Image.FromFile("..\\images\\" + spaceShipKey + "\\" + result.Elements("SideView").FirstOrDefault().Value.ToString());
            pbx_topview.Image = Image.FromFile("..\\images\\" + spaceShipKey + "\\" + result.Elements("TopView").FirstOrDefault().Value.ToString());
            pbx_rearview.Image = Image.FromFile("..\\images\\" + spaceShipKey + "\\" + result.Elements("RearView").FirstOrDefault().Value.ToString());
            pbx_view360.Image = Image.FromFile("..\\images\\" + spaceShipKey + "\\" + result.Elements("View360").FirstOrDefault().Value.ToString());

        }

        private void pbx_frontview_Click(object sender, EventArgs e)
        {
        }

        private void pbx_sideview_Click(object sender, EventArgs e)
        {

        }

        private void pbx_topview_Click(object sender, EventArgs e)
        {

        }

        private void pbx_rearview_Click(object sender, EventArgs e)
        {

        }

        private void pbx_view360_Click(object sender, EventArgs e)
        {

        }
    }
}
