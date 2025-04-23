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

namespace subiect_1048
{
    public partial class Form1 : Form
    {
        RezervariDinZi r = new RezervariDinZi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbNume.Text)) errorProvider1.SetError(tbNume, "Numele nu poate fi gol");
            else if (String.IsNullOrWhiteSpace(tbNumarNopti.Text)) errorProvider1.SetError(tbNumarNopti, "Numarul nu poate fi gol");
            else if (String.IsNullOrWhiteSpace(tbPret.Text)) errorProvider1.SetError(tbPret, "Pretul nu poate fi gol");
            else if (DateTime.Compare(dateTimePicker1.Value.Date, DateTime.Today) < 0)
                errorProvider1.SetError(dateTimePicker1, "Data nu poate fi mai devreme de azi");
            else
            {
                errorProvider1.Clear();
                
                Rezervare rezervare = new Rezervare(
                    tbNume.Text,
                    dateTimePicker1.Value,
                    Convert.ToInt32(tbNumarNopti.Text),
                    Decimal.Parse(tbPret.Text),
                    cbAchitat.Text.Equals("Da") ? true : false);
                r += rezervare;
                tbNume.Clear();
                tbNumarNopti.Clear();
                tbPret.Clear();
                dateTimePicker1.Value = DateTime.Now;
                cbAchitat.SelectedIndex = 0;
            }
        }

        private void tbNumarNopti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar);
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVizualizare frm = new FormVizualizare(r.list);
            frm.ShowDialog();
        }
        
    }
}
