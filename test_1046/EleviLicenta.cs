using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1046
{
    public class EleviLicenta
    {
        public string facultate;
        public List<Candidat> candidati;

        public EleviLicenta(string facultate)
        {
            this.facultate = facultate;
            candidati = new List<Candidat>();
        }
        public static EleviLicenta operator +(EleviLicenta e,Candidat c)
        {
            e.candidati.Add(c);
            return e;
        }
    }
}
