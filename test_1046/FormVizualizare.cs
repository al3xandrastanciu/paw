using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace test_1046
{
    public partial class FormVizualizare : Form
    {
        private EleviLicenta lic;
        private StudentiMasteranzi mast;
        public FormVizualizare(EleviLicenta lic, StudentiMasteranzi mast)
        {
            InitializeComponent();
            this.lic = lic;
            this.mast = mast;
            populareTreeView();
        }
        void populareTreeView()
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add("Candidati");
            treeView1.Nodes[0].Nodes.Add("Licenta");
            treeView1.Nodes[0].Nodes.Add("Masteranzi");
            foreach(Candidat c in lic.candidati)
            {
                treeView1.Nodes[0].Nodes[0].Nodes.Add(c.ToString());
            }
            foreach (Candidat c in mast.candidati)
            {
                treeView1.Nodes[0].Nodes[1].Nodes.Add(c.ToString());
            }
            treeView1.ExpandAll();
        }

        private void stergeElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string candidat = treeView1.SelectedNode.Text;
            foreach(Candidat c in lic.candidati)
            {
                if (c.ToString().Equals(candidat))
                {
                    lic.candidati.Remove(c);
                    populareTreeView();
                    return;
                }
            }

            foreach (Candidat c in mast.candidati)
            {
                if (c.ToString().Equals(candidat))
                {
                    mast.candidati.Remove(c);
                    populareTreeView();
                    return;
                }
            }
        }

        private void FormVizualizare_FormClosing(object sender, FormClosingEventArgs e)
        {
            scriereXml();
        }

        void scriereXml()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Salvare fisier xml";
            dlg.Filter = "Fisier XML|*.xml";
            if (dlg.ShowDialog() != DialogResult.OK) return;

            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            foreach (TreeNode parinte in treeView1.Nodes)
            {
                writer.WriteStartElement(parinte.Text);
                foreach (TreeNode copil in parinte.Nodes)
                {
                    writer.WriteStartElement(copil.Text);
                    foreach (TreeNode nepot in copil.Nodes)
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
            string rezultat = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();

            StreamWriter sw = new StreamWriter(dlg.FileName);
            sw.WriteLine(rezultat);
            sw.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
