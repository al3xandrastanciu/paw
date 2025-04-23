using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1046
{
    public class Candidat
    {
        public int id;
        private string nume;
        private string oras;

        public Candidat(int id, string nume, string oras)
        {
            this.id = id;
            this.nume = nume;
            this.oras = oras;
        }
        public string getNume() { return nume; }
        public void setNume(string n) { nume = n; }
        public string getOras() { return oras; }
        public void setOras(string o) { oras = o; }

        public override string ToString()
        {
            return $"{id}-{nume}-{oras}";
        }
    }
}
