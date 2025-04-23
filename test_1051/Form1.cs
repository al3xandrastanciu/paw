using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test_1051
{
    public partial class Form1 : Form
    {
        List<Pastila> pastile = new List<Pastila>();
        public Form1()
        {
            InitializeComponent();
        }
        private void populareListView()
        {
            listView1.Items.Clear();
            foreach(Pastila p in pastile)
            {
                ListViewItem itm = new ListViewItem(p.Gramaj.ToString());
                itm.SubItems.Add(p.Denumire);
                itm.SubItems.Add(p.Producator);
                itm.SubItems.Add(p.ModEliberare);
                listView1.Items.Add(itm);
            }
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            int gramaj = Convert.ToInt32(tbGramaj.Text);
            if (gramaj <= 0) errorProvider1.SetError(tbGramaj, "Valoarea trebuie sa fie pozitiva");
            else if (String.IsNullOrWhiteSpace(tbDenumire.Text)) errorProvider1.SetError(tbDenumire, "Campul nu poate fi gol");
            else
            {
                errorProvider1.Clear();
                pastile.Add(new Pastila(
                    gramaj,
                    tbDenumire.Text,
                    tbProducator.Text,
                    comboBox1.Text));

                tbGramaj.Clear();
                tbDenumire.Clear();
                tbProducator.Clear();
                comboBox1.SelectedIndex = -1;

                populareListView();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count==1)
            {
                int index = listView1.SelectedItems[0].Index;
                Form2 frm = new Form2(pastile[index]);
                if (frm.ShowDialog() != DialogResult.OK) return;
                populareListView();
            }
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream("pastila.dat", FileMode.Open);
            pastile.Add(formatter.Deserialize(stream) as Pastila);
            stream.Close();
            populareListView();
        }
    }
}
