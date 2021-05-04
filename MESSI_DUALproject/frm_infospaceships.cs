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
        List<XElement> result;
        string spaceShipKey = "";

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

            label4.Visible = false;
            lbl_spaceshipname.Visible = false;
            pbx_blueprint.Visible = false;
            tableLayoutPanel2.Visible = false;
            rtbx_description.Visible = false;
            //axWindowsMediaPlayer1.Visible = false;

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
            string spaceShipValue = "";

            label4.Visible = true;
            lbl_spaceshipname.Visible = true;
            pbx_blueprint.Visible = true;
            tableLayoutPanel2.Visible = true;
            rtbx_description.Visible = true;


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

            //lbl_spaceshipname.Text = this.lstNodes.SelectedItem.ToString();

            spaceShipValue = Dict_SpaceShips[spaceShipKey];

            reader.Close();

            var xmlStr = File.ReadAllText(xmlPath);
            var str = XElement.Parse(xmlStr);
            result = str.Element("TechnicalInfo").Elements("InfoDetails").Elements("InfoDetail").
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

            try
            {
                pnl_bigimage.Image = Image.FromFile("..\\images\\" + spaceShipKey + "\\" + result.Elements("GeneralView").FirstOrDefault().Value.ToString());
            }
            catch (OutOfMemoryException)
            {

            }

        }

        private void pbx_frontview_MouseHover(object sender, EventArgs e)
        {
            pnl_bigimage.Image = Image.FromFile("..\\images\\" + spaceShipKey + "\\" + result.Elements("FrontView").FirstOrDefault().Value.ToString());

        }

        private void pbx_sideview_MouseHover(object sender, EventArgs e)
        {
            pnl_bigimage.Image = Image.FromFile("..\\images\\" + spaceShipKey + "\\" + result.Elements("SideView").FirstOrDefault().Value.ToString());

        }

        private void pbx_topview_MouseHover(object sender, EventArgs e)
        {
            pnl_bigimage.Image = Image.FromFile("..\\images\\" + spaceShipKey + "\\" + result.Elements("TopView").FirstOrDefault().Value.ToString());

        }

        private void pbx_rearview_MouseHover(object sender, EventArgs e)
        {
            pnl_bigimage.Image = Image.FromFile("..\\images\\" + spaceShipKey + "\\" + result.Elements("RearView").FirstOrDefault().Value.ToString());

        }

        private void pbx_view360_MouseHover(object sender, EventArgs e)
        {
            AxWMPLib.AxWindowsMediaPlayer wmp = new AxWMPLib.AxWindowsMediaPlayer();

            try
            {
                pnl_bigimage.Image = Image.FromFile("..\\images\\" + spaceShipKey + "\\" + result.Elements("GeneralView").FirstOrDefault().Value.ToString());
            } catch (OutOfMemoryException)
            {

            }
            pnl_image_or_video.Controls.Add(wmp);
            //wmp.Ctlenabled = false;
            wmp.URL = "..\\images\\" + spaceShipKey + "\\" + result.Elements("GeneralView").FirstOrDefault().Value.ToString();
            pnl_bigimage.Image = null;
            

        }

        private void pbx_blueprint_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("..\\images\\" + spaceShipKey + "\\" + result.Elements("pdfFile").FirstOrDefault().Value.ToString());

            //pdfFile
        }
    }
}
