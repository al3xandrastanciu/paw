using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subiect_1048
{
    [Serializable]
    public class Rezervare
    {
        private String nume;
        DateTime dataCheckIn;
        int numarNopti;
        private decimal pret;
        public bool isAchitat;

        public Rezervare(string nume, DateTime dataCheckIn, int numarNopti, decimal pret, bool achitat = false)
        {
            this.nume = nume;
            this.dataCheckIn = dataCheckIn;
            this.numarNopti = numarNopti;
            this.pret = pret;
            this.isAchitat = achitat;
        }
        public void setNume(String n) { nume = n; }
        public string getNume() { return nume; }
        public void setPret(decimal p) { pret = p; }
        public decimal getPret() { return pret; }
        public override string ToString()
        {
            return $"{nume}-{dataCheckIn.ToShortDateString()}-{numarNopti}-{pret}";
        }
    }
}
