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
    public partial class Form1 : Form
    {
        StudentiAbsenti abs = new StudentiAbsenti();
        StudentiPrezenti prez = new StudentiPrezenti();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string mesajEroare = "Acest camp nu poate fi gol";
            if (String.IsNullOrWhiteSpace(tbId.Text)) errorProvider1.SetError(tbId, mesajEroare);
            else if (String.IsNullOrWhiteSpace(tbNume.Text)) errorProvider1.SetError(tbNume, mesajEroare);
            else if (String.IsNullOrWhiteSpace(tbGrupa.Text)) errorProvider1.SetError(tbGrupa, mesajEroare);
            else
            {
                errorProvider1.Clear();
                int id;
                try
                {
                    id = Int32.Parse(tbId.Text);
                }catch(Exception)
                {
                    MessageBox.Show("Numarul introdus in campul id nu este valid", "Eroare", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Student s = new Student(id, tbNume.Text, tbGrupa.Text);
                if (checkBox1.Checked) prez += s;
                else abs += s;
                tbId.Clear();
                tbNume.Clear();
                tbGrupa.Clear();
            }
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            FormView frm = new FormView(abs, prez);
            frm.ShowDialog();
        }

        void deserializare()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Deserializare";
            dlg.Filter = "Fisiere binare|*.dat";
            if (dlg.ShowDialog() != DialogResult.OK) return;
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(dlg.FileName, FileMode.Open);
            List<Student> toti = (List<Student>)formatter.Deserialize(stream);
            stream.Close();
            foreach(Student s in toti)
            {
                MessageBox.Show(s.ToString());
            }
        }

        private void btnDeserializare_Click(object sender, EventArgs e)
        {
            deserializare();
        }
    }
}
