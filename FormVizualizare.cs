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
using System.Xml;

namespace subiect_1048
{
    public partial class FormVizualizare : Form
    {
        List<Rezervare> list;
        public FormVizualizare(List<Rezervare> list)
        {
            InitializeComponent();
            this.list = list;
            populareTreeView();
        }
        void populareTreeView()
        {
            treeView1.Nodes.Add("Rezervari");
            treeView1.Nodes[0].Nodes.Add("Achitat");
            foreach (Rezervare r in list)
            {
                if (r.isAchitat) treeView1.Nodes[0].Nodes[0].Nodes.Add(r.ToString());
            }
            treeView1.Nodes[0].Nodes.Add("Neachitat");
            foreach (Rezervare r in list)
            {
                if (!r.isAchitat) treeView1.Nodes[0].Nodes[1].Nodes.Add(r.ToString());
            }
            treeView1.ExpandAll();
        }

        private void stergeElementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Rezervare r in list)
            {
                if (treeView1.SelectedNode.Text.Equals(r.ToString()))
                {
                    list.Remove(r);
                    break;
                }
            }
            treeView1.Nodes.Clear();
            populareTreeView();
        }

        void salvareXml()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Fisier Xml|*.xml";
            if (dlg.ShowDialog() != DialogResult.OK) return;
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();

            foreach(TreeNode parinte in treeView1.Nodes)
            {
                writer.WriteStartElement(parinte.Text);
                foreach(TreeNode copil in parinte.Nodes)
                {
                    writer.WriteStartElement(copil.Text);
                    foreach(TreeNode nepot in copil.Nodes)
                    {
                        writer.WriteStartElement(nepot.Text);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }

            writer.WriteEndDocument();
            writer.Close();

            string text = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();
            StreamWriter sw = new StreamWriter(dlg.FileName);
            sw.WriteLine(text);
            sw.Close();
        }

        private void salvareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvareXml();
        }
    }
}
