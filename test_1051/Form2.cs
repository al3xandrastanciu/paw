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
    public partial class Form2 : Form
    {
        private Pastila p;
        public Form2(Pastila p)
        {
            InitializeComponent();
            this.p = p;
            populareDate();
        }
        void populareDate()
        {
            tbGramaj.Text = p.Gramaj.ToString();
            tbDenumire.Text = p.Denumire;
            tbProducator.Text = p.Producator;
            if (comboBox1.Items[0].Equals(p.ModEliberare)) comboBox1.SelectedIndex = 0;
            else if (comboBox1.Items[1].Equals(p.ModEliberare)) comboBox1.SelectedIndex = 1;
            else comboBox1.SelectedIndex = 2;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            p.ModEliberare = comboBox1.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("pastila.dat",FileMode.Create);
            formatter.Serialize(stream, p);
            stream.Close();
        }
    }
}
