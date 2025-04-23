using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1051
{
    [Serializable]
    public class Pastila
    {
        private int gramaj;
        private string denumire;
        private string producator;
        private string modEliberare;

        public int Gramaj { get => gramaj; set => gramaj = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public string Producator { get => producator; set => producator = value; }
        public string ModEliberare { get => modEliberare; set => modEliberare = value; }

        public Pastila(int gramaj, string denumire, string producator, string modEliberare)
        {
            this.gramaj = gramaj;
            this.denumire = denumire;
            this.producator = producator;
            this.modEliberare = modEliberare;
        }

        public Pastila() { }

        public override string ToString()
        {
            return gramaj+"-"+denumire+"-"+producator+"-"+modEliberare;
        }
    }
}
