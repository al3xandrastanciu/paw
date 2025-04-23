using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_1049
{
    public partial class FormView : Form
    {
        StudentiAbsenti abs;
        StudentiPrezenti prez;
        public FormView(StudentiAbsenti abs, StudentiPrezenti prez)
        {
            InitializeComponent();
            this.abs = abs;
            this.prez = prez;
            populareListView();
        }
        void populareListView()
        {
            listView1.Items.Clear();
            foreach (Student s in abs.lista)
            {
                ListViewItem itm = new ListViewItem(s.Id.ToString());
                itm.SubItems.Add(s.Nume);
                itm.SubItems.Add(s.Grupa);
                itm.SubItems.Add("Nu");
                listView1.Items.Add(itm);
            }

            foreach (Student s in prez.lista)
            {
                ListViewItem itm = new ListViewItem(s.Id.ToString());
                itm.SubItems.Add(s.Nume);
                itm.SubItems.Add(s.Grupa);
                itm.SubItems.Add("Da");
                listView1.Items.Add(itm);
            }

        }

        private void stergeElementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem itm = listView1.SelectedItems[0];
            if (itm.SubItems[3].Text.Equals("Da"))
                foreach (Student s in prez.lista)
                {
                    if (s.Id == Convert.ToInt32(itm.SubItems[0].Text) &&
                        s.Nume.Equals(itm.SubItems[1].Text) &&
                        s.Grupa.Equals(itm.SubItems[2].Text))
                    {
                        prez.lista.Remove(s);
                        break;
                    }
                }

            else
                foreach (Student s in abs.lista)
                {
                    if (s.Id == Convert.ToInt32(itm.SubItems[0].Text) &&
                        s.Nume.Equals(itm.SubItems[1].Text) &&
                        s.Grupa.Equals(itm.SubItems[2].Text))
                    {
                        abs.lista.Remove(s);
                        break;
                    }
                }

            populareListView();
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Serializare date";
            dlg.Filter = "Fisier binar|*.dat";
            if (dlg.ShowDialog() != DialogResult.OK) return;
            BinaryFormatter frm = new BinaryFormatter();
            FileStream stream = new FileStream(dlg.FileName,FileMode.Create);
            List<Student> toti = new List<Student>();
            toti.AddRange(abs.lista);
            toti.AddRange(prez.lista);
            frm.Serialize(stream, toti);
            stream.Close();
        }
    }
}
