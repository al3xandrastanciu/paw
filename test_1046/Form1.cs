using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_1046
{
    public partial class Form1 : Form
    {
        StudentiMasteranzi mast = new StudentiMasteranzi("Baze de date");
        EleviLicenta lic = new EleviLicenta("CSIE");
        public Form1()
        {
            InitializeComponent();
            cbProgram.SelectedIndex = 0;
        }


        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string mesajEroare = "Nu poate fi gol";
            if (String.IsNullOrWhiteSpace(tbId.Text)) errorProvider1.SetError(tbId, mesajEroare);
            else if (String.IsNullOrWhiteSpace(tbNume.Text)) errorProvider1.SetError(tbNume, mesajEroare);
            else if (String.IsNullOrWhiteSpace(tbOras.Text)) errorProvider1.SetError(tbOras, mesajEroare);
            else
            {
                errorProvider1.Clear();
                int id;
                try
                {
                    id = Int32.Parse(tbId.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Numarul din casuta de id nu este valid", "Eroare");
                    return;
                }
                Candidat c = new Candidat(id, tbNume.Text, tbOras.Text);
                if (cbProgram.SelectedIndex == 0)
                    lic += c;
                else mast += c;
                tbId.Clear();
                tbNume.Clear();
                tbOras.Clear();
                cbProgram.SelectedIndex = 0;
            }
        }

        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnVizualizeaza_Click(object sender, EventArgs e)
        {
            FormVizualizare frm = new FormVizualizare(lic, mast);
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
